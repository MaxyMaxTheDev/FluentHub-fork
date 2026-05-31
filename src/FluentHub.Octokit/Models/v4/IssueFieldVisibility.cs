// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The visibility of an issue field.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum IssueFieldVisibility
	{
		/// <summary>
		/// Org Only
		/// </summary>
		[EnumMember(Value = "ORG_ONLY")]
		OrgOnly,

		/// <summary>
		/// All
		/// </summary>
		[EnumMember(Value = "ALL")]
		All,
	}
}
