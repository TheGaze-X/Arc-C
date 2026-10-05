using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B23 RID: 23331
	[Token(Token = "0x2005B23")]
	public class ShopQCViewModel : IComparable<ShopQCViewModel>, IHotfixable
	{
		// Token: 0x06021E15 RID: 138773 RVA: 0x000BB890 File Offset: 0x000B9A90
		[Token(Token = "0x6021E15")]
		[Address(RVA = "0x1C64E90", Offset = "0x1C63A90", VA = "0x181C64E90", Slot = "4")]
		public int CompareTo(ShopQCViewModel other)
		{
			return 0;
		}

		// Token: 0x06021E16 RID: 138774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E16")]
		[Address(RVA = "0x1C64F20", Offset = "0x1C63B20", VA = "0x181C64F20")]
		public ShopQCViewModel()
		{
		}

		// Token: 0x0402E6B2 RID: 190130
		[Token(Token = "0x402E6B2")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x0402E6B3 RID: 190131
		[Token(Token = "0x402E6B3")]
		[FieldOffset(Offset = "0x18")]
		public string potentialId;

		// Token: 0x0402E6B4 RID: 190132
		[Token(Token = "0x402E6B4")]
		[FieldOffset(Offset = "0x20")]
		public UIItemViewModel potentialItem;

		// Token: 0x0402E6B5 RID: 190133
		[Token(Token = "0x402E6B5")]
		[FieldOffset(Offset = "0x28")]
		public UIItemViewModel item;

		// Token: 0x0402E6B6 RID: 190134
		[Token(Token = "0x402E6B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402E6B7 RID: 190135
		[Token(Token = "0x402E6B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
