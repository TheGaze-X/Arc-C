using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200017E RID: 382
	[Token(Token = "0x200017E")]
	public struct SteamNetConnectionRealTimeLaneStatus_t
	{
		// Token: 0x04000A42 RID: 2626
		[Token(Token = "0x4000A42")]
		[FieldOffset(Offset = "0x0")]
		public int m_cbPendingUnreliable;

		// Token: 0x04000A43 RID: 2627
		[Token(Token = "0x4000A43")]
		[FieldOffset(Offset = "0x4")]
		public int m_cbPendingReliable;

		// Token: 0x04000A44 RID: 2628
		[Token(Token = "0x4000A44")]
		[FieldOffset(Offset = "0x8")]
		public int m_cbSentUnackedReliable;

		// Token: 0x04000A45 RID: 2629
		[Token(Token = "0x4000A45")]
		[FieldOffset(Offset = "0xC")]
		public int _reservePad1;

		// Token: 0x04000A46 RID: 2630
		[Token(Token = "0x4000A46")]
		[FieldOffset(Offset = "0x10")]
		public SteamNetworkingMicroseconds m_usecQueueTime;

		// Token: 0x04000A47 RID: 2631
		[Token(Token = "0x4000A47")]
		[FieldOffset(Offset = "0x18")]
		public uint[] reserved;
	}
}
