// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{

	/// <summary>
	/// Comments that can be updated.
	/// </summary>
	public interface IUpdatableComment
	{
		/// <summary>
		/// Reasons why the current viewer can not update this comment.
		/// </summary>
		List<CommentCannotUpdateReason> ViewerCannotUpdateReasons { get; set; }
	}
}

namespace FluentHub.Octokit.Models.v4
{
	public class UpdatableComment : IUpdatableComment
	{
		public List<CommentCannotUpdateReason> ViewerCannotUpdateReasons { get; set; } = default!;
	}
}

