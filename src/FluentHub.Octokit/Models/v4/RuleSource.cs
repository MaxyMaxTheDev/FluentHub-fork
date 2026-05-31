// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Types which can have `RepositoryRule` objects.
	/// </summary>
	public class RuleSource
	{
		/// <summary>
		/// An account to manage multiple organizations with consolidated policy and billing.
		/// </summary>
		public Enterprise? Enterprise { get; set; }

		/// <summary>
		/// An account on GitHub, with one or more owners, that has repositories, members and teams.
		/// </summary>
		public Organization? Organization { get; set; }

		/// <summary>
		/// A repository contains the content for a project.
		/// </summary>
		public Repository? Repository { get; set; }
	}
}
