// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The possible archived states of a project card.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ProjectCardArchivedState
	{
		/// <summary>
		/// A project card that is archived
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		[EnumMember(Value = "ARCHIVED")]
		Archived,

		/// <summary>
		/// A project card that is not archived
		/// </summary>
		[Obsolete(@"Projects (classic) is being deprecated in favor of the new Projects experience, see: https://github.blog/changelog/2024-05-23-sunset-notice-projects-classic/. Removal on 2025-04-01 UTC.")]
		[EnumMember(Value = "NOT_ARCHIVED")]
		NotArchived,
	}
}
