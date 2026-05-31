// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Properties by which issue dependencies can be ordered.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum IssueDependencyOrderField
	{
		/// <summary>
		/// Order issue dependencies by time of when the dependency relationship was added
		/// </summary>
		[EnumMember(Value = "DEPENDENCY_ADDED_AT")]
		DependencyAddedAt,

		/// <summary>
		/// Order issue dependencies by the creation time of the dependent issue
		/// </summary>
		[EnumMember(Value = "CREATED_AT")]
		CreatedAt,
	}
}
