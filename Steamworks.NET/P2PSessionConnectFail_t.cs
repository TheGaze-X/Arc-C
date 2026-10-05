using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	[CallbackIdentity(1203)]
	public struct P2PSessionConnectFail_t
	{
		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		public const int k_iCallback = 1203;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDRemote;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x8")]
		public byte m_eP2PSessionError;
	}
}
