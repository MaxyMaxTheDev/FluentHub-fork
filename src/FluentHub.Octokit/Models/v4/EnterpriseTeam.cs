// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A team that belongs to an enterprise and can be assigned to multiple organizations.
	/// </summary>
	public class EnterpriseTeam
	{
		/// <summary>
		/// Organizations this team is assigned to.
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		/// <param name="orderBy">Ordering options for organizations returned from the connection.</param>
		public EnterpriseTeamAssignedOrganizationConnection AssignedOrganizations { get; set; }

		/// <summary>
		/// The human-readable, unique identifier for the enterprise and team.
		/// </summary>
		public string CombinedSlug { get; set; }

		/// <summary>
		/// Identifies the date and time when the object was created.
		/// </summary>
		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when the object was created."
		/// <summary>
		public string CreatedAtHumanized { get; set; }

		/// <summary>
		/// The description of the team.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The enterprise this team belongs to.
		/// </summary>
		public Enterprise Enterprise { get; set; }

		/// <summary>
		/// A list of users who are members of this enterprise team.
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		/// <param name="orderBy">Order for the connection.</param>
		/// <param name="query">The search string to look for.</param>
		public EnterpriseTeamMemberConnection EnterpriseTeamMembers { get; set; }

		/// <summary>
		/// Identifies the primary key from the database as a BigInt.
		/// </summary>
		public string FullDatabaseId { get; set; }

		/// <summary>
		/// The Node ID of the EnterpriseTeam object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// Whether the viewer is a member of this team.
		/// </summary>
		public bool IsViewerMember { get; set; }

		/// <summary>
		/// The name of the team.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Whether the team will receive notifications when mentioned.
		/// </summary>
		public TeamNotificationSetting NotificationSetting { get; set; }

		/// <summary>
		/// How this team selects its associated organizations.
		/// </summary>
		public EnterpriseTeamOrganizationSelectionType OrganizationSelectionType { get; set; }

		/// <summary>
		/// The level of privacy the team has.
		/// </summary>
		public TeamPrivacy Privacy { get; set; }

		/// <summary>
		/// The slug corresponding to the team.
		/// </summary>
		public string Slug { get; set; }

		/// <summary>
		/// Identifies the date and time when the object was last updated.
		/// </summary>
		public DateTimeOffset UpdatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when the object was last updated."
		/// <summary>
		public string UpdatedAtHumanized { get; set; }

		/// <summary>
		/// Whether the viewer can administer this team.
		/// </summary>
		public bool ViewerCanAdminister { get; set; }
	}
}
