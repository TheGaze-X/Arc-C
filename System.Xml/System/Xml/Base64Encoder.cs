using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	internal abstract class Base64Encoder
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x4F72FD0", Offset = "0x4F71BD0", VA = "0x184F72FD0")]
		internal Base64Encoder()
		{
		}

		// Token: 0x06000005 RID: 5
		[Token(Token = "0x6000005")]
		internal abstract void WriteChars(char[] chars, int index, int count);

		// Token: 0x06000006 RID: 6 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x4F72B20", Offset = "0x4F71720", VA = "0x184F72B20")]
		internal void Encode(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x4F72EF0", Offset = "0x4F71AF0", VA = "0x184F72EF0")]
		internal void Flush()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		private byte[] leftOverBytes;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		private int leftOverBytesCount;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		private char[] charsLine;
	}
}
