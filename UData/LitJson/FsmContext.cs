using System;
using Il2CppDummyDll;

namespace UDatasdk.LitJson
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	internal class FsmContext
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FsmContext()
		{
		}

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x10")]
		public bool Return;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x14")]
		public int NextState;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x18")]
		public Lexer L;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x20")]
		public int StateStack;
	}
}
