using System;
using Il2CppDummyDll;

namespace Mono.Security.Interface
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[Flags]
	public enum MonoSslPolicyErrors
	{
		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		None = 0,
		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		RemoteCertificateNotAvailable = 1,
		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		RemoteCertificateNameMismatch = 2,
		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		RemoteCertificateChainErrors = 4
	}
}
