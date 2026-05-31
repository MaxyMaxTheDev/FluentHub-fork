// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The targets supported for rulesets.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RepositoryRulesetTarget
	{
		/// <summary>
		/// Branch
		/// </summary>
		[EnumMember(Value = "BRANCH")]
		Branch,

		/// <summary>
		/// Tag
		/// </summary>
		[EnumMember(Value = "TAG")]
		Tag,

		/// <summary>
		/// Push
		/// </summary>
		[EnumMember(Value = "PUSH")]
		Push,

		/// <summary>
		/// repository
		/// </summary>
		[EnumMember(Value = "REPOSITORY")]
		Repository,
	}
}
