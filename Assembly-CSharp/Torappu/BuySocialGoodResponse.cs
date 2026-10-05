using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200085A RID: 2138
	[Token(Token = "0x200085A")]
	public class BuySocialGoodResponse : PlayerDeltaResponse
	{
		// Token: 0x060064F1 RID: 25841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F1")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuySocialGoodResponse()
		{
		}

		// Token: 0x0400316F RID: 12655
		[Token(Token = "0x400316F")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
