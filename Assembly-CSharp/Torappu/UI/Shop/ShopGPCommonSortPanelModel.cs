using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AE4 RID: 23268
	[Token(Token = "0x2005AE4")]
	public class ShopGPCommonSortPanelModel : AbstractShopGPPanelModel
	{
		// Token: 0x17004F27 RID: 20263
		// (get) Token: 0x06021D26 RID: 138534 RVA: 0x000BB548 File Offset: 0x000B9748
		[Token(Token = "0x17004F27")]
		public override ShopGPPanelType panelType
		{
			[Token(Token = "0x6021D26")]
			[Address(RVA = "0x1C4E820", Offset = "0x1C4D420", VA = "0x181C4E820", Slot = "4")]
			get
			{
				return ShopGPPanelType.DEFAULT_COMMON;
			}
		}

		// Token: 0x06021D27 RID: 138535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D27")]
		[Address(RVA = "0x1C4E6D0", Offset = "0x1C4D2D0", VA = "0x181C4E6D0", Slot = "5")]
		public override void RefreshData(ShopGPTabDisplayData data, ShopGpTabGroupModel groupModel)
		{
		}

		// Token: 0x06021D28 RID: 138536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D28")]
		[Address(RVA = "0x1C4E780", Offset = "0x1C4D380", VA = "0x181C4E780")]
		public ShopGPCommonSortPanelModel()
		{
		}

		// Token: 0x0402E4E7 RID: 189671
		[Token(Token = "0x402E4E7")]
		[FieldOffset(Offset = "0x10")]
		public List<ShopGPCommonItemViewModel> shopItemList;

		// Token: 0x0402E4E8 RID: 189672
		[Token(Token = "0x402E4E8")]
		[FieldOffset(Offset = "0x18")]
		public List<ShopGPCommonItemViewModel> soldOutItemList;

		// Token: 0x0402E4E9 RID: 189673
		[Token(Token = "0x402E4E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0402E4EA RID: 189674
		[Token(Token = "0x402E4EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0402E4EB RID: 189675
		[Token(Token = "0x402E4EB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
