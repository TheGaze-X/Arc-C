using System;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace Mono.Security.Interface
{
	// Token: 0x02000040 RID: 64
	// (Invoke) Token: 0x0600014F RID: 335
	[Token(Token = "0x2000040")]
	public delegate bool MonoRemoteCertificateValidationCallback(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors);
}
