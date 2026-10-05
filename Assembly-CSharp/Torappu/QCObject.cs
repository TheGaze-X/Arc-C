using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200086C RID: 2156
	[Token(Token = "0x200086C")]
	public class QCObject
	{
		// Token: 0x06006506 RID: 25862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006506")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public QCObject()
		{
		}

		// Token: 0x040031B6 RID: 12726
		[Token(Token = "0x40031B6")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x040031B7 RID: 12727
		[Token(Token = "0x40031B7")]
		[FieldOffset(Offset = "0x18")]
		public ItemBundle item;

		// Token: 0x040031B8 RID: 12728
		[Token(Token = "0x40031B8")]
		[FieldOffset(Offset = "0x20")]
		public string progressGoodId;

		// Token: 0x040031B9 RID: 12729
		[Token(Token = "0x40031B9")]
		[FieldOffset(Offset = "0x28")]
		public string displayName;

		// Token: 0x040031BA RID: 12730
		[Token(Token = "0x40031BA")]
		[FieldOffset(Offset = "0x30")]
		public int slotId;

		// Token: 0x040031BB RID: 12731
		[Token(Token = "0x40031BB")]
		[FieldOffset(Offset = "0x34")]
		public int originPrice;

		// Token: 0x040031BC RID: 12732
		[Token(Token = "0x40031BC")]
		[FieldOffset(Offset = "0x38")]
		public int price;

		// Token: 0x040031BD RID: 12733
		[Token(Token = "0x40031BD")]
		[FieldOffset(Offset = "0x3C")]
		public int availCount;

		// Token: 0x040031BE RID: 12734
		[Token(Token = "0x40031BE")]
		[FieldOffset(Offset = "0x40")]
		public float discount;

		// Token: 0x040031BF RID: 12735
		[Token(Token = "0x40031BF")]
		[FieldOffset(Offset = "0x44")]
		public int priority;

		// Token: 0x040031C0 RID: 12736
		[Token(Token = "0x40031C0")]
		[FieldOffset(Offset = "0x48")]
		public int number;

		// Token: 0x040031C1 RID: 12737
		[Token(Token = "0x40031C1")]
		[FieldOffset(Offset = "0x50")]
		public string groupId;

		// Token: 0x040031C2 RID: 12738
		[Token(Token = "0x40031C2")]
		[FieldOffset(Offset = "0x58")]
		public long goodStartTime;

		// Token: 0x040031C3 RID: 12739
		[Token(Token = "0x40031C3")]
		[FieldOffset(Offset = "0x60")]
		public long goodEndTime;

		// Token: 0x040031C4 RID: 12740
		[Token(Token = "0x40031C4")]
		[FieldOffset(Offset = "0x68")]
		public ShopQCGoodType goodType;

		// Token: 0x040031C5 RID: 12741
		[Token(Token = "0x40031C5")]
		[FieldOffset(Offset = "0x6C")]
		public bool disableMax;
	}
}
