using System;
using Il2CppDummyDll;

namespace BestHTTP
{
	// Token: 0x020004A2 RID: 1186
	[Token(Token = "0x20004A2")]
	public enum HTTPRequestStates
	{
		// Token: 0x0400158B RID: 5515
		[Token(Token = "0x400158B")]
		Initial,
		// Token: 0x0400158C RID: 5516
		[Token(Token = "0x400158C")]
		Queued,
		// Token: 0x0400158D RID: 5517
		[Token(Token = "0x400158D")]
		Processing,
		// Token: 0x0400158E RID: 5518
		[Token(Token = "0x400158E")]
		Finished,
		// Token: 0x0400158F RID: 5519
		[Token(Token = "0x400158F")]
		Error,
		// Token: 0x04001590 RID: 5520
		[Token(Token = "0x4001590")]
		Aborted,
		// Token: 0x04001591 RID: 5521
		[Token(Token = "0x4001591")]
		ConnectionTimedOut,
		// Token: 0x04001592 RID: 5522
		[Token(Token = "0x4001592")]
		TimedOut
	}
}
