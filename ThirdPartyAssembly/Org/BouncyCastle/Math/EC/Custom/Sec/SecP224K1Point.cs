using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001B8 RID: 440
	[Token(Token = "0x20001B8")]
	internal class SecP224K1Point : AbstractFpPoint
	{
		// Token: 0x06000D5A RID: 3418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x54CF390", Offset = "0x54CDF90", VA = "0x1854CF390")]
		public SecP224K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D5B")]
		[Address(RVA = "0x54CF2F0", Offset = "0x54CDEF0", VA = "0x1854CF2F0")]
		public SecP224K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D5C")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecP224K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5D")]
		[Address(RVA = "0x54CE970", Offset = "0x54CD570", VA = "0x1854CE970", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0x54CE130", Offset = "0x54CCD30", VA = "0x1854CE130", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0x54CEBE0", Offset = "0x54CD7E0", VA = "0x1854CEBE0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D60")]
		[Address(RVA = "0x51E7BF0", Offset = "0x51E67F0", VA = "0x1851E7BF0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D61")]
		[Address(RVA = "0x51E7B20", Offset = "0x51E6720", VA = "0x1851E7B20", Slot = "34")]
		public override ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x54CEAB0", Offset = "0x54CD6B0", VA = "0x1854CEAB0", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
