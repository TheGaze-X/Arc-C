using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	public enum EDenyReason
	{
		// Token: 0x04000833 RID: 2099
		[Token(Token = "0x4000833")]
		k_EDenyInvalid,
		// Token: 0x04000834 RID: 2100
		[Token(Token = "0x4000834")]
		k_EDenyInvalidVersion,
		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x4000835")]
		k_EDenyGeneric,
		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		k_EDenyNotLoggedOn,
		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		k_EDenyNoLicense,
		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		k_EDenyCheater,
		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		k_EDenyLoggedInElseWhere,
		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x400083A")]
		k_EDenyUnknownText,
		// Token: 0x0400083B RID: 2107
		[Token(Token = "0x400083B")]
		k_EDenyIncompatibleAnticheat,
		// Token: 0x0400083C RID: 2108
		[Token(Token = "0x400083C")]
		k_EDenyMemoryCorruption,
		// Token: 0x0400083D RID: 2109
		[Token(Token = "0x400083D")]
		k_EDenyIncompatibleSoftware,
		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x400083E")]
		k_EDenySteamConnectionLost,
		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x400083F")]
		k_EDenySteamConnectionError,
		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x4000840")]
		k_EDenySteamResponseTimedOut,
		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		k_EDenySteamValidationStalled,
		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		k_EDenySteamOwnerLeftGuestUser
	}
}
