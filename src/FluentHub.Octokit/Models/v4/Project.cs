// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Projects manage issues, pull requests and notes within a project owner.
	/// </summary>
	public class Project
	{
		/// <summary>
		/// The project's description body.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public string Body { get; set; }

		/// <summary>
		/// The projects description body rendered to HTML.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public string BodyHTML { get; set; }

		/// <summary>
		/// Indicates if the object is closed (definition of closed may depend on type)
		/// </summary>
		public bool Closed { get; set; }

		/// <summary>
		/// Identifies the date and time when the object was closed.
		/// </summary>
		public DateTimeOffset? ClosedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when the object was closed."
		/// <summary>
		public string ClosedAtHumanized { get; set; }

		/// <summary>
		/// List of columns in the project
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		public ProjectColumnConnection Columns { get; set; }

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
		/// The actor who originally created the project.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public IActor Creator { get; set; }

		/// <summary>
		/// Identifies the primary key from the database.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public int? DatabaseId { get; set; }

		/// <summary>
		/// The Node ID of the Project object
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public ID Id { get; set; }

		/// <summary>
		/// The project's name.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public string Name { get; set; }

		/// <summary>
		/// The project's number.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public int Number { get; set; }

		/// <summary>
		/// The project's owner. Currently limited to repositories, organizations, and users.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public IProjectOwner Owner { get; set; }

		/// <summary>
		/// List of pending cards in this project
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		/// <param name="archivedStates">A list of archived states to filter the cards by</param>
		public ProjectCardConnection PendingCards { get; set; }

		/// <summary>
		/// Project progress details.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public ProjectProgress Progress { get; set; }

		/// <summary>
		/// The HTTP path for this project
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public string ResourcePath { get; set; }

		/// <summary>
		/// Whether the project is open or closed.
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public ProjectState State { get; set; }

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
		/// The HTTP URL for this project
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		public string Url { get; set; }

		/// <summary>
		/// Indicates if the object can be closed by the viewer.
		/// </summary>
		public bool ViewerCanClose { get; set; }

		/// <summary>
		/// Indicates if the object can be reopened by the viewer.
		/// </summary>
		public bool ViewerCanReopen { get; set; }

		/// <summary>
		/// Check if the current viewer can update this object.
		/// </summary>
		public bool ViewerCanUpdate { get; set; }
	}
}
