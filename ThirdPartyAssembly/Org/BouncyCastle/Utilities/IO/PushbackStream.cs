using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x0200013C RID: 316
	[Token(Token = "0x200013C")]
	public class PushbackStream : FilterStream
	{
		// Token: 0x0600076B RID: 1899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x5469D00", Offset = "0x5468900", VA = "0x185469D00")]
		public PushbackStream(Stream s)
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00005538 File Offset: 0x00003738
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x5469B80", Offset = "0x5468780", VA = "0x185469B80", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00005550 File Offset: 0x00003750
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x5469BE0", Offset = "0x54687E0", VA = "0x185469BE0", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x5469C90", Offset = "0x5468890", VA = "0x185469C90", Slot = "38")]
		public virtual void Unread(int b)
		{
		}

		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0x30")]
		private int buf;
	}
}
