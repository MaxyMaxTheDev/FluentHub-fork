// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The connection type for DependencyGraphDependency.
	/// </summary>
	public class DependencyGraphDependencyConnection
	{
		/// <summary>
		/// A list of edges.
		/// </summary>
		public List<DependencyGraphDependencyEdge?>? Edges { get; set; }

		/// <summary>
		/// A list of nodes.
		/// </summary>
		public List<DependencyGraphDependency?>? Nodes { get; set; }

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
