// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A value associated with a repository custom property.
	/// </summary>
	public class RepositoryCustomPropertyValue
	{
		/// <summary>
		/// The name of the custom property.
		/// </summary>
		public string PropertyName { get; set; } = default!;

		/// <summary>
		/// The value of the custom property.
		/// </summary>
		public string Value { get; set; } = default!;
	}
}
