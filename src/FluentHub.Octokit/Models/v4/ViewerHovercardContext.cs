// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A hovercard context with a message describing how the viewer is related.
	/// </summary>
	public class ViewerHovercardContext
	{
		/// <summary>
		/// A string describing this context
		/// </summary>
		public string Message { get; set; } = default!;

		/// <summary>
		/// An octicon to accompany this context
		/// </summary>
		public string Octicon { get; set; } = default!;

		/// <summary>
		/// Identifies the user who is related to this context.
		/// </summary>
		public User Viewer { get; set; } = default!;
	}
}
