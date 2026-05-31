// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A single selection option for an issue field.
	/// </summary>
	public class IssueFieldSingleSelectOptionInput
	{
		/// <summary>
		/// The name of the option.
		/// </summary>
		public string Name { get; set; } = default!;

		/// <summary>
		/// The color associated with the option.
		/// </summary>
		public IssueFieldSingleSelectOptionColor Color { get; set; }

		/// <summary>
		/// A description of the option.
		/// </summary>
		public string? Description { get; set; }

		/// <summary>
		/// The priority of the option in the list.
		/// </summary>
		public int Priority { get; set; }
	}
}
