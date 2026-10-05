using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200017B RID: 379
	[Token(Token = "0x200017B")]
	public struct CallbackMsg_t
	{
		// Token: 0x04000A23 RID: 2595
		[Token(Token = "0x4000A23")]
		[FieldOffset(Offset = "0x0")]
		public int m_hSteamUser;

		// Token: 0x04000A24 RID: 2596
		[Token(Token = "0x4000A24")]
		[FieldOffset(Offset = "0x4")]
		public int m_iCallback;

		// Token: 0x04000A25 RID: 2597
		[Token(Token = "0x4000A25")]
		[FieldOffset(Offset = "0x8")]
		public IntPtr m_pubParam;

		// Token: 0x04000A26 RID: 2598
		[Token(Token = "0x4000A26")]
		[FieldOffset(Offset = "0x10")]
		public int m_cubParam;
	}
}
