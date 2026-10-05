using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B5B RID: 23387
	[Token(Token = "0x2005B5B")]
	public class SkinGoodListDataWrapper
	{
		// Token: 0x06021F2D RID: 139053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F2D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SkinGoodListDataWrapper()
		{
		}

		// Token: 0x0402E81C RID: 190492
		[Token(Token = "0x402E81C")]
		[FieldOffset(Offset = "0x10")]
		public List<ShopSkinItemViewModel> data;

		// Token: 0x0402E81D RID: 190493
		[Token(Token = "0x402E81D")]
		[FieldOffset(Offset = "0x18")]
		public long lastRefreshTs;
	}
}
