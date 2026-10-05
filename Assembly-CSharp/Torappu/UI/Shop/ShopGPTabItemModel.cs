using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AE2 RID: 23266
	[Token(Token = "0x2005AE2")]
	public class ShopGPTabItemModel : IHotfixable, IComparable<ShopGPTabItemModel>
	{
		// Token: 0x06021D20 RID: 138528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D20")]
		[Address(RVA = "0x1C55000", Offset = "0x1C53C00", VA = "0x181C55000")]
		public void RefreshData(ShopGPTabDisplayData data, ShopGpTabGroupModel groupModel)
		{
		}

		// Token: 0x06021D21 RID: 138529 RVA: 0x000BB530 File Offset: 0x000B9730
		[Token(Token = "0x6021D21")]
		[Address(RVA = "0x1C54F60", Offset = "0x1C53B60", VA = "0x181C54F60", Slot = "4")]
		public int CompareTo(ShopGPTabItemModel other)
		{
			return 0;
		}

		// Token: 0x06021D22 RID: 138530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D22")]
		[Address(RVA = "0x1C55170", Offset = "0x1C53D70", VA = "0x181C55170")]
		public ShopGPTabItemModel()
		{
		}

		// Token: 0x0402E4DA RID: 189658
		[Token(Token = "0x402E4DA")]
		[FieldOffset(Offset = "0x10")]
		public string tabId;

		// Token: 0x0402E4DB RID: 189659
		[Token(Token = "0x402E4DB")]
		[FieldOffset(Offset = "0x18")]
		public string tabName;

		// Token: 0x0402E4DC RID: 189660
		[Token(Token = "0x402E4DC")]
		[FieldOffset(Offset = "0x20")]
		public ShopGPTabType tabType;

		// Token: 0x0402E4DD RID: 189661
		[Token(Token = "0x402E4DD")]
		[FieldOffset(Offset = "0x28")]
		public string tabPicId;

		// Token: 0x0402E4DE RID: 189662
		[Token(Token = "0x402E4DE")]
		[FieldOffset(Offset = "0x30")]
		public string tabPicOnColor;

		// Token: 0x0402E4DF RID: 189663
		[Token(Token = "0x402E4DF")]
		[FieldOffset(Offset = "0x38")]
		public string tabPicOffColor;

		// Token: 0x0402E4E0 RID: 189664
		[Token(Token = "0x402E4E0")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x0402E4E1 RID: 189665
		[Token(Token = "0x402E4E1")]
		[FieldOffset(Offset = "0x48")]
		public string markerPicId;

		// Token: 0x0402E4E2 RID: 189666
		[Token(Token = "0x402E4E2")]
		[FieldOffset(Offset = "0x50")]
		public bool canUseTicket;

		// Token: 0x0402E4E3 RID: 189667
		[Token(Token = "0x402E4E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0402E4E4 RID: 189668
		[Token(Token = "0x402E4E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402E4E5 RID: 189669
		[Token(Token = "0x402E4E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
