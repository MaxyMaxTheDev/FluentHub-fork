// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents the type of Issue.
	/// </summary>
	public class IssueType
	{
		/// <summary>
		/// The issue type's color.
		/// </summary>
		public IssueTypeColor Color { get; set; }

		/// <summary>
		/// The issue type's description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// The Node ID of the IssueType object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The issue type's enabled state.
		/// </summary>
		public bool IsEnabled { get; set; }

		/// <summary>
		/// Whether the issue type is publicly visible.
		/// </summary>
		[Obsolete(@"Private issue types are being deprecated and can no longer be created. Removal on 2025-04-01 UTC.")]
		public bool IsPrivate { get; set; }

		/// <summary>
		/// The issues with this issue type in the given repository.
		/// </summary>
		/// <param name="repositoryId">Target repository to load the issues from.</param>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		/// <param name="filterBy">Filtering options for issues returned from the connection.</param>
		/// <param name="labels">A list of label names to filter the pull requests by.</param>
		/// <param name="orderBy">Ordering options for issues returned from the connection.</param>
		/// <param name="states">A list of states to filter the issues by.</param>
		public IssueConnection Issues { get; set; }

		/// <summary>
		/// The issue type's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// An ordered list of issue fields pinned to this type.
		/// </summary>
		public List<IssueFields> PinnedFields { get; set; }
	}
}
