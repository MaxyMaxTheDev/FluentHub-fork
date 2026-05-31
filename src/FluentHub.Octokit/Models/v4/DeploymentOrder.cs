// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Ordering options for deployment connections
	/// </summary>
	public class DeploymentOrder
	{
		/// <summary>
		/// The field to order deployments by.
		/// </summary>
		public DeploymentOrderField Field { get; set; }

		/// <summary>
		/// The ordering direction.
		/// </summary>
		public OrderDirection Direction { get; set; }
	}
}
