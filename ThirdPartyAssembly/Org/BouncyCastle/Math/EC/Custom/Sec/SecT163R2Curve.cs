using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001DF RID: 479
	[Token(Token = "0x20001DF")]
	internal class SecT163R2Curve : AbstractF2mCurve
	{
		// Token: 0x06000FC0 RID: 4032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC0")]
		[Address(RVA = "0x520AE10", Offset = "0x5209A10", VA = "0x18520AE10")]
		public SecT163R2Curve()
		{
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC1")]
		[Address(RVA = "0x520ABB0", Offset = "0x52097B0", VA = "0x18520ABB0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00008FE8 File Offset: 0x000071E8
		[Token(Token = "0x6000FC2")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E1")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000FC3")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00009000 File Offset: 0x00007200
		[Token(Token = "0x170001E2")]
		public override int FieldSize
		{
			[Token(Token = "0x6000FC4")]
			[Address(RVA = "0x5205D30", Offset = "0x5204930", VA = "0x185205D30", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x520ADB0", Offset = "0x52099B0", VA = "0x18520ADB0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0x520AC00", Offset = "0x5209800", VA = "0x18520AC00", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x520AD00", Offset = "0x5209900", VA = "0x18520AD00", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x00009018 File Offset: 0x00007218
		[Token(Token = "0x170001E3")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x6000FC8")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x00009030 File Offset: 0x00007230
		[Token(Token = "0x170001E4")]
		public virtual int M
		{
			[Token(Token = "0x6000FC9")]
			[Address(RVA = "0x5205D30", Offset = "0x5204930", VA = "0x185205D30", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x170001E5")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x6000FCA")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x00009060 File Offset: 0x00007260
		[Token(Token = "0x170001E6")]
		public virtual int K1
		{
			[Token(Token = "0x6000FCB")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00009078 File Offset: 0x00007278
		[Token(Token = "0x170001E7")]
		public virtual int K2
		{
			[Token(Token = "0x6000FCC")]
			[Address(RVA = "0x54BA20", Offset = "0x54A620", VA = "0x18054BA20", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x00009090 File Offset: 0x00007290
		[Token(Token = "0x170001E8")]
		public virtual int K3
		{
			[Token(Token = "0x6000FCD")]
			[Address(RVA = "0x54AC30", Offset = "0x549830", VA = "0x18054AC30", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		private const int SecT163R2_DEFAULT_COORDS = 6;

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT163R2Point m_infinity;
	}
}
