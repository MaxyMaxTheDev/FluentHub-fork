// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{

	/// <summary>
	/// Common fields across different issue field value types
	/// </summary>
	public interface IIssueFieldValueCommon
	{
		/// <summary>
		/// The issue field that contains this value.
		/// </summary>
		IssueFields Field { get; set; }
	}
}

namespace FluentHub.Octokit.Models.v4
{
	public class SsueFieldValueCommon : IIssueFieldValueCommon
	{
		public IssueFields Field { get; set; }
	}
}

