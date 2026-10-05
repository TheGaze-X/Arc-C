using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	[CallbackIdentity(343)]
	public struct GameConnectedFriendChatMsg_t
	{
		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		public const int k_iCallback = 343;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x8")]
		public int m_iMessageID;
	}
}
