using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x20001E3")]
	internal class SecT193R1Curve : AbstractF2mCurve
	{
		// Token: 0x0600100C RID: 4108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600100C")]
		[Address(RVA = "0x520F330", Offset = "0x520DF30", VA = "0x18520F330")]
		public SecT193R1Curve()
		{
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x520F0D0", Offset = "0x520DCD0", VA = "0x18520F0D0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00009210 File Offset: 0x00007410
		[Token(Token = "0x600100E")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F4")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x600100F")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00009228 File Offset: 0x00007428
		[Token(Token = "0x170001F5")]
		public override int FieldSize
		{
			[Token(Token = "0x6001010")]
			[Address(RVA = "0x520D9D0", Offset = "0x520C5D0", VA = "0x18520D9D0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001011")]
		[Address(RVA = "0x520F2D0", Offset = "0x520DED0", VA = "0x18520F2D0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001012")]
		[Address(RVA = "0x520F1D0", Offset = "0x520DDD0", VA = "0x18520F1D0", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001013")]
		[Address(RVA = "0x520F120", Offset = "0x520DD20", VA = "0x18520F120", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x00009240 File Offset: 0x00007440
		[Token(Token = "0x170001F6")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x6001014")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x00009258 File Offset: 0x00007458
		[Token(Token = "0x170001F7")]
		public virtual int M
		{
			[Token(Token = "0x6001015")]
			[Address(RVA = "0x520D9D0", Offset = "0x520C5D0", VA = "0x18520D9D0", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x00009270 File Offset: 0x00007470
		[Token(Token = "0x170001F8")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x6001016")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06001017 RID: 4119 RVA: 0x00009288 File Offset: 0x00007488
		[Token(Token = "0x170001F9")]
		public virtual int K1
		{
			[Token(Token = "0x6001017")]
			[Address(RVA = "0x4D502D0", Offset = "0x4D4EED0", VA = "0x184D502D0", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x000092A0 File Offset: 0x000074A0
		[Token(Token = "0x170001FA")]
		public virtual int K2
		{
			[Token(Token = "0x6001018")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06001019 RID: 4121 RVA: 0x000092B8 File Offset: 0x000074B8
		[Token(Token = "0x170001FB")]
		public virtual int K3
		{
			[Token(Token = "0x6001019")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		private const int SecT193R1_DEFAULT_COORDS = 6;

		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT193R1Point m_infinity;
	}
}
