using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000853 RID: 2131
	[Token(Token = "0x2000853")]
	public class BuyClassicGoodResponse : PlayerDeltaResponse
	{
		// Token: 0x060064EA RID: 25834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EA")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuyClassicGoodResponse()
		{
		}

		// Token: 0x04003165 RID: 12645
		[Token(Token = "0x4003165")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
