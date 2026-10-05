using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	[CallbackIdentity(333)]
	public struct GameLobbyJoinRequested_t
	{
		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		public const int k_iCallback = 333;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDLobby;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDFriend;
	}
}
