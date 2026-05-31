// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a 'blocked_by_added' event on a given issue.
	/// </summary>
	public class BlockedByAddedEvent
	{
		/// <summary>
		/// Identifies the actor who performed the event.
		/// </summary>
		public IActor? Actor { get; set; }

		/// <summary>
		/// The blocking issue that was added.
		/// </summary>
		public Issue? BlockingIssue { get; set; }

		/// <summary>
		/// Identifies the date and time when the object was created.
		/// </summary>
		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when the object was created."
		/// <summary>
		public string? CreatedAtHumanized { get; set; }

		/// <summary>
		/// The Node ID of the BlockedByAddedEvent object
		/// </summary>
		public ID Id { get; set; }
	}
}
