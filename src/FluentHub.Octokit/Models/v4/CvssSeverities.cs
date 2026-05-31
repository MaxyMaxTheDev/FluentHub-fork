// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The Common Vulnerability Scoring System
	/// </summary>
	public class CvssSeverities
	{
		/// <summary>
		/// The CVSS v3 severity associated with this advisory
		/// </summary>
		public CVSS? CvssV3 { get; set; }

		/// <summary>
		/// The CVSS v4 severity associated with this advisory
		/// </summary>
		public CVSS? CvssV4 { get; set; }
	}
}
