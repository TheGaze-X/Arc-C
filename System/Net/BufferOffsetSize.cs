using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002CE RID: 718
	[Token(Token = "0x20002CE")]
	internal class BufferOffsetSize
	{
		// Token: 0x06001406 RID: 5126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001406")]
		[Address(RVA = "0x5049C40", Offset = "0x5048840", VA = "0x185049C40")]
		internal BufferOffsetSize(byte[] buffer, int offset, int size, bool copyBuffer)
		{
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001407")]
		[Address(RVA = "0x5049B80", Offset = "0x5048780", VA = "0x185049B80")]
		internal BufferOffsetSize(byte[] buffer, bool copyBuffer)
		{
		}

		// Token: 0x04000ACC RID: 2764
		[Token(Token = "0x4000ACC")]
		[FieldOffset(Offset = "0x10")]
		internal byte[] Buffer;

		// Token: 0x04000ACD RID: 2765
		[Token(Token = "0x4000ACD")]
		[FieldOffset(Offset = "0x18")]
		internal int Offset;

		// Token: 0x04000ACE RID: 2766
		[Token(Token = "0x4000ACE")]
		[FieldOffset(Offset = "0x1C")]
		internal int Size;
	}
}
