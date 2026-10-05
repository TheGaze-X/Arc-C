using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	internal class ReaderWriterCount
	{
		// Token: 0x06000414 RID: 1044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ReaderWriterCount()
		{
		}

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x10")]
		public long lockID;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x18")]
		public int readercount;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x1C")]
		public int writercount;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x20")]
		public int upgradecount;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x28")]
		public ReaderWriterCount next;
	}
}
