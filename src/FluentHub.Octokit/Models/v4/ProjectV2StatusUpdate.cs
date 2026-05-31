// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A status update within a project.
	/// </summary>
	public class ProjectV2StatusUpdate
	{
		/// <summary>
		/// The body of the status update.
		/// </summary>
		public string? Body { get; set; }

		/// <summary>
		/// The body of the status update rendered to HTML.
		/// </summary>
		public string? BodyHTML { get; set; }

		/// <summary>
		/// Identifies the date and time when the object was created.
		/// </summary>
		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when the object was created."
		/// <summary>
		public string? CreatedAtHumanized { get; set; }

		/// <summary>
		/// The actor who created the status update.
		/// </summary>
		public IActor? Creator { get; set; }

		/// <summary>
		/// Identifies the primary key from the database.
		/// </summary>
		[Obsolete(@"`databaseId` will be removed because it does not support 64-bit signed integer identifiers. Use `fullDatabaseId` instead. Removal on 2025-04-01 UTC.")]
		public int? DatabaseId { get; set; }

		/// <summary>
		/// Identifies the primary key from the database as a BigInt.
		/// </summary>
		public string? FullDatabaseId { get; set; }

		/// <summary>
		/// The Node ID of the ProjectV2StatusUpdate object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The project that contains this status update.
		/// </summary>
		public ProjectV2 Project { get; set; } = default!;

		/// <summary>
		/// The start date of the status update.
		/// </summary>
		public string? StartDate { get; set; }

		/// <summary>
		/// The status of the status update.
		/// </summary>
		public ProjectV2StatusUpdateStatus? Status { get; set; }

		/// <summary>
		/// The target date of the status update.
		/// </summary>
		public string? TargetDate { get; set; }

		/// <summary>
		/// Identifies the date and time when the object was last updated.
		/// </summary>
		public DateTimeOffset UpdatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when the object was last updated."
		/// <summary>
		public string? UpdatedAtHumanized { get; set; }
	}
}
