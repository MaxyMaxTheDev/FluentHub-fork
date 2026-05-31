// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A list of repositories owned by users in an enterprise with Enterprise Managed Users.
	/// </summary>
	public class UserNamespaceRepositoryConnection
	{
		/// <summary>
		/// A list of edges.
		/// </summary>
		public List<UserNamespaceRepositoryEdge?>? Edges { get; set; }

		/// <summary>
		/// A list of nodes.
		/// </summary>
		public List<UserNamespaceRepository?>? Nodes { get; set; }

		/// <summary>
		/// Information to aid in pagination.
		/// </summary>
		public PageInfo PageInfo { get; set; } = default!;

		/// <summary>
		/// Identifies the total count of items in the connection.
		/// </summary>
		public int TotalCount { get; set; }
	}
}
