using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000788 RID: 1928
	[Token(Token = "0x2000788")]
	public class ItemVoucherPool
	{
		// Token: 0x06006404 RID: 25604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006404")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ItemVoucherPool()
		{
		}

		// Token: 0x04003044 RID: 12356
		[Token(Token = "0x4003044")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04003045 RID: 12357
		[Token(Token = "0x4003045")]
		[FieldOffset(Offset = "0x18")]
		public ItemType itemType;

		// Token: 0x04003046 RID: 12358
		[Token(Token = "0x4003046")]
		[FieldOffset(Offset = "0x1C")]
		public int itemNum;

		// Token: 0x04003047 RID: 12359
		[Token(Token = "0x4003047")]
		[FieldOffset(Offset = "0x20")]
		public int weight;

		// Token: 0x04003048 RID: 12360
		[Token(Token = "0x4003048")]
		[FieldOffset(Offset = "0x28")]
		public string groupId;

		// Token: 0x04003049 RID: 12361
		[Token(Token = "0x4003049")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;
	}
}
