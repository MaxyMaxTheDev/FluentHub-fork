// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Specifies the attributes for a new or updated ruleset bypass actor. Only one of `actor_id`, `repository_role_database_id`, `organization_admin`, `enterprise_owner`, or `deploy_key` should be specified.
	/// </summary>
	public class RepositoryRulesetBypassActorInput
	{
		/// <summary>
		/// For Team, Integration and User bypasses, the Team, Integration, or User ID
		/// </summary>
		public ID? ActorId { get; set; }

		/// <summary>
		/// For role bypasses, the role database ID
		/// </summary>
		public int? RepositoryRoleDatabaseId { get; set; }

		/// <summary>
		/// For organization owner bypasses, true
		/// </summary>
		public bool? OrganizationAdmin { get; set; }

		/// <summary>
		/// For enterprise owner bypasses, true
		/// </summary>
		public bool? EnterpriseOwner { get; set; }

		/// <summary>
		/// For enterprise role bypasses, true. NOTE: This bypass actor is in beta.
		/// </summary>
		public bool? EnterpriseRole { get; set; }

		/// <summary>
		/// For deploy key bypasses, true. Can only use ALWAYS as the bypass mode
		/// </summary>
		public bool? DeployKey { get; set; }

		/// <summary>
		/// The bypass mode for this actor.
		/// </summary>
		public RepositoryRulesetBypassActorBypassMode BypassMode { get; set; }
	}
}
