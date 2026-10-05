using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000220 RID: 544
	[Token(Token = "0x2000220")]
	public interface IDsa
	{
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600132F RID: 4911
		[Token(Token = "0x170002A9")]
		string AlgorithmName { [Token(Token = "0x600132F")] get; }

		// Token: 0x06001330 RID: 4912
		[Token(Token = "0x6001330")]
		void Init(bool forSigning, ICipherParameters parameters);

		// Token: 0x06001331 RID: 4913
		[Token(Token = "0x6001331")]
		BigInteger[] GenerateSignature(byte[] message);

		// Token: 0x06001332 RID: 4914
		[Token(Token = "0x6001332")]
		bool VerifySignature(byte[] message, BigInteger r, BigInteger s);
	}
}
