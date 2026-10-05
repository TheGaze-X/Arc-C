using System;
using Il2CppDummyDll;

namespace BestHTTP.ServerSentEvents
{
	// Token: 0x020004C0 RID: 1216
	[Token(Token = "0x20004C0")]
	public enum States
	{
		// Token: 0x04001652 RID: 5714
		[Token(Token = "0x4001652")]
		Initial,
		// Token: 0x04001653 RID: 5715
		[Token(Token = "0x4001653")]
		Connecting,
		// Token: 0x04001654 RID: 5716
		[Token(Token = "0x4001654")]
		Open,
		// Token: 0x04001655 RID: 5717
		[Token(Token = "0x4001655")]
		Retrying,
		// Token: 0x04001656 RID: 5718
		[Token(Token = "0x4001656")]
		Closing,
		// Token: 0x04001657 RID: 5719
		[Token(Token = "0x4001657")]
		Closed
	}
}
