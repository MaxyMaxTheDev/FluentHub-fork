// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{

	/// <summary>
	/// Entities that can be pinned.
	/// </summary>
	public interface IPinnable
	{
		/// <summary>
		/// Indicates whether or not this entity is currently pinned.
		/// </summary>
		bool? IsPinned { get; set; }

		/// <summary>
		/// Identifies the date and time when this entity was pinned.
		/// </summary>
		DateTimeOffset? PinnedAt { get; set; }

		/// <summary>
		/// Humanized string of "Identifies the date and time when this entity was pinned."
		/// <summary>
		string PinnedAtHumanized { get; set; }

		/// <summary>
		/// The user who pinned this entity.
		/// </summary>
		User PinnedBy { get; set; }

		/// <summary>
		/// Check if the current viewer can pin this entity.
		/// </summary>
		bool ViewerCanPin { get; set; }

		/// <summary>
		/// Check if the current viewer can unpin this entity.
		/// </summary>
		bool ViewerCanUnpin { get; set; }
	}
}

namespace FluentHub.Octokit.Models.v4
{
	public class Pinnable : IPinnable
	{
		public bool? IsPinned { get; set; }

		public DateTimeOffset? PinnedAt { get; set; }

		public string PinnedAtHumanized { get; set; }

		public User PinnedBy { get; set; }

		public bool ViewerCanPin { get; set; }

		public bool ViewerCanUnpin { get; set; }
	}
}

