using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001B9 RID: 441
	[Token(Token = "0x20001B9")]
	internal class SecP224R1Curve : AbstractFpCurve
	{
		// Token: 0x06000D63 RID: 3427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x54CF700", Offset = "0x54CE300", VA = "0x1854CF700")]
		public SecP224R1Curve()
		{
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x54CF430", Offset = "0x54CE030", VA = "0x1854CF430", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00008208 File Offset: 0x00006408
		[Token(Token = "0x6000D65")]
		[Address(RVA = "0x1C58490", Offset = "0x1C57090", VA = "0x181C58490", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000167")]
		public virtual BigInteger Q
		{
			[Token(Token = "0x6000D66")]
			[Address(RVA = "0x54CF9F0", Offset = "0x54CE5F0", VA = "0x1854CF9F0", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000168")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000D67")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00008220 File Offset: 0x00006420
		[Token(Token = "0x17000169")]
		public override int FieldSize
		{
			[Token(Token = "0x6000D68")]
			[Address(RVA = "0x54CF990", Offset = "0x54CE590", VA = "0x1854CF990", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D69")]
		[Address(RVA = "0x54CF5D0", Offset = "0x54CE1D0", VA = "0x1854CF5D0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x54CF480", Offset = "0x54CE080", VA = "0x1854CF480", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0x54CF520", Offset = "0x54CE120", VA = "0x1854CF520", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x40008C0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger q;

		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		private const int SecP224R1_DEFAULT_COORDS = 2;

		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		[FieldOffset(Offset = "0x50")]
		protected readonly SecP224R1Point m_infinity;
	}
}
