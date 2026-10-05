using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	public struct LeaderboardEntry_t
	{
		// Token: 0x04000A1C RID: 2588
		[Token(Token = "0x4000A1C")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;

		// Token: 0x04000A1D RID: 2589
		[Token(Token = "0x4000A1D")]
		[FieldOffset(Offset = "0x8")]
		public int m_nGlobalRank;

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0xC")]
		public int m_nScore;

		// Token: 0x04000A1F RID: 2591
		[Token(Token = "0x4000A1F")]
		[FieldOffset(Offset = "0x10")]
		public int m_cDetails;

		// Token: 0x04000A20 RID: 2592
		[Token(Token = "0x4000A20")]
		[FieldOffset(Offset = "0x18")]
		public UGCHandle_t m_hUGC;
	}
}
