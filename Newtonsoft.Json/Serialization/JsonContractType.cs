using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	[Preserve]
	internal enum JsonContractType
	{
		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		None,
		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		Object,
		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		Array,
		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		Primitive,
		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		String,
		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		Dictionary,
		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		Dynamic,
		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		Serializable,
		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		Linq
	}
}
