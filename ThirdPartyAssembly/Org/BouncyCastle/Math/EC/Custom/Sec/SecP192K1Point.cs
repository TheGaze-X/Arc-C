using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001B0 RID: 432
	[Token(Token = "0x20001B0")]
	internal class SecP192K1Point : AbstractFpPoint
	{
		// Token: 0x06000CE2 RID: 3298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x54C7730", Offset = "0x54C6330", VA = "0x1854C7730")]
		public SecP192K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x54C7690", Offset = "0x54C6290", VA = "0x1854C7690")]
		public SecP192K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecP192K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x54C6D10", Offset = "0x54C5910", VA = "0x1854C6D10", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE6")]
		[Address(RVA = "0x54C64D0", Offset = "0x54C50D0", VA = "0x1854C64D0", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE7")]
		[Address(RVA = "0x54C6F80", Offset = "0x54C5B80", VA = "0x1854C6F80", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE8")]
		[Address(RVA = "0x51E7BF0", Offset = "0x51E67F0", VA = "0x1851E7BF0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE9")]
		[Address(RVA = "0x51E7B20", Offset = "0x51E6720", VA = "0x1851E7B20", Slot = "34")]
		public override ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CEA")]
		[Address(RVA = "0x54C6E50", Offset = "0x54C5A50", VA = "0x1854C6E50", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
