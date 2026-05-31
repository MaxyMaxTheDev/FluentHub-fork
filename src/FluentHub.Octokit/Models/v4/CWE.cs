// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A common weakness enumeration
	/// </summary>
	public class CWE
	{
		/// <summary>
		/// The id of the CWE
		/// </summary>
		public string CweId { get; set; } = default!;

		/// <summary>
		/// A detailed description of this CWE
		/// </summary>
		public string Description { get; set; } = default!;

		/// <summary>
		/// The Node ID of the CWE object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The name of this CWE
		/// </summary>
		public string Name { get; set; } = default!;
	}
}
