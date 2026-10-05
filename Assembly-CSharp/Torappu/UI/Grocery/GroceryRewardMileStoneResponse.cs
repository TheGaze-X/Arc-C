using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D27 RID: 19751
	[Token(Token = "0x2004D27")]
	public class GroceryRewardMileStoneResponse : PlayerDeltaResponse
	{
		// Token: 0x0601D95B RID: 121179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D95B")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GroceryRewardMileStoneResponse()
		{
		}

		// Token: 0x0402711D RID: 160029
		[Token(Token = "0x402711D")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
