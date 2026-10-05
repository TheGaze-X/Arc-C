using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	public enum ESteamNetworkingGetConfigValueResult
	{
		// Token: 0x040009C1 RID: 2497
		[Token(Token = "0x40009C1")]
		k_ESteamNetworkingGetConfigValue_BadValue = -1,
		// Token: 0x040009C2 RID: 2498
		[Token(Token = "0x40009C2")]
		k_ESteamNetworkingGetConfigValue_BadScopeObj = -2,
		// Token: 0x040009C3 RID: 2499
		[Token(Token = "0x40009C3")]
		k_ESteamNetworkingGetConfigValue_BufferTooSmall = -3,
		// Token: 0x040009C4 RID: 2500
		[Token(Token = "0x40009C4")]
		k_ESteamNetworkingGetConfigValue_OK = 1,
		// Token: 0x040009C5 RID: 2501
		[Token(Token = "0x40009C5")]
		k_ESteamNetworkingGetConfigValue_OKInherited,
		// Token: 0x040009C6 RID: 2502
		[Token(Token = "0x40009C6")]
		k_ESteamNetworkingGetConfigValueResult__Force32Bit = 2147483647
	}
}
