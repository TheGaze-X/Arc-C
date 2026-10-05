using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	[CallbackIdentity(503)]
	public struct LobbyInvite_t
	{
		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		public const int k_iCallback = 503;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDUser;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDLobby;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_ulGameID;
	}
}
