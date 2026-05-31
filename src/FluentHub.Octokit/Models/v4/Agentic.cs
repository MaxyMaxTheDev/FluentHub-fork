// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{

	/// <summary>
	/// Copilot Agentic fields in context of the current viewer.
	/// </summary>
	public interface IAgentic
	{
		/// <summary>
		/// Channel value for subscribing to live updates for session creations.
		/// </summary>
		string ViewerCopilotAgentCreatesChannel { get; set; }

		/// <summary>
		/// Channel value for subscribing to live updates for session log updates.
		/// </summary>
		string ViewerCopilotAgentLogUpdatesChannel { get; set; }

		/// <summary>
		/// Channel value for subscribing to live updates for task updates.
		/// </summary>
		string ViewerCopilotAgentTaskUpdatesChannel { get; set; }

		/// <summary>
		/// Channel value for subscribing to live updates for session updates.
		/// </summary>
		string ViewerCopilotAgentUpdatesChannel { get; set; }
	}
}

namespace FluentHub.Octokit.Models.v4
{
	public class Agentic : IAgentic
	{
		public string ViewerCopilotAgentCreatesChannel { get; set; }

		public string ViewerCopilotAgentLogUpdatesChannel { get; set; }

		public string ViewerCopilotAgentTaskUpdatesChannel { get; set; }

		public string ViewerCopilotAgentUpdatesChannel { get; set; }
	}
}

