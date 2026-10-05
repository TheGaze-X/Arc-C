using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000EF")]
	[CallbackIdentity(1108)]
	public struct UserStatsUnloaded_t
	{
		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		public const int k_iCallback = 1108;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;
	}
}
