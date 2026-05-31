// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A single check annotation.
	/// </summary>
	public class CheckAnnotation
	{
		/// <summary>
		/// The annotation's severity level.
		/// </summary>
		public CheckAnnotationLevel? AnnotationLevel { get; set; }

		/// <summary>
		/// The path to the file that this annotation was made on.
		/// </summary>
		public string BlobUrl { get; set; }

		/// <summary>
		/// Identifies the primary key from the database.
		/// </summary>
		[Obsolete(@"`databaseId` will be removed because it does not support 64-bit signed integer identifiers. Use `fullDatabaseId` instead. Removal on 2027-01-01 UTC.")]
		public int? DatabaseId { get; set; }

		/// <summary>
		/// Identifies the primary key from the database as a BigInt.
		/// </summary>
		public string FullDatabaseId { get; set; }

		/// <summary>
		/// The position of this annotation.
		/// </summary>
		public CheckAnnotationSpan Location { get; set; }

		/// <summary>
		/// The annotation's message.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// The path that this annotation was made on.
		/// </summary>
		public string Path { get; set; }

		/// <summary>
		/// Additional information about the annotation.
		/// </summary>
		public string RawDetails { get; set; }

		/// <summary>
		/// The annotation's title
		/// </summary>
		public string Title { get; set; }
	}
}
