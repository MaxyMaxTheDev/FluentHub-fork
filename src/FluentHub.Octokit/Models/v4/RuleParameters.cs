// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Types which can be parameters for `RepositoryRule` objects.
	/// </summary>
	public class RuleParameters
	{
		/// <summary>
		/// Parameters to be used for the branch_name_pattern rule
		/// </summary>
		public BranchNamePatternParameters BranchNamePatternParameters { get; set; }

		/// <summary>
		/// Choose which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated.
		/// </summary>
		public CodeScanningParameters CodeScanningParameters { get; set; }

		/// <summary>
		/// Parameters to be used for the commit_author_email_pattern rule
		/// </summary>
		public CommitAuthorEmailPatternParameters CommitAuthorEmailPatternParameters { get; set; }

		/// <summary>
		/// Parameters to be used for the commit_message_pattern rule
		/// </summary>
		public CommitMessagePatternParameters CommitMessagePatternParameters { get; set; }

		/// <summary>
		/// Parameters to be used for the committer_email_pattern rule
		/// </summary>
		public CommitterEmailPatternParameters CommitterEmailPatternParameters { get; set; }

		/// <summary>
		/// Request Copilot code review for new pull requests automatically if the author has access to Copilot code review and their premium requests quota has not reached the limit.
		/// </summary>
		public CopilotCodeReviewParameters CopilotCodeReviewParameters { get; set; }

		/// <summary>
		/// Prevent commits that include files with specified file extensions from being pushed to the commit graph.
		/// </summary>
		public FileExtensionRestrictionParameters FileExtensionRestrictionParameters { get; set; }

		/// <summary>
		/// Prevent commits that include changes in specified file and folder paths from being pushed to the commit graph. This includes absolute paths that contain file names.
		/// </summary>
		public FilePathRestrictionParameters FilePathRestrictionParameters { get; set; }

		/// <summary>
		/// Prevent commits that include file paths that exceed the specified character limit from being pushed to the commit graph.
		/// </summary>
		public MaxFilePathLengthParameters MaxFilePathLengthParameters { get; set; }

		/// <summary>
		/// Prevent commits with individual files that exceed the specified limit from being pushed to the commit graph.
		/// </summary>
		public MaxFileSizeParameters MaxFileSizeParameters { get; set; }

		/// <summary>
		/// Merges must be performed via a merge queue.
		/// </summary>
		public MergeQueueParameters MergeQueueParameters { get; set; }

		/// <summary>
		/// Require all commits be made to a non-target branch and submitted via a pull request before they can be merged.
		/// </summary>
		public PullRequestParameters PullRequestParameters { get; set; }

		/// <summary>
		/// Choose which environments must be successfully deployed to before refs can be pushed into a ref that matches this rule.
		/// </summary>
		public RequiredDeploymentsParameters RequiredDeploymentsParameters { get; set; }

		/// <summary>
		/// Choose which status checks must pass before the ref is updated. When enabled, commits must first be pushed to another ref where the checks pass.
		/// </summary>
		public RequiredStatusChecksParameters RequiredStatusChecksParameters { get; set; }

		/// <summary>
		/// Parameters to be used for the tag_name_pattern rule
		/// </summary>
		public TagNamePatternParameters TagNamePatternParameters { get; set; }

		/// <summary>
		/// Only allow users with bypass permission to update matching refs.
		/// </summary>
		public UpdateParameters UpdateParameters { get; set; }

		/// <summary>
		/// Require all changes made to a targeted branch to pass the specified workflows before they can be merged.
		/// </summary>
		public WorkflowsParameters WorkflowsParameters { get; set; }
	}
}
