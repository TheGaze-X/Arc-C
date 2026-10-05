using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000201 RID: 513
	[Token(Token = "0x2000201")]
	internal class SecT571R1Curve : AbstractF2mCurve
	{
		// Token: 0x06001207 RID: 4615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001207")]
		[Address(RVA = "0x5237F50", Offset = "0x5236B50", VA = "0x185237F50")]
		public SecT571R1Curve()
		{
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001208")]
		[Address(RVA = "0x5237A90", Offset = "0x5236690", VA = "0x185237A90", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0000A110 File Offset: 0x00008310
		[Token(Token = "0x6001209")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000285")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x600120A")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x0000A128 File Offset: 0x00008328
		[Token(Token = "0x17000286")]
		public override int FieldSize
		{
			[Token(Token = "0x600120B")]
			[Address(RVA = "0x5233FC0", Offset = "0x5232BC0", VA = "0x185233FC0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120C")]
		[Address(RVA = "0x5237C90", Offset = "0x5236890", VA = "0x185237C90", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120D")]
		[Address(RVA = "0x5237B90", Offset = "0x5236790", VA = "0x185237B90", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600120E")]
		[Address(RVA = "0x5237AE0", Offset = "0x52366E0", VA = "0x185237AE0", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x0000A140 File Offset: 0x00008340
		[Token(Token = "0x17000287")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x600120F")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x0000A158 File Offset: 0x00008358
		[Token(Token = "0x17000288")]
		public virtual int M
		{
			[Token(Token = "0x6001210")]
			[Address(RVA = "0x5233FC0", Offset = "0x5232BC0", VA = "0x185233FC0", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x0000A170 File Offset: 0x00008370
		[Token(Token = "0x17000289")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x6001211")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x0000A188 File Offset: 0x00008388
		[Token(Token = "0x1700028A")]
		public virtual int K1
		{
			[Token(Token = "0x6001212")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x0000A1A0 File Offset: 0x000083A0
		[Token(Token = "0x1700028B")]
		public virtual int K2
		{
			[Token(Token = "0x6001213")]
			[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x0000A1B8 File Offset: 0x000083B8
		[Token(Token = "0x1700028C")]
		public virtual int K3
		{
			[Token(Token = "0x6001214")]
			[Address(RVA = "0x2114980", Offset = "0x2113580", VA = "0x182114980", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000930 RID: 2352
		[Token(Token = "0x4000930")]
		private const int SecT571R1_DEFAULT_COORDS = 6;

		// Token: 0x04000931 RID: 2353
		[Token(Token = "0x4000931")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT571R1Point m_infinity;

		// Token: 0x04000932 RID: 2354
		[Token(Token = "0x4000932")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly SecT571FieldElement SecT571R1_B;

		// Token: 0x04000933 RID: 2355
		[Token(Token = "0x4000933")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly SecT571FieldElement SecT571R1_B_SQRT;
	}
}
