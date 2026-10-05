using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Endo
{
	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	public interface GlvEndomorphism : ECEndomorphism
	{
		// Token: 0x06000BDC RID: 3036
		[Token(Token = "0x6000BDC")]
		BigInteger[] DecomposeScalar(BigInteger k);
	}
}
