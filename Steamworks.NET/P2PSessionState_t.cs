using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	public struct P2PSessionState_t
	{
		// Token: 0x040009F7 RID: 2551
		[Token(Token = "0x40009F7")]
		[FieldOffset(Offset = "0x0")]
		public byte m_bConnectionActive;

		// Token: 0x040009F8 RID: 2552
		[Token(Token = "0x40009F8")]
		[FieldOffset(Offset = "0x1")]
		public byte m_bConnecting;

		// Token: 0x040009F9 RID: 2553
		[Token(Token = "0x40009F9")]
		[FieldOffset(Offset = "0x2")]
		public byte m_eP2PSessionError;

		// Token: 0x040009FA RID: 2554
		[Token(Token = "0x40009FA")]
		[FieldOffset(Offset = "0x3")]
		public byte m_bUsingRelay;

		// Token: 0x040009FB RID: 2555
		[Token(Token = "0x40009FB")]
		[FieldOffset(Offset = "0x4")]
		public int m_nBytesQueuedForSend;

		// Token: 0x040009FC RID: 2556
		[Token(Token = "0x40009FC")]
		[FieldOffset(Offset = "0x8")]
		public int m_nPacketsQueuedForSend;

		// Token: 0x040009FD RID: 2557
		[Token(Token = "0x40009FD")]
		[FieldOffset(Offset = "0xC")]
		public uint m_nRemoteIP;

		// Token: 0x040009FE RID: 2558
		[Token(Token = "0x40009FE")]
		[FieldOffset(Offset = "0x10")]
		public ushort m_nRemotePort;
	}
}
