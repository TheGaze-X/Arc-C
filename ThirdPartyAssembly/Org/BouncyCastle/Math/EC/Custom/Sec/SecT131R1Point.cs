using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001D6 RID: 470
	[Token(Token = "0x20001D6")]
	internal class SecT131R1Point : AbstractF2mPoint
	{
		// Token: 0x06000F39 RID: 3897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F39")]
		[Address(RVA = "0x5202BF0", Offset = "0x52017F0", VA = "0x185202BF0")]
		public SecT131R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x5202C90", Offset = "0x5201890", VA = "0x185202C90")]
		public SecT131R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT131R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0x5201D80", Offset = "0x5200980", VA = "0x185201D80", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B8")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x6000F3D")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x00008BF8 File Offset: 0x00006DF8
		[Token(Token = "0x170001B9")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x6000F3E")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0x5201520", Offset = "0x5200120", VA = "0x185201520", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F40")]
		[Address(RVA = "0x52026D0", Offset = "0x52012D0", VA = "0x1852026D0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F41")]
		[Address(RVA = "0x52020B0", Offset = "0x5200CB0", VA = "0x1852020B0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x5201EC0", Offset = "0x5200AC0", VA = "0x185201EC0", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}
