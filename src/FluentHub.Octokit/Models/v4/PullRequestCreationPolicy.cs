// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The policy controlling who can create pull requests in a repository.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PullRequestCreationPolicy
	{
		/// <summary>
		/// Anyone can create pull requests.
		/// </summary>
		[EnumMember(Value = "ALL")]
		All,

		/// <summary>
		/// Only collaborators can create pull requests.
		/// </summary>
		[EnumMember(Value = "COLLABORATORS_ONLY")]
		CollaboratorsOnly,
	}
}
