using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public class ConsoleMessageEventArgs : EventArgs
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x5BB2FB0", Offset = "0x5BB1BB0", VA = "0x185BB2FB0")]
		public ConsoleMessageEventArgs(ConsoleMessageLevel level, string message, string source, int line)
		{
		}

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x10")]
		public readonly ConsoleMessageLevel Level;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x18")]
		public readonly string Message;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x20")]
		public readonly string Source;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x28")]
		public readonly int Line;
	}
}
