// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Whether a user being viewed contains public or private information.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum UserViewType
	{
		/// <summary>
		/// A user that is publicly visible.
		/// </summary>
		[EnumMember(Value = "PUBLIC")]
		Public,

		/// <summary>
		/// A user containing information only visible to the authenticated user.
		/// </summary>
		[EnumMember(Value = "PRIVATE")]
		Private,
	}
}
