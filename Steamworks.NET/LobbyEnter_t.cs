using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	[CallbackIdentity(504)]
	public struct LobbyEnter_t
	{
		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		public const int k_iCallback = 504;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x8")]
		public uint m_rgfChatPermissions;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0xC")]
		public bool m_bLocked;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x10")]
		public uint m_EChatRoomEnterResponse;
	}
}
