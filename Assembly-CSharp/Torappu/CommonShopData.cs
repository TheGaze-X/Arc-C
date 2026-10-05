using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000862 RID: 2146
	[Token(Token = "0x2000862")]
	public class CommonShopData
	{
		// Token: 0x060064F8 RID: 25848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CommonShopData()
		{
		}

		// Token: 0x04003177 RID: 12663
		[Token(Token = "0x4003177")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04003178 RID: 12664
		[Token(Token = "0x4003178")]
		[FieldOffset(Offset = "0x18")]
		public string goodType;

		// Token: 0x04003179 RID: 12665
		[Token(Token = "0x4003179")]
		[FieldOffset(Offset = "0x20")]
		public int availCount;

		// Token: 0x0400317A RID: 12666
		[Token(Token = "0x400317A")]
		[FieldOffset(Offset = "0x28")]
		public ShopSlot slotItem;

		// Token: 0x0400317B RID: 12667
		[Token(Token = "0x400317B")]
		[FieldOffset(Offset = "0x30")]
		public float discount;

		// Token: 0x0400317C RID: 12668
		[Token(Token = "0x400317C")]
		[FieldOffset(Offset = "0x34")]
		public int originPrice;
	}
}
