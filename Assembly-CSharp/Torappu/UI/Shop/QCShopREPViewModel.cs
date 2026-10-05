using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B1E RID: 23326
	[Token(Token = "0x2005B1E")]
	public class QCShopREPViewModel : IHotfixable
	{
		// Token: 0x06021E09 RID: 138761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E09")]
		[Address(RVA = "0x1C5EED0", Offset = "0x1C5DAD0", VA = "0x181C5EED0")]
		public void ApplyData(GetREPGoodListResponse response)
		{
		}

		// Token: 0x06021E0A RID: 138762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E0A")]
		[Address(RVA = "0x1C5F270", Offset = "0x1C5DE70", VA = "0x181C5F270")]
		public QCShopREPViewModel()
		{
		}

		// Token: 0x0402E69D RID: 190109
		[Token(Token = "0x402E69D")]
		[FieldOffset(Offset = "0x10")]
		public List<QCShopREPGood> commonGoodList;

		// Token: 0x0402E69E RID: 190110
		[Token(Token = "0x402E69E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E69F RID: 190111
		[Token(Token = "0x402E69F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
