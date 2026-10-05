using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[CallbackIdentity(1801)]
	public struct GSStatsStored_t
	{
		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		public const int k_iCallback = 1801;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x4")]
		public CSteamID m_steamIDUser;
	}
}
