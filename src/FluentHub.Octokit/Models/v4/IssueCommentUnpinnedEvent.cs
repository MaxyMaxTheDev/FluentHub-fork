// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a 'issue_comment_unpinned' event on a given issue.
	/// </summary>
	public class IssueCommentUnpinnedEvent
	{
		/// <summary>
		/// Identifies the actor who performed the event.
		/// </summary>
		public IActor Actor { get; set; }

		/// <summary>
		/// Identifies the date and time when the object was created.
		/// </summary>
		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when the object was created."
		/// <summary>
		public string CreatedAtHumanized { get; set; }

		/// <summary>
		/// The Node ID of the IssueCommentUnpinnedEvent object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// Identifies the issue comment associated with the 'issue_comment_unpinned' event.
		/// </summary>
		public IssueComment IssueComment { get; set; }
	}
}
