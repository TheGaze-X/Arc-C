using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000233 RID: 563
	[Token(Token = "0x2000233")]
	public class AbstractTlsCipherFactory : TlsCipherFactory
	{
		// Token: 0x060013A0 RID: 5024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A0")]
		[Address(RVA = "0x523E380", Offset = "0x523CF80", VA = "0x18523E380", Slot = "5")]
		public virtual TlsCipher CreateCipher(TlsContext context, int encryptionAlgorithm, int macAlgorithm)
		{
			return null;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AbstractTlsCipherFactory()
		{
		}
	}
}
