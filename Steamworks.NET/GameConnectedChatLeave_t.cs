using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	[CallbackIdentity(340)]
	public struct GameConnectedChatLeave_t
	{
		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		public const int k_iCallback = 340;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDClanChat;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDUser;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bKicked;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x11")]
		public bool m_bDropped;
	}
}
