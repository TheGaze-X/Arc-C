using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200086E RID: 2158
	[Token(Token = "0x200086E")]
	public class ExtraQCObject
	{
		// Token: 0x06006507 RID: 25863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006507")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ExtraQCObject()
		{
		}

		// Token: 0x040031CB RID: 12747
		[Token(Token = "0x40031CB")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x040031CC RID: 12748
		[Token(Token = "0x40031CC")]
		[FieldOffset(Offset = "0x18")]
		public ItemBundle item;

		// Token: 0x040031CD RID: 12749
		[Token(Token = "0x40031CD")]
		[FieldOffset(Offset = "0x20")]
		public string displayName;

		// Token: 0x040031CE RID: 12750
		[Token(Token = "0x40031CE")]
		[FieldOffset(Offset = "0x28")]
		public int slotId;

		// Token: 0x040031CF RID: 12751
		[Token(Token = "0x40031CF")]
		[FieldOffset(Offset = "0x2C")]
		public int originPrice;

		// Token: 0x040031D0 RID: 12752
		[Token(Token = "0x40031D0")]
		[FieldOffset(Offset = "0x30")]
		public int price;

		// Token: 0x040031D1 RID: 12753
		[Token(Token = "0x40031D1")]
		[FieldOffset(Offset = "0x34")]
		public int availCount;

		// Token: 0x040031D2 RID: 12754
		[Token(Token = "0x40031D2")]
		[FieldOffset(Offset = "0x38")]
		public float discount;

		// Token: 0x040031D3 RID: 12755
		[Token(Token = "0x40031D3")]
		[FieldOffset(Offset = "0x40")]
		public long goodEndTime;

		// Token: 0x040031D4 RID: 12756
		[Token(Token = "0x40031D4")]
		[FieldOffset(Offset = "0x48")]
		public ExtraShopGroupType shopType;

		// Token: 0x040031D5 RID: 12757
		[Token(Token = "0x40031D5")]
		[FieldOffset(Offset = "0x50")]
		public long newFlagTimeStamp;
	}
}
