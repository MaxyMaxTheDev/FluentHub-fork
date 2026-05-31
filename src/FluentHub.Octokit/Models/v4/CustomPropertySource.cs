// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Sources which can have custom properties defined.
	/// </summary>
	public class CustomPropertySource
	{
		/// <summary>
		/// An account to manage multiple organizations with consolidated policy and billing.
		/// </summary>
		public Enterprise? Enterprise { get; set; }

		/// <summary>
		/// An account on GitHub, with one or more owners, that has repositories, members and teams.
		/// </summary>
		public Organization? Organization { get; set; }
	}
}
