using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	[CallbackIdentity(166)]
	public struct MarketEligibilityResponse_t
	{
		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		public const int k_iCallback = 166;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x0")]
		public bool m_bAllowed;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x4")]
		public EMarketNotAllowedReasonFlags m_eNotAllowedReason;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x8")]
		public RTime32 m_rtAllowedAtTime;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0xC")]
		public int m_cdaySteamGuardRequiredDays;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x10")]
		public int m_cdayNewDeviceCooldown;
	}
}
