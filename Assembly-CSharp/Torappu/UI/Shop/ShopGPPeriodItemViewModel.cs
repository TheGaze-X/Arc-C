using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AD9 RID: 23257
	[Token(Token = "0x2005AD9")]
	public class ShopGPPeriodItemViewModel : ShopGPCommonItemViewModel, IHotfixable
	{
		// Token: 0x06021CEF RID: 138479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021CEF")]
		[Address(RVA = "0x1C50310", Offset = "0x1C4EF10", VA = "0x181C50310", Slot = "4")]
		public override NormalGPItem ReturnCommonItem()
		{
			return null;
		}

		// Token: 0x06021CF0 RID: 138480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021CF0")]
		[Address(RVA = "0x1C50370", Offset = "0x1C4EF70", VA = "0x181C50370", Slot = "5")]
		public override PlayerGoodItemData ReturnPlayerInfo()
		{
			return null;
		}

		// Token: 0x06021CF1 RID: 138481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CF1")]
		[Address(RVA = "0x1C503D0", Offset = "0x1C4EFD0", VA = "0x181C503D0")]
		public ShopGPPeriodItemViewModel()
		{
		}

		// Token: 0x06021CF2 RID: 138482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021CF2")]
		[Address(RVA = "0x1C4B9B0", Offset = "0x1C4A5B0", VA = "0x181C4B9B0")]
		private PlayerGoodItemData <>xLuaBaseProxy_ReturnPlayerInfo()
		{
			return null;
		}

		// Token: 0x0402E494 RID: 189588
		[Token(Token = "0x402E494")]
		[FieldOffset(Offset = "0x38")]
		public PeriodicityGPItem item;

		// Token: 0x0402E495 RID: 189589
		[Token(Token = "0x402E495")]
		[FieldOffset(Offset = "0x40")]
		public PlayerGoodItemData playerInfo;

		// Token: 0x0402E496 RID: 189590
		[Token(Token = "0x402E496")]
		[FieldOffset(Offset = "0x48")]
		public long endTime;

		// Token: 0x0402E497 RID: 189591
		[Token(Token = "0x402E497")]
		[FieldOffset(Offset = "0x50")]
		public GPPeriodDetailType detailType;

		// Token: 0x0402E498 RID: 189592
		[Token(Token = "0x402E498")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ReturnCommonItem;

		// Token: 0x0402E499 RID: 189593
		[Token(Token = "0x402E499")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ReturnPlayerInfo;

		// Token: 0x0402E49A RID: 189594
		[Token(Token = "0x402E49A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
