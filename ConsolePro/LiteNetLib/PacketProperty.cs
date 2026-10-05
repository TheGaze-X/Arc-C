using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	internal enum PacketProperty : byte
	{
		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		Unreliable,
		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		Channeled,
		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		Ack,
		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		Ping,
		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		Pong,
		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		ConnectRequest,
		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		ConnectAccept,
		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		Disconnect,
		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		UnconnectedMessage,
		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		MtuCheck,
		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		MtuOk,
		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		Broadcast,
		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		Merged,
		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		ShutdownOk,
		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		PeerNotFound,
		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		InvalidProtocol,
		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		NatMessage,
		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		Empty
	}
}
