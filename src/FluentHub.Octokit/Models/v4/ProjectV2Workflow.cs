// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A workflow inside a project.
	/// </summary>
	public class ProjectV2Workflow
	{
		/// <summary>
		/// Identifies the date and time when the object was created.
		/// </summary>
		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when the object was created."
		/// <summary>
		public string? CreatedAtHumanized { get; set; }

		/// <summary>
		/// Identifies the primary key from the database.
		/// </summary>
		[Obsolete(@"`databaseId` will be removed because it does not support 64-bit signed integer identifiers. Use `fullDatabaseId` instead. Removal on 2025-04-01 UTC.")]
		public int? DatabaseId { get; set; }

		/// <summary>
		/// Whether the workflow is enabled.
		/// </summary>
		public bool Enabled { get; set; }

		/// <summary>
		/// Identifies the primary key from the database as a BigInt.
		/// </summary>
		public string? FullDatabaseId { get; set; }

		/// <summary>
		/// The Node ID of the ProjectV2Workflow object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The name of the workflow.
		/// </summary>
		public string Name { get; set; } = default!;

		/// <summary>
		/// The number of the workflow.
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// The project that contains this workflow.
		/// </summary>
		public ProjectV2 Project { get; set; } = default!;

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
