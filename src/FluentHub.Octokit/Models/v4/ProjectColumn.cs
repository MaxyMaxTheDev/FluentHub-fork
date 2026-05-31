// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A column inside a project.
	/// </summary>
	public class ProjectColumn
	{
		/// <summary>
		/// List of cards in the column
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		/// <param name="archivedStates">A list of archived states to filter the cards by</param>
		public ProjectCardConnection Cards { get; set; } = default!;

		/// <summary>
		/// Identifies the date and time when the object was created.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
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
		/// The Node ID of the ProjectColumn object
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public ID Id { get; set; }

		/// <summary>
		/// The project column's name.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public string Name { get; set; } = default!;

		/// <summary>
		/// The project that contains this column.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public Project Project { get; set; } = default!;

		/// <summary>
		/// The semantic purpose of the column
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public ProjectColumnPurpose? Purpose { get; set; }

		/// <summary>
		/// The HTTP path for this project column
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public string ResourcePath { get; set; } = default!;

		/// <summary>
		/// Identifies the date and time when the object was last updated.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public DateTimeOffset UpdatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when the object was last updated."
		/// <summary>
		public string? UpdatedAtHumanized { get; set; }

		/// <summary>
		/// The HTTP URL for this project column
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public string Url { get; set; } = default!;
	}
}
