using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x20000F3")]
	[CallbackIdentity(1112)]
	public struct GlobalStatsReceived_t
	{
		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		public const int k_iCallback = 1112;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
}
