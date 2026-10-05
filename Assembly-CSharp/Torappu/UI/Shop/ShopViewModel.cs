using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B59 RID: 23385
	[Token(Token = "0x2005B59")]
	public class ShopViewModel : IHotfixable
	{
		// Token: 0x06021F2B RID: 139051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F2B")]
		[Address(RVA = "0x1C79C80", Offset = "0x1C78880", VA = "0x181C79C80")]
		public ShopViewModel()
		{
		}

		// Token: 0x0402E818 RID: 190488
		[Token(Token = "0x402E818")]
		[FieldOffset(Offset = "0x10")]
		public CommonShopData[] shopData;

		// Token: 0x0402E819 RID: 190489
		[Token(Token = "0x402E819")]
		[FieldOffset(Offset = "0x18")]
		public ShopType priceType;

		// Token: 0x0402E81A RID: 190490
		[Token(Token = "0x402E81A")]
		[FieldOffset(Offset = "0x20")]
		public long refreshTime;

		// Token: 0x0402E81B RID: 190491
		[Token(Token = "0x402E81B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
