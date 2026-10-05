using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	[CallbackIdentity(5201)]
	public struct SearchForGameProgressCallback_t
	{
		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		public const int k_iCallback = 5201;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ullSearchID;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0xC")]
		public CSteamID m_lobbyID;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x14")]
		public CSteamID m_steamIDEndedSearch;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x1C")]
		public int m_nSecondsRemainingEstimate;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x20")]
		public int m_cPlayersSearching;
	}
}
