using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	[CallbackIdentity(1111)]
	public struct LeaderboardUGCSet_t
	{
		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		public const int k_iCallback = 1111;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x8")]
		public SteamLeaderboard_t m_hSteamLeaderboard;
	}
}
