using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	public struct SteamNetConnectionRealTimeStatus_t
	{
		// Token: 0x04000A34 RID: 2612
		[Token(Token = "0x4000A34")]
		[FieldOffset(Offset = "0x0")]
		public ESteamNetworkingConnectionState m_eState;

		// Token: 0x04000A35 RID: 2613
		[Token(Token = "0x4000A35")]
		[FieldOffset(Offset = "0x4")]
		public int m_nPing;

		// Token: 0x04000A36 RID: 2614
		[Token(Token = "0x4000A36")]
		[FieldOffset(Offset = "0x8")]
		public float m_flConnectionQualityLocal;

		// Token: 0x04000A37 RID: 2615
		[Token(Token = "0x4000A37")]
		[FieldOffset(Offset = "0xC")]
		public float m_flConnectionQualityRemote;

		// Token: 0x04000A38 RID: 2616
		[Token(Token = "0x4000A38")]
		[FieldOffset(Offset = "0x10")]
		public float m_flOutPacketsPerSec;

		// Token: 0x04000A39 RID: 2617
		[Token(Token = "0x4000A39")]
		[FieldOffset(Offset = "0x14")]
		public float m_flOutBytesPerSec;

		// Token: 0x04000A3A RID: 2618
		[Token(Token = "0x4000A3A")]
		[FieldOffset(Offset = "0x18")]
		public float m_flInPacketsPerSec;

		// Token: 0x04000A3B RID: 2619
		[Token(Token = "0x4000A3B")]
		[FieldOffset(Offset = "0x1C")]
		public float m_flInBytesPerSec;

		// Token: 0x04000A3C RID: 2620
		[Token(Token = "0x4000A3C")]
		[FieldOffset(Offset = "0x20")]
		public int m_nSendRateBytesPerSecond;

		// Token: 0x04000A3D RID: 2621
		[Token(Token = "0x4000A3D")]
		[FieldOffset(Offset = "0x24")]
		public int m_cbPendingUnreliable;

		// Token: 0x04000A3E RID: 2622
		[Token(Token = "0x4000A3E")]
		[FieldOffset(Offset = "0x28")]
		public int m_cbPendingReliable;

		// Token: 0x04000A3F RID: 2623
		[Token(Token = "0x4000A3F")]
		[FieldOffset(Offset = "0x2C")]
		public int m_cbSentUnackedReliable;

		// Token: 0x04000A40 RID: 2624
		[Token(Token = "0x4000A40")]
		[FieldOffset(Offset = "0x30")]
		public SteamNetworkingMicroseconds m_usecQueueTime;

		// Token: 0x04000A41 RID: 2625
		[Token(Token = "0x4000A41")]
		[FieldOffset(Offset = "0x38")]
		public uint[] reserved;
	}
}
