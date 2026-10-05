using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x0200022A RID: 554
	[Token(Token = "0x200022A")]
	public interface IVerifierFactoryProvider
	{
		// Token: 0x06001354 RID: 4948
		[Token(Token = "0x6001354")]
		IVerifierFactory CreateVerifierFactory(object algorithmDetails);
	}
}
