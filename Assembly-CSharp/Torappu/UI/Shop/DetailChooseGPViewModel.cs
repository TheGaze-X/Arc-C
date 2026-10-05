using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A83 RID: 23171
	[Token(Token = "0x2005A83")]
	public class DetailChooseGPViewModel : DetailCommonViewModel, IHotfixable
	{
		// Token: 0x06021B57 RID: 138071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B57")]
		[Address(RVA = "0x1C18360", Offset = "0x1C16F60", VA = "0x181C18360")]
		public DetailChooseGPViewModel()
		{
		}

		// Token: 0x0402E17E RID: 188798
		[Token(Token = "0x402E17E")]
		[FieldOffset(Offset = "0x70")]
		public List<ChooseGiftPackageShopOption> options;

		// Token: 0x0402E17F RID: 188799
		[Token(Token = "0x402E17F")]
		[FieldOffset(Offset = "0x78")]
		public string itemDesc;

		// Token: 0x0402E180 RID: 188800
		[Token(Token = "0x402E180")]
		[FieldOffset(Offset = "0x80")]
		public string itemDescNum;

		// Token: 0x0402E181 RID: 188801
		[Token(Token = "0x402E181")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
