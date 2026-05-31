// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The custom property name and value to be set.
	/// </summary>
	public class CustomPropertyValueInput
	{
		/// <summary>
		/// The name of the custom property.
		/// </summary>
		public string PropertyName { get; set; } = default!;

		/// <summary>
		/// The value to set for the custom property. Using a value of null will unset the property value, reverting to the default value if the property is required.
		/// </summary>
		public string? Value { get; set; }
	}
}
