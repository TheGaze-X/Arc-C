using System;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x02000088 RID: 136
	[Token(Token = "0x2000088")]
	[Flags]
	internal enum MonoBtlsSslRenegotiateMode
	{
		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		NEVER = 0,
		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		ONCE = 1,
		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		FREELY = 2,
		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		IGNORE = 3
	}
}
