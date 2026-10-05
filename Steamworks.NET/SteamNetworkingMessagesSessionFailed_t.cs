using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	[CallbackIdentity(1252)]
	public struct SteamNetworkingMessagesSessionFailed_t
	{
		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		public const int k_iCallback = 1252;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x0")]
		public SteamNetConnectionInfo_t m_info;
	}
}
