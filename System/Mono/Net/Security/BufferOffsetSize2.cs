using System;
using Il2CppDummyDll;

namespace Mono.Net.Security
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	internal class BufferOffsetSize2 : BufferOffsetSize
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x4F4E020", Offset = "0x4F4CC20", VA = "0x184F4E020")]
		public BufferOffsetSize2(int size)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x4F4DFC0", Offset = "0x4F4CBC0", VA = "0x184F4DFC0")]
		public void Reset()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x4F4DEF0", Offset = "0x4F4CAF0", VA = "0x184F4DEF0")]
		public void MakeRoom(int size)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x4F4DDE0", Offset = "0x4F4C9E0", VA = "0x184F4DDE0")]
		public void AppendData(byte[] buffer, int offset, int size)
		{
		}

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x28")]
		public readonly int InitialSize;
	}
}
