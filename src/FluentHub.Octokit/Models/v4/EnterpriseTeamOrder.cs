// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Ordering options for enterprise team connections.
	/// </summary>
	public class EnterpriseTeamOrder
	{
		/// <summary>
		/// The field to order enterprise teams by.
		/// </summary>
		public EnterpriseTeamOrderField Field { get; set; }

		/// <summary>
		/// The ordering direction.
		/// </summary>
		public OrderDirection Direction { get; set; }
	}
}
