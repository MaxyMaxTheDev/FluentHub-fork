// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// An edge in a connection.
	/// </summary>
	public class SearchResultItemEdge
	{
		/// <summary>
		/// A cursor for use in pagination.
		/// </summary>
		public string Cursor { get; set; } = default!;

		/// <summary>
		/// The item at the end of the edge.
		/// </summary>
		public SearchResultItem? Node { get; set; }

		/// <summary>
		/// Text matches on the result found.
		/// </summary>
		public List<TextMatch?>? TextMatches { get; set; }
	}
}
