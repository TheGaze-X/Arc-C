using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200102C RID: 4140
	[Token(Token = "0x200102C")]
	public class StickerItemData
	{
		// Token: 0x06006D7C RID: 28028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D7C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StickerItemData()
		{
		}

		// Token: 0x040057E7 RID: 22503
		[Token(Token = "0x40057E7")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040057E8 RID: 22504
		[Token(Token = "0x40057E8")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040057E9 RID: 22505
		[Token(Token = "0x40057E9")]
		[FieldOffset(Offset = "0x20")]
		public StickerType stickerType;

		// Token: 0x040057EA RID: 22506
		[Token(Token = "0x40057EA")]
		[FieldOffset(Offset = "0x24")]
		public int sortId;

		// Token: 0x040057EB RID: 22507
		[Token(Token = "0x40057EB")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x040057EC RID: 22508
		[Token(Token = "0x40057EC")]
		[FieldOffset(Offset = "0x30")]
		public string usage;

		// Token: 0x040057ED RID: 22509
		[Token(Token = "0x40057ED")]
		[FieldOffset(Offset = "0x38")]
		public string approach;

		// Token: 0x040057EE RID: 22510
		[Token(Token = "0x40057EE")]
		[FieldOffset(Offset = "0x40")]
		public ItemRarity rarity;
	}
}
