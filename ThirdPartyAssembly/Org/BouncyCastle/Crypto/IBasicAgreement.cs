using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000218 RID: 536
	[Token(Token = "0x2000218")]
	public interface IBasicAgreement
	{
		// Token: 0x06001308 RID: 4872
		[Token(Token = "0x6001308")]
		void Init(ICipherParameters parameters);

		// Token: 0x06001309 RID: 4873
		[Token(Token = "0x6001309")]
		int GetFieldSize();

		// Token: 0x0600130A RID: 4874
		[Token(Token = "0x600130A")]
		BigInteger CalculateAgreement(ICipherParameters pubKey);
	}
}
