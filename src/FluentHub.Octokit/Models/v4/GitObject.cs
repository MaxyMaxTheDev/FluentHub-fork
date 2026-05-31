// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{

	/// <summary>
	/// Represents a Git object.
	/// </summary>
	public interface IGitObject
	{
		/// <summary>
		/// An abbreviated version of the Git object ID
		/// </summary>
		string AbbreviatedOid { get; set; }

		/// <summary>
		/// The HTTP path for this Git object
		/// </summary>
		string CommitResourcePath { get; set; }

		/// <summary>
		/// The HTTP URL for this Git object
		/// </summary>
		string CommitUrl { get; set; }

		/// <summary>
		/// The Node ID of the GitObject object
		/// </summary>
		ID Id { get; set; }

		/// <summary>
		/// The Git object ID
		/// </summary>
		string Oid { get; set; }

		/// <summary>
		/// The Repository the Git object belongs to
		/// </summary>
		Repository Repository { get; set; }
	}
}

namespace FluentHub.Octokit.Models.v4
{
	public class GitObject : IGitObject
	{
		public string AbbreviatedOid { get; set; } = default!;

		public string CommitResourcePath { get; set; } = default!;

		public string CommitUrl { get; set; } = default!;

		public ID Id { get; set; }

		public string Oid { get; set; } = default!;

		public Repository Repository { get; set; } = default!;
	}
}

