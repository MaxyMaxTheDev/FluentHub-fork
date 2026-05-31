// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Types that can represent a repository ruleset bypass actor.
	/// </summary>
	public class BypassActor
	{
		/// <summary>
		/// A GitHub App.
		/// </summary>
		public App App { get; set; }

		/// <summary>
		/// A team that belongs to an enterprise and can be assigned to multiple organizations.
		/// </summary>
		public EnterpriseTeam EnterpriseTeam { get; set; }

		/// <summary>
		/// A team of users in an organization.
		/// </summary>
		public Team Team { get; set; }

		/// <summary>
		/// A user is an individual's account on GitHub that owns repositories and can make new content.
		/// </summary>
		public User User { get; set; }
	}
}
