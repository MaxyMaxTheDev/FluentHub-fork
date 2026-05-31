// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// The possible values for an enabled/no policy enterprise setting.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EnterpriseDisallowedMethodsSettingValue
	{
		/// <summary>
		/// The setting prevents insecure 2FA methods from being used by members of the enterprise.
		/// </summary>
		[EnumMember(Value = "INSECURE")]
		Insecure,

		/// <summary>
		/// There is no policy set for preventing insecure 2FA methods from being used by members of the enterprise.
		/// </summary>
		[EnumMember(Value = "NO_POLICY")]
		NoPolicy,
	}
}
