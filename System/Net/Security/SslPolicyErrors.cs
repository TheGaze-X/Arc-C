using System;
using Il2CppDummyDll;

namespace System.Net.Security
{
	// Token: 0x020003D4 RID: 980
	[Token(Token = "0x20003D4")]
	[Flags]
	public enum SslPolicyErrors
	{
		// Token: 0x04001127 RID: 4391
		[Token(Token = "0x4001127")]
		None = 0,
		// Token: 0x04001128 RID: 4392
		[Token(Token = "0x4001128")]
		RemoteCertificateNotAvailable = 1,
		// Token: 0x04001129 RID: 4393
		[Token(Token = "0x4001129")]
		RemoteCertificateNameMismatch = 2,
		// Token: 0x0400112A RID: 4394
		[Token(Token = "0x400112A")]
		RemoteCertificateChainErrors = 4
	}
}
