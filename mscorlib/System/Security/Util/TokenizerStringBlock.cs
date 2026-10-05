using System;
using Il2CppDummyDll;

namespace System.Security.Util
{
	// Token: 0x020002CD RID: 717
	[Token(Token = "0x20002CD")]
	internal sealed class TokenizerStringBlock
	{
		// Token: 0x060017EC RID: 6124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EC")]
		[Address(RVA = "0x4B1C5A0", Offset = "0x4B1B1A0", VA = "0x184B1C5A0")]
		public TokenizerStringBlock()
		{
		}

		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0x10")]
		internal string[] m_block;

		// Token: 0x04000CFD RID: 3325
		[Token(Token = "0x4000CFD")]
		[FieldOffset(Offset = "0x18")]
		internal TokenizerStringBlock m_next;
	}
}
