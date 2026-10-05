using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200084E RID: 2126
	[Token(Token = "0x200084E")]
	public class BuyExtraGoodResponse : PlayerDeltaResponse
	{
		// Token: 0x060064E5 RID: 25829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E5")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuyExtraGoodResponse()
		{
		}

		// Token: 0x0400315D RID: 12637
		[Token(Token = "0x400315D")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
