using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x0200022C RID: 556
	[Token(Token = "0x200022C")]
	public interface IXof : IDigest
	{
		// Token: 0x06001359 RID: 4953
		[Token(Token = "0x6001359")]
		int DoFinal(byte[] output, int outOff, int outLen);

		// Token: 0x0600135A RID: 4954
		[Token(Token = "0x600135A")]
		int DoOutput(byte[] output, int outOff, int outLen);
	}
}
