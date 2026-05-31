// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a single select field option
	/// </summary>
	public class ProjectV2SingleSelectFieldOptionInput
	{
		/// <summary>
		/// The ID of an existing single select option. Include this to preserve the option's identity during updates, preventing item field values from being cleared.
		/// </summary>
		public string? Id { get; set; }

		/// <summary>
		/// The name of the option
		/// </summary>
		public string Name { get; set; } = default!;

		/// <summary>
		/// The display color of the option
		/// </summary>
		public ProjectV2SingleSelectFieldOptionColor Color { get; set; }

		/// <summary>
		/// The description text of the option
		/// </summary>
		public string Description { get; set; } = default!;
	}
}
