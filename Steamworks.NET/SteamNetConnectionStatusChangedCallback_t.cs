using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	[CallbackIdentity(1221)]
	public struct SteamNetConnectionStatusChangedCallback_t
	{
		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		public const int k_iCallback = 1221;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x0")]
		public HSteamNetConnection m_hConn;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x8")]
		public SteamNetConnectionInfo_t m_info;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0xE8")]
		public ESteamNetworkingConnectionState m_eOldState;
	}
}
