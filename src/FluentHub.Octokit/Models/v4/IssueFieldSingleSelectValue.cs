// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The value of a single select field in an Issue item.
	/// </summary>
	public class IssueFieldSingleSelectValue
	{
		/// <summary>
		/// The option's display color.
		/// </summary>
		public IssueFieldSingleSelectOptionColor Color { get; set; }

		/// <summary>
		/// The option's plain-text description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The issue field that contains this value.
		/// </summary>
		public IssueFields Field { get; set; }

		/// <summary>
		/// The Node ID of the IssueFieldSingleSelectValue object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The option's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The selected option's global relay ID.
		/// </summary>
		public string OptionId { get; set; }

		/// <summary>
		/// The option's name text (alias for `name`, for consistency with other field value types).
		/// </summary>
		public string Value { get; set; }
	}
}
