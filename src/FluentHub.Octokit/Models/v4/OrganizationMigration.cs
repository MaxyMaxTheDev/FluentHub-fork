// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A GitHub Enterprise Importer (GEI) organization migration.
	/// </summary>
	public class OrganizationMigration
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
		public string? DatabaseId { get; set; }

		/// <summary>
		/// The reason the organization migration failed.
		/// </summary>
		public string? FailureReason { get; set; }

		/// <summary>
		/// The Node ID of the OrganizationMigration object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The remaining amount of repos to be migrated.
		/// </summary>
		public int? RemainingRepositoriesCount { get; set; }

		/// <summary>
		/// The name of the source organization to be migrated.
		/// </summary>
		public string SourceOrgName { get; set; } = default!;

		/// <summary>
		/// The URL of the source organization to migrate.
		/// </summary>
		public string SourceOrgUrl { get; set; } = default!;

		/// <summary>
		/// The migration state.
		/// </summary>
		public OrganizationMigrationState State { get; set; }

		/// <summary>
		/// The name of the target organization.
		/// </summary>
		public string TargetOrgName { get; set; } = default!;

		/// <summary>
		/// The total amount of repositories to be migrated.
		/// </summary>
		public int? TotalRepositoriesCount { get; set; }
	}
}
