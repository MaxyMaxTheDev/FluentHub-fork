// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a user who is a member of a team.
	/// </summary>
	public class TeamMemberEdge
	{
		/// <summary>
		/// A cursor for use in pagination.
		/// </summary>
		public string Cursor { get; set; } = default!;

		/// <summary>
		/// The HTTP path to the organization's member access page.
		/// </summary>
		public string MemberAccessResourcePath { get; set; } = default!;

		/// <summary>
		/// The HTTP URL to the organization's member access page.
		/// </summary>
		public string MemberAccessUrl { get; set; } = default!;

		public User Node { get; set; } = default!;

		/// <summary>
		/// The role the member has on the team.
		/// </summary>
		public TeamMemberRole Role { get; set; }
	}
}
