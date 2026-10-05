using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FBB RID: 4027
	[Token(Token = "0x2000FBB")]
	public class CrisisV2SeasonShopInfo
	{
		// Token: 0x06006D02 RID: 27906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D02")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2SeasonShopInfo()
		{
		}

		// Token: 0x0400556E RID: 21870
		[Token(Token = "0x400556E")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0400556F RID: 21871
		[Token(Token = "0x400556F")]
		[FieldOffset(Offset = "0x18")]
		public string displayName;

		// Token: 0x04005570 RID: 21872
		[Token(Token = "0x4005570")]
		[FieldOffset(Offset = "0x20")]
		public int slotId;

		// Token: 0x04005571 RID: 21873
		[Token(Token = "0x4005571")]
		[FieldOffset(Offset = "0x28")]
		public long startTs;

		// Token: 0x04005572 RID: 21874
		[Token(Token = "0x4005572")]
		[FieldOffset(Offset = "0x30")]
		public long endTs;

		// Token: 0x04005573 RID: 21875
		[Token(Token = "0x4005573")]
		[FieldOffset(Offset = "0x38")]
		public CrisisV2GoodType goodType;

		// Token: 0x04005574 RID: 21876
		[Token(Token = "0x4005574")]
		[FieldOffset(Offset = "0x40")]
		public string rarity;

		// Token: 0x04005575 RID: 21877
		[Token(Token = "0x4005575")]
		[FieldOffset(Offset = "0x48")]
		public ItemBundle item;

		// Token: 0x04005576 RID: 21878
		[Token(Token = "0x4005576")]
		[FieldOffset(Offset = "0x50")]
		public string progressGoodId;

		// Token: 0x04005577 RID: 21879
		[Token(Token = "0x4005577")]
		[FieldOffset(Offset = "0x58")]
		public int price;

		// Token: 0x04005578 RID: 21880
		[Token(Token = "0x4005578")]
		[FieldOffset(Offset = "0x5C")]
		public int availCount;
	}
}
