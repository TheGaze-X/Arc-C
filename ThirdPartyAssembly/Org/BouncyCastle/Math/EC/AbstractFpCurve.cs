using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200017F RID: 383
	[Token(Token = "0x200017F")]
	public abstract class AbstractFpCurve : ECCurve
	{
		// Token: 0x06000A76 RID: 2678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x54988C0", Offset = "0x54974C0", VA = "0x1854988C0")]
		protected AbstractFpCurve(BigInteger q)
		{
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00007458 File Offset: 0x00005658
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x5498810", Offset = "0x5497410", VA = "0x185498810", Slot = "6")]
		public override bool IsValidFieldElement(BigInteger x)
		{
			return default(bool);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x5498540", Offset = "0x5497140", VA = "0x185498540", Slot = "33")]
		protected override ECPoint DecompressPoint(int yTilde, BigInteger X1)
		{
			return null;
		}
	}
}
