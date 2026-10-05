using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	internal class ByteStack
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x4F741F0", Offset = "0x4F72DF0", VA = "0x184F741F0")]
		public ByteStack(int growthRate)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4F74120", Offset = "0x4F72D20", VA = "0x184F74120")]
		public void Push(byte data)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4F740D0", Offset = "0x4F72CD0", VA = "0x184F740D0")]
		public byte Pop()
		{
			return 0;
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		private byte[] stack;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		private int growthRate;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x1C")]
		private int top;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x20")]
		private int size;
	}
}
