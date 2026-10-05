using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	[CallbackIdentity(509)]
	public struct LobbyGameCreated_t
	{
		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		public const int k_iCallback = 509;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDGameServer;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x10")]
		public uint m_unIP;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x14")]
		public ushort m_usPort;
	}
}
