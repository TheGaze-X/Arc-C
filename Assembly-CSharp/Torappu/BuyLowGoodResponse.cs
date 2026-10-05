using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200084C RID: 2124
	[Token(Token = "0x200084C")]
	public class BuyLowGoodResponse : PlayerDeltaResponse
	{
		// Token: 0x060064E3 RID: 25827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E3")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuyLowGoodResponse()
		{
		}

		// Token: 0x0400315A RID: 12634
		[Token(Token = "0x400315A")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
