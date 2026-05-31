// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// An error produced from a Dependabot Update
	/// </summary>
	public class DependabotUpdateError
	{
		/// <summary>
		/// The body of the error
		/// </summary>
		public string Body { get; set; } = default!;

		/// <summary>
		/// The error code
		/// </summary>
		public string ErrorType { get; set; } = default!;

		/// <summary>
		/// The title of the error
		/// </summary>
		public string Title { get; set; } = default!;
	}
}
