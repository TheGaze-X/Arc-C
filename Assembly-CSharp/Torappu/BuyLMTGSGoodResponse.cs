using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000854 RID: 2132
	[Token(Token = "0x2000854")]
	public class BuyLMTGSGoodResponse : PlayerDeltaResponse
	{
		// Token: 0x060064EB RID: 25835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EB")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuyLMTGSGoodResponse()
		{
		}

		// Token: 0x04003166 RID: 12646
		[Token(Token = "0x4003166")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
