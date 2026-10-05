using System;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork.ServerBase
{
	// Token: 0x020014C7 RID: 5319
	[Token(Token = "0x20014C7")]
	public struct ServerConfig
	{
		// Token: 0x040078B1 RID: 30897
		[Token(Token = "0x40078B1")]
		[FieldOffset(Offset = "0x0")]
		public float maxRetryTime;

		// Token: 0x040078B2 RID: 30898
		[Token(Token = "0x40078B2")]
		[FieldOffset(Offset = "0x8")]
		public IServerLogRule logRule;

		// Token: 0x040078B3 RID: 30899
		[Token(Token = "0x40078B3")]
		[FieldOffset(Offset = "0x10")]
		public IServerLoadingMask mask;
	}
}
