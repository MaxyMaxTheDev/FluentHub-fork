// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a 'parent_issue_added' event on a given issue.
	/// </summary>
	public class ParentIssueAddedEvent
	{
		/// <summary>
		/// Identifies the actor who performed the event.
		/// </summary>
		public IActor? Actor { get; set; }

		/// <summary>
		/// Identifies the date and time when the object was created.
		/// </summary>
		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when the object was created."
		/// <summary>
		public string? CreatedAtHumanized { get; set; }

		/// <summary>
		/// The Node ID of the ParentIssueAddedEvent object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The parent issue added.
		/// </summary>
		public Issue? Parent { get; set; }
	}
}
