// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The value of a text field in an Issue item.
	/// </summary>
	public class IssueFieldTextValue
	{
		/// <summary>
		/// The issue field that contains this value.
		/// </summary>
		public IssueFields Field { get; set; }

		/// <summary>
		/// The Node ID of the IssueFieldTextValue object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// Value of the field.
		/// </summary>
		public string Value { get; set; }
	}
}
