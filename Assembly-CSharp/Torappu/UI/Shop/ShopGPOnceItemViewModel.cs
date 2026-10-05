using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ADD RID: 23261
	[Token(Token = "0x2005ADD")]
	public class ShopGPOnceItemViewModel : ShopGPCommonItemViewModel, IHotfixable
	{
		// Token: 0x06021D01 RID: 138497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D01")]
		[Address(RVA = "0x1C501F0", Offset = "0x1C4EDF0", VA = "0x181C501F0", Slot = "4")]
		public override NormalGPItem ReturnCommonItem()
		{
			return null;
		}

		// Token: 0x06021D02 RID: 138498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D02")]
		[Address(RVA = "0x1C50250", Offset = "0x1C4EE50", VA = "0x181C50250", Slot = "5")]
		public override PlayerGoodItemData ReturnPlayerInfo()
		{
			return null;
		}

		// Token: 0x06021D03 RID: 138499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D03")]
		[Address(RVA = "0x1C502B0", Offset = "0x1C4EEB0", VA = "0x181C502B0")]
		public ShopGPOnceItemViewModel()
		{
		}

		// Token: 0x06021D04 RID: 138500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D04")]
		[Address(RVA = "0x1C4B9B0", Offset = "0x1C4A5B0", VA = "0x181C4B9B0")]
		private PlayerGoodItemData <>xLuaBaseProxy_ReturnPlayerInfo()
		{
			return null;
		}

		// Token: 0x0402E4B3 RID: 189619
		[Token(Token = "0x402E4B3")]
		[FieldOffset(Offset = "0x38")]
		public NormalGPItem item;

		// Token: 0x0402E4B4 RID: 189620
		[Token(Token = "0x402E4B4")]
		[FieldOffset(Offset = "0x40")]
		public PlayerGoodItemData playerInfo;

		// Token: 0x0402E4B5 RID: 189621
		[Token(Token = "0x402E4B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ReturnCommonItem;

		// Token: 0x0402E4B6 RID: 189622
		[Token(Token = "0x402E4B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ReturnPlayerInfo;

		// Token: 0x0402E4B7 RID: 189623
		[Token(Token = "0x402E4B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
