// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Required status check
	/// </summary>
	public class StatusCheckConfiguration
	{
		/// <summary>
		/// The status check context name that must be present on the commit.
		/// </summary>
		public string Context { get; set; } = default!;

		/// <summary>
		/// The optional integration ID that this status check must originate from.
		/// </summary>
		public int? IntegrationId { get; set; }
	}
}
