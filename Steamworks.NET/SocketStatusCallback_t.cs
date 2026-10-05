using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	[CallbackIdentity(1201)]
	public struct SocketStatusCallback_t
	{
		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		public const int k_iCallback = 1201;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x0")]
		public SNetSocket_t m_hSocket;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x4")]
		public SNetListenSocket_t m_hListenSocket;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDRemote;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x10")]
		public int m_eSNetSocketState;
	}
}
