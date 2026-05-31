// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a Git tag.
	/// </summary>
	public class Tag
	{
		/// <summary>
		/// An abbreviated version of the Git object ID
		/// </summary>
		public string AbbreviatedOid { get; set; } = default!;

		/// <summary>
		/// The HTTP path for this Git object
		/// </summary>
		public string CommitResourcePath { get; set; } = default!;

		/// <summary>
		/// The HTTP URL for this Git object
		/// </summary>
		public string CommitUrl { get; set; } = default!;

		/// <summary>
		/// The Node ID of the Tag object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The Git tag message.
		/// </summary>
		public string? Message { get; set; }

		/// <summary>
		/// The Git tag name.
		/// </summary>
		public string Name { get; set; } = default!;

		/// <summary>
		/// The Git object ID
		/// </summary>
		public string Oid { get; set; } = default!;

		/// <summary>
		/// The Repository the Git object belongs to
		/// </summary>
		public Repository Repository { get; set; } = default!;

		/// <summary>
		/// Details about the tag author.
		/// </summary>
		public GitActor? Tagger { get; set; }

		/// <summary>
		/// The Git object the tag points to.
		/// </summary>
		public IGitObject Target { get; set; } = default!;
	}
}
