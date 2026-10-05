using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006E1 RID: 1761
	[Token(Token = "0x20006E1")]
	public class CrisisV2GetInfoResponse : PlayerDeltaResponse
	{
		// Token: 0x06006330 RID: 25392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006330")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public CrisisV2GetInfoResponse()
		{
		}

		// Token: 0x04002EF2 RID: 12018
		[Token(Token = "0x4002EF2")]
		[FieldOffset(Offset = "0x28")]
		public long ts;

		// Token: 0x04002EF3 RID: 12019
		[Token(Token = "0x4002EF3")]
		[FieldOffset(Offset = "0x30")]
		public CrisisV2CacheServerData info;
	}
}
