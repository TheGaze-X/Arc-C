using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ADB RID: 23259
	[Token(Token = "0x2005ADB")]
	public class ShopGPLevelItemViewModel : ShopGPCommonItemViewModel, IHotfixable
	{
		// Token: 0x06021CFB RID: 138491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021CFB")]
		[Address(RVA = "0x1C4F610", Offset = "0x1C4E210", VA = "0x181C4F610", Slot = "4")]
		public override NormalGPItem ReturnCommonItem()
		{
			return null;
		}

		// Token: 0x06021CFC RID: 138492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021CFC")]
		[Address(RVA = "0x1C4F670", Offset = "0x1C4E270", VA = "0x181C4F670", Slot = "5")]
		public override PlayerGoodItemData ReturnPlayerInfo()
		{
			return null;
		}

		// Token: 0x06021CFD RID: 138493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CFD")]
		[Address(RVA = "0x1C4F6D0", Offset = "0x1C4E2D0", VA = "0x181C4F6D0")]
		public ShopGPLevelItemViewModel()
		{
		}

		// Token: 0x06021CFE RID: 138494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021CFE")]
		[Address(RVA = "0x1C4B9B0", Offset = "0x1C4A5B0", VA = "0x181C4B9B0")]
		private PlayerGoodItemData <>xLuaBaseProxy_ReturnPlayerInfo()
		{
			return null;
		}

		// Token: 0x0402E4AA RID: 189610
		[Token(Token = "0x402E4AA")]
		[FieldOffset(Offset = "0x38")]
		public LevelGPItem item;

		// Token: 0x0402E4AB RID: 189611
		[Token(Token = "0x402E4AB")]
		[FieldOffset(Offset = "0x40")]
		public PlayerGoodItemData playerInfo;

		// Token: 0x0402E4AC RID: 189612
		[Token(Token = "0x402E4AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ReturnCommonItem;

		// Token: 0x0402E4AD RID: 189613
		[Token(Token = "0x402E4AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ReturnPlayerInfo;

		// Token: 0x0402E4AE RID: 189614
		[Token(Token = "0x402E4AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
