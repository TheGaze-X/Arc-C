using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public enum DisconnectReason
	{
		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		ConnectionFailed,
		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		Timeout,
		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		HostUnreachable,
		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		NetworkUnreachable,
		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		RemoteConnectionClose,
		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		DisconnectPeerCalled,
		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		ConnectionRejected,
		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		InvalidProtocol,
		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		UnknownHost,
		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		Reconnect,
		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		PeerToPeerConnection
	}
}
