using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001D5 RID: 469
	[Token(Token = "0x20001D5")]
	internal class SecT131R1Curve : AbstractF2mCurve
	{
		// Token: 0x06000F2B RID: 3883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x52012B0", Offset = "0x51FFEB0", VA = "0x1852012B0")]
		public SecT131R1Curve()
		{
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x5201050", Offset = "0x51FFC50", VA = "0x185201050", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00008B38 File Offset: 0x00006D38
		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B0")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000F2E")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x00008B50 File Offset: 0x00006D50
		[Token(Token = "0x170001B1")]
		public override int FieldSize
		{
			[Token(Token = "0x6000F2F")]
			[Address(RVA = "0x51FF920", Offset = "0x51FE520", VA = "0x1851FF920", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F30")]
		[Address(RVA = "0x5201250", Offset = "0x51FFE50", VA = "0x185201250", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F31")]
		[Address(RVA = "0x52010A0", Offset = "0x51FFCA0", VA = "0x1852010A0", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F32")]
		[Address(RVA = "0x52011A0", Offset = "0x51FFDA0", VA = "0x1852011A0", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00008B68 File Offset: 0x00006D68
		[Token(Token = "0x170001B2")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x6000F33")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00008B80 File Offset: 0x00006D80
		[Token(Token = "0x170001B3")]
		public virtual int M
		{
			[Token(Token = "0x6000F34")]
			[Address(RVA = "0x51FF920", Offset = "0x51FE520", VA = "0x1851FF920", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00008B98 File Offset: 0x00006D98
		[Token(Token = "0x170001B4")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x6000F35")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x00008BB0 File Offset: 0x00006DB0
		[Token(Token = "0x170001B5")]
		public virtual int K1
		{
			[Token(Token = "0x6000F36")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00008BC8 File Offset: 0x00006DC8
		[Token(Token = "0x170001B6")]
		public virtual int K2
		{
			[Token(Token = "0x6000F37")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x00008BE0 File Offset: 0x00006DE0
		[Token(Token = "0x170001B7")]
		public virtual int K3
		{
			[Token(Token = "0x6000F38")]
			[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x40008FA")]
		private const int SecT131R1_DEFAULT_COORDS = 6;

		// Token: 0x040008FB RID: 2299
		[Token(Token = "0x40008FB")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT131R1Point m_infinity;
	}
}
