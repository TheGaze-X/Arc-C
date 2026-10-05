using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000887 RID: 2183
	[Token(Token = "0x2000887")]
	public class GetSocialGoodListResponse : PlayerDeltaResponse, IShopGetResposne
	{
		// Token: 0x06006527 RID: 25895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006527")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetSocialGoodListResponse()
		{
		}

		// Token: 0x04003216 RID: 12822
		[Token(Token = "0x4003216")]
		[FieldOffset(Offset = "0x28")]
		public List<SocialShopData> goodList;

		// Token: 0x04003217 RID: 12823
		[Token(Token = "0x4003217")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, int> charPurchase;

		// Token: 0x04003218 RID: 12824
		[Token(Token = "0x4003218")]
		[FieldOffset(Offset = "0x38")]
		public int costSocialPoint;

		// Token: 0x04003219 RID: 12825
		[Token(Token = "0x4003219")]
		[FieldOffset(Offset = "0x40")]
		public string creditGroup;
	}
}
