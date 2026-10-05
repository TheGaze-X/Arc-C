using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000283 RID: 643
	[Token(Token = "0x2000283")]
	public interface TlsCipherFactory
	{
		// Token: 0x0600157E RID: 5502
		[Token(Token = "0x600157E")]
		TlsCipher CreateCipher(TlsContext context, int encryptionAlgorithm, int macAlgorithm);
	}
}
