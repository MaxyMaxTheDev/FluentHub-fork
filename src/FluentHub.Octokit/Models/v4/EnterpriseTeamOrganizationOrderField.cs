// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Properties by which enterprise team organization connections can be ordered.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnterpriseTeamOrganizationOrderField
	{
		/// <summary>
		/// Order enterprise team organizations by ID.
		/// </summary>
		[EnumMember(Value = "ID")]
		Id,

		/// <summary>
		/// Order enterprise team organizations by login.
		/// </summary>
		[EnumMember(Value = "LOGIN")]
		Login,

		/// <summary>
		/// Order enterprise team organizations by creation time.
		/// </summary>
		[EnumMember(Value = "CREATED_AT")]
		CreatedAt,
	}
}
