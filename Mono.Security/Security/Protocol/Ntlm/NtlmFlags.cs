using System;
using Il2CppDummyDll;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	[Flags]
	public enum NtlmFlags
	{
		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		NegotiateUnicode = 1,
		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		NegotiateOem = 2,
		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		RequestTarget = 4,
		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		NegotiateNtlm = 512,
		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		NegotiateDomainSupplied = 4096,
		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		NegotiateWorkstationSupplied = 8192,
		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		NegotiateAlwaysSign = 32768,
		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		NegotiateNtlm2Key = 524288,
		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		Negotiate128 = 536870912,
		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		Negotiate56 = -2147483648
	}
}
