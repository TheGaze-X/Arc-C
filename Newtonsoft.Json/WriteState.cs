using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[Preserve]
	public enum WriteState
	{
		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		Error,
		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		Closed,
		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		Object,
		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		Array,
		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		Constructor,
		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		Property,
		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		Start
	}
}
