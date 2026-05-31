// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The type of an issue field.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum IssueFieldDataType
	{
		/// <summary>
		/// Text
		/// </summary>
		[EnumMember(Value = "TEXT")]
		Text,

		/// <summary>
		/// Single Select
		/// </summary>
		[EnumMember(Value = "SINGLE_SELECT")]
		SingleSelect,

		/// <summary>
		/// Date
		/// </summary>
		[EnumMember(Value = "DATE")]
		Date,

		/// <summary>
		/// Number
		/// </summary>
		[EnumMember(Value = "NUMBER")]
		Number,

		/// <summary>
		/// Multi Select
		/// </summary>
		[EnumMember(Value = "MULTI_SELECT")]
		MultiSelect,
	}
}
