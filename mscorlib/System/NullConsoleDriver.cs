using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001B9 RID: 441
	[Token(Token = "0x20001B9")]
	internal class NullConsoleDriver : IConsoleDriver
	{
		// Token: 0x0600101F RID: 4127 RVA: 0x0000D470 File Offset: 0x0000B670
		[Token(Token = "0x600101F")]
		[Address(RVA = "0x4D3B920", Offset = "0x4D3A520", VA = "0x184D3B920", Slot = "4")]
		public System.ConsoleKeyInfo ReadKey(bool intercept)
		{
			return default(System.ConsoleKeyInfo);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001020")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public NullConsoleDriver()
		{
		}

		// Token: 0x04000779 RID: 1913
		[Token(Token = "0x4000779")]
		[FieldOffset(Offset = "0x0")]
		private static readonly System.ConsoleKeyInfo EmptyConsoleKeyInfo;
	}
}
