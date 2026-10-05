using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001DB RID: 475
	[Token(Token = "0x20001DB")]
	internal class SecT163K1Curve : AbstractF2mCurve
	{
		// Token: 0x06000F8F RID: 3983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F8F")]
		[Address(RVA = "0x52075F0", Offset = "0x52061F0", VA = "0x1852075F0")]
		public SecT163K1Curve()
		{
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F90")]
		[Address(RVA = "0x5207340", Offset = "0x5205F40", VA = "0x185207340", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00008E38 File Offset: 0x00007038
		[Token(Token = "0x6000F91")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F92")]
		[Address(RVA = "0x5207390", Offset = "0x5205F90", VA = "0x185207390", Slot = "15")]
		protected override ECMultiplier CreateDefaultMultiplier()
		{
			return null;
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CD")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000F93")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000F94 RID: 3988 RVA: 0x00008E50 File Offset: 0x00007050
		[Token(Token = "0x170001CE")]
		public override int FieldSize
		{
			[Token(Token = "0x6000F94")]
			[Address(RVA = "0x5205D30", Offset = "0x5204930", VA = "0x185205D30", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F95")]
		[Address(RVA = "0x5207590", Offset = "0x5206190", VA = "0x185207590", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x5207490", Offset = "0x5206090", VA = "0x185207490", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x52073E0", Offset = "0x5205FE0", VA = "0x1852073E0", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x170001CF")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x6000F98")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x170001D0")]
		public virtual int M
		{
			[Token(Token = "0x6000F99")]
			[Address(RVA = "0x5205D30", Offset = "0x5204930", VA = "0x185205D30", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x00008E98 File Offset: 0x00007098
		[Token(Token = "0x170001D1")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x6000F9A")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x00008EB0 File Offset: 0x000070B0
		[Token(Token = "0x170001D2")]
		public virtual int K1
		{
			[Token(Token = "0x6000F9B")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x00008EC8 File Offset: 0x000070C8
		[Token(Token = "0x170001D3")]
		public virtual int K2
		{
			[Token(Token = "0x6000F9C")]
			[Address(RVA = "0x54BA20", Offset = "0x54A620", VA = "0x18054BA20", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x00008EE0 File Offset: 0x000070E0
		[Token(Token = "0x170001D4")]
		public virtual int K3
		{
			[Token(Token = "0x6000F9D")]
			[Address(RVA = "0x54AC30", Offset = "0x549830", VA = "0x18054AC30", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		private const int SecT163K1_DEFAULT_COORDS = 6;

		// Token: 0x04000903 RID: 2307
		[Token(Token = "0x4000903")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT163K1Point m_infinity;
	}
}
