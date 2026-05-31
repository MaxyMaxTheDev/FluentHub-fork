// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A suggestion to review a pull request based on an actor's commit history, review comments, and integrations.
	/// </summary>
	public class SuggestedReviewerActor
	{
		/// <summary>
		/// Is this suggestion based on past commits?
		/// </summary>
		public bool IsAuthor { get; set; }

		/// <summary>
		/// Is this suggestion based on past review comments?
		/// </summary>
		public bool IsCommenter { get; set; }

		/// <summary>
		/// Identifies the actor suggested to review the pull request.
		/// </summary>
		public IActor Reviewer { get; set; }
	}
}
