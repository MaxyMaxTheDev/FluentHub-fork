// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Ordering options issue dependencies
	/// </summary>
	public class IssueDependencyOrder
	{
		/// <summary>
		/// The field to order issue dependencies by.
		/// </summary>
		public IssueDependencyOrderField Field { get; set; }

		/// <summary>
		/// The ordering direction.
		/// </summary>
		public OrderDirection Direction { get; set; }
	}
}
