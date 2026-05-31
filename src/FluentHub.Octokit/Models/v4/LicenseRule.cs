// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Describes a License's conditions, permissions, and limitations
	/// </summary>
	public class LicenseRule
	{
		/// <summary>
		/// A description of the rule
		/// </summary>
		public string Description { get; set; } = default!;

		/// <summary>
		/// The machine-readable rule key
		/// </summary>
		public string Key { get; set; } = default!;

		/// <summary>
		/// The human-readable rule label
		/// </summary>
		public string Label { get; set; } = default!;
	}
}
