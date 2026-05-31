// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a 'added_to_project' event on a given issue or pull request.
	/// </summary>
	public class AddedToProjectEvent
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
		/// Identifies the primary key from the database.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public int? DatabaseId { get; set; }

		/// <summary>
		/// The Node ID of the AddedToProjectEvent object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// Project referenced by event.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public Project? Project { get; set; }

		/// <summary>
		/// Project card referenced by this project event.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public ProjectCard? ProjectCard { get; set; }

		/// <summary>
		/// Column name referenced by this project event.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public string ProjectColumnName { get; set; } = default!;
	}
}
