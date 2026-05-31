// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The allowed actors who can edit the values of a custom property.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RepositoryCustomPropertyValuesEditableBy
	{
		/// <summary>
		/// The organization actors.
		/// </summary>
		[EnumMember(Value = "ORG_ACTORS")]
		OrgActors,

		/// <summary>
		/// The organization and repository actors.
		/// </summary>
		[EnumMember(Value = "ORG_AND_REPO_ACTORS")]
		OrgAndRepoActors,
	}
}
