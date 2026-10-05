using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	[CallbackIdentity(1102)]
	public struct UserStatsStored_t
	{
		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		public const int k_iCallback = 1102;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
}
