// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The value of a date field in an Issue item.
	/// </summary>
	public class IssueFieldDateValue
	{
		/// <summary>
		/// The issue field that contains this value.
		/// </summary>
		public IssueFields Field { get; set; }

		/// <summary>
		/// The Node ID of the IssueFieldDateValue object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// Value of the field.
		/// </summary>
		public string Value { get; set; }
	}
}
