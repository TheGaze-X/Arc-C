using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	[CallbackIdentity(1105)]
	public struct LeaderboardScoresDownloaded_t
	{
		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		public const int k_iCallback = 1105;

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x0")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x8")]
		public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x10")]
		public int m_cEntryCount;
	}
}
