using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001A2 RID: 418
	[Token(Token = "0x20001A2")]
	internal class SecP128R1Point : AbstractFpPoint
	{
		// Token: 0x06000C1E RID: 3102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x54BAE30", Offset = "0x54B9A30", VA = "0x1854BAE30")]
		public SecP128R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x54BAED0", Offset = "0x54B9AD0", VA = "0x1854BAED0")]
		public SecP128R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecP128R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x54BA2D0", Offset = "0x54B8ED0", VA = "0x1854BA2D0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x54B9AD0", Offset = "0x54B86D0", VA = "0x1854B9AD0", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x54BA540", Offset = "0x54B9140", VA = "0x1854BA540", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x51E7BF0", Offset = "0x51E67F0", VA = "0x1851E7BF0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x51E7B20", Offset = "0x51E6720", VA = "0x1851E7B20", Slot = "34")]
		public override ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x54BA410", Offset = "0x54B9010", VA = "0x1854BA410", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
