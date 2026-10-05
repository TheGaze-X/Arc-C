using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200084A RID: 2122
	[Token(Token = "0x200084A")]
	public class BuyGpGoodWithTicketResponse : PlayerDeltaResponse
	{
		// Token: 0x060064E1 RID: 25825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E1")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuyGpGoodWithTicketResponse()
		{
		}

		// Token: 0x04003157 RID: 12631
		[Token(Token = "0x4003157")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
