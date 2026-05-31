// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Properties by which enterprise team connections can be ordered.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnterpriseTeamOrderField
	{
		/// <summary>
		/// Order enterprise teams by ID.
		/// </summary>
		[EnumMember(Value = "ID")]
		Id,

		/// <summary>
		/// Order enterprise teams by name.
		/// </summary>
		[EnumMember(Value = "NAME")]
		Name,

		/// <summary>
		/// Order enterprise teams by creation time.
		/// </summary>
		[EnumMember(Value = "CREATED_AT")]
		CreatedAt,
	}
}
