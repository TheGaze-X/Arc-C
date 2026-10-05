using System;
using Il2CppDummyDll;

namespace BestHTTP.WebSocket
{
	// Token: 0x020004B8 RID: 1208
	[Token(Token = "0x20004B8")]
	public enum WebSocketStausCodes : uint
	{
		// Token: 0x04001613 RID: 5651
		[Token(Token = "0x4001613")]
		NormalClosure = 1000U,
		// Token: 0x04001614 RID: 5652
		[Token(Token = "0x4001614")]
		GoingAway,
		// Token: 0x04001615 RID: 5653
		[Token(Token = "0x4001615")]
		ProtocolError,
		// Token: 0x04001616 RID: 5654
		[Token(Token = "0x4001616")]
		WrongDataType,
		// Token: 0x04001617 RID: 5655
		[Token(Token = "0x4001617")]
		Reserved,
		// Token: 0x04001618 RID: 5656
		[Token(Token = "0x4001618")]
		NoStatusCode,
		// Token: 0x04001619 RID: 5657
		[Token(Token = "0x4001619")]
		ClosedAbnormally,
		// Token: 0x0400161A RID: 5658
		[Token(Token = "0x400161A")]
		DataError,
		// Token: 0x0400161B RID: 5659
		[Token(Token = "0x400161B")]
		PolicyError,
		// Token: 0x0400161C RID: 5660
		[Token(Token = "0x400161C")]
		TooBigMessage,
		// Token: 0x0400161D RID: 5661
		[Token(Token = "0x400161D")]
		ExtensionExpected,
		// Token: 0x0400161E RID: 5662
		[Token(Token = "0x400161E")]
		WrongRequest,
		// Token: 0x0400161F RID: 5663
		[Token(Token = "0x400161F")]
		TLSHandshakeError = 1015U
	}
}
