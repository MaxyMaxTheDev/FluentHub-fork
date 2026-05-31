// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

using Octokit.GraphQL;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using FluentHub.Octokit.ModelGenerator.Generators;
using System.Text;

namespace FluentHub.Octokit.ModelGenerator
{
	public class Program
	{
		private readonly static string rootNamespace = "FluentHub.Octokit";

		private readonly static string entityNamespace = "FluentHub.Octokit.Models.v4";

		static async Task<int> Main(string[] args)
		{
			var options = ParseOptions(args);

			if (options.ShowHelp)
			{
				WriteUsage();
				return 0;
			}

			if (!string.IsNullOrWhiteSpace(options.ErrorMessage))
			{
				WriteUsage(options.ErrorMessage);
				return 1;
			}

			var token = await ResolveToken(options);
			if (string.IsNullOrWhiteSpace(token))
			{
				WriteUsage($"GitHub token was not found. Set {options.TokenEnvironmentVariable}, pass --token-stdin, or use an interactive prompt.");
				return 1;
			}

			await GenerateEntities(token, options.OutputPath);

			return 0;
		}

		private static async Task GenerateEntities(string token, string path)
		{
			var targetPath = Path.GetFullPath(path);
			var parentPath = Directory.GetParent(targetPath)?.FullName;

			if (string.IsNullOrWhiteSpace(parentPath))
				throw new InvalidOperationException($"Could not resolve parent directory for '{targetPath}'.");

			var header = new ProductHeaderValue("FluentHub.Octokit", "1.0");
			var connection = new Connection(header, token);

			Console.WriteLine("Reading from " + connection.Uri);
			var schema = await SchemaReader.ReadSchema(connection);

			Directory.CreateDirectory(parentPath);

			var targetDirectoryName = Path.GetFileName(Path.TrimEndingDirectorySeparator(targetPath));
			var tempPath = Path.Combine(parentPath, $".{targetDirectoryName}.tmp.{Guid.NewGuid():N}");
			Directory.CreateDirectory(tempPath);

			try
			{
				var generatedFiles = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

				foreach (var file in CodeGenerator.Generate(schema, rootNamespace, entityNamespace))
				{
					if (file?.Content is null)
						continue;

					generatedFiles.Add(file.Path);
					Console.WriteLine("Generating " + file.Path);
					WriteGeneratedFile(tempPath, file);
				}

				SyncGeneratedFiles(tempPath, targetPath, generatedFiles);
			}
			finally
			{
				if (Directory.Exists(tempPath))
					Directory.Delete(tempPath, recursive: true);
			}
		}

		private static void SyncGeneratedFiles(string tempPath, string targetPath, HashSet<string> generatedFiles)
		{
			Directory.CreateDirectory(targetPath);

			foreach (var relativePath in generatedFiles)
			{
				var sourcePath = GetSafeCombinedPath(tempPath, relativePath);
				var destinationPath = GetSafeCombinedPath(targetPath, relativePath);
				var destinationDirectory = Path.GetDirectoryName(destinationPath);

				if (!string.IsNullOrWhiteSpace(destinationDirectory))
					Directory.CreateDirectory(destinationDirectory);

				if (File.Exists(destinationPath) && File.ReadAllText(destinationPath) == File.ReadAllText(sourcePath))
					continue;

				Console.WriteLine("Writing " + relativePath);
				File.Move(sourcePath, destinationPath, overwrite: true);
			}

			foreach (var existingFile in Directory.EnumerateFiles(targetPath, "*.cs"))
			{
				var relativePath = Path.GetRelativePath(targetPath, existingFile);

				if (generatedFiles.Contains(relativePath))
					continue;

				Console.WriteLine("Deleting " + relativePath);
				File.Delete(existingFile);
			}
		}

		private static void WriteGeneratedFile(string rootPath, GeneratedFile file)
		{
			var outputPath = GetSafeCombinedPath(rootPath, file.Path);
			var outputDirectory = Path.GetDirectoryName(outputPath);

			if (!string.IsNullOrWhiteSpace(outputDirectory))
				Directory.CreateDirectory(outputDirectory);

			File.WriteAllText(outputPath, file.Content);
		}

		private static string GetSafeCombinedPath(string rootPath, string relativePath)
		{
			if (Path.IsPathRooted(relativePath))
				throw new InvalidOperationException($"Generated file path must be relative: '{relativePath}'.");

			var rootFullPath = Path.GetFullPath(rootPath);
			var combinedPath = Path.GetFullPath(Path.Combine(rootFullPath, relativePath));
			var rootPrefix = rootFullPath.EndsWith(Path.DirectorySeparatorChar)
				? rootFullPath
				: rootFullPath + Path.DirectorySeparatorChar;

			if (!combinedPath.StartsWith(rootPrefix, StringComparison.OrdinalIgnoreCase))
				throw new InvalidOperationException($"Generated file path escapes the output directory: '{relativePath}'.");

			return combinedPath;
		}

		private static async Task<string> ResolveToken(Options options)
		{
			if (options.ReadTokenFromStdin)
			{
				return (await Console.In.ReadLineAsync())?.Trim();
			}

			var token = Environment.GetEnvironmentVariable(options.TokenEnvironmentVariable);
			if (!string.IsNullOrWhiteSpace(token))
				return token.Trim();

			if (!Console.IsInputRedirected)
				return ReadSecretFromConsole($"GitHub token ({options.TokenEnvironmentVariable}): ");

			return null;
		}

		private static string ReadSecretFromConsole(string prompt)
		{
			Console.Write(prompt);

			var builder = new StringBuilder();
			while (true)
			{
				var key = Console.ReadKey(intercept: true);

				if (key.Key == ConsoleKey.Enter)
				{
					Console.WriteLine();
					return builder.ToString();
				}

				if (key.Key == ConsoleKey.Backspace)
				{
					if (builder.Length > 0)
						builder.Length--;

					continue;
				}

				if (!char.IsControl(key.KeyChar))
					builder.Append(key.KeyChar);
			}
		}

		private static Options ParseOptions(string[] args)
		{
			var options = new Options
			{
				TokenEnvironmentVariable = "GITHUB_TOKEN",
			};

			for (var i = 0; i < args.Length; i++)
			{
				var arg = args[i];

				switch (arg)
				{
					case "-h":
					case "--help":
						options.ShowHelp = true;
						return options;

					case "-o":
					case "--output":
						if (!TryReadOptionValue(args, ref i, arg, out options.OutputPath, out options.ErrorMessage))
							return options;
						break;

					case "--token-env":
						if (!TryReadOptionValue(args, ref i, arg, out options.TokenEnvironmentVariable, out options.ErrorMessage))
							return options;
						break;

					case "--token-stdin":
						options.ReadTokenFromStdin = true;
						break;

					default:
						if (arg.StartsWith("-", StringComparison.Ordinal))
						{
							options.ErrorMessage = $"Unknown option '{arg}'.";
							return options;
						}

						if (!string.IsNullOrWhiteSpace(options.OutputPath))
						{
							options.ErrorMessage = "Only one output path can be specified.";
							return options;
						}

						options.OutputPath = arg;
						break;
				}
			}

			if (string.IsNullOrWhiteSpace(options.OutputPath))
				options.ErrorMessage = "Output path is required.";

			if (string.IsNullOrWhiteSpace(options.TokenEnvironmentVariable))
				options.ErrorMessage = "Token environment variable name cannot be empty.";

			return options;
		}

		private static bool TryReadOptionValue(string[] args, ref int index, string optionName, out string value, out string errorMessage)
		{
			value = null;
			errorMessage = null;

			if (index + 1 >= args.Length)
			{
				errorMessage = $"Option '{optionName}' requires a value.";
				return false;
			}

			index++;
			value = args[index];
			return true;
		}

		private static void WriteUsage(string errorMessage = null)
		{
			if (!string.IsNullOrWhiteSpace(errorMessage))
			{
				Console.Error.WriteLine(errorMessage);
				Console.Error.WriteLine();
			}

			StringBuilder message = new(1024);

			message.AppendLine("Copyright (c) 2022-2024 0x5BFA");
			message.AppendLine("Licensed under the MIT License. See the LICENSE.");
			message.AppendLine();
			message.AppendLine("FluentHub Octokit Model Generator");
			message.AppendLine("--------------------------------------------------");
			message.AppendLine();
			message.AppendLine("Syntax:");
			message.AppendLine("	filename.exe [options] [path to copy]");
			message.AppendLine();
			message.AppendLine("Options:");
			message.AppendLine("	-o, --output [path]       Output directory. Alternative to positional path.");
			message.AppendLine("	--token-env [name]        Environment variable that contains the GitHub token. Defaults to GITHUB_TOKEN.");
			message.AppendLine("	--token-stdin             Read the GitHub token from stdin.");
			message.AppendLine("	-h, --help                Show this help text.");
			message.AppendLine();

			Console.Write(message.ToString());
		}

		private class Options
		{
			public string OutputPath;

			public string TokenEnvironmentVariable;

			public bool ReadTokenFromStdin;

			public bool ShowHelp;

			public string ErrorMessage;
		}
	}
}
