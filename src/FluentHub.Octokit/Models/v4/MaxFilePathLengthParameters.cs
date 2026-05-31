// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Prevent commits that include file paths that exceed the specified character limit from being pushed to the commit graph.
	/// </summary>
	public class MaxFilePathLengthParameters
	{
		/// <summary>
		/// The maximum amount of characters allowed in file paths.
		/// </summary>
		public int MaxFilePathLength { get; set; }
	}
}
