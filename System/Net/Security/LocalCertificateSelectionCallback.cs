using System;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace System.Net.Security
{
	// Token: 0x020003D2 RID: 978
	// (Invoke) Token: 0x06001A49 RID: 6729
	[Token(Token = "0x20003D2")]
	public delegate X509Certificate LocalCertificateSelectionCallback(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers);
}
