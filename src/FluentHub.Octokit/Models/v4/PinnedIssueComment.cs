// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A comment pinned to an Issue.
	/// </summary>
	public class PinnedIssueComment
	{
		/// <summary>
		/// Identifies the primary key from the database.
		/// </summary>
		public int? DatabaseId { get; set; }

		/// <summary>
		/// Identifies the primary key from the database as a BigInt.
		/// </summary>
		public string FullDatabaseId { get; set; }

		/// <summary>
		/// The Node ID of the PinnedIssueComment object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The issue that this comment belongs to.
		/// </summary>
		public Issue Issue { get; set; }

		/// <summary>
		/// The comment that was pinned.
		/// </summary>
		public IssueComment IssueComment { get; set; }

		/// <summary>
		/// Identifies when the comment was pinned.
		/// </summary>
		public DateTimeOffset PinnedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies when the comment was pinned."
		/// <summary>
		public string PinnedAtHumanized { get; set; }

		/// <summary>
		/// The actor that pinned this comment.
		/// </summary>
		public IActor PinnedBy { get; set; }
	}
}
