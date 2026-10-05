using System;
using Il2CppDummyDll;

namespace Mono.Security.Interface
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	[Flags]
	public enum TlsProtocols
	{
		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		Zero = 0,
		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		Tls10Client = 128,
		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		Tls10Server = 64,
		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		Tls10 = 192,
		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		Tls11Client = 512,
		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		Tls11Server = 256,
		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		Tls11 = 768,
		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		Tls12Client = 2048,
		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		Tls12Server = 1024,
		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		Tls12 = 3072,
		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		ClientMask = 2688,
		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		ServerMask = 1344
	}
}
