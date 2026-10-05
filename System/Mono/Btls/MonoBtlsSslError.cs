using System;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	internal enum MonoBtlsSslError
	{
		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		None,
		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		Ssl,
		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		WantRead,
		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		WantWrite,
		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		WantX509Lookup,
		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		Syscall,
		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		ZeroReturn,
		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		WantConnect,
		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		WantAccept,
		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		WantChannelIdLookup,
		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		PendingSession = 11,
		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		PendingCertificate,
		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		WantPrivateKeyOperation
	}
}
