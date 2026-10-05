using System;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace System.Net.Security
{
	// Token: 0x020003D3 RID: 979
	// (Invoke) Token: 0x06001A4B RID: 6731
	[Token(Token = "0x20003D3")]
	public delegate bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors);
}
