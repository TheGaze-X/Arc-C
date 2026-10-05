using System;
using System.Net;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	internal sealed class NetEvent
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x369F450", Offset = "0x369E050", VA = "0x18369F450")]
		public NetEvent(NetManager manager)
		{
		}

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x10")]
		public NetEvent Next;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x18")]
		public NetEvent.EType Type;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x20")]
		public NetPeer Peer;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x28")]
		public IPEndPoint RemoteEndPoint;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x30")]
		public object UserData;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x38")]
		public int Latency;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x3C")]
		public SocketError ErrorCode;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x40")]
		public DisconnectReason DisconnectReason;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x48")]
		public ConnectionRequest ConnectionRequest;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x50")]
		public DeliveryMethod DeliveryMethod;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x58")]
		public readonly NetPacketReader DataReader;

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200002C")]
		public enum EType
		{
			// Token: 0x04000076 RID: 118
			[Token(Token = "0x4000076")]
			Connect,
			// Token: 0x04000077 RID: 119
			[Token(Token = "0x4000077")]
			Disconnect,
			// Token: 0x04000078 RID: 120
			[Token(Token = "0x4000078")]
			Receive,
			// Token: 0x04000079 RID: 121
			[Token(Token = "0x4000079")]
			ReceiveUnconnected,
			// Token: 0x0400007A RID: 122
			[Token(Token = "0x400007A")]
			Error,
			// Token: 0x0400007B RID: 123
			[Token(Token = "0x400007B")]
			ConnectionLatencyUpdated,
			// Token: 0x0400007C RID: 124
			[Token(Token = "0x400007C")]
			Broadcast,
			// Token: 0x0400007D RID: 125
			[Token(Token = "0x400007D")]
			ConnectionRequest,
			// Token: 0x0400007E RID: 126
			[Token(Token = "0x400007E")]
			MessageDelivered
		}
	}
}
