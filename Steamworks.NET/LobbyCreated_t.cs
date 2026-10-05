using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	[CallbackIdentity(513)]
	public struct LobbyCreated_t
	{
		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		public const int k_iCallback = 513;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDLobby;
	}
}
