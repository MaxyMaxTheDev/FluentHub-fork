// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Parameters to be used for the organization_property condition
	/// </summary>
	public class OrganizationPropertyConditionTargetInput
	{
		/// <summary>
		/// Array of organization properties that must not match.
		/// </summary>
		public List<OrganizationPropertyTargetDefinitionInput> Exclude { get; set; } = default!;

		/// <summary>
		/// Array of organization properties that must match
		/// </summary>
		public List<OrganizationPropertyTargetDefinitionInput> Include { get; set; } = default!;
	}
}
