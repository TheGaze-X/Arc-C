using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002B7 RID: 695
	[Token(Token = "0x20002B7")]
	public interface IDsaKCalculator
	{
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060017D9 RID: 6105
		[Token(Token = "0x1700033B")]
		bool IsDeterministic { [Token(Token = "0x60017D9")] get; }

		// Token: 0x060017DA RID: 6106
		[Token(Token = "0x60017DA")]
		void Init(BigInteger n, SecureRandom random);

		// Token: 0x060017DB RID: 6107
		[Token(Token = "0x60017DB")]
		void Init(BigInteger n, BigInteger d, byte[] message);

		// Token: 0x060017DC RID: 6108
		[Token(Token = "0x60017DC")]
		BigInteger NextK();
	}
}
