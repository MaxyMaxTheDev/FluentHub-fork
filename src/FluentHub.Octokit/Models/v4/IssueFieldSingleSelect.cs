// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a single select issue field.
	/// </summary>
	public class IssueFieldSingleSelect
	{
		/// <summary>
		/// The issue field's creation timestamp.
		/// </summary>
		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Humanized string of "The issue field's creation timestamp."
		/// <summary>
		public string CreatedAtHumanized { get; set; }

		/// <summary>
		/// The issue field's data type.
		/// </summary>
		public IssueFieldDataType DataType { get; set; }

		/// <summary>
		/// The issue field's description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Identifies the primary key from the database as a BigInt.
		/// </summary>
		public string FullDatabaseId { get; set; }

		/// <summary>
		/// The Node ID of the IssueFieldSingleSelect object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The issue field's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Options for the single select field
		/// </summary>
		public List<IssueFieldSingleSelectOption> Options { get; set; }

		/// <summary>
		/// The issue field's visibility.
		/// </summary>
		public IssueFieldVisibility Visibility { get; set; }
	}
}
