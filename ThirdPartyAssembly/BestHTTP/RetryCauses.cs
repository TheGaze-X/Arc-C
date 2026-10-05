using System;
using Il2CppDummyDll;

namespace BestHTTP
{
	// Token: 0x02000497 RID: 1175
	[Token(Token = "0x2000497")]
	internal enum RetryCauses
	{
		// Token: 0x04001544 RID: 5444
		[Token(Token = "0x4001544")]
		None,
		// Token: 0x04001545 RID: 5445
		[Token(Token = "0x4001545")]
		Reconnect,
		// Token: 0x04001546 RID: 5446
		[Token(Token = "0x4001546")]
		Authenticate,
		// Token: 0x04001547 RID: 5447
		[Token(Token = "0x4001547")]
		ProxyAuthenticate
	}
}
