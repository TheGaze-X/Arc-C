using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000897 RID: 2199
	[Token(Token = "0x2000897")]
	public class NormalGPItem
	{
		// Token: 0x06006536 RID: 25910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006536")]
		[Address(RVA = "0x1EE7AE0", Offset = "0x1EE66E0", VA = "0x181EE7AE0")]
		public NormalGPItem()
		{
		}

		// Token: 0x0400323D RID: 12861
		[Token(Token = "0x400323D")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0400323E RID: 12862
		[Token(Token = "0x400323E")]
		[FieldOffset(Offset = "0x18")]
		public string giftPackageId;

		// Token: 0x0400323F RID: 12863
		[Token(Token = "0x400323F")]
		[FieldOffset(Offset = "0x20")]
		public int priority;

		// Token: 0x04003240 RID: 12864
		[Token(Token = "0x4003240")]
		[FieldOffset(Offset = "0x28")]
		public string displayName;

		// Token: 0x04003241 RID: 12865
		[Token(Token = "0x4003241")]
		[FieldOffset(Offset = "0x30")]
		public ShopCurrencyUnit currencyUnit;

		// Token: 0x04003242 RID: 12866
		[Token(Token = "0x4003242")]
		[FieldOffset(Offset = "0x34")]
		public int availCount;

		// Token: 0x04003243 RID: 12867
		[Token(Token = "0x4003243")]
		[FieldOffset(Offset = "0x38")]
		public int buyCount;

		// Token: 0x04003244 RID: 12868
		[Token(Token = "0x4003244")]
		[FieldOffset(Offset = "0x3C")]
		public int price;

		// Token: 0x04003245 RID: 12869
		[Token(Token = "0x4003245")]
		[FieldOffset(Offset = "0x40")]
		public int originPrice;

		// Token: 0x04003246 RID: 12870
		[Token(Token = "0x4003246")]
		[FieldOffset(Offset = "0x44")]
		public float discount;

		// Token: 0x04003247 RID: 12871
		[Token(Token = "0x4003247")]
		[FieldOffset(Offset = "0x48")]
		public ItemBundle[] items;

		// Token: 0x04003248 RID: 12872
		[Token(Token = "0x4003248")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, SpecialItemInfo> specialItemInfos;

		// Token: 0x04003249 RID: 12873
		[Token(Token = "0x4003249")]
		[FieldOffset(Offset = "0x58")]
		public long startDateTime;

		// Token: 0x0400324A RID: 12874
		[Token(Token = "0x400324A")]
		[FieldOffset(Offset = "0x60")]
		public long endDateTime;

		// Token: 0x0400324B RID: 12875
		[Token(Token = "0x400324B")]
		[FieldOffset(Offset = "0x68")]
		public List<string> tab;

		// Token: 0x0400324C RID: 12876
		[Token(Token = "0x400324C")]
		[FieldOffset(Offset = "0x70")]
		public List<string> gpTicketIdList;

		// Token: 0x0400324D RID: 12877
		[Token(Token = "0x400324D")]
		[FieldOffset(Offset = "0x78")]
		public List<PackageImgDisplayData> imgDisplayDataList;
	}
}
