using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	[CallbackIdentity(5702)]
	public struct SteamRemotePlaySessionDisconnected_t
	{
		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		public const int k_iCallback = 5702;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x0")]
		public RemotePlaySessionID_t m_unSessionID;
	}
}
