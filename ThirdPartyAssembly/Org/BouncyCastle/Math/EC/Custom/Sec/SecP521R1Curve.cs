using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	internal class SecP521R1Curve : AbstractFpCurve
	{
		// Token: 0x06000E59 RID: 3673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x51F4490", Offset = "0x51F3090", VA = "0x1851F4490")]
		public SecP521R1Curve()
		{
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x51F3FE0", Offset = "0x51F2BE0", VA = "0x1851F3FE0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x000085F8 File Offset: 0x000067F8
		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x1C58490", Offset = "0x1C57090", VA = "0x181C58490", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000183")]
		public virtual BigInteger Q
		{
			[Token(Token = "0x6000E5C")]
			[Address(RVA = "0x51F4780", Offset = "0x51F3380", VA = "0x1851F4780", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000184")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000E5D")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00008610 File Offset: 0x00006810
		[Token(Token = "0x17000185")]
		public override int FieldSize
		{
			[Token(Token = "0x6000E5E")]
			[Address(RVA = "0x51F4720", Offset = "0x51F3320", VA = "0x1851F4720", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x51F41E0", Offset = "0x51F2DE0", VA = "0x1851F41E0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x51F4030", Offset = "0x51F2C30", VA = "0x1851F4030", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x51F4130", Offset = "0x51F2D30", VA = "0x1851F4130", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger q;

		// Token: 0x040008E9 RID: 2281
		[Token(Token = "0x40008E9")]
		private const int SecP521R1_DEFAULT_COORDS = 2;

		// Token: 0x040008EA RID: 2282
		[Token(Token = "0x40008EA")]
		[FieldOffset(Offset = "0x50")]
		protected readonly SecP521R1Point m_infinity;
	}
}
