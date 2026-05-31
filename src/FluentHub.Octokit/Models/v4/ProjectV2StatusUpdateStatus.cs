// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The possible statuses of a project v2.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ProjectV2StatusUpdateStatus
	{
		/// <summary>
		/// A project v2 that is inactive.
		/// </summary>
		[EnumMember(Value = "INACTIVE")]
		Inactive,

		/// <summary>
		/// A project v2 that is on track with no risks.
		/// </summary>
		[EnumMember(Value = "ON_TRACK")]
		OnTrack,

		/// <summary>
		/// A project v2 that is at risk and encountering some challenges.
		/// </summary>
		[EnumMember(Value = "AT_RISK")]
		AtRisk,

		/// <summary>
		/// A project v2 that is off track and needs attention.
		/// </summary>
		[EnumMember(Value = "OFF_TRACK")]
		OffTrack,

		/// <summary>
		/// A project v2 that is complete.
		/// </summary>
		[EnumMember(Value = "COMPLETE")]
		Complete,
	}
}
