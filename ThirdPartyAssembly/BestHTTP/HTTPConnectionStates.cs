using System;
using Il2CppDummyDll;

namespace BestHTTP
{
	// Token: 0x02000499 RID: 1177
	[Token(Token = "0x2000499")]
	internal enum HTTPConnectionStates
	{
		// Token: 0x0400154C RID: 5452
		[Token(Token = "0x400154C")]
		Initial,
		// Token: 0x0400154D RID: 5453
		[Token(Token = "0x400154D")]
		Processing,
		// Token: 0x0400154E RID: 5454
		[Token(Token = "0x400154E")]
		Redirected,
		// Token: 0x0400154F RID: 5455
		[Token(Token = "0x400154F")]
		Upgraded,
		// Token: 0x04001550 RID: 5456
		[Token(Token = "0x4001550")]
		WaitForProtocolShutdown,
		// Token: 0x04001551 RID: 5457
		[Token(Token = "0x4001551")]
		WaitForRecycle,
		// Token: 0x04001552 RID: 5458
		[Token(Token = "0x4001552")]
		Free,
		// Token: 0x04001553 RID: 5459
		[Token(Token = "0x4001553")]
		AbortRequested,
		// Token: 0x04001554 RID: 5460
		[Token(Token = "0x4001554")]
		TimedOut,
		// Token: 0x04001555 RID: 5461
		[Token(Token = "0x4001555")]
		Closed
	}
}
