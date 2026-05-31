// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Summary of the state of an issue's dependencies
	/// </summary>
	public class IssueDependenciesSummary
	{
		/// <summary>
		/// Count of issues this issue is blocked by
		/// </summary>
		public int BlockedBy { get; set; }

		/// <summary>
		/// Count of issues this issue is blocking
		/// </summary>
		public int Blocking { get; set; }

		/// <summary>
		/// Total count of issues this issue is blocked by (open and closed)
		/// </summary>
		public int TotalBlockedBy { get; set; }

		/// <summary>
		/// Total count of issues this issue is blocking (open and closed)
		/// </summary>
		public int TotalBlocking { get; set; }
	}
}
