using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D2F RID: 19759
	[Token(Token = "0x2004D2F")]
	public class GrocerySaleSettleResponse : PlayerDeltaResponse
	{
		// Token: 0x0601D963 RID: 121187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D963")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GrocerySaleSettleResponse()
		{
		}

		// Token: 0x04027124 RID: 160036
		[Token(Token = "0x4027124")]
		[FieldOffset(Offset = "0x28")]
		public int pointPrev;

		// Token: 0x04027125 RID: 160037
		[Token(Token = "0x4027125")]
		[FieldOffset(Offset = "0x30")]
		public List<RewardItemModel> rewards;
	}
}
