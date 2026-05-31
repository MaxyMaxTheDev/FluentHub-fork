// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Summary of the state of an issue's sub-issues
	/// </summary>
	public class SubIssuesSummary
	{
		/// <summary>
		/// Count of completed sub-issues
		/// </summary>
		public int Completed { get; set; }

		/// <summary>
		/// Percent of sub-issues which are completed
		/// </summary>
		public int PercentCompleted { get; set; }

		/// <summary>
		/// Count of total number of sub-issues
		/// </summary>
		public int Total { get; set; }
	}
}
