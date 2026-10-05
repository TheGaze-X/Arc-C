using System;
using Il2CppDummyDll;

namespace Mono.Net.Security
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	internal class BufferOffsetSize
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x17000018")]
		public int EndOffset
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x4F4E350", Offset = "0x4F4CF50", VA = "0x184F4E350")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x17000019")]
		public int Remaining
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x4F4E360", Offset = "0x4F4CF60", VA = "0x184F4E360")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x4F4E1E0", Offset = "0x4F4CDE0", VA = "0x184F4E1E0")]
		public BufferOffsetSize(byte[] buffer, int offset, int size)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x4F4E150", Offset = "0x4F4CD50", VA = "0x184F4E150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x10")]
		public byte[] Buffer;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x18")]
		public int Offset;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x1C")]
		public int Size;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x20")]
		public int TotalBytes;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x24")]
		public bool Complete;
	}
}
