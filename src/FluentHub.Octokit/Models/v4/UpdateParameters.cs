// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Only allow users with bypass permission to update matching refs.
	/// </summary>
	public class UpdateParameters
	{
		/// <summary>
		/// Branch can pull changes from its upstream repository
		/// </summary>
		public bool UpdateAllowsFetchAndMerge { get; set; }
	}
}
