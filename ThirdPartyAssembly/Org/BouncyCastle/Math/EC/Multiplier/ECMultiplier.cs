using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000190 RID: 400
	[Token(Token = "0x2000190")]
	public interface ECMultiplier
	{
		// Token: 0x06000BA7 RID: 2983
		[Token(Token = "0x6000BA7")]
		ECPoint Multiply(ECPoint p, BigInteger k);
	}
}
