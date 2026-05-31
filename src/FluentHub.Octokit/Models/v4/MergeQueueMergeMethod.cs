// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Method to use when merging changes from queued pull requests.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MergeQueueMergeMethod
	{
		/// <summary>
		/// Merge commit
		/// </summary>
		[EnumMember(Value = "MERGE")]
		Merge,

		/// <summary>
		/// Squash and merge
		/// </summary>
		[EnumMember(Value = "SQUASH")]
		Squash,

		/// <summary>
		/// Rebase and merge
		/// </summary>
		[EnumMember(Value = "REBASE")]
		Rebase,
	}
}
