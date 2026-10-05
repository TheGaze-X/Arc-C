using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ABD RID: 23229
	[Token(Token = "0x2005ABD")]
	public class ShopDetailVoucherGachaStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06021C56 RID: 138326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C56")]
		[Address(RVA = "0x1C3FBC0", Offset = "0x1C3E7C0", VA = "0x181C3FBC0")]
		public ShopDetailVoucherGachaStateBean()
		{
		}

		// Token: 0x0402E373 RID: 189299
		[Token(Token = "0x402E373")]
		[FieldOffset(Offset = "0x10")]
		public CharGachaVoucherData voucherData;

		// Token: 0x0402E374 RID: 189300
		[Token(Token = "0x402E374")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
