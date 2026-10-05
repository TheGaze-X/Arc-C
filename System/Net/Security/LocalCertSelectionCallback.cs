using System;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace System.Net.Security
{
	// Token: 0x020003D5 RID: 981
	// (Invoke) Token: 0x06001A4D RID: 6733
	[Token(Token = "0x20003D5")]
	internal delegate X509Certificate LocalCertSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers);
}
