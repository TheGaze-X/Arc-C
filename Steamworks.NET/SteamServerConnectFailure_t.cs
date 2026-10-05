using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000DA RID: 218
	[Token(Token = "0x20000DA")]
	[CallbackIdentity(102)]
	public struct SteamServerConnectFailure_t
	{
		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		public const int k_iCallback = 102;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x4")]
		public bool m_bStillRetrying;
	}
}
