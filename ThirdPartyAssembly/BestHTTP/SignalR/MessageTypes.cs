using System;
using Il2CppDummyDll;

namespace BestHTTP.SignalR
{
	// Token: 0x02000539 RID: 1337
	[Token(Token = "0x2000539")]
	public enum MessageTypes
	{
		// Token: 0x0400191C RID: 6428
		[Token(Token = "0x400191C")]
		KeepAlive,
		// Token: 0x0400191D RID: 6429
		[Token(Token = "0x400191D")]
		Data,
		// Token: 0x0400191E RID: 6430
		[Token(Token = "0x400191E")]
		Multiple,
		// Token: 0x0400191F RID: 6431
		[Token(Token = "0x400191F")]
		Result,
		// Token: 0x04001920 RID: 6432
		[Token(Token = "0x4001920")]
		Failure,
		// Token: 0x04001921 RID: 6433
		[Token(Token = "0x4001921")]
		MethodCall,
		// Token: 0x04001922 RID: 6434
		[Token(Token = "0x4001922")]
		Progress
	}
}
