using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001C8 RID: 456
	[Token(Token = "0x20001C8")]
	internal class SecP384R1Point : AbstractFpPoint
	{
		// Token: 0x06000E50 RID: 3664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E50")]
		[Address(RVA = "0x51F3EA0", Offset = "0x51F2AA0", VA = "0x1851F3EA0")]
		public SecP384R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x51F3F40", Offset = "0x51F2B40", VA = "0x1851F3F40")]
		public SecP384R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecP384R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E53")]
		[Address(RVA = "0x51F34D0", Offset = "0x51F20D0", VA = "0x1851F34D0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x51F2C90", Offset = "0x51F1890", VA = "0x1851F2C90", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x51F3740", Offset = "0x51F2340", VA = "0x1851F3740", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x51E7BF0", Offset = "0x51E67F0", VA = "0x1851E7BF0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x51E7B20", Offset = "0x51E6720", VA = "0x1851E7B20", Slot = "34")]
		public override ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x51F3610", Offset = "0x51F2210", VA = "0x1851F3610", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
