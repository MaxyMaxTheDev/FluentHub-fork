// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The value of a number field in an Issue item.
	/// </summary>
	public class IssueFieldNumberValue
	{
		/// <summary>
		/// The issue field that contains this value.
		/// </summary>
		public IssueFields Field { get; set; }

		/// <summary>
		/// The Node ID of the IssueFieldNumberValue object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// Value of the field.
		/// </summary>
		public double Value { get; set; }
	}
}
