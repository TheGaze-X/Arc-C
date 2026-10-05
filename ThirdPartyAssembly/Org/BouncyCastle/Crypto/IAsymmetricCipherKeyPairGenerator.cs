using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000217 RID: 535
	[Token(Token = "0x2000217")]
	public interface IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06001306 RID: 4870
		[Token(Token = "0x6001306")]
		void Init(KeyGenerationParameters parameters);

		// Token: 0x06001307 RID: 4871
		[Token(Token = "0x6001307")]
		AsymmetricCipherKeyPair GenerateKeyPair();
	}
}
