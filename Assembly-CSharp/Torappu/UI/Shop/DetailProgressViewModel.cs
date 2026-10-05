using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A88 RID: 23176
	[Token(Token = "0x2005A88")]
	public class DetailProgressViewModel : DetailCommonViewModel, IHotfixable
	{
		// Token: 0x06021B63 RID: 138083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B63")]
		[Address(RVA = "0x1C19720", Offset = "0x1C18320", VA = "0x181C19720")]
		public DetailProgressViewModel()
		{
		}

		// Token: 0x0402E192 RID: 188818
		[Token(Token = "0x402E192")]
		[FieldOffset(Offset = "0x70")]
		public QCShopObjProgressViewModel viewModel;

		// Token: 0x0402E193 RID: 188819
		[Token(Token = "0x402E193")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
