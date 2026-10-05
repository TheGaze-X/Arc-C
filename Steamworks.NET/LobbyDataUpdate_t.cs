using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	[CallbackIdentity(505)]
	public struct LobbyDataUpdate_t
	{
		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		public const int k_iCallback = 505;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDMember;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x10")]
		public byte m_bSuccess;
	}
}
