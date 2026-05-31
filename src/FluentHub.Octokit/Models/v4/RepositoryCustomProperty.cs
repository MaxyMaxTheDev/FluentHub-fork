// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A repository custom property.
	/// </summary>
	public class RepositoryCustomProperty
	{
		/// <summary>
		/// The allowed values for the custom property. Required if `value_type` is `single_select` or `multi_select`.
		/// </summary>
		public List<string> AllowedValues { get; set; }

		/// <summary>
		/// The default value of the custom property, if the property is `required`.
		/// </summary>
		public string DefaultValue { get; set; }

		/// <summary>
		/// The description of the custom property.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The Node ID of the RepositoryCustomProperty object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The name of the custom property.
		/// </summary>
		public string PropertyName { get; set; }

		/// <summary>
		/// The regex pattern that the value of the custom property must match, if the `value_type` is `string`.
		/// </summary>
		public string Regex { get; set; }

		/// <summary>
		/// Whether this repository custom property requires explicit values.
		/// </summary>
		public bool? RequireExplicitValues { get; set; }

		/// <summary>
		/// Whether the custom property is required.
		/// </summary>
		public bool? Required { get; set; }

		/// <summary>
		/// The source type of the custom property.
		/// </summary>
		public CustomPropertySource Source { get; set; }

		/// <summary>
		/// The value type of the custom property.
		/// </summary>
		public CustomPropertyValueType ValueType { get; set; }

		/// <summary>
		/// Who can edit the values of this repository custom property.
		/// </summary>
		public RepositoryCustomPropertyValuesEditableBy ValuesEditableBy { get; set; }
	}
}
