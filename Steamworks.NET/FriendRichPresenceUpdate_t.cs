using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[CallbackIdentity(336)]
	public struct FriendRichPresenceUpdate_t
	{
		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		public const int k_iCallback = 336;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDFriend;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x8")]
		public AppId_t m_nAppID;
	}
}
