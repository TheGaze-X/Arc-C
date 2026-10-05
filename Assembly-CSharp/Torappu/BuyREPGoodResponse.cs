using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000858 RID: 2136
	[Token(Token = "0x2000858")]
	public class BuyREPGoodResponse : PlayerDeltaResponse
	{
		// Token: 0x060064EF RID: 25839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EF")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuyREPGoodResponse()
		{
		}

		// Token: 0x0400316C RID: 12652
		[Token(Token = "0x400316C")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
