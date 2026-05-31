// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Reason why a semantic or hybrid issue search fell back to lexical search
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LexicalFallbackReason
	{
		/// <summary>
		/// Query contains quoted text requiring exact matches
		/// </summary>
		[EnumMember(Value = "QUOTED_TEXT")]
		QuotedText,

		/// <summary>
		/// Query has only qualifiers and no free text terms
		/// </summary>
		[EnumMember(Value = "NO_TEXT_TERMS")]
		NoTextTerms,

		/// <summary>
		/// Embedding generation failed or timed out
		/// </summary>
		[EnumMember(Value = "SERVER_ERROR")]
		ServerError,

		/// <summary>
		/// Query uses an in: qualifier targeting non-semantic fields
		/// </summary>
		[EnumMember(Value = "ONLY_NON_SEMANTIC_FIELDS_REQUESTED")]
		OnlyNonSemanticFieldsRequested,

		/// <summary>
		/// Query contains OR operators (nested boolean qualifiers)
		/// </summary>
		[EnumMember(Value = "OR_BOOLEAN_NOT_SUPPORTED")]
		OrBooleanNotSupported,

		/// <summary>
		/// Query targets non-issue types (e.g., pull requests)
		/// </summary>
		[EnumMember(Value = "NON_ISSUE_TARGET")]
		NonIssueTarget,

		/// <summary>
		/// Scoped query resolved to zero accessible repositories
		/// </summary>
		[EnumMember(Value = "NO_ACCESSIBLE_REPOS")]
		NoAccessibleRepos,
	}
}
