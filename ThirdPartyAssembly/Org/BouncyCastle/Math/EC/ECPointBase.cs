using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000187 RID: 391
	[Token(Token = "0x2000187")]
	public abstract class ECPointBase : ECPoint
	{
		// Token: 0x06000B2E RID: 2862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x549F090", Offset = "0x549DC90", VA = "0x18549F090")]
		protected internal ECPointBase(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x549EFD0", Offset = "0x549DBD0", VA = "0x18549EFD0")]
		protected internal ECPointBase(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x549EBF0", Offset = "0x549D7F0", VA = "0x18549EBF0", Slot = "25")]
		public override byte[] GetEncoded(bool compressed)
		{
			return null;
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x549EE80", Offset = "0x549DA80", VA = "0x18549EE80", Slot = "32")]
		public override ECPoint Multiply(BigInteger k)
		{
			return null;
		}
	}
}
