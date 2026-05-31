// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{

	/// <summary>
	/// Represents an event related to a project on the timeline of an issue or pull request.
	/// </summary>
	public interface IProjectV2Event
	{
		/// <summary>
		/// Project referenced by event.
		/// </summary>
		ProjectV2? Project { get; set; }

		/// <summary>
		/// Did this event result from workflow automation?
		/// </summary>
		bool WasAutomated { get; set; }
	}
}

namespace FluentHub.Octokit.Models.v4
{
	public class ProjectV2Event : IProjectV2Event
	{
		public ProjectV2? Project { get; set; }

		public bool WasAutomated { get; set; }
	}
}

