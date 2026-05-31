// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents an iteration field configuration.
	/// </summary>
	public class ProjectV2IterationFieldConfigurationInput
	{
		/// <summary>
		/// The start date for the first iteration.
		/// </summary>
		public string StartDate { get; set; } = default!;

		/// <summary>
		/// The duration of each iteration, in days.
		/// </summary>
		public int Duration { get; set; }

		/// <summary>
		/// Zero or more iterations for the field.
		/// </summary>
		public List<ProjectV2Iteration> Iterations { get; set; } = default!;
	}
}
