using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D29 RID: 19753
	[Token(Token = "0x2004D29")]
	public class GroceryRewardAllMileStoneResponse : PlayerDeltaResponse
	{
		// Token: 0x0601D95D RID: 121181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D95D")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GroceryRewardAllMileStoneResponse()
		{
		}

		// Token: 0x0402711F RID: 160031
		[Token(Token = "0x402711F")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
