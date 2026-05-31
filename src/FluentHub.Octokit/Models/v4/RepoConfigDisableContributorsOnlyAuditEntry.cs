// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Audit log entry for a repo.config.disable_contributors_only event.
	/// </summary>
	public class RepoConfigDisableContributorsOnlyAuditEntry
	{
		/// <summary>
		/// The action name
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string Action { get; set; } = default!;

		/// <summary>
		/// The user who initiated the action
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public AuditEntryActor? Actor { get; set; }

		/// <summary>
		/// The IP address of the actor
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? ActorIp { get; set; }

		/// <summary>
		/// A readable representation of the actor's location
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public ActorLocation? ActorLocation { get; set; }

		/// <summary>
		/// The username of the user who initiated the action
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? ActorLogin { get; set; }

		/// <summary>
		/// The HTTP path for the actor.
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? ActorResourcePath { get; set; }

		/// <summary>
		/// The HTTP URL for the actor.
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? ActorUrl { get; set; }

		/// <summary>
		/// The time the action was initiated
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string CreatedAt { get; set; } = default!;

		/// <summary>
		/// The Node ID of the RepoConfigDisableContributorsOnlyAuditEntry object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The corresponding operation type for the action
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public OperationType? OperationType { get; set; }

		/// <summary>
		/// The Organization associated with the Audit Entry.
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public Organization? Organization { get; set; }

		/// <summary>
		/// The name of the Organization.
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? OrganizationName { get; set; }

		/// <summary>
		/// The HTTP path for the organization
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? OrganizationResourcePath { get; set; }

		/// <summary>
		/// The HTTP URL for the organization
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? OrganizationUrl { get; set; }

		/// <summary>
		/// The repository associated with the action
		/// </summary>
		public Repository? Repository { get; set; }

		/// <summary>
		/// The name of the repository
		/// </summary>
		public string? RepositoryName { get; set; }

		/// <summary>
		/// The HTTP path for the repository
		/// </summary>
		public string? RepositoryResourcePath { get; set; }

		/// <summary>
		/// The HTTP URL for the repository
		/// </summary>
		public string? RepositoryUrl { get; set; }

		/// <summary>
		/// The user affected by the action
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public User? User { get; set; }

		/// <summary>
		/// For actions involving two users, the actor is the initiator and the user is the affected user.
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? UserLogin { get; set; }

		/// <summary>
		/// The HTTP path for the user.
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? UserResourcePath { get; set; }

		/// <summary>
		/// The HTTP URL for the user.
		/// </summary>
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? UserUrl { get; set; }
	}
}
