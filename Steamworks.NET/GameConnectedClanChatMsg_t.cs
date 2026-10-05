using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	[CallbackIdentity(338)]
	public struct GameConnectedClanChatMsg_t
	{
		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		public const int k_iCallback = 338;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x10")]
		public int m_iMessageID;
	}
}
