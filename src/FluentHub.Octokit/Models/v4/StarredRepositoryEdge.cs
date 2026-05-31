// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a starred repository.
	/// </summary>
	public class StarredRepositoryEdge
	{
		/// <summary>
		/// A cursor for use in pagination.
		/// </summary>
		public string Cursor { get; set; } = default!;

		public Repository Node { get; set; } = default!;

		/// <summary>
		/// Identifies when the item was starred.
		/// </summary>
		public DateTimeOffset StarredAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies when the item was starred."
		/// <summary>
		public string? StarredAtHumanized { get; set; }
	}
}
