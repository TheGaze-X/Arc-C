using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AE7 RID: 23271
	[Token(Token = "0x2005AE7")]
	public class ShopGpTabGroupModel
	{
		// Token: 0x06021D2F RID: 138543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D2F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShopGpTabGroupModel()
		{
		}

		// Token: 0x0402E4F8 RID: 189688
		[Token(Token = "0x402E4F8")]
		[FieldOffset(Offset = "0x10")]
		public List<ShopGPCommonItemViewModel> shopItemList;

		// Token: 0x0402E4F9 RID: 189689
		[Token(Token = "0x402E4F9")]
		[FieldOffset(Offset = "0x18")]
		public List<ShopGPCommonItemViewModel> soldOutItemList;
	}
}
