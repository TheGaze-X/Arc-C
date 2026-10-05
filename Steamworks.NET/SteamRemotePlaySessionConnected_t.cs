using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	[CallbackIdentity(5701)]
	public struct SteamRemotePlaySessionConnected_t
	{
		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		public const int k_iCallback = 5701;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x0")]
		public RemotePlaySessionID_t m_unSessionID;
	}
}
