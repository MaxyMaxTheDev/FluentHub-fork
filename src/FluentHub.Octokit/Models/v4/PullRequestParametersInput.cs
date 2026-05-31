// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Require all commits be made to a non-target branch and submitted via a pull request before they can be merged.
	/// </summary>
	public class PullRequestParametersInput
	{
		/// <summary>
		/// Array of allowed merge methods. Allowed values include `merge`, `squash`, and `rebase`. At least one option must be enabled.
		/// </summary>
		public List<PullRequestAllowedMergeMethods>? AllowedMergeMethods { get; set; }

		/// <summary>
		/// New, reviewable commits pushed will dismiss previous pull request review approvals.
		/// </summary>
		public bool DismissStaleReviewsOnPush { get; set; }

		/// <summary>
		/// Require an approving review in pull requests that modify files that have a designated code owner.
		/// </summary>
		public bool RequireCodeOwnerReview { get; set; }

		/// <summary>
		/// Whether the most recent reviewable push must be approved by someone other than the person who pushed it.
		/// </summary>
		public bool RequireLastPushApproval { get; set; }

		/// <summary>
		/// The number of approving reviews that are required before a pull request can be merged.
		/// </summary>
		public int RequiredApprovingReviewCount { get; set; }

		/// <summary>
		/// All conversations on code must be resolved before a pull request can be merged.
		/// </summary>
		public bool RequiredReviewThreadResolution { get; set; }

		/// <summary>
		/// This argument is in beta and subject to change. A collection of reviewers and associated file patterns. Each reviewer has a list of file patterns which determine the files that reviewer is required to review.
		/// </summary>
		public List<RequiredReviewerConfigurationInput>? RequiredReviewers { get; set; }
	}
}
