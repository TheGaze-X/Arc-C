using System;
using Il2CppDummyDll;

namespace System.Security.Authentication
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	[Flags]
	public enum SslProtocols
	{
		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		None = 0,
		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		Ssl2 = 12,
		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		Ssl3 = 48,
		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		Tls = 192,
		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[MonoTODO("unsupported")]
		Tls11 = 768,
		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[MonoTODO("unsupported")]
		Tls12 = 3072,
		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		Tls13 = 12288,
		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		Default = 240
	}
}
