using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	internal class SecT113R1Curve : AbstractF2mCurve
	{
		// Token: 0x06000EC5 RID: 3781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x51FABB0", Offset = "0x51F97B0", VA = "0x1851FABB0")]
		public SecT113R1Curve()
		{
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x51FA200", Offset = "0x51F8E00", VA = "0x1851FA200", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00008838 File Offset: 0x00006A38
		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000193")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000EC8")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x00008850 File Offset: 0x00006A50
		[Token(Token = "0x17000194")]
		public override int FieldSize
		{
			[Token(Token = "0x6000EC9")]
			[Address(RVA = "0x51F9150", Offset = "0x51F7D50", VA = "0x1851F9150", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECA")]
		[Address(RVA = "0x51FA7A0", Offset = "0x51F93A0", VA = "0x1851FA7A0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x51FA250", Offset = "0x51F8E50", VA = "0x1851FA250", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x51FA350", Offset = "0x51F8F50", VA = "0x1851FA350", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x00008868 File Offset: 0x00006A68
		[Token(Token = "0x17000195")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x6000ECD")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x51FA400", Offset = "0x51F9000", VA = "0x1851FA400", Slot = "33")]
		protected override ECPoint DecompressPoint(int yTilde, BigInteger X1)
		{
			return null;
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x51FA800", Offset = "0x51F9400", VA = "0x1851FA800")]
		private ECFieldElement SolveQuadraticEquation(ECFieldElement beta)
		{
			return null;
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x00008880 File Offset: 0x00006A80
		[Token(Token = "0x17000196")]
		public virtual int M
		{
			[Token(Token = "0x6000ED0")]
			[Address(RVA = "0x51F9150", Offset = "0x51F7D50", VA = "0x1851F9150", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x00008898 File Offset: 0x00006A98
		[Token(Token = "0x17000197")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x6000ED1")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x000088B0 File Offset: 0x00006AB0
		[Token(Token = "0x17000198")]
		public virtual int K1
		{
			[Token(Token = "0x6000ED2")]
			[Address(RVA = "0x54AFD0", Offset = "0x549BD0", VA = "0x18054AFD0", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x000088C8 File Offset: 0x00006AC8
		[Token(Token = "0x17000199")]
		public virtual int K2
		{
			[Token(Token = "0x6000ED3")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x000088E0 File Offset: 0x00006AE0
		[Token(Token = "0x1700019A")]
		public virtual int K3
		{
			[Token(Token = "0x6000ED4")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040008F2 RID: 2290
		[Token(Token = "0x40008F2")]
		private const int SecT113R1_DEFAULT_COORDS = 6;

		// Token: 0x040008F3 RID: 2291
		[Token(Token = "0x40008F3")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT113R1Point m_infinity;
	}
}
