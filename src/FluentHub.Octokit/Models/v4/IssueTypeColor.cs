// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The possible color for an issue type
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum IssueTypeColor
	{
		/// <summary>
		/// gray
		/// </summary>
		[EnumMember(Value = "GRAY")]
		Gray,

		/// <summary>
		/// blue
		/// </summary>
		[EnumMember(Value = "BLUE")]
		Blue,

		/// <summary>
		/// green
		/// </summary>
		[EnumMember(Value = "GREEN")]
		Green,

		/// <summary>
		/// yellow
		/// </summary>
		[EnumMember(Value = "YELLOW")]
		Yellow,

		/// <summary>
		/// orange
		/// </summary>
		[EnumMember(Value = "ORANGE")]
		Orange,

		/// <summary>
		/// red
		/// </summary>
		[EnumMember(Value = "RED")]
		Red,

		/// <summary>
		/// pink
		/// </summary>
		[EnumMember(Value = "PINK")]
		Pink,

		/// <summary>
		/// purple
		/// </summary>
		[EnumMember(Value = "PURPLE")]
		Purple,
	}
}
