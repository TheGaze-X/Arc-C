using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000867 RID: 2151
	[Token(Token = "0x2000867")]
	public class ShopBlindboxItemViewModel : IHotfixable
	{
		// Token: 0x06006502 RID: 25858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006502")]
		[Address(RVA = "0x1F01480", Offset = "0x1F00080", VA = "0x181F01480")]
		public ShopBlindboxItemViewModel()
		{
		}

		// Token: 0x0400319B RID: 12699
		[Token(Token = "0x400319B")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0400319C RID: 12700
		[Token(Token = "0x400319C")]
		[FieldOffset(Offset = "0x18")]
		public string goodName;

		// Token: 0x0400319D RID: 12701
		[Token(Token = "0x400319D")]
		[FieldOffset(Offset = "0x20")]
		public long startDateTime;

		// Token: 0x0400319E RID: 12702
		[Token(Token = "0x400319E")]
		[FieldOffset(Offset = "0x28")]
		public long endDateTime;

		// Token: 0x0400319F RID: 12703
		[Token(Token = "0x400319F")]
		[FieldOffset(Offset = "0x30")]
		public string subtitleName;

		// Token: 0x040031A0 RID: 12704
		[Token(Token = "0x40031A0")]
		[FieldOffset(Offset = "0x38")]
		public int slotId;

		// Token: 0x040031A1 RID: 12705
		[Token(Token = "0x40031A1")]
		[FieldOffset(Offset = "0x3C")]
		public ShopCurrencyUnit currencyUnit;

		// Token: 0x040031A2 RID: 12706
		[Token(Token = "0x40031A2")]
		[FieldOffset(Offset = "0x40")]
		public int price;

		// Token: 0x040031A3 RID: 12707
		[Token(Token = "0x40031A3")]
		[FieldOffset(Offset = "0x44")]
		public int count;

		// Token: 0x040031A4 RID: 12708
		[Token(Token = "0x40031A4")]
		[FieldOffset(Offset = "0x48")]
		public SkinGachaItemViewModel gachaItemInfo;

		// Token: 0x040031A5 RID: 12709
		[Token(Token = "0x40031A5")]
		[FieldOffset(Offset = "0x50")]
		public SDVoucher chooseSkinVoucherInfo;

		// Token: 0x040031A6 RID: 12710
		[Token(Token = "0x40031A6")]
		[FieldOffset(Offset = "0x58")]
		public string gachaVoucherDesc;

		// Token: 0x040031A7 RID: 12711
		[Token(Token = "0x40031A7")]
		[FieldOffset(Offset = "0x60")]
		public string selectionVoucherDesc;

		// Token: 0x040031A8 RID: 12712
		[Token(Token = "0x40031A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
