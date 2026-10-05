using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200087C RID: 2172
	[Token(Token = "0x200087C")]
	public class LMTGSGood
	{
		// Token: 0x06006519 RID: 25881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006519")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LMTGSGood()
		{
		}

		// Token: 0x040031F3 RID: 12787
		[Token(Token = "0x40031F3")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x040031F4 RID: 12788
		[Token(Token = "0x40031F4")]
		[FieldOffset(Offset = "0x18")]
		public long startTime;

		// Token: 0x040031F5 RID: 12789
		[Token(Token = "0x40031F5")]
		[FieldOffset(Offset = "0x20")]
		public long endTime;

		// Token: 0x040031F6 RID: 12790
		[Token(Token = "0x40031F6")]
		[FieldOffset(Offset = "0x28")]
		public int availCount;

		// Token: 0x040031F7 RID: 12791
		[Token(Token = "0x40031F7")]
		[FieldOffset(Offset = "0x30")]
		public ItemBundle item;

		// Token: 0x040031F8 RID: 12792
		[Token(Token = "0x40031F8")]
		[FieldOffset(Offset = "0x38")]
		public ItemBundle price;

		// Token: 0x040031F9 RID: 12793
		[Token(Token = "0x40031F9")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;
	}
}
