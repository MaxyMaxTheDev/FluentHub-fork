// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents the language of a repository.
	/// </summary>
	public class LanguageEdge
	{
		public string Cursor { get; set; } = default!;

		public Language Node { get; set; } = default!;

		/// <summary>
		/// The number of bytes of code written in the language.
		/// </summary>
		public int Size { get; set; }
	}
}
