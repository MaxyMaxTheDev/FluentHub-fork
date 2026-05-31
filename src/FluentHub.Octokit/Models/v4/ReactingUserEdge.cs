// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a user that's made a reaction.
	/// </summary>
	public class ReactingUserEdge
	{
		/// <summary>
		/// A cursor for use in pagination.
		/// </summary>
		public string Cursor { get; set; } = default!;

		public User Node { get; set; } = default!;

		/// <summary>
		/// The moment when the user made the reaction.
		/// </summary>
		public DateTimeOffset ReactedAt { get; set; }

		/// <summary>
		/// Humanized string of "The moment when the user made the reaction."
		/// <summary>
		public string? ReactedAtHumanized { get; set; }
	}
}
