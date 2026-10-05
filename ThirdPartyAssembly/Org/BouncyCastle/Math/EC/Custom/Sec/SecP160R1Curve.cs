using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001A5 RID: 421
	[Token(Token = "0x20001A5")]
	internal class SecP160R1Curve : AbstractFpCurve
	{
		// Token: 0x06000C3A RID: 3130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x54BC9B0", Offset = "0x54BB5B0", VA = "0x1854BC9B0")]
		public SecP160R1Curve()
		{
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x54BC680", Offset = "0x54BB280", VA = "0x1854BC680", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00007D58 File Offset: 0x00005F58
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x1C58490", Offset = "0x1C57090", VA = "0x181C58490", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000144")]
		public virtual BigInteger Q
		{
			[Token(Token = "0x6000C3D")]
			[Address(RVA = "0x54BCCA0", Offset = "0x54BB8A0", VA = "0x1854BCCA0", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000145")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00007D70 File Offset: 0x00005F70
		[Token(Token = "0x17000146")]
		public override int FieldSize
		{
			[Token(Token = "0x6000C3F")]
			[Address(RVA = "0x54BCC40", Offset = "0x54BB840", VA = "0x1854BCC40", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x54BC880", Offset = "0x54BB480", VA = "0x1854BC880", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C41")]
		[Address(RVA = "0x54BC6D0", Offset = "0x54BB2D0", VA = "0x1854BC6D0", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x54BC7D0", Offset = "0x54BB3D0", VA = "0x1854BC7D0", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x04000889 RID: 2185
		[Token(Token = "0x4000889")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger q;

		// Token: 0x0400088A RID: 2186
		[Token(Token = "0x400088A")]
		private const int SecP160R1_DEFAULT_COORDS = 2;

		// Token: 0x0400088B RID: 2187
		[Token(Token = "0x400088B")]
		[FieldOffset(Offset = "0x50")]
		protected readonly SecP160R1Point m_infinity;
	}
}
