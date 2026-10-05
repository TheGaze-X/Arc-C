using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A72 RID: 23154
	[Token(Token = "0x2005A72")]
	public class CashItemViewModel : IHotfixable
	{
		// Token: 0x06021B04 RID: 137988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B04")]
		[Address(RVA = "0x1C16D80", Offset = "0x1C15980", VA = "0x181C16D80")]
		public void ApplyData(CashShopObject data)
		{
		}

		// Token: 0x06021B05 RID: 137989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B05")]
		[Address(RVA = "0x1C16F50", Offset = "0x1C15B50", VA = "0x181C16F50")]
		public CashItemViewModel()
		{
		}

		// Token: 0x0402E109 RID: 188681
		[Token(Token = "0x402E109")]
		[FieldOffset(Offset = "0x10")]
		public CashShopObject cacheData;

		// Token: 0x0402E10A RID: 188682
		[Token(Token = "0x402E10A")]
		[FieldOffset(Offset = "0x18")]
		public ShopCashInfo cashInfo;

		// Token: 0x0402E10B RID: 188683
		[Token(Token = "0x402E10B")]
		[FieldOffset(Offset = "0x28")]
		public bool isDouble;

		// Token: 0x0402E10C RID: 188684
		[Token(Token = "0x402E10C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E10D RID: 188685
		[Token(Token = "0x402E10D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
