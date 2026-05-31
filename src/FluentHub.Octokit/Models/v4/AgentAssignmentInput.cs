// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents configuration for assigning Copilot to an issue (public variant)
	/// </summary>
	public class AgentAssignmentInput
	{
		/// <summary>
		/// The Node ID of the target repository where Copilot should work. Defaults to the issue's repository if not provided.
		/// </summary>
		public ID? TargetRepositoryId { get; set; }

		/// <summary>
		/// The base ref/branch for the repository. Defaults to the default branch if not provided.
		/// </summary>
		public string? BaseRef { get; set; }

		/// <summary>
		/// Custom instructions for Copilot.
		/// </summary>
		public string? CustomInstructions { get; set; }

		/// <summary>
		/// Custom agent for Copilot.
		/// </summary>
		public string? CustomAgent { get; set; }
	}
}
