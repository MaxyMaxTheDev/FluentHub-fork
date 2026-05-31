// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A team, app or user that has the ability to bypass rules defined on a ruleset
	/// </summary>
	public class RepositoryRulesetBypassActor
	{
		/// <summary>
		/// The actor that can bypass rules.
		/// </summary>
		public BypassActor? Actor { get; set; }

		/// <summary>
		/// The mode for the bypass actor
		/// </summary>
		public RepositoryRulesetBypassActorBypassMode? BypassMode { get; set; }

		/// <summary>
		/// This actor represents the ability for a deploy key to bypass
		/// </summary>
		public bool DeployKey { get; set; }

		/// <summary>
		/// This actor represents the ability for an enterprise owner to bypass
		/// </summary>
		public bool EnterpriseOwner { get; set; }

		/// <summary>
		/// This actor represents the ability for an enterprise role to bypass
		/// </summary>
		public bool EnterpriseRole { get; set; }

		/// <summary>
		/// The Node ID of the RepositoryRulesetBypassActor object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// This actor represents the ability for an organization owner to bypass
		/// </summary>
		public bool OrganizationAdmin { get; set; }

		/// <summary>
		/// If the actor is a repository role, the repository role's ID that can bypass
		/// </summary>
		public int? RepositoryRoleDatabaseId { get; set; }

		/// <summary>
		/// If the actor is a repository role, the repository role's name that can bypass
		/// </summary>
		public string? RepositoryRoleName { get; set; }

		/// <summary>
		/// Identifies the ruleset associated with the allowed actor
		/// </summary>
		public RepositoryRuleset? RepositoryRuleset { get; set; }
	}
}
