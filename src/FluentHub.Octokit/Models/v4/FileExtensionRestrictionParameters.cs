// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Prevent commits that include files with specified file extensions from being pushed to the commit graph.
	/// </summary>
	public class FileExtensionRestrictionParameters
	{
		/// <summary>
		/// The file extensions that are restricted from being pushed to the commit graph.
		/// </summary>
		public List<string> RestrictedFileExtensions { get; set; } = default!;
	}
}
