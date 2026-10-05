using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x0200018F RID: 399
	[Token(Token = "0x200018F")]
	public abstract class AbstractECMultiplier : ECMultiplier
	{
		// Token: 0x06000BA4 RID: 2980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x54B58A0", Offset = "0x54B44A0", VA = "0x1854B58A0", Slot = "5")]
		public virtual ECPoint Multiply(ECPoint p, BigInteger k)
		{
			return null;
		}

		// Token: 0x06000BA5 RID: 2981
		[Token(Token = "0x6000BA5")]
		protected abstract ECPoint MultiplyPositive(ECPoint p, BigInteger k);

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AbstractECMultiplier()
		{
		}
	}
}
