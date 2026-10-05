using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ADC RID: 23260
	[Token(Token = "0x2005ADC")]
	public class ShopGPMonthlySubItemViewModel : ShopGPCommonItemViewModel, IHotfixable
	{
		// Token: 0x06021CFF RID: 138495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021CFF")]
		[Address(RVA = "0x1C4FB60", Offset = "0x1C4E760", VA = "0x181C4FB60", Slot = "4")]
		public override NormalGPItem ReturnCommonItem()
		{
			return null;
		}

		// Token: 0x06021D00 RID: 138496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D00")]
		[Address(RVA = "0x1C4FBC0", Offset = "0x1C4E7C0", VA = "0x181C4FBC0")]
		public ShopGPMonthlySubItemViewModel()
		{
		}

		// Token: 0x0402E4AF RID: 189615
		[Token(Token = "0x402E4AF")]
		[FieldOffset(Offset = "0x38")]
		public MonthlySubItem item;

		// Token: 0x0402E4B0 RID: 189616
		[Token(Token = "0x402E4B0")]
		[FieldOffset(Offset = "0x40")]
		public PlayerMonthlySubPer playerInfo;

		// Token: 0x0402E4B1 RID: 189617
		[Token(Token = "0x402E4B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ReturnCommonItem;

		// Token: 0x0402E4B2 RID: 189618
		[Token(Token = "0x402E4B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
