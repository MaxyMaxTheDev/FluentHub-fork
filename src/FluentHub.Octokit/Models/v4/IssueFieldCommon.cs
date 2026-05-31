// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{

	/// <summary>
	/// Common fields across different issue field types
	/// </summary>
	public interface IIssueFieldCommon
	{
		/// <summary>
		/// The issue field's creation timestamp.
		/// </summary>
		DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Humanized string of "The issue field's creation timestamp."
		/// <summary>
		string? CreatedAtHumanized { get; set; }

		/// <summary>
		/// The issue field's data type.
		/// </summary>
		IssueFieldDataType DataType { get; set; }

		/// <summary>
		/// The issue field's description.
		/// </summary>
		string? Description { get; set; }

		/// <summary>
		/// Identifies the primary key from the database as a BigInt.
		/// </summary>
		string? FullDatabaseId { get; set; }

		/// <summary>
		/// The issue field's name.
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// The issue field's visibility.
		/// </summary>
		IssueFieldVisibility Visibility { get; set; }
	}
}

namespace FluentHub.Octokit.Models.v4
{
	public class SsueFieldCommon : IIssueFieldCommon
	{
		public DateTimeOffset CreatedAt { get; set; }

		public string? CreatedAtHumanized { get; set; }

		public IssueFieldDataType DataType { get; set; }

		public string? Description { get; set; }

		public string? FullDatabaseId { get; set; }

		public string Name { get; set; } = default!;

		public IssueFieldVisibility Visibility { get; set; }
	}
}

