using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	public class ScriptDialogEventArgs : EventArgs
	{
		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x5BBA6C0", Offset = "0x5BB92C0", VA = "0x185BBA6C0")]
		public ScriptDialogEventArgs(string message, Action continueCallback)
		{
		}

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x10")]
		public readonly string Message;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x18")]
		public readonly Action Continue;
	}
}
