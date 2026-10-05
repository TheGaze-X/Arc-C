using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public class FocusedInputFieldChangedEventArgs : EventArgs
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x5BB54F0", Offset = "0x5BB40F0", VA = "0x185BB54F0")]
		public FocusedInputFieldChangedEventArgs(FocusedInputFieldType type)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x5BB5420", Offset = "0x5BB4020", VA = "0x185BB5420")]
		public static FocusedInputFieldType ParseType(string typeString)
		{
			return FocusedInputFieldType.Text;
		}

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x10")]
		public readonly FocusedInputFieldType Type;
	}
}
