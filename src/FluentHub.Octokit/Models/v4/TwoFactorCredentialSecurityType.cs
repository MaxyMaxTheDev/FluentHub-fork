// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Filters by whether or not 2FA is enabled and if the method configured is considered secure or insecure.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TwoFactorCredentialSecurityType
	{
		/// <summary>
		/// Has only secure methods of two-factor authentication.
		/// </summary>
		[EnumMember(Value = "SECURE")]
		Secure,

		/// <summary>
		/// Has an insecure method of two-factor authentication. GitHub currently defines this as SMS two-factor authentication.
		/// </summary>
		[EnumMember(Value = "INSECURE")]
		Insecure,

		/// <summary>
		/// No method of two-factor authentication.
		/// </summary>
		[EnumMember(Value = "DISABLED")]
		Disabled,
	}
}
