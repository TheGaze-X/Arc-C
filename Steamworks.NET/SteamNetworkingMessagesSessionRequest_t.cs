using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x20000A2")]
	[CallbackIdentity(1251)]
	public struct SteamNetworkingMessagesSessionRequest_t
	{
		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		public const int k_iCallback = 1251;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x0")]
		public SteamNetworkingIdentity m_identityRemote;
	}
}
