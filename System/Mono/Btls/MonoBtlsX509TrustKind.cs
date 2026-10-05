using System;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x20000A2")]
	[Flags]
	internal enum MonoBtlsX509TrustKind
	{
		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		DEFAULT = 0,
		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		TRUST_CLIENT = 1,
		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		TRUST_SERVER = 2,
		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		TRUST_ALL = 4,
		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		REJECT_CLIENT = 32,
		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		REJECT_SERVER = 64,
		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		REJECT_ALL = 128
	}
}
