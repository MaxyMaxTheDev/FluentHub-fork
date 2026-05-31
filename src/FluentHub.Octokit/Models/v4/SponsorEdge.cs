// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a user or organization who is sponsoring someone in GitHub Sponsors.
	/// </summary>
	public class SponsorEdge
	{
		/// <summary>
		/// A cursor for use in pagination.
		/// </summary>
		public string Cursor { get; set; } = default!;

		/// <summary>
		/// The item at the end of the edge.
		/// </summary>
		public Sponsor? Node { get; set; }
	}
}
