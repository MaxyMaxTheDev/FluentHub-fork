// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Prevent commits with individual files that exceed the specified limit from being pushed to the commit graph.
	/// </summary>
	public class MaxFileSizeParameters
	{
		/// <summary>
		/// The maximum file size allowed in megabytes. This limit does not apply to Git Large File Storage (Git LFS).
		/// </summary>
		public int MaxFileSize { get; set; }
	}
}
