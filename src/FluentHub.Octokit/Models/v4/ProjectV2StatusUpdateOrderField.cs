// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Properties by which project v2 status updates can be ordered.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ProjectV2StatusUpdateOrderField
	{
		/// <summary>
		/// Allows chronological ordering of project v2 status updates.
		/// </summary>
		[EnumMember(Value = "CREATED_AT")]
		CreatedAt,
	}
}
