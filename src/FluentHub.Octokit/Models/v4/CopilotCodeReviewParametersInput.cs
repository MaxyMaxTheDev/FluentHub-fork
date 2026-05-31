// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Request Copilot code review for new pull requests automatically if the author has access to Copilot code review and their premium requests quota has not reached the limit.
	/// </summary>
	public class CopilotCodeReviewParametersInput
	{
		/// <summary>
		/// Copilot automatically reviews draft pull requests before they are marked as ready for review.
		/// </summary>
		public bool? ReviewDraftPullRequests { get; set; }

		/// <summary>
		/// Copilot automatically reviews each new push to the pull request.
		/// </summary>
		public bool? ReviewOnPush { get; set; }
	}
}
