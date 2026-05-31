// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Ordering options for enterprise administrator invitation connections
	/// </summary>
	public class EnterpriseMemberInvitationOrder
	{
		/// <summary>
		/// The field to order enterprise member invitations by.
		/// </summary>
		public EnterpriseMemberInvitationOrderField Field { get; set; }

		/// <summary>
		/// The ordering direction.
		/// </summary>
		public OrderDirection Direction { get; set; }
	}
}
