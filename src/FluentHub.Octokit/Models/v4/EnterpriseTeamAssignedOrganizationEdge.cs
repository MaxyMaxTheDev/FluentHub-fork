// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents an organization that an enterprise team is assigned to.
	/// </summary>
	public class EnterpriseTeamAssignedOrganizationEdge
	{
		/// <summary>
		/// A cursor for use in pagination.
		/// </summary>
		public string Cursor { get; set; }

		public Organization Node { get; set; }
	}
}
