using System;
using Il2CppDummyDll;

namespace BestHTTP.SignalR
{
	// Token: 0x0200053C RID: 1340
	[Token(Token = "0x200053C")]
	public enum TransportStates
	{
		// Token: 0x04001935 RID: 6453
		[Token(Token = "0x4001935")]
		Initial,
		// Token: 0x04001936 RID: 6454
		[Token(Token = "0x4001936")]
		Connecting,
		// Token: 0x04001937 RID: 6455
		[Token(Token = "0x4001937")]
		Reconnecting,
		// Token: 0x04001938 RID: 6456
		[Token(Token = "0x4001938")]
		Starting,
		// Token: 0x04001939 RID: 6457
		[Token(Token = "0x4001939")]
		Started,
		// Token: 0x0400193A RID: 6458
		[Token(Token = "0x400193A")]
		Closing,
		// Token: 0x0400193B RID: 6459
		[Token(Token = "0x400193B")]
		Closed
	}
}
