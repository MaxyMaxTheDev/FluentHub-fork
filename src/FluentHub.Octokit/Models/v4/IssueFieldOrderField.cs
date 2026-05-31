// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Properties by which issue field connections can be ordered.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum IssueFieldOrderField
	{
		/// <summary>
		/// Order issue fields by creation time
		/// </summary>
		[EnumMember(Value = "CREATED_AT")]
		CreatedAt,

		/// <summary>
		/// Order issue fields by name
		/// </summary>
		[EnumMember(Value = "NAME")]
		Name,
	}
}
