using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001FB RID: 507
	[Token(Token = "0x20001FB")]
	internal class SecT409R1Curve : AbstractF2mCurve
	{
		// Token: 0x060011A1 RID: 4513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x5231130", Offset = "0x522FD30", VA = "0x185231130")]
		public SecT409R1Curve()
		{
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A2")]
		[Address(RVA = "0x5230ED0", Offset = "0x522FAD0", VA = "0x185230ED0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x00009E10 File Offset: 0x00008010
		[Token(Token = "0x60011A3")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000268")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x60011A4")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00009E28 File Offset: 0x00008028
		[Token(Token = "0x17000269")]
		public override int FieldSize
		{
			[Token(Token = "0x60011A5")]
			[Address(RVA = "0x522D5D0", Offset = "0x522C1D0", VA = "0x18522D5D0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A6")]
		[Address(RVA = "0x52310D0", Offset = "0x522FCD0", VA = "0x1852310D0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A7")]
		[Address(RVA = "0x5230FD0", Offset = "0x522FBD0", VA = "0x185230FD0", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A8")]
		[Address(RVA = "0x5230F20", Offset = "0x522FB20", VA = "0x185230F20", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00009E40 File Offset: 0x00008040
		[Token(Token = "0x1700026A")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x60011A9")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x00009E58 File Offset: 0x00008058
		[Token(Token = "0x1700026B")]
		public virtual int M
		{
			[Token(Token = "0x60011AA")]
			[Address(RVA = "0x522D5D0", Offset = "0x522C1D0", VA = "0x18522D5D0", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x00009E70 File Offset: 0x00008070
		[Token(Token = "0x1700026C")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x60011AB")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00009E88 File Offset: 0x00008088
		[Token(Token = "0x1700026D")]
		public virtual int K1
		{
			[Token(Token = "0x60011AC")]
			[Address(RVA = "0x522D600", Offset = "0x522C200", VA = "0x18522D600", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x00009EA0 File Offset: 0x000080A0
		[Token(Token = "0x1700026E")]
		public virtual int K2
		{
			[Token(Token = "0x60011AD")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x00009EB8 File Offset: 0x000080B8
		[Token(Token = "0x1700026F")]
		public virtual int K3
		{
			[Token(Token = "0x60011AE")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000928 RID: 2344
		[Token(Token = "0x4000928")]
		private const int SecT409R1_DEFAULT_COORDS = 6;

		// Token: 0x04000929 RID: 2345
		[Token(Token = "0x4000929")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT409R1Point m_infinity;
	}
}
