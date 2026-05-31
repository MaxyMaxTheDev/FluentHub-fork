// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Possible issue field values for a Project item.
	/// </summary>
	public class ProjectV2IssueFieldValues
	{
		/// <summary>
		/// The value of a date field in an Issue item.
		/// </summary>
		public IssueFieldDateValue? IssueFieldDateValue { get; set; }

		/// <summary>
		/// The value of a number field in an Issue item.
		/// </summary>
		public IssueFieldNumberValue? IssueFieldNumberValue { get; set; }

		/// <summary>
		/// The value of a single select field in an Issue item.
		/// </summary>
		public IssueFieldSingleSelectValue? IssueFieldSingleSelectValue { get; set; }

		/// <summary>
		/// The value of a text field in an Issue item.
		/// </summary>
		public IssueFieldTextValue? IssueFieldTextValue { get; set; }
	}
}
