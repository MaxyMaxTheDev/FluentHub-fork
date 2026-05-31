// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a 'issue_field_added' event on a given issue.
	/// </summary>
	public class IssueFieldAddedEvent
	{
		/// <summary>
		/// Identifies the actor who performed the event.
		/// </summary>
		public IActor Actor { get; set; }

		/// <summary>
		/// The color if it is a single-select field.
		/// </summary>
		public string Color { get; set; }

		/// <summary>
		/// Identifies the date and time when the object was created.
		/// </summary>
		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when the object was created."
		/// <summary>
		public string CreatedAtHumanized { get; set; }

		/// <summary>
		/// The Node ID of the IssueFieldAddedEvent object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The issue field added.
		/// </summary>
		public IssueFields IssueField { get; set; }

		/// <summary>
		/// The value of the added field.
		/// </summary>
		public string Value { get; set; }
	}
}
