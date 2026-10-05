using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[CallbackIdentity(344)]
	public struct FriendsGetFollowerCount_t
	{
		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		public const int k_iCallback = 344;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0xC")]
		public int m_nCount;
	}
}
