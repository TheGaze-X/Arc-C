using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002AA RID: 682
	[Token(Token = "0x20002AA")]
	public interface TlsSignerCredentials : TlsCredentials
	{
		// Token: 0x06001700 RID: 5888
		[Token(Token = "0x6001700")]
		byte[] GenerateCertificateSignature(byte[] hash);

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001701 RID: 5889
		[Token(Token = "0x1700032C")]
		SignatureAndHashAlgorithm SignatureAndHashAlgorithm { [Token(Token = "0x6001701")] get; }
	}
}
