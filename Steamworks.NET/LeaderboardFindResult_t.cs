using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	[CallbackIdentity(1104)]
	public struct LeaderboardFindResult_t
	{
		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		public const int k_iCallback = 1104;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x0")]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x8")]
		public byte m_bLeaderboardFound;
	}
}
