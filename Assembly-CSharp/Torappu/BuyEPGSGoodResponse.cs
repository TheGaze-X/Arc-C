using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000856 RID: 2134
	[Token(Token = "0x2000856")]
	public class BuyEPGSGoodResponse : PlayerDeltaResponse
	{
		// Token: 0x060064ED RID: 25837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064ED")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuyEPGSGoodResponse()
		{
		}

		// Token: 0x04003169 RID: 12649
		[Token(Token = "0x4003169")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
