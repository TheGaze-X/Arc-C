using System;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B6E RID: 23406
	[Token(Token = "0x2005B6E")]
	public class ShopCreditViewModel
	{
		// Token: 0x06021FBD RID: 139197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FBD")]
		[Address(RVA = "0x1C6FD20", Offset = "0x1C6E920", VA = "0x181C6FD20")]
		public ShopCreditViewModel()
		{
		}

		// Token: 0x0402E93D RID: 190781
		[Token(Token = "0x402E93D")]
		[FieldOffset(Offset = "0x10")]
		public SocialShopData socialViewModel;

		// Token: 0x0402E93E RID: 190782
		[Token(Token = "0x402E93E")]
		[FieldOffset(Offset = "0x18")]
		public int buyCount;
	}
}
