using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000167")]
	public enum ESteamNetworkingConnectionState
	{
		// Token: 0x04000940 RID: 2368
		[Token(Token = "0x4000940")]
		k_ESteamNetworkingConnectionState_None,
		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x4000941")]
		k_ESteamNetworkingConnectionState_Connecting,
		// Token: 0x04000942 RID: 2370
		[Token(Token = "0x4000942")]
		k_ESteamNetworkingConnectionState_FindingRoute,
		// Token: 0x04000943 RID: 2371
		[Token(Token = "0x4000943")]
		k_ESteamNetworkingConnectionState_Connected,
		// Token: 0x04000944 RID: 2372
		[Token(Token = "0x4000944")]
		k_ESteamNetworkingConnectionState_ClosedByPeer,
		// Token: 0x04000945 RID: 2373
		[Token(Token = "0x4000945")]
		k_ESteamNetworkingConnectionState_ProblemDetectedLocally,
		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x4000946")]
		k_ESteamNetworkingConnectionState_FinWait = -1,
		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x4000947")]
		k_ESteamNetworkingConnectionState_Linger = -2,
		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		k_ESteamNetworkingConnectionState_Dead = -3,
		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		k_ESteamNetworkingConnectionState__Force32Bit = 2147483647
	}
}
