// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents an issue field value that must be set on an issue during issue creation
	/// </summary>
	public class IssueFieldCreateOrUpdateInput
	{
		/// <summary>
		/// The ID of the issue field
		/// </summary>
		public ID FieldId { get; set; }

		/// <summary>
		/// The text value, for a text field
		/// </summary>
		public string? TextValue { get; set; }

		/// <summary>
		/// The date value, for a date field
		/// </summary>
		public string? DateValue { get; set; }

		/// <summary>
		/// The ID of the selected option, for a single select field
		/// </summary>
		public ID? SingleSelectOptionId { get; set; }

		/// <summary>
		/// The numeric value, for a number field
		/// </summary>
		public double? NumberValue { get; set; }

		/// <summary>
		/// Set to true to delete the field value
		/// </summary>
		public bool? Delete { get; set; }
	}
}
