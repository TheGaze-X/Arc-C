using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200027F RID: 639
	[Token(Token = "0x200027F")]
	public interface TlsAgreementCredentials : TlsCredentials
	{
		// Token: 0x0600156F RID: 5487
		[Token(Token = "0x600156F")]
		byte[] GenerateAgreement(AsymmetricKeyParameter peerPublicKey);
	}
}
