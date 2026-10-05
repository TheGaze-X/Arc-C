using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200078A RID: 1930
	[Token(Token = "0x200078A")]
	public class UseItemsRequest
	{
		// Token: 0x06006406 RID: 25606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006406")]
		[Address(RVA = "0x1F04790", Offset = "0x1F03390", VA = "0x181F04790")]
		public UseItemsRequest()
		{
		}

		// Token: 0x0400304D RID: 12365
		[Token(Token = "0x400304D")]
		[FieldOffset(Offset = "0x10")]
		public List<UseItemsRequest.Item> items;

		// Token: 0x0200078B RID: 1931
		[Token(Token = "0x200078B")]
		public class Item
		{
			// Token: 0x06006407 RID: 25607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006407")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Item()
			{
			}

			// Token: 0x0400304E RID: 12366
			[Token(Token = "0x400304E")]
			[FieldOffset(Offset = "0x10")]
			public int instId;

			// Token: 0x0400304F RID: 12367
			[Token(Token = "0x400304F")]
			[FieldOffset(Offset = "0x18")]
			public string itemId;

			// Token: 0x04003050 RID: 12368
			[Token(Token = "0x4003050")]
			[FieldOffset(Offset = "0x20")]
			public int cnt;
		}
	}
}
