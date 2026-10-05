using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000264 RID: 612
	[Token(Token = "0x2000264")]
	public interface ICertificateVerifyer
	{
		// Token: 0x060014DA RID: 5338
		[Token(Token = "0x60014DA")]
		bool IsValid(Uri targetUri, X509CertificateStructure[] certs);
	}
}
