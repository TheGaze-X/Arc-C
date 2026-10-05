using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001319 RID: 4889
	[Token(Token = "0x2001319")]
	public class ShopCarouselData
	{
		// Token: 0x06007296 RID: 29334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007296")]
		[Address(RVA = "0x22111A0", Offset = "0x220FDA0", VA = "0x1822111A0")]
		public ShopCarouselData()
		{
		}

		// Token: 0x04006C53 RID: 27731
		[Token(Token = "0x4006C53")]
		[FieldOffset(Offset = "0x10")]
		public List<ShopCarouselData.Item> items;

		// Token: 0x0200131A RID: 4890
		[Token(Token = "0x200131A")]
		public class Item
		{
			// Token: 0x06007297 RID: 29335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007297")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Item()
			{
			}

			// Token: 0x04006C54 RID: 27732
			[Token(Token = "0x4006C54")]
			[FieldOffset(Offset = "0x10")]
			public string spriteId;

			// Token: 0x04006C55 RID: 27733
			[Token(Token = "0x4006C55")]
			[FieldOffset(Offset = "0x18")]
			public long startTime;

			// Token: 0x04006C56 RID: 27734
			[Token(Token = "0x4006C56")]
			[FieldOffset(Offset = "0x20")]
			public long endTime;

			// Token: 0x04006C57 RID: 27735
			[Token(Token = "0x4006C57")]
			[FieldOffset(Offset = "0x28")]
			public ShopRouteTarget cmd;

			// Token: 0x04006C58 RID: 27736
			[Token(Token = "0x4006C58")]
			[FieldOffset(Offset = "0x30")]
			public string param1;

			// Token: 0x04006C59 RID: 27737
			[Token(Token = "0x4006C59")]
			[FieldOffset(Offset = "0x38")]
			public string skinId;

			// Token: 0x04006C5A RID: 27738
			[Token(Token = "0x4006C5A")]
			[FieldOffset(Offset = "0x40")]
			public string furniId;
		}
	}
}
