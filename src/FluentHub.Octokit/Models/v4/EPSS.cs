// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The Exploit Prediction Scoring System
	/// </summary>
	public class EPSS
	{
		/// <summary>
		/// The EPSS percentage represents the likelihood of a CVE being exploited.
		/// </summary>
		public double? Percentage { get; set; }

		/// <summary>
		/// The EPSS percentile represents the relative rank of the CVE's likelihood of being exploited compared to other CVEs.
		/// </summary>
		public double? Percentile { get; set; }
	}
}
