// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The possible organization selection types for an enterprise team.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnterpriseTeamOrganizationSelectionType
	{
		/// <summary>
		/// The team is not associated with any organizations.
		/// </summary>
		[EnumMember(Value = "DISABLED")]
		Disabled,

		/// <summary>
		/// The team is associated with all organizations in the enterprise.
		/// </summary>
		[EnumMember(Value = "ALL")]
		All,

		/// <summary>
		/// The team is associated with selected organizations.
		/// </summary>
		[EnumMember(Value = "SELECTED")]
		Selected,
	}
}
