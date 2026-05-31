// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The possible roles of a collaborator on a project.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ProjectV2PermissionLevel
	{
		/// <summary>
		/// The collaborator can view the project
		/// </summary>
		[EnumMember(Value = "READ")]
		Read,

		/// <summary>
		/// The collaborator can view and edit the project
		/// </summary>
		[EnumMember(Value = "WRITE")]
		Write,

		/// <summary>
		/// The collaborator can view, edit, and maange the settings of the project
		/// </summary>
		[EnumMember(Value = "ADMIN")]
		Admin,
	}
}
