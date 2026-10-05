using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000237 RID: 567
	[Token(Token = "0x2000237")]
	public abstract class AbstractTlsEncryptionCredentials : AbstractTlsCredentials, TlsEncryptionCredentials, TlsCredentials
	{
		// Token: 0x060013CF RID: 5071
		[Token(Token = "0x60013CF")]
		public abstract byte[] DecryptPreMasterSecret(byte[] encryptedPreMasterSecret);

		// Token: 0x060013D0 RID: 5072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013D0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AbstractTlsEncryptionCredentials()
		{
		}
	}
}
