// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// When set to ALLGREEN, the merge commit created by merge queue for each PR in the group must pass all required checks to merge. When set to HEADGREEN, only the commit at the head of the merge group, i.e. the commit containing changes from all of the PRs in the group, must pass its required checks to merge.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MergeQueueGroupingStrategy
	{
		/// <summary>
		/// The merge commit created by merge queue for each PR in the group must pass all required checks to merge
		/// </summary>
		[EnumMember(Value = "ALLGREEN")]
		Allgreen,

		/// <summary>
		/// Only the commit at the head of the merge group must pass its required checks to merge.
		/// </summary>
		[EnumMember(Value = "HEADGREEN")]
		Headgreen,
	}
}
