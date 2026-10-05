using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001B4 RID: 436
	[Token(Token = "0x20001B4")]
	internal class SecP192R1Point : AbstractFpPoint
	{
		// Token: 0x06000D1F RID: 3359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D1F")]
		[Address(RVA = "0x54CB800", Offset = "0x54CA400", VA = "0x1854CB800")]
		public SecP192R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D20")]
		[Address(RVA = "0x54CB760", Offset = "0x54CA360", VA = "0x1854CB760")]
		public SecP192R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D21")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecP192R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x54CAD30", Offset = "0x54C9930", VA = "0x1854CAD30", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x54CA550", Offset = "0x54C9150", VA = "0x1854CA550", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x54CAFA0", Offset = "0x54C9BA0", VA = "0x1854CAFA0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x51E7BF0", Offset = "0x51E67F0", VA = "0x1851E7BF0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x51E7B20", Offset = "0x51E6720", VA = "0x1851E7B20", Slot = "34")]
		public override ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x54CAE70", Offset = "0x54C9A70", VA = "0x1854CAE70", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
