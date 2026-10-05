using System;
using Il2CppDummyDll;

namespace BestHTTP.WebSocket.Frames
{
	// Token: 0x020004BB RID: 1211
	[Token(Token = "0x20004BB")]
	public enum WebSocketFrameTypes : byte
	{
		// Token: 0x0400162F RID: 5679
		[Token(Token = "0x400162F")]
		Continuation,
		// Token: 0x04001630 RID: 5680
		[Token(Token = "0x4001630")]
		Text,
		// Token: 0x04001631 RID: 5681
		[Token(Token = "0x4001631")]
		Binary,
		// Token: 0x04001632 RID: 5682
		[Token(Token = "0x4001632")]
		ConnectionClose = 8,
		// Token: 0x04001633 RID: 5683
		[Token(Token = "0x4001633")]
		Ping,
		// Token: 0x04001634 RID: 5684
		[Token(Token = "0x4001634")]
		Pong
	}
}
