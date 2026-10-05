using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000889 RID: 2185
	[Token(Token = "0x2000889")]
	public class ShopCashGoodPurchaseResponse : PlayerDeltaResponse
	{
		// Token: 0x06006529 RID: 25897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006529")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ShopCashGoodPurchaseResponse()
		{
		}

		// Token: 0x0400321A RID: 12826
		[Token(Token = "0x400321A")]
		[FieldOffset(Offset = "0x28")]
		public List<ShopCashGoodPurchaseResponse.Good> receiveCashGoodResult;

		// Token: 0x0200088A RID: 2186
		[Token(Token = "0x200088A")]
		public class Good
		{
			// Token: 0x0600652A RID: 25898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600652A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Good()
			{
			}

			// Token: 0x0400321B RID: 12827
			[Token(Token = "0x400321B")]
			[FieldOffset(Offset = "0x10")]
			public string productId;

			// Token: 0x0400321C RID: 12828
			[Token(Token = "0x400321C")]
			[FieldOffset(Offset = "0x18")]
			public string productName;

			// Token: 0x0400321D RID: 12829
			[Token(Token = "0x400321D")]
			[FieldOffset(Offset = "0x20")]
			public List<RewardItemModel> items;

			// Token: 0x0400321E RID: 12830
			[Token(Token = "0x400321E")]
			[FieldOffset(Offset = "0x28")]
			public List<RewardItemModel> checkInItems;
		}
	}
}
