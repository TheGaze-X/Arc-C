using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public class FileSelectionEventArgs : EventArgs
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x5BB52E0", Offset = "0x5BB3EE0", VA = "0x185BB52E0")]
		public FileSelectionEventArgs(string[] acceptFilters, bool multipleAllowed, Action<string[]> continueCallback, Action cancelCallback)
		{
		}

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x10")]
		public readonly string[] AcceptFilters;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x18")]
		public readonly bool MultipleAllowed;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x20")]
		public readonly Action<string[]> Continue;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x28")]
		public readonly Action Cancel;
	}
}
