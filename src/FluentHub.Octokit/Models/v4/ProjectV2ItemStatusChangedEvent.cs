// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a 'project_v2_item_status_changed' event on a given issue or pull request.
	/// </summary>
	public class ProjectV2ItemStatusChangedEvent
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
		/// The Node ID of the ProjectV2ItemStatusChangedEvent object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The previous status of the project item.
		/// </summary>
		public string PreviousStatus { get; set; } = default!;

		/// <summary>
		/// Project referenced by event.
		/// </summary>
		public ProjectV2? Project { get; set; }

		/// <summary>
		/// The new status of the project item.
		/// </summary>
		public string Status { get; set; } = default!;

		/// <summary>
		/// Did this event result from workflow automation?
		/// </summary>
		public bool WasAutomated { get; set; }
	}
}
