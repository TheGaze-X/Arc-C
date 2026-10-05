using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000850 RID: 2128
	[Token(Token = "0x2000850")]
	public class BuyHighGoodResponse : PlayerDeltaResponse
	{
		// Token: 0x060064E7 RID: 25831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E7")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuyHighGoodResponse()
		{
		}

		// Token: 0x04003160 RID: 12640
		[Token(Token = "0x4003160")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
