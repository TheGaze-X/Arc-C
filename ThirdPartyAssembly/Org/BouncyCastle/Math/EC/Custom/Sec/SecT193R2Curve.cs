using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001E5 RID: 485
	[Token(Token = "0x20001E5")]
	internal class SecT193R2Curve : AbstractF2mCurve
	{
		// Token: 0x06001024 RID: 4132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001024")]
		[Address(RVA = "0x5211000", Offset = "0x520FC00", VA = "0x185211000")]
		public SecT193R2Curve()
		{
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001025")]
		[Address(RVA = "0x5210DA0", Offset = "0x520F9A0", VA = "0x185210DA0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x000092E8 File Offset: 0x000074E8
		[Token(Token = "0x6001026")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FE")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6001027")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x00009300 File Offset: 0x00007500
		[Token(Token = "0x170001FF")]
		public override int FieldSize
		{
			[Token(Token = "0x6001028")]
			[Address(RVA = "0x520D9D0", Offset = "0x520C5D0", VA = "0x18520D9D0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001029")]
		[Address(RVA = "0x5210FA0", Offset = "0x520FBA0", VA = "0x185210FA0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102A")]
		[Address(RVA = "0x5210EA0", Offset = "0x520FAA0", VA = "0x185210EA0", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600102B")]
		[Address(RVA = "0x5210DF0", Offset = "0x520F9F0", VA = "0x185210DF0", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x00009318 File Offset: 0x00007518
		[Token(Token = "0x17000200")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x600102C")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600102D RID: 4141 RVA: 0x00009330 File Offset: 0x00007530
		[Token(Token = "0x17000201")]
		public virtual int M
		{
			[Token(Token = "0x600102D")]
			[Address(RVA = "0x520D9D0", Offset = "0x520C5D0", VA = "0x18520D9D0", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x00009348 File Offset: 0x00007548
		[Token(Token = "0x17000202")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x600102E")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x00009360 File Offset: 0x00007560
		[Token(Token = "0x17000203")]
		public virtual int K1
		{
			[Token(Token = "0x600102F")]
			[Address(RVA = "0x4D502D0", Offset = "0x4D4EED0", VA = "0x184D502D0", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x00009378 File Offset: 0x00007578
		[Token(Token = "0x17000204")]
		public virtual int K2
		{
			[Token(Token = "0x6001030")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x00009390 File Offset: 0x00007590
		[Token(Token = "0x17000205")]
		public virtual int K3
		{
			[Token(Token = "0x6001031")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		private const int SecT193R2_DEFAULT_COORDS = 6;

		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400090E")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT193R2Point m_infinity;
	}
}
