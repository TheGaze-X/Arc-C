using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200087F RID: 2175
	[Token(Token = "0x200087F")]
	public class EPGSGood
	{
		// Token: 0x0600651D RID: 25885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600651D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EPGSGood()
		{
		}

		// Token: 0x040031FC RID: 12796
		[Token(Token = "0x40031FC")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x040031FD RID: 12797
		[Token(Token = "0x40031FD")]
		[FieldOffset(Offset = "0x18")]
		public long startTime;

		// Token: 0x040031FE RID: 12798
		[Token(Token = "0x40031FE")]
		[FieldOffset(Offset = "0x20")]
		public long endTime;

		// Token: 0x040031FF RID: 12799
		[Token(Token = "0x40031FF")]
		[FieldOffset(Offset = "0x28")]
		public int availCount;

		// Token: 0x04003200 RID: 12800
		[Token(Token = "0x4003200")]
		[FieldOffset(Offset = "0x30")]
		public ItemBundle item;

		// Token: 0x04003201 RID: 12801
		[Token(Token = "0x4003201")]
		[FieldOffset(Offset = "0x38")]
		public int price;

		// Token: 0x04003202 RID: 12802
		[Token(Token = "0x4003202")]
		[FieldOffset(Offset = "0x3C")]
		public int sortId;
	}
}
