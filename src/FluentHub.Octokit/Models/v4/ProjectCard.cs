// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A card in a project.
	/// </summary>
	public class ProjectCard
	{
		/// <summary>
		/// The project column this card is associated under. A card may only belong to one
		/// project column at a time. The column field will be null if the card is created
		/// in a pending state and has yet to be associated with a column. Once cards are
		/// associated with a column, they will not become pending in the future.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public ProjectColumn Column { get; set; }

		/// <summary>
		/// The card content item
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public ProjectCardItem Content { get; set; }

		/// <summary>
		/// Identifies the date and time when the object was created.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when the object was created."
		/// <summary>
		public string CreatedAtHumanized { get; set; }

		/// <summary>
		/// The actor who created this card
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public IActor Creator { get; set; }

		/// <summary>
		/// Identifies the primary key from the database.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public int? DatabaseId { get; set; }

		/// <summary>
		/// The Node ID of the ProjectCard object
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public ID Id { get; set; }

		/// <summary>
		/// Whether the card is archived
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public bool IsArchived { get; set; }

		/// <summary>
		/// The card note
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public string Note { get; set; }

		/// <summary>
		/// The project that contains this card.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public Project Project { get; set; }

		/// <summary>
		/// The HTTP path for this card
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public string ResourcePath { get; set; }

		/// <summary>
		/// The state of ProjectCard
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public ProjectCardState? State { get; set; }

		/// <summary>
		/// Identifies the date and time when the object was last updated.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public DateTimeOffset UpdatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when the object was last updated."
		/// <summary>
		public string UpdatedAtHumanized { get; set; }

		/// <summary>
		/// The HTTP URL for this card
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public string Url { get; set; }
	}
}
