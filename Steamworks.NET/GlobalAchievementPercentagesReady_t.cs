using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	[CallbackIdentity(1110)]
	public struct GlobalAchievementPercentagesReady_t
	{
		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		public const int k_iCallback = 1110;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;
	}
}
