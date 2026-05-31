// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Ordering options for enterprise team member connections.
	/// </summary>
	public class EnterpriseTeamMemberOrder
	{
		/// <summary>
		/// The field to order enterprise team members by.
		/// </summary>
		public EnterpriseTeamMemberOrderField Field { get; set; }

		/// <summary>
		/// The ordering direction.
		/// </summary>
		public OrderDirection Direction { get; set; }
	}
}
