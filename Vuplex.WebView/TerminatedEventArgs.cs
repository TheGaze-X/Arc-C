using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public class TerminatedEventArgs : EventArgs
	{
		// Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x5BC4C20", Offset = "0x5BC3820", VA = "0x185BC4C20")]
		public TerminatedEventArgs(TerminationType type)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x5BC4BA0", Offset = "0x5BC37A0", VA = "0x185BC4BA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x10")]
		public readonly TerminationType Type;
	}
}
