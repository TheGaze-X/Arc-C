using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000170 RID: 368
	[Token(Token = "0x2000170")]
	public struct FriendGameInfo_t
	{
		// Token: 0x040009DC RID: 2524
		[Token(Token = "0x40009DC")]
		[FieldOffset(Offset = "0x0")]
		public CGameID m_gameID;

		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x40009DD")]
		[FieldOffset(Offset = "0x8")]
		public uint m_unGameIP;

		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x40009DE")]
		[FieldOffset(Offset = "0xC")]
		public ushort m_usGamePort;

		// Token: 0x040009DF RID: 2527
		[Token(Token = "0x40009DF")]
		[FieldOffset(Offset = "0xE")]
		public ushort m_usQueryPort;

		// Token: 0x040009E0 RID: 2528
		[Token(Token = "0x40009E0")]
		[FieldOffset(Offset = "0x10")]
		public CSteamID m_steamIDLobby;
	}
}
