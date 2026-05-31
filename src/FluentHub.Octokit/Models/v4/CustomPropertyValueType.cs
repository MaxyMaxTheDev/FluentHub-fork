// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The allowed value types for a custom property definition.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CustomPropertyValueType
	{
		/// <summary>
		/// A string value.
		/// </summary>
		[EnumMember(Value = "STRING")]
		String,

		/// <summary>
		/// A multi-select value.
		/// </summary>
		[EnumMember(Value = "MULTI_SELECT")]
		MultiSelect,

		/// <summary>
		/// A single-select value.
		/// </summary>
		[EnumMember(Value = "SINGLE_SELECT")]
		SingleSelect,

		/// <summary>
		/// A true/false value.
		/// </summary>
		[EnumMember(Value = "TRUE_FALSE")]
		TrueFalse,

		/// <summary>
		/// A URL value.
		/// </summary>
		[EnumMember(Value = "URL")]
		Url,
	}
}
