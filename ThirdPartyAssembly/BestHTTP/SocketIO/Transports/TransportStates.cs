using System;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO.Transports
{
	// Token: 0x02000521 RID: 1313
	[Token(Token = "0x2000521")]
	public enum TransportStates
	{
		// Token: 0x040018C7 RID: 6343
		[Token(Token = "0x40018C7")]
		Connecting,
		// Token: 0x040018C8 RID: 6344
		[Token(Token = "0x40018C8")]
		Opening,
		// Token: 0x040018C9 RID: 6345
		[Token(Token = "0x40018C9")]
		Open,
		// Token: 0x040018CA RID: 6346
		[Token(Token = "0x40018CA")]
		Closed,
		// Token: 0x040018CB RID: 6347
		[Token(Token = "0x40018CB")]
		Paused
	}
}
