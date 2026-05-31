// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents an iteration
	/// </summary>
	public class ProjectV2Iteration
	{
		/// <summary>
		/// The start date for the iteration.
		/// </summary>
		public string StartDate { get; set; }

		/// <summary>
		/// The duration of the iteration, in days.
		/// </summary>
		public int Duration { get; set; }

		/// <summary>
		/// The title for the iteration.
		/// </summary>
		public string Title { get; set; }
	}
}
