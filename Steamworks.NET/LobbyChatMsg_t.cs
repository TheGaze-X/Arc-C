using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	[CallbackIdentity(507)]
	public struct LobbyChatMsg_t
	{
		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		public const int k_iCallback = 507;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDUser;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x10")]
		public byte m_eChatEntryType;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x14")]
		public uint m_iChatID;
	}
}
