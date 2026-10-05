using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	internal class SecP256K1Point : AbstractFpPoint
	{
		// Token: 0x06000DD7 RID: 3543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x51EBEB0", Offset = "0x51EAAB0", VA = "0x1851EBEB0")]
		public SecP256K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x51EBF50", Offset = "0x51EAB50", VA = "0x1851EBF50")]
		public SecP256K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecP256K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x51EB530", Offset = "0x51EA130", VA = "0x1851EB530", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x51EACF0", Offset = "0x51E98F0", VA = "0x1851EACF0", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x51EB7A0", Offset = "0x51EA3A0", VA = "0x1851EB7A0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x51E7BF0", Offset = "0x51E67F0", VA = "0x1851E7BF0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x51E7B20", Offset = "0x51E6720", VA = "0x1851E7B20", Slot = "34")]
		public override ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x51EB670", Offset = "0x51EA270", VA = "0x1851EB670", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
