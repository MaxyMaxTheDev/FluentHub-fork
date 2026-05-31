// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A reviewing team, and file patterns describing which files they must approve changes to.
	/// </summary>
	public class RequiredReviewerConfigurationInput
	{
		/// <summary>
		/// Array of file patterns. Pull requests which change matching files must be approved by the specified team. File patterns use fnmatch syntax.
		/// </summary>
		public List<string> FilePatterns { get; set; }

		/// <summary>
		/// Minimum number of approvals required from the specified team. If set to zero, the team will be added to the pull request but approval is optional.
		/// </summary>
		public int MinimumApprovals { get; set; }

		/// <summary>
		/// Node ID of the team which must review changes to matching files.
		/// </summary>
		public ID ReviewerId { get; set; }
	}
}
