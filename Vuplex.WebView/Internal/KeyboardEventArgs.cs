using System;
using Il2CppDummyDll;

namespace Vuplex.WebView.Internal
{
	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	public class KeyboardEventArgs : EventArgs
	{
		// Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x5BCBD20", Offset = "0x5BCA920", VA = "0x185BCBD20")]
		public KeyboardEventArgs(string key, KeyModifier modifiers)
		{
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x5BCBCA0", Offset = "0x5BCA8A0", VA = "0x185BCBCA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x10")]
		public readonly string Key;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x18")]
		public readonly KeyModifier Modifiers;
	}
}
