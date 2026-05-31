// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{

	/// <summary>
	/// An entry in the audit log.
	/// </summary>
	public interface IAuditEntry
	{
		/// <summary>
		/// The action name
		/// </summary>
		string Action { get; set; }

		/// <summary>
		/// The user who initiated the action
		/// </summary>
		AuditEntryActor? Actor { get; set; }

		/// <summary>
		/// The IP address of the actor
		/// </summary>
		string? ActorIp { get; set; }

		/// <summary>
		/// A readable representation of the actor's location
		/// </summary>
		ActorLocation? ActorLocation { get; set; }

		/// <summary>
		/// The username of the user who initiated the action
		/// </summary>
		string? ActorLogin { get; set; }

		/// <summary>
		/// The HTTP path for the actor.
		/// </summary>
		string? ActorResourcePath { get; set; }

		/// <summary>
		/// The HTTP URL for the actor.
		/// </summary>
		string? ActorUrl { get; set; }

		/// <summary>
		/// The time the action was initiated
		/// </summary>
		string CreatedAt { get; set; }

		/// <summary>
		/// The corresponding operation type for the action
		/// </summary>
		OperationType? OperationType { get; set; }

		/// <summary>
		/// The user affected by the action
		/// </summary>
		User? User { get; set; }

		/// <summary>
		/// For actions involving two users, the actor is the initiator and the user is the affected user.
		/// </summary>
		string? UserLogin { get; set; }

		/// <summary>
		/// The HTTP path for the user.
		/// </summary>
		string? UserResourcePath { get; set; }

		/// <summary>
		/// The HTTP URL for the user.
		/// </summary>
		string? UserUrl { get; set; }
	}
}

namespace FluentHub.Octokit.Models.v4
{
	public class AuditEntry : IAuditEntry
	{
		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string Action { get; set; } = default!;

		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public AuditEntryActor? Actor { get; set; }

		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? ActorIp { get; set; }

		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public ActorLocation? ActorLocation { get; set; }

		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? ActorLogin { get; set; }

		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? ActorResourcePath { get; set; }

		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? ActorUrl { get; set; }

		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string CreatedAt { get; set; } = default!;

		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public OperationType? OperationType { get; set; }

		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public User? User { get; set; }

		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? UserLogin { get; set; }

		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? UserResourcePath { get; set; }

		[Obsolete(@"The GraphQL audit-log is deprecated. Please use the REST API instead. Removal on 2026-04-01 UTC.")]
		public string? UserUrl { get; set; }
	}
}

