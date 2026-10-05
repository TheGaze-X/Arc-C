using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ADE RID: 23262
	[Token(Token = "0x2005ADE")]
	public class ShopGPChooseItemViewModel : ShopGPCommonItemViewModel, IHotfixable
	{
		// Token: 0x06021D05 RID: 138501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D05")]
		[Address(RVA = "0x1C4B8F0", Offset = "0x1C4A4F0", VA = "0x181C4B8F0", Slot = "4")]
		public override NormalGPItem ReturnCommonItem()
		{
			return null;
		}

		// Token: 0x06021D06 RID: 138502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D06")]
		[Address(RVA = "0x1C4B950", Offset = "0x1C4A550", VA = "0x181C4B950", Slot = "5")]
		public override PlayerGoodItemData ReturnPlayerInfo()
		{
			return null;
		}

		// Token: 0x06021D07 RID: 138503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D07")]
		[Address(RVA = "0x1C4B9C0", Offset = "0x1C4A5C0", VA = "0x181C4B9C0")]
		public ShopGPChooseItemViewModel()
		{
		}

		// Token: 0x06021D08 RID: 138504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D08")]
		[Address(RVA = "0x1C4B9B0", Offset = "0x1C4A5B0", VA = "0x181C4B9B0")]
		private PlayerGoodItemData <>xLuaBaseProxy_ReturnPlayerInfo()
		{
			return null;
		}

		// Token: 0x0402E4B8 RID: 189624
		[Token(Token = "0x402E4B8")]
		[FieldOffset(Offset = "0x38")]
		public NormalGPItem item;

		// Token: 0x0402E4B9 RID: 189625
		[Token(Token = "0x402E4B9")]
		[FieldOffset(Offset = "0x40")]
		public PlayerGoodItemData playerInfo;

		// Token: 0x0402E4BA RID: 189626
		[Token(Token = "0x402E4BA")]
		[FieldOffset(Offset = "0x48")]
		public int boughtCount;

		// Token: 0x0402E4BB RID: 189627
		[Token(Token = "0x402E4BB")]
		[FieldOffset(Offset = "0x50")]
		public long endTime;

		// Token: 0x0402E4BC RID: 189628
		[Token(Token = "0x402E4BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ReturnCommonItem;

		// Token: 0x0402E4BD RID: 189629
		[Token(Token = "0x402E4BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ReturnPlayerInfo;

		// Token: 0x0402E4BE RID: 189630
		[Token(Token = "0x402E4BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
