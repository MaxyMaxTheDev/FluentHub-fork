// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Possible issue fields.
	/// </summary>
	public class IssueFields
	{
		/// <summary>
		/// Represents a date issue field.
		/// </summary>
		public IssueFieldDate? IssueFieldDate { get; set; }

		/// <summary>
		/// Represents a number issue field.
		/// </summary>
		public IssueFieldNumber? IssueFieldNumber { get; set; }

		/// <summary>
		/// Represents a single select issue field.
		/// </summary>
		public IssueFieldSingleSelect? IssueFieldSingleSelect { get; set; }

		/// <summary>
		/// Represents a text issue field.
		/// </summary>
		public IssueFieldText? IssueFieldText { get; set; }
	}
}
