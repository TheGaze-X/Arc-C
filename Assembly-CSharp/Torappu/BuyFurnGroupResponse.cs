using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000846 RID: 2118
	[Token(Token = "0x2000846")]
	public class BuyFurnGroupResponse : PlayerDeltaResponse
	{
		// Token: 0x060064DD RID: 25821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DD")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuyFurnGroupResponse()
		{
		}

		// Token: 0x04003151 RID: 12625
		[Token(Token = "0x4003151")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
