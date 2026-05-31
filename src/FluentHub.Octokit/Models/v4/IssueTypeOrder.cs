// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Ordering options for issue types connections
	/// </summary>
	public class IssueTypeOrder
	{
		/// <summary>
		/// The field to order issue types by.
		/// </summary>
		public IssueTypeOrderField Field { get; set; }

		/// <summary>
		/// The ordering direction.
		/// </summary>
		public OrderDirection Direction { get; set; }
	}
}
