// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents an option in a single-select issue field.
	/// </summary>
	public class IssueFieldSingleSelectOption
	{
		/// <summary>
		/// The option's display color.
		/// </summary>
		public IssueFieldSingleSelectOptionColor Color { get; set; }

		/// <summary>
		/// Identifies the primary key from the database.
		/// </summary>
		public int? DatabaseId { get; set; }

		/// <summary>
		/// The option's plain-text description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Identifies the primary key from the database as a BigInt.
		/// </summary>
		public string FullDatabaseId { get; set; }

		/// <summary>
		/// The Node ID of the IssueFieldSingleSelectOption object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The option's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The option's priority order.
		/// </summary>
		public int? Priority { get; set; }
	}
}
