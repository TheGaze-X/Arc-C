using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000885 RID: 2181
	[Token(Token = "0x2000885")]
	public class SocialShopData
	{
		// Token: 0x06006525 RID: 25893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006525")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SocialShopData()
		{
		}

		// Token: 0x0400320E RID: 12814
		[Token(Token = "0x400320E")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0400320F RID: 12815
		[Token(Token = "0x400320F")]
		[FieldOffset(Offset = "0x18")]
		public string displayName;

		// Token: 0x04003210 RID: 12816
		[Token(Token = "0x4003210")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle item;

		// Token: 0x04003211 RID: 12817
		[Token(Token = "0x4003211")]
		[FieldOffset(Offset = "0x28")]
		public int price;

		// Token: 0x04003212 RID: 12818
		[Token(Token = "0x4003212")]
		[FieldOffset(Offset = "0x2C")]
		public int availCount;

		// Token: 0x04003213 RID: 12819
		[Token(Token = "0x4003213")]
		[FieldOffset(Offset = "0x30")]
		public ShopSlot slotItem;

		// Token: 0x04003214 RID: 12820
		[Token(Token = "0x4003214")]
		[FieldOffset(Offset = "0x38")]
		public float discount;

		// Token: 0x04003215 RID: 12821
		[Token(Token = "0x4003215")]
		[FieldOffset(Offset = "0x3C")]
		public int originPrice;
	}
}
