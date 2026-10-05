using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000266 RID: 614
	[Token(Token = "0x2000266")]
	public interface IClientCredentialsProvider
	{
		// Token: 0x060014DC RID: 5340
		[Token(Token = "0x60014DC")]
		TlsCredentials GetClientCredentials(TlsContext context, CertificateRequest certificateRequest);
	}
}
