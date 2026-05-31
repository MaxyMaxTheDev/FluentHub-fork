// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a 'issue_field_changed' event on a given issue.
	/// </summary>
	public class IssueFieldChangedEvent
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
		/// The Node ID of the IssueFieldChangedEvent object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The issue field changed.
		/// </summary>
		public IssueFields? IssueField { get; set; }

		/// <summary>
		/// The new color if it is a single-select field.
		/// </summary>
		public string? NewColor { get; set; }

		/// <summary>
		/// The new value of the field.
		/// </summary>
		public string? NewValue { get; set; }

		/// <summary>
		/// The previous color if it was a single-select field.
		/// </summary>
		public string? PreviousColor { get; set; }

		/// <summary>
		/// The previous value of the field.
		/// </summary>
		public string? PreviousValue { get; set; }
	}
}
