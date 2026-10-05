using System;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x0200048E RID: 1166
	[Token(Token = "0x200048E")]
	internal class FsmContext
	{
		// Token: 0x060025CD RID: 9677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FsmContext()
		{
		}

		// Token: 0x0400150E RID: 5390
		[Token(Token = "0x400150E")]
		[FieldOffset(Offset = "0x10")]
		public bool Return;

		// Token: 0x0400150F RID: 5391
		[Token(Token = "0x400150F")]
		[FieldOffset(Offset = "0x14")]
		public int NextState;

		// Token: 0x04001510 RID: 5392
		[Token(Token = "0x4001510")]
		[FieldOffset(Offset = "0x18")]
		public Lexer L;

		// Token: 0x04001511 RID: 5393
		[Token(Token = "0x4001511")]
		[FieldOffset(Offset = "0x20")]
		public int StateStack;
	}
}
