using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000ED")]
	[CallbackIdentity(1106)]
	public struct LeaderboardScoreUploaded_t
	{
		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		public const int k_iCallback = 1106;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x0")]
		public byte m_bSuccess;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x8")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x10")]
		public int m_nScore;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x14")]
		public byte m_bScoreChanged;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x18")]
		public int m_nGlobalRankNew;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x1C")]
		public int m_nGlobalRankPrevious;
	}
}
