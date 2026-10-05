using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AE5 RID: 23269
	[Token(Token = "0x2005AE5")]
	public class ShopGPRecommedPanelModel : AbstractShopGPPanelModel
	{
		// Token: 0x17004F28 RID: 20264
		// (get) Token: 0x06021D29 RID: 138537 RVA: 0x000BB560 File Offset: 0x000B9760
		[Token(Token = "0x17004F28")]
		public override ShopGPPanelType panelType
		{
			[Token(Token = "0x6021D29")]
			[Address(RVA = "0x1C505F0", Offset = "0x1C4F1F0", VA = "0x181C505F0", Slot = "4")]
			get
			{
				return ShopGPPanelType.DEFAULT_COMMON;
			}
		}

		// Token: 0x06021D2A RID: 138538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D2A")]
		[Address(RVA = "0x1C50490", Offset = "0x1C4F090", VA = "0x181C50490", Slot = "5")]
		public override void RefreshData(ShopGPTabDisplayData data, ShopGpTabGroupModel groupModel)
		{
		}

		// Token: 0x06021D2B RID: 138539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D2B")]
		[Address(RVA = "0x1C50550", Offset = "0x1C4F150", VA = "0x181C50550")]
		public ShopGPRecommedPanelModel()
		{
		}

		// Token: 0x0402E4EC RID: 189676
		[Token(Token = "0x402E4EC")]
		[FieldOffset(Offset = "0x10")]
		public int limitNum;

		// Token: 0x0402E4ED RID: 189677
		[Token(Token = "0x402E4ED")]
		[FieldOffset(Offset = "0x18")]
		public List<ShopGPCommonItemViewModel> shopItemList;

		// Token: 0x0402E4EE RID: 189678
		[Token(Token = "0x402E4EE")]
		[FieldOffset(Offset = "0x20")]
		public List<ShopGPCommonItemViewModel> soldOutItemList;

		// Token: 0x0402E4EF RID: 189679
		[Token(Token = "0x402E4EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelType;

		// Token: 0x0402E4F0 RID: 189680
		[Token(Token = "0x402E4F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0402E4F1 RID: 189681
		[Token(Token = "0x402E4F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
