// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// A repository owned by an Enterprise Managed user.
	/// </summary>
	public class UserNamespaceRepository
	{
		/// <summary>
		/// The Node ID of the UserNamespaceRepository object
		/// </summary>
		public ID Id { get; set; }

		/// <summary>
		/// The name of the repository.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The repository's name with owner.
		/// </summary>
		public string NameWithOwner { get; set; }

		/// <summary>
		/// The user owner of the repository.
		/// </summary>
		public IRepositoryOwner Owner { get; set; }
	}
}
