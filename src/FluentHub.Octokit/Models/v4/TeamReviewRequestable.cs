// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{

	/// <summary>
	/// Represents a team that can be requested to review a pull request.
	/// </summary>
	public interface ITeamReviewRequestable
	{
		/// <summary>
		/// The Node ID of the TeamReviewRequestable object
		/// </summary>
		ID Id { get; set; }

		/// <summary>
		/// The name of the team.
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// A unique, human-readable identifier for the team.
		/// </summary>
		string Slug { get; set; }
	}
}

namespace FluentHub.Octokit.Models.v4
{
	public class TeamReviewRequestable : ITeamReviewRequestable
	{
		public ID Id { get; set; }

		public string Name { get; set; } = default!;

		public string Slug { get; set; } = default!;
	}
}

