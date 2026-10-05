using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000232 RID: 562
	[Token(Token = "0x2000232")]
	public abstract class AbstractTlsAgreementCredentials : AbstractTlsCredentials, TlsAgreementCredentials, TlsCredentials
	{
		// Token: 0x0600139E RID: 5022
		[Token(Token = "0x600139E")]
		public abstract byte[] GenerateAgreement(AsymmetricKeyParameter peerPublicKey);

		// Token: 0x0600139F RID: 5023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600139F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AbstractTlsAgreementCredentials()
		{
		}
	}
}
