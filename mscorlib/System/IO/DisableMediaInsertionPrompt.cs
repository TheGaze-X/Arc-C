using System;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x02000642 RID: 1602
	[Token(Token = "0x2000642")]
	internal struct DisableMediaInsertionPrompt : System.IDisposable
	{
		// Token: 0x06002FFF RID: 12287 RVA: 0x0001A0B8 File Offset: 0x000182B8
		[Token(Token = "0x6002FFF")]
		[Address(RVA = "0x4C5D3B0", Offset = "0x4C5BFB0", VA = "0x184C5D3B0")]
		public static DisableMediaInsertionPrompt Create()
		{
			return default(DisableMediaInsertionPrompt);
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003000")]
		[Address(RVA = "0x4C5D430", Offset = "0x4C5C030", VA = "0x184C5D430", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04001A9D RID: 6813
		[Token(Token = "0x4001A9D")]
		[FieldOffset(Offset = "0x0")]
		private bool _disableSuccess;

		// Token: 0x04001A9E RID: 6814
		[Token(Token = "0x4001A9E")]
		[FieldOffset(Offset = "0x4")]
		private uint _oldMode;

		// Token: 0x04001A9F RID: 6815
		[Token(Token = "0x4001A9F")]
		[FieldOffset(Offset = "0x0")]
		private static bool useUWPFallback;
	}
}
