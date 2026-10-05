using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	public class ScriptDialogEventArgs<T> : EventArgs
	{
		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		public ScriptDialogEventArgs(string message, Action<T> continueCallback)
		{
		}

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x0")]
		public readonly string Message;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x0")]
		public readonly Action<T> Continue;
	}
}
