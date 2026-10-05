using System;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public struct DisconnectInfo
	{
		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x0")]
		public DisconnectReason Reason;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x4")]
		public SocketError SocketErrorCode;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x8")]
		public NetPacketReader AdditionalData;
	}
}
