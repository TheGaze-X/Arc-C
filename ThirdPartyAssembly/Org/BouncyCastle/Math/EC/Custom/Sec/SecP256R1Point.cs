using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001C4 RID: 452
	[Token(Token = "0x20001C4")]
	internal class SecP256R1Point : AbstractFpPoint
	{
		// Token: 0x06000E14 RID: 3604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E14")]
		[Address(RVA = "0x51EFD10", Offset = "0x51EE910", VA = "0x1851EFD10")]
		public SecP256R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E15")]
		[Address(RVA = "0x51EFC70", Offset = "0x51EE870", VA = "0x1851EFC70")]
		public SecP256R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E16")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecP256R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x51EF2B0", Offset = "0x51EDEB0", VA = "0x1851EF2B0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x51EEB30", Offset = "0x51ED730", VA = "0x1851EEB30", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x51EF520", Offset = "0x51EE120", VA = "0x1851EF520", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x51E7BF0", Offset = "0x51E67F0", VA = "0x1851E7BF0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x51E7B20", Offset = "0x51E6720", VA = "0x1851E7B20", Slot = "34")]
		public override ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x51EF3F0", Offset = "0x51EDFF0", VA = "0x1851EF3F0", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
