// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Ordering options for enterprise team organization connections.
	/// </summary>
	public class EnterpriseTeamOrganizationOrder
	{
		/// <summary>
		/// The field to order organizations by.
		/// </summary>
		public EnterpriseTeamOrganizationOrderField Field { get; set; }

		/// <summary>
		/// The ordering direction.
		/// </summary>
		public OrderDirection Direction { get; set; }
	}
}
