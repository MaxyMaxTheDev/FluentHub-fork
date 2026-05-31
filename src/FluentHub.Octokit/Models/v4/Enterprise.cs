// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// An account to manage multiple organizations with consolidated policy and billing.
	/// </summary>
	public class Enterprise
	{
		/// <summary>
		/// The announcement banner set on this enterprise, if any. Only visible to members of the enterprise.
		/// </summary>
		public AnnouncementBanner AnnouncementBanner { get; set; }

		/// <summary>
		/// A URL pointing to the enterprise's public avatar.
		/// </summary>
		/// <param name="size">The size of the resulting square image.</param>
		public string AvatarUrl { get; set; }

		/// <summary>
		/// The enterprise's billing email.
		/// </summary>
		public string BillingEmail { get; set; }

		/// <summary>
		/// Enterprise billing information visible to enterprise billing managers.
		/// </summary>
		public EnterpriseBillingInfo BillingInfo { get; set; }

		/// <summary>
		/// Identifies the date and time when the object was created.
		/// </summary>
		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when the object was created."
		/// <summary>
		public string CreatedAtHumanized { get; set; }

		/// <summary>
		/// Identifies the primary key from the database.
		/// </summary>
		public int? DatabaseId { get; set; }

		/// <summary>
		/// The description of the enterprise.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The description of the enterprise as HTML.
		/// </summary>
		public string DescriptionHTML { get; set; }

		/// <summary>
		/// Find an enterprise team by its slug.
		/// </summary>
		/// <param name="slug">The slug of the enterprise team to find.</param>
		public EnterpriseTeam EnterpriseTeam { get; set; }

		/// <summary>
		/// A list of enterprise teams in this enterprise.
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		/// <param name="orderBy">Ordering options for enterprise teams returned from the connection.</param>
		/// <param name="query">The search string to look for.</param>
		public EnterpriseTeamConnection EnterpriseTeams { get; set; }

		/// <summary>
		/// The Node ID of the Enterprise object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The location of the enterprise.
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// A list of users who are members of this enterprise.
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		/// <param name="deployment">Only return members within the selected GitHub Enterprise deployment</param>
		/// <param name="hasTwoFactorEnabled">Only return members with this two-factor authentication status. Does not include members who only have an account on a GitHub Enterprise Server instance. **Upcoming Change on 2025-04-01 UTC** **Description:** `hasTwoFactorEnabled` will be removed. Use `two_factor_method_security` instead. **Reason:** `has_two_factor_enabled` will be removed.</param>
		/// <param name="orderBy">Ordering options for members returned from the connection.</param>
		/// <param name="organizationLogins">Only return members within the organizations with these logins</param>
		/// <param name="query">The search string to look for.</param>
		/// <param name="role">The role of the user in the enterprise organization or server.</param>
		/// <param name="twoFactorMethodSecurity">Only return members with this type of two-factor authentication method. Does not include members who only have an account on a GitHub Enterprise Server instance.</param>
		public EnterpriseMemberConnection Members { get; set; }

		/// <summary>
		/// The name of the enterprise.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// A list of organizations that belong to this enterprise.
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		/// <param name="orderBy">Ordering options for organizations returned from the connection.</param>
		/// <param name="query">The search string to look for.</param>
		/// <param name="viewerOrganizationRole">The viewer's role in an organization.</param>
		public OrganizationConnection Organizations { get; set; }

		/// <summary>
		/// Enterprise information visible to enterprise owners or enterprise owners' personal access tokens (classic) with read:enterprise or admin:enterprise scope.
		/// </summary>
		public EnterpriseOwnerInfo OwnerInfo { get; set; }

		/// <summary>
		/// The raw content of the enterprise README.
		/// </summary>
		public string Readme { get; set; }

		/// <summary>
		/// The content of the enterprise README as HTML.
		/// </summary>
		public string ReadmeHTML { get; set; }

		/// <summary>
		/// A list of repository custom properties for this enterprise.
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		public RepositoryCustomPropertyConnection RepositoryCustomProperties { get; set; }

		/// <summary>
		/// Returns a single repository custom property for the current enterprise by name.
		/// </summary>
		/// <param name="propertyName">The name of the repository custom property to be returned.</param>
		public RepositoryCustomProperty RepositoryCustomProperty { get; set; }

		/// <summary>
		/// The HTTP path for this enterprise.
		/// </summary>
		public string ResourcePath { get; set; }

		/// <summary>
		/// Returns a single ruleset from the current enterprise by ID.
		/// </summary>
		/// <param name="databaseId">The ID of the ruleset to be returned.</param>
		public RepositoryRuleset Ruleset { get; set; }

		/// <summary>
		/// A list of rulesets for this enterprise.
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		public RepositoryRulesetConnection Rulesets { get; set; }

		/// <summary>
		/// The enterprise's security contact email address.
		/// </summary>
		public string SecurityContactEmail { get; set; }

		/// <summary>
		/// The URL-friendly identifier for the enterprise.
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
		/// The HTTP URL for this enterprise.
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// A list of repositories that belong to users. Only available for enterprises with Enterprise Managed Users.
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		/// <param name="orderBy">Ordering options for repositories returned from the connection.</param>
		/// <param name="query">The search string to look for.</param>
		public UserNamespaceRepositoryConnection UserNamespaceRepositories { get; set; }

		/// <summary>
		/// Is the current viewer an admin of this enterprise?
		/// </summary>
		public bool ViewerIsAdmin { get; set; }

		/// <summary>
		/// The URL of the enterprise website.
		/// </summary>
		public string WebsiteUrl { get; set; }
	}
}
