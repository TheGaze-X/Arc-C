using System;
using Il2CppDummyDll;

namespace BestHTTP.SignalR
{
	// Token: 0x0200053A RID: 1338
	[Token(Token = "0x200053A")]
	public enum ConnectionStates
	{
		// Token: 0x04001924 RID: 6436
		[Token(Token = "0x4001924")]
		Initial,
		// Token: 0x04001925 RID: 6437
		[Token(Token = "0x4001925")]
		Authenticating,
		// Token: 0x04001926 RID: 6438
		[Token(Token = "0x4001926")]
		Negotiating,
		// Token: 0x04001927 RID: 6439
		[Token(Token = "0x4001927")]
		Connecting,
		// Token: 0x04001928 RID: 6440
		[Token(Token = "0x4001928")]
		Connected,
		// Token: 0x04001929 RID: 6441
		[Token(Token = "0x4001929")]
		Reconnecting,
		// Token: 0x0400192A RID: 6442
		[Token(Token = "0x400192A")]
		Closed
	}
}
