// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The possible filters for suggested actors in a repository
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RepositorySuggestedActorFilter
	{
		/// <summary>
		/// Actors that can be assigned to issues and pull requests
		/// </summary>
		[EnumMember(Value = "CAN_BE_ASSIGNED")]
		CanBeAssigned,

		/// <summary>
		/// Actors that can be the author of issues and pull requests
		/// </summary>
		[EnumMember(Value = "CAN_BE_AUTHOR")]
		CanBeAuthor,
	}
}
