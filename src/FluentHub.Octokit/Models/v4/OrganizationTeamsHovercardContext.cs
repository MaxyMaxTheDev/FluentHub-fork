// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// An organization teams hovercard context
	/// </summary>
	public class OrganizationTeamsHovercardContext
	{
		/// <summary>
		/// A string describing this context
		/// </summary>
		public string Message { get; set; } = default!;

		/// <summary>
		/// An octicon to accompany this context
		/// </summary>
		public string Octicon { get; set; } = default!;

		/// <summary>
		/// Teams in this organization the user is a member of that are relevant
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		public TeamConnection RelevantTeams { get; set; } = default!;

		/// <summary>
		/// The path for the full team list for this user
		/// </summary>
		public string TeamsResourcePath { get; set; } = default!;

		/// <summary>
		/// The URL for the full team list for this user
		/// </summary>
		public string TeamsUrl { get; set; } = default!;

		/// <summary>
		/// The total number of teams the user is on in the organization
		/// </summary>
		public int TotalTeamCount { get; set; }
	}
}
