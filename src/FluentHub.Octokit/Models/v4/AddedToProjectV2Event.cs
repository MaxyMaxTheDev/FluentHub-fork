// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a 'added_to_project_v2' event on a given issue or pull request.
	/// </summary>
	public class AddedToProjectV2Event
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
		/// The Node ID of the AddedToProjectV2Event object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// Project referenced by event.
		/// </summary>
		public ProjectV2 Project { get; set; }

		/// <summary>
		/// Did this event result from workflow automation?
		/// </summary>
		public bool WasAutomated { get; set; }
	}
}
