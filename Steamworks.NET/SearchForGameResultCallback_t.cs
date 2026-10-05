using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	[CallbackIdentity(5202)]
	public struct SearchForGameResultCallback_t
	{
		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		public const int k_iCallback = 5202;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ullSearchID;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0xC")]
		public int m_nCountPlayersInGame;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x10")]
		public int m_nCountAcceptedGame;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x14")]
		public CSteamID m_steamIDHost;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x1C")]
		public bool m_bFinalCallback;
	}
}
