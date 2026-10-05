using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000296 RID: 662
	[Token(Token = "0x2000296")]
	public interface TlsEncryptionCredentials : TlsCredentials
	{
		// Token: 0x0600162F RID: 5679
		[Token(Token = "0x600162F")]
		byte[] DecryptPreMasterSecret(byte[] encryptedPreMasterSecret);
	}
}
