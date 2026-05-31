// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Prevent commits that include changes in specified file and folder paths from being pushed to the commit graph. This includes absolute paths that contain file names.
	/// </summary>
	public class FilePathRestrictionParametersInput
	{
		/// <summary>
		/// The file paths that are restricted from being pushed to the commit graph.
		/// </summary>
		public List<string> RestrictedFilePaths { get; set; } = default!;
	}
}
