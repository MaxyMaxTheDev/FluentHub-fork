// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The content warning for a repository
	/// </summary>
	public class ContentWarning
	{
		/// <summary>
		/// The content warning' category. E.g. 'mis_dis_information'
		/// </summary>
		public string Category { get; set; }

		/// <summary>
		/// The content warning's custom sub category text. E.g. 'dangerous stuff.'
		/// </summary>
		public string CustomSubCategory { get; set; }

		/// <summary>
		/// The content warning's sub category. E.g. 'medical_scientific'
		/// </summary>
		public string SubCategory { get; set; }

		/// <summary>
		/// The content warning's sub title. E.g. 'The information contained in this page has not been verified.'
		/// </summary>
		public string SubTitle { get; set; }

		/// <summary>
		/// The content warning's title. E.g. 'This page may contain false or misleading information.'
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// The type of content warning. E.g. 'interstitial'
		/// </summary>
		public string Type { get; set; }
	}
}
