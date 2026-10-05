using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001F9 RID: 505
	[Token(Token = "0x20001F9")]
	internal class SecT409K1Curve : AbstractF2mCurve
	{
		// Token: 0x06001188 RID: 4488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001188")]
		[Address(RVA = "0x522F5D0", Offset = "0x522E1D0", VA = "0x18522F5D0")]
		public SecT409K1Curve()
		{
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001189")]
		[Address(RVA = "0x522F320", Offset = "0x522DF20", VA = "0x18522F320", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00009D38 File Offset: 0x00007F38
		[Token(Token = "0x600118A")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118B")]
		[Address(RVA = "0x522F370", Offset = "0x522DF70", VA = "0x18522F370", Slot = "15")]
		protected override ECMultiplier CreateDefaultMultiplier()
		{
			return null;
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025E")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x600118C")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x00009D50 File Offset: 0x00007F50
		[Token(Token = "0x1700025F")]
		public override int FieldSize
		{
			[Token(Token = "0x600118D")]
			[Address(RVA = "0x522D5D0", Offset = "0x522C1D0", VA = "0x18522D5D0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118E")]
		[Address(RVA = "0x522F570", Offset = "0x522E170", VA = "0x18522F570", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600118F")]
		[Address(RVA = "0x522F3C0", Offset = "0x522DFC0", VA = "0x18522F3C0", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001190")]
		[Address(RVA = "0x522F4C0", Offset = "0x522E0C0", VA = "0x18522F4C0", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x00009D68 File Offset: 0x00007F68
		[Token(Token = "0x17000260")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x6001191")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x00009D80 File Offset: 0x00007F80
		[Token(Token = "0x17000261")]
		public virtual int M
		{
			[Token(Token = "0x6001192")]
			[Address(RVA = "0x522D5D0", Offset = "0x522C1D0", VA = "0x18522D5D0", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x00009D98 File Offset: 0x00007F98
		[Token(Token = "0x17000262")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x6001193")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00009DB0 File Offset: 0x00007FB0
		[Token(Token = "0x17000263")]
		public virtual int K1
		{
			[Token(Token = "0x6001194")]
			[Address(RVA = "0x522D600", Offset = "0x522C200", VA = "0x18522D600", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x00009DC8 File Offset: 0x00007FC8
		[Token(Token = "0x17000264")]
		public virtual int K2
		{
			[Token(Token = "0x6001195")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x00009DE0 File Offset: 0x00007FE0
		[Token(Token = "0x17000265")]
		public virtual int K3
		{
			[Token(Token = "0x6001196")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000926 RID: 2342
		[Token(Token = "0x4000926")]
		private const int SecT409K1_DEFAULT_COORDS = 6;

		// Token: 0x04000927 RID: 2343
		[Token(Token = "0x4000927")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT409K1Point m_infinity;
	}
}
