using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public class LoadFailedEventArgs : EventArgs
	{
		// Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x5BB5C80", Offset = "0x5BB4880", VA = "0x185BB5C80")]
		public LoadFailedEventArgs(string nativeErrorCode, string url)
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x5BB5C20", Offset = "0x5BB4820", VA = "0x185BB5C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x10")]
		public readonly string NativeErrorCode;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x18")]
		public readonly string Url;
	}
}
