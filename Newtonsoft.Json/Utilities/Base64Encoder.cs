using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	[Preserve]
	internal class Base64Encoder
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x4D7D400", Offset = "0x4D7C000", VA = "0x184D7D400")]
		public Base64Encoder(TextWriter writer)
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x4D7CEC0", Offset = "0x4D7BAC0", VA = "0x184D7CEC0")]
		public void Encode(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x4D7D2A0", Offset = "0x4D7BEA0", VA = "0x184D7D2A0")]
		public void Flush()
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x4D7D380", Offset = "0x4D7BF80", VA = "0x184D7D380")]
		private void WriteChars(char[] chars, int index, int count)
		{
		}

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		private const int Base64LineSize = 76;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		private const int LineSizeInBytes = 57;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x10")]
		private readonly char[] _charsLine;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x18")]
		private readonly TextWriter _writer;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x20")]
		private byte[] _leftOverBytes;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x28")]
		private int _leftOverBytesCount;
	}
}
