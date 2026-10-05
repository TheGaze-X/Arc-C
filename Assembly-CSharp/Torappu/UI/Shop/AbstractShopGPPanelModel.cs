using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AE3 RID: 23267
	[Token(Token = "0x2005AE3")]
	public abstract class AbstractShopGPPanelModel : IHotfixable
	{
		// Token: 0x17004F26 RID: 20262
		// (get) Token: 0x06021D23 RID: 138531
		[Token(Token = "0x17004F26")]
		public abstract ShopGPPanelType panelType { [Token(Token = "0x6021D23")] get; }

		// Token: 0x06021D24 RID: 138532
		[Token(Token = "0x6021D24")]
		public abstract void RefreshData(ShopGPTabDisplayData data, ShopGpTabGroupModel groupModel);

		// Token: 0x06021D25 RID: 138533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D25")]
		[Address(RVA = "0x1C42940", Offset = "0x1C41540", VA = "0x181C42940")]
		protected AbstractShopGPPanelModel()
		{
		}

		// Token: 0x0402E4E6 RID: 189670
		[Token(Token = "0x402E4E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
