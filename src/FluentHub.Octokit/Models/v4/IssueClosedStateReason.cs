// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The possible state reasons of a closed issue.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum IssueClosedStateReason
	{
		/// <summary>
		/// An issue that has been closed as completed
		/// </summary>
		[EnumMember(Value = "COMPLETED")]
		Completed,

		/// <summary>
		/// An issue that has been closed as not planned
		/// </summary>
		[EnumMember(Value = "NOT_PLANNED")]
		NotPlanned,

		/// <summary>
		/// An issue that has been closed as a duplicate
		/// </summary>
		[EnumMember(Value = "DUPLICATE")]
		Duplicate,
	}
}
