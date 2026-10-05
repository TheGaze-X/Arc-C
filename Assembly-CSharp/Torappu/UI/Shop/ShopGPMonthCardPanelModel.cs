using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AE6 RID: 23270
	[Token(Token = "0x2005AE6")]
	public class ShopGPMonthCardPanelModel : AbstractShopGPPanelModel
	{
		// Token: 0x17004F29 RID: 20265
		// (get) Token: 0x06021D2C RID: 138540 RVA: 0x000BB578 File Offset: 0x000B9778
		[Token(Token = "0x17004F29")]
		public override ShopGPPanelType panelType
		{
			[Token(Token = "0x6021D2C")]
			[Address(RVA = "0x1C4FB00", Offset = "0x1C4E700", VA = "0x181C4FB00", Slot = "4")]
			get
			{
				return ShopGPPanelType.DEFAULT_COMMON;
			}
		}

		// Token: 0x06021D2D RID: 138541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D2D")]
		[Address(RVA = "0x1C4F730", Offset = "0x1C4E330", VA = "0x181C4F730", Slot = "5")]
		public override void RefreshData(ShopGPTabDisplayData data, ShopGpTabGroupModel groupModel)
		{
		}

		// Token: 0x06021D2E RID: 138542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D2E")]
		[Address(RVA = "0x1C4FA60", Offset = "0x1C4E660", VA = "0x181C4FA60")]
		public ShopGPMonthCardPanelModel()
		{
		}

		// Token: 0x0402E4F2 RID: 189682
		[Token(Token = "0x402E4F2")]
		[FieldOffset(Offset = "0x10")]
		public string priceText;

		// Token: 0x0402E4F3 RID: 189683
		[Token(Token = "0x402E4F3")]
		[FieldOffset(Offset = "0x18")]
		public string remainTimeText;

		// Token: 0x0402E4F4 RID: 189684
		[Token(Token = "0x402E4F4")]
		[FieldOffset(Offset = "0x20")]
		public ShopGPMonthlySubItemViewModel itemModel;

		// Token: 0x0402E4F5 RID: 189685
		[Token(Token = "0x402E4F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0402E4F6 RID: 189686
		[Token(Token = "0x402E4F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0402E4F7 RID: 189687
		[Token(Token = "0x402E4F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
