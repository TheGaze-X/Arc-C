using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007DD RID: 2013
	[Token(Token = "0x20007DD")]
	public class RetroTrailRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x06006468 RID: 25704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006468")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RetroTrailRewardResponse()
		{
		}

		// Token: 0x040030FF RID: 12543
		[Token(Token = "0x40030FF")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemGet> items;
	}
}
