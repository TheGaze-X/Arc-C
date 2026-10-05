using System;
using Il2CppDummyDll;

namespace Mono.Security.X509
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[Flags]
	[Serializable]
	public enum X509ChainStatusFlags
	{
		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		InvalidBasicConstraints = 1024,
		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		NoError = 0,
		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		NotSignatureValid = 8,
		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		NotTimeNested = 2,
		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		NotTimeValid = 1,
		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		PartialChain = 65536,
		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		UntrustedRoot = 32
	}
}
