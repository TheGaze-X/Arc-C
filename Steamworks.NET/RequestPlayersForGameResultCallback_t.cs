using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	[CallbackIdentity(5212)]
	public struct RequestPlayersForGameResultCallback_t
	{
		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		public const int k_iCallback = 5212;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x8")]
		public ulong m_ullSearchID;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x10")]
		public CSteamID m_SteamIDPlayerFound;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x18")]
		public CSteamID m_SteamIDLobby;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x20")]
		public PlayerAcceptState_t m_ePlayerAcceptState;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x24")]
		public int m_nPlayerIndex;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x28")]
		public int m_nTotalPlayersFound;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x2C")]
		public int m_nTotalPlayersAcceptedGame;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x30")]
		public int m_nSuggestedTeamIndex;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x38")]
		public ulong m_ullUniqueGameID;
	}
}
