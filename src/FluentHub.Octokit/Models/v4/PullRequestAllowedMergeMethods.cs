// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Array of allowed merge methods. Allowed values include `merge`, `squash`, and `rebase`. At least one option must be enabled.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PullRequestAllowedMergeMethods
	{
		/// <summary>
		/// Add all commits from the head branch to the base branch with a merge commit.
		/// </summary>
		[EnumMember(Value = "MERGE")]
		Merge,

		/// <summary>
		/// Combine all commits from the head branch into a single commit in the base branch.
		/// </summary>
		[EnumMember(Value = "SQUASH")]
		Squash,

		/// <summary>
		/// Add all commits from the head branch onto the base branch individually.
		/// </summary>
		[EnumMember(Value = "REBASE")]
		Rebase,
	}
}
