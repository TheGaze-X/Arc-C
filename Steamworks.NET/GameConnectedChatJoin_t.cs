using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	[CallbackIdentity(339)]
	public struct GameConnectedChatJoin_t
	{
		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		public const int k_iCallback = 339;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;
	}
}
