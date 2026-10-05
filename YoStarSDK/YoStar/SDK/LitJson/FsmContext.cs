using System;
using Il2CppDummyDll;

namespace YoStar.SDK.LitJson
{
	// Token: 0x020002FA RID: 762
	[Token(Token = "0x20002FA")]
	internal class FsmContext
	{
		// Token: 0x060011C8 RID: 4552 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60011C8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FsmContext()
		{
		}

		// Token: 0x04000E4C RID: 3660
		[Token(Token = "0x4000E4C")]
		[FieldOffset(Offset = "0x10")]
		public bool Return;

		// Token: 0x04000E4D RID: 3661
		[Token(Token = "0x4000E4D")]
		[FieldOffset(Offset = "0x14")]
		public int NextState;

		// Token: 0x04000E4E RID: 3662
		[Token(Token = "0x4000E4E")]
		[FieldOffset(Offset = "0x18")]
		public Lexer L;

		// Token: 0x04000E4F RID: 3663
		[Token(Token = "0x4000E4F")]
		[FieldOffset(Offset = "0x20")]
		public int StateStack;
	}
}
