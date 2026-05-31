// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The connection type for ProjectColumn.
	/// </summary>
	public class ProjectColumnConnection
	{
		/// <summary>
		/// A list of edges.
		/// </summary>
		public List<ProjectColumnEdge?>? Edges { get; set; }

		/// <summary>
		/// A list of nodes.
		/// </summary>
		public List<ProjectColumn?>? Nodes { get; set; }

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
