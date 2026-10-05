using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000280 RID: 640
	[Token(Token = "0x2000280")]
	public interface TlsAuthentication
	{
		// Token: 0x06001570 RID: 5488
		[Token(Token = "0x6001570")]
		void NotifyServerCertificate(Certificate serverCertificate);

		// Token: 0x06001571 RID: 5489
		[Token(Token = "0x6001571")]
		TlsCredentials GetClientCredentials(TlsContext context, CertificateRequest certificateRequest);
	}
}
