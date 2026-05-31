// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// An edge in a connection.
	/// </summary>
	public class IssueTypeEdge
	{
		/// <summary>
		/// A cursor for use in pagination.
		/// </summary>
		public string Cursor { get; set; } = default!;

		/// <summary>
		/// The item at the end of the edge.
		/// </summary>
		public IssueType? Node { get; set; }
	}
}
