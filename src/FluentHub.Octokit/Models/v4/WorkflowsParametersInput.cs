// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Require all changes made to a targeted branch to pass the specified workflows before they can be merged.
	/// </summary>
	public class WorkflowsParametersInput
	{
		/// <summary>
		/// Allow repositories and branches to be created if a check would otherwise prohibit it.
		/// </summary>
		public bool? DoNotEnforceOnCreate { get; set; }

		/// <summary>
		/// Workflows that must pass for this rule to pass.
		/// </summary>
		public List<WorkflowFileReferenceInput> Workflows { get; set; }
	}
}
