// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// An announcement banner for an enterprise or organization.
	/// </summary>
	public class AnnouncementBanner
	{
		/// <summary>
		/// The date the announcement was created
		/// </summary>
		public DateTimeOffset CreatedAt { get; set; }

		/// <summary>
		/// Humanized string of "The date the announcement was created"
		/// <summary>
		public string CreatedAtHumanized { get; set; }

		/// <summary>
		/// The expiration date of the announcement, if any
		/// </summary>
		public DateTimeOffset? ExpiresAt { get; set; }

		/// <summary>
		/// Humanized string of "The expiration date of the announcement, if any"
		/// <summary>
		public string ExpiresAtHumanized { get; set; }

		/// <summary>
		/// Whether the announcement can be dismissed by the user
		/// </summary>
		public bool IsUserDismissible { get; set; }

		/// <summary>
		/// The text of the announcement
		/// </summary>
		public string Message { get; set; }
	}
}
