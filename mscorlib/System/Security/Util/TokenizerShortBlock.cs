using System;
using Il2CppDummyDll;

namespace System.Security.Util
{
	// Token: 0x020002CC RID: 716
	[Token(Token = "0x20002CC")]
	internal sealed class TokenizerShortBlock
	{
		// Token: 0x060017EB RID: 6123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EB")]
		[Address(RVA = "0x4B1BDA0", Offset = "0x4B1A9A0", VA = "0x184B1BDA0")]
		public TokenizerShortBlock()
		{
		}

		// Token: 0x04000CFA RID: 3322
		[Token(Token = "0x4000CFA")]
		[FieldOffset(Offset = "0x10")]
		internal short[] m_block;

		// Token: 0x04000CFB RID: 3323
		[Token(Token = "0x4000CFB")]
		[FieldOffset(Offset = "0x18")]
		internal TokenizerShortBlock m_next;
	}
}
