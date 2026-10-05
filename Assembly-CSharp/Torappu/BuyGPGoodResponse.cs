using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000848 RID: 2120
	[Token(Token = "0x2000848")]
	public class BuyGPGoodResponse : PlayerDeltaResponse
	{
		// Token: 0x060064DF RID: 25823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DF")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuyGPGoodResponse()
		{
		}

		// Token: 0x04003154 RID: 12628
		[Token(Token = "0x4003154")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
