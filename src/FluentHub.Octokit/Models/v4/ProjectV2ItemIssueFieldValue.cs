// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The value of an issue field in a Project item.
	/// </summary>
	public class ProjectV2ItemIssueFieldValue
	{
		/// <summary>
		/// Field that contains this value.
		/// </summary>
		public ProjectV2FieldConfiguration Field { get; set; }

		/// <summary>
		/// Value of the Issue Field
		/// </summary>
		public ProjectV2IssueFieldValues IssueFieldValue { get; set; }
	}
}
