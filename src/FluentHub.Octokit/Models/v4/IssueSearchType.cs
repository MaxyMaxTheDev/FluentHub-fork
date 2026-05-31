// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Type of issue search performed
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum IssueSearchType
	{
		/// <summary>
		/// Lexical (keyword-based) search
		/// </summary>
		[EnumMember(Value = "LEXICAL")]
		Lexical,

		/// <summary>
		/// Semantic (meaning-based) search using embeddings
		/// </summary>
		[EnumMember(Value = "SEMANTIC")]
		Semantic,

		/// <summary>
		/// Hybrid search combining lexical and semantic approaches
		/// </summary>
		[EnumMember(Value = "HYBRID")]
		Hybrid,
	}
}
