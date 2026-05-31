// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{

	/// <summary>
	/// An object that can have labels assigned to it.
	/// </summary>
	public interface ILabelable
	{
		/// <summary>
		/// A list of labels associated with the object.
		/// </summary>
		/// <param name="first">Returns the first _n_ elements from the list.</param>
		/// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
		/// <param name="last">Returns the last _n_ elements from the list.</param>
		/// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
		/// <param name="orderBy">Ordering options for labels returned from the connection.</param>
		LabelConnection? Labels { get; set; }

		/// <summary>
		/// Indicates if the viewer can edit labels for this object.
		/// </summary>
		bool ViewerCanLabel { get; set; }
	}
}

namespace FluentHub.Octokit.Models.v4
{
	public class Labelable : ILabelable
	{
		public LabelConnection? Labels { get; set; }

		public bool ViewerCanLabel { get; set; }
	}
}

