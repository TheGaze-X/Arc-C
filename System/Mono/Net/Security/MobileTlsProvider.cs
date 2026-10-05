using System;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	internal abstract class MobileTlsProvider : MonoTlsProvider
	{
		// Token: 0x0600013A RID: 314
		[Token(Token = "0x600013A")]
		internal abstract MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

		// Token: 0x0600013B RID: 315
		[Token(Token = "0x600013B")]
		internal abstract bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11);

		// Token: 0x0600013C RID: 316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		protected MobileTlsProvider()
		{
		}
	}
}
