using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001A4 RID: 420
	[Token(Token = "0x20001A4")]
	internal class SecP160K1Point : AbstractFpPoint
	{
		// Token: 0x06000C31 RID: 3121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x54BC5E0", Offset = "0x54BB1E0", VA = "0x1854BC5E0")]
		public SecP160K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x54BC540", Offset = "0x54BB140", VA = "0x1854BC540")]
		public SecP160K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecP160K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x54BBC60", Offset = "0x54BA860", VA = "0x1854BBC60", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x54BB520", Offset = "0x54BA120", VA = "0x1854BB520", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x54BBED0", Offset = "0x54BAAD0", VA = "0x1854BBED0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x51E7BF0", Offset = "0x51E67F0", VA = "0x1851E7BF0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x51E7B20", Offset = "0x51E6720", VA = "0x1851E7B20", Slot = "34")]
		public override ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x54BBDA0", Offset = "0x54BA9A0", VA = "0x1854BBDA0", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
