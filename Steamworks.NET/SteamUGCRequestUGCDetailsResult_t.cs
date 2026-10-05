using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	[CallbackIdentity(3402)]
	public struct SteamUGCRequestUGCDetailsResult_t
	{
		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		public const int k_iCallback = 3402;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x0")]
		public SteamUGCDetails_t m_details;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x90")]
		public bool m_bCachedData;
	}
}
