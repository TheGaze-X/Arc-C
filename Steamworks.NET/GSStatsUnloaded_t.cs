using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	[CallbackIdentity(1108)]
	public struct GSStatsUnloaded_t
	{
		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		public const int k_iCallback = 1108;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_steamIDUser;
	}
}
