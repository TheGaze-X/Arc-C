using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001E9 RID: 489
	[Token(Token = "0x20001E9")]
	internal class SecT233K1Curve : AbstractF2mCurve
	{
		// Token: 0x06001070 RID: 4208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001070")]
		[Address(RVA = "0x5215700", Offset = "0x5214300", VA = "0x185215700")]
		public SecT233K1Curve()
		{
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001071")]
		[Address(RVA = "0x5215450", Offset = "0x5214050", VA = "0x185215450", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00009510 File Offset: 0x00007710
		[Token(Token = "0x6001072")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001073")]
		[Address(RVA = "0x52154A0", Offset = "0x52140A0", VA = "0x1852154A0", Slot = "15")]
		protected override ECMultiplier CreateDefaultMultiplier()
		{
			return null;
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x00009528 File Offset: 0x00007728
		[Token(Token = "0x17000211")]
		public override int FieldSize
		{
			[Token(Token = "0x6001074")]
			[Address(RVA = "0x5213B60", Offset = "0x5212760", VA = "0x185213B60", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001075")]
		[Address(RVA = "0x52156A0", Offset = "0x52142A0", VA = "0x1852156A0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001076")]
		[Address(RVA = "0x52154F0", Offset = "0x52140F0", VA = "0x1852154F0", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001077")]
		[Address(RVA = "0x52155F0", Offset = "0x52141F0", VA = "0x1852155F0", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06001078 RID: 4216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000212")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6001078")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x00009540 File Offset: 0x00007740
		[Token(Token = "0x17000213")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x6001079")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600107A RID: 4218 RVA: 0x00009558 File Offset: 0x00007758
		[Token(Token = "0x17000214")]
		public virtual int M
		{
			[Token(Token = "0x600107A")]
			[Address(RVA = "0x5213B60", Offset = "0x5212760", VA = "0x185213B60", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x00009570 File Offset: 0x00007770
		[Token(Token = "0x17000215")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x600107B")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00009588 File Offset: 0x00007788
		[Token(Token = "0x17000216")]
		public virtual int K1
		{
			[Token(Token = "0x600107C")]
			[Address(RVA = "0x5213B70", Offset = "0x5212770", VA = "0x185213B70", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x17000217")]
		public virtual int K2
		{
			[Token(Token = "0x600107D")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x000095B8 File Offset: 0x000077B8
		[Token(Token = "0x17000218")]
		public virtual int K3
		{
			[Token(Token = "0x600107E")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		private const int SecT233K1_DEFAULT_COORDS = 6;

		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT233K1Point m_infinity;
	}
}
