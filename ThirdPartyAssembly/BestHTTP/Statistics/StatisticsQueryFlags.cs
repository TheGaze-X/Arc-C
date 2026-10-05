using System;
using Il2CppDummyDll;

namespace BestHTTP.Statistics
{
	// Token: 0x020004BE RID: 1214
	[Token(Token = "0x20004BE")]
	[Flags]
	public enum StatisticsQueryFlags : byte
	{
		// Token: 0x04001643 RID: 5699
		[Token(Token = "0x4001643")]
		Connections = 1,
		// Token: 0x04001644 RID: 5700
		[Token(Token = "0x4001644")]
		Cache = 2,
		// Token: 0x04001645 RID: 5701
		[Token(Token = "0x4001645")]
		Cookies = 4,
		// Token: 0x04001646 RID: 5702
		[Token(Token = "0x4001646")]
		All = 255
	}
}
