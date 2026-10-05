using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001EB RID: 491
	[Token(Token = "0x20001EB")]
	internal class SecT233R1Curve : AbstractF2mCurve
	{
		// Token: 0x06001089 RID: 4233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001089")]
		[Address(RVA = "0x5217260", Offset = "0x5215E60", VA = "0x185217260")]
		public SecT233R1Curve()
		{
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600108A")]
		[Address(RVA = "0x5217000", Offset = "0x5215C00", VA = "0x185217000", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x600108B")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700021B")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x600108C")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x00009600 File Offset: 0x00007800
		[Token(Token = "0x1700021C")]
		public override int FieldSize
		{
			[Token(Token = "0x600108D")]
			[Address(RVA = "0x5213B60", Offset = "0x5212760", VA = "0x185213B60", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600108E")]
		[Address(RVA = "0x5217200", Offset = "0x5215E00", VA = "0x185217200", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600108F")]
		[Address(RVA = "0x5217100", Offset = "0x5215D00", VA = "0x185217100", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001090")]
		[Address(RVA = "0x5217050", Offset = "0x5215C50", VA = "0x185217050", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x00009618 File Offset: 0x00007818
		[Token(Token = "0x1700021D")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x6001091")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x00009630 File Offset: 0x00007830
		[Token(Token = "0x1700021E")]
		public virtual int M
		{
			[Token(Token = "0x6001092")]
			[Address(RVA = "0x5213B60", Offset = "0x5212760", VA = "0x185213B60", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x00009648 File Offset: 0x00007848
		[Token(Token = "0x1700021F")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x6001093")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x00009660 File Offset: 0x00007860
		[Token(Token = "0x17000220")]
		public virtual int K1
		{
			[Token(Token = "0x6001094")]
			[Address(RVA = "0x5213B70", Offset = "0x5212770", VA = "0x185213B70", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x00009678 File Offset: 0x00007878
		[Token(Token = "0x17000221")]
		public virtual int K2
		{
			[Token(Token = "0x6001095")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x00009690 File Offset: 0x00007890
		[Token(Token = "0x17000222")]
		public virtual int K3
		{
			[Token(Token = "0x6001096")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		private const int SecT233R1_DEFAULT_COORDS = 6;

		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT233R1Point m_infinity;
	}
}
