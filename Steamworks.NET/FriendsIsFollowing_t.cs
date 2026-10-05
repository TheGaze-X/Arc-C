using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[CallbackIdentity(345)]
	public struct FriendsIsFollowing_t
	{
		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		public const int k_iCallback = 345;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xC")]
		public bool m_bIsFollowing;
	}
}
