using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001A3 RID: 419
	[Token(Token = "0x20001A3")]
	internal class SecP160K1Curve : AbstractFpCurve
	{
		// Token: 0x06000C27 RID: 3111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x54BB250", Offset = "0x54B9E50", VA = "0x1854BB250")]
		public SecP160K1Curve()
		{
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x54BAF70", Offset = "0x54B9B70", VA = "0x1854BAF70", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00007D28 File Offset: 0x00005F28
		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x1C58490", Offset = "0x1C57090", VA = "0x181C58490", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000141")]
		public virtual BigInteger Q
		{
			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0x54BB4D0", Offset = "0x54BA0D0", VA = "0x1854BB4D0", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000142")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000C2B")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x00007D40 File Offset: 0x00005F40
		[Token(Token = "0x17000143")]
		public override int FieldSize
		{
			[Token(Token = "0x6000C2C")]
			[Address(RVA = "0x54BB470", Offset = "0x54BA070", VA = "0x1854BB470", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x54BB170", Offset = "0x54B9D70", VA = "0x1854BB170", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x54BAFC0", Offset = "0x54B9BC0", VA = "0x1854BAFC0", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x54BB0C0", Offset = "0x54B9CC0", VA = "0x1854BB0C0", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4000886")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger q;

		// Token: 0x04000887 RID: 2183
		[Token(Token = "0x4000887")]
		private const int SECP160K1_DEFAULT_COORDS = 2;

		// Token: 0x04000888 RID: 2184
		[Token(Token = "0x4000888")]
		[FieldOffset(Offset = "0x50")]
		protected readonly SecP160K1Point m_infinity;
	}
}
