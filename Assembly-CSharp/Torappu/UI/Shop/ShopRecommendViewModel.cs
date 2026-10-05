using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B2A RID: 23338
	[Token(Token = "0x2005B2A")]
	public class ShopRecommendViewModel
	{
		// Token: 0x06021E36 RID: 138806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E36")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShopRecommendViewModel()
		{
		}

		// Token: 0x0402E6E3 RID: 190179
		[Token(Token = "0x402E6E3")]
		[FieldOffset(Offset = "0x10")]
		public bool isNew;

		// Token: 0x0402E6E4 RID: 190180
		[Token(Token = "0x402E6E4")]
		[FieldOffset(Offset = "0x18")]
		public ShopRecommendItem recommendItem;

		// Token: 0x0402E6E5 RID: 190181
		[Token(Token = "0x402E6E5")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<int, ShopRecommendData> imgList;
	}
}
