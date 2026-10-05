using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001C5 RID: 453
	[Token(Token = "0x20001C5")]
	internal class SecP384R1Curve : AbstractFpCurve
	{
		// Token: 0x06000E1D RID: 3613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x51F00E0", Offset = "0x51EECE0", VA = "0x1851F00E0")]
		public SecP384R1Curve()
		{
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x51EFDB0", Offset = "0x51EE9B0", VA = "0x1851EFDB0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00008508 File Offset: 0x00006708
		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x1C58490", Offset = "0x1C57090", VA = "0x181C58490", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017C")]
		public virtual BigInteger Q
		{
			[Token(Token = "0x6000E20")]
			[Address(RVA = "0x51F03D0", Offset = "0x51EEFD0", VA = "0x1851F03D0", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017D")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000E21")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x00008520 File Offset: 0x00006720
		[Token(Token = "0x1700017E")]
		public override int FieldSize
		{
			[Token(Token = "0x6000E22")]
			[Address(RVA = "0x51F0370", Offset = "0x51EEF70", VA = "0x1851F0370", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E23")]
		[Address(RVA = "0x51EFFB0", Offset = "0x51EEBB0", VA = "0x1851EFFB0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E24")]
		[Address(RVA = "0x51EFEB0", Offset = "0x51EEAB0", VA = "0x1851EFEB0", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x51EFE00", Offset = "0x51EEA00", VA = "0x1851EFE00", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x040008DE RID: 2270
		[Token(Token = "0x40008DE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger q;

		// Token: 0x040008DF RID: 2271
		[Token(Token = "0x40008DF")]
		private const int SecP384R1_DEFAULT_COORDS = 2;

		// Token: 0x040008E0 RID: 2272
		[Token(Token = "0x40008E0")]
		[FieldOffset(Offset = "0x50")]
		protected readonly SecP384R1Point m_infinity;
	}
}
