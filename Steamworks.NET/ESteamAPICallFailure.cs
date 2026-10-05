using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	public enum ESteamAPICallFailure
	{
		// Token: 0x0400077C RID: 1916
		[Token(Token = "0x400077C")]
		k_ESteamAPICallFailureNone = -1,
		// Token: 0x0400077D RID: 1917
		[Token(Token = "0x400077D")]
		k_ESteamAPICallFailureSteamGone,
		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		k_ESteamAPICallFailureNetworkFailure,
		// Token: 0x0400077F RID: 1919
		[Token(Token = "0x400077F")]
		k_ESteamAPICallFailureInvalidHandle,
		// Token: 0x04000780 RID: 1920
		[Token(Token = "0x4000780")]
		k_ESteamAPICallFailureMismatchedCallback
	}
}
