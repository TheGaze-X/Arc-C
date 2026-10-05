using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	public class ProgressChangedEventArgs : EventArgs
	{
		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x5BBA650", Offset = "0x5BB9250", VA = "0x185BBA650")]
		public ProgressChangedEventArgs(ProgressChangeType type, float progress)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x5BBA5B0", Offset = "0x5BB91B0", VA = "0x185BBA5B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x10")]
		public readonly float Progress;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x14")]
		public readonly ProgressChangeType Type;
	}
}
