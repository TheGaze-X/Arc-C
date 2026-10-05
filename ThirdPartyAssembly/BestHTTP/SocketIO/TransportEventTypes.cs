using System;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO
{
	// Token: 0x02000513 RID: 1299
	[Token(Token = "0x2000513")]
	public enum TransportEventTypes
	{
		// Token: 0x04001867 RID: 6247
		[Token(Token = "0x4001867")]
		Unknown = -1,
		// Token: 0x04001868 RID: 6248
		[Token(Token = "0x4001868")]
		Open,
		// Token: 0x04001869 RID: 6249
		[Token(Token = "0x4001869")]
		Close,
		// Token: 0x0400186A RID: 6250
		[Token(Token = "0x400186A")]
		Ping,
		// Token: 0x0400186B RID: 6251
		[Token(Token = "0x400186B")]
		Pong,
		// Token: 0x0400186C RID: 6252
		[Token(Token = "0x400186C")]
		Message,
		// Token: 0x0400186D RID: 6253
		[Token(Token = "0x400186D")]
		Upgrade,
		// Token: 0x0400186E RID: 6254
		[Token(Token = "0x400186E")]
		Noop
	}
}
