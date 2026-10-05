using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	[CallbackIdentity(512)]
	public struct LobbyKicked_t
	{
		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		public const int k_iCallback = 512;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamIDLobby;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ulSteamIDAdmin;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x10")]
		public byte m_bKickedDueToDisconnect;
	}
}
