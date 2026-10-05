using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001B5 RID: 437
	[Token(Token = "0x20001B5")]
	internal class SecP224K1Curve : AbstractFpCurve
	{
		// Token: 0x06000D28 RID: 3368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x54CBBD0", Offset = "0x54CA7D0", VA = "0x1854CBBD0")]
		public SecP224K1Curve()
		{
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D29")]
		[Address(RVA = "0x54CB8A0", Offset = "0x54CA4A0", VA = "0x1854CB8A0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00008118 File Offset: 0x00006318
		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0x1C58490", Offset = "0x1C57090", VA = "0x181C58490", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000160")]
		public virtual BigInteger Q
		{
			[Token(Token = "0x6000D2B")]
			[Address(RVA = "0x54CBE50", Offset = "0x54CAA50", VA = "0x1854CBE50", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000D2C RID: 3372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000161")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000D2C")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x00008130 File Offset: 0x00006330
		[Token(Token = "0x17000162")]
		public override int FieldSize
		{
			[Token(Token = "0x6000D2D")]
			[Address(RVA = "0x54CBDF0", Offset = "0x54CA9F0", VA = "0x1854CBDF0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0x54CBAA0", Offset = "0x54CA6A0", VA = "0x1854CBAA0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D2F")]
		[Address(RVA = "0x54CB9A0", Offset = "0x54CA5A0", VA = "0x1854CB9A0", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D30")]
		[Address(RVA = "0x54CB8F0", Offset = "0x54CA4F0", VA = "0x1854CB8F0", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger q;

		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		private const int SECP224K1_DEFAULT_COORDS = 2;

		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		[FieldOffset(Offset = "0x50")]
		protected readonly SecP224K1Point m_infinity;
	}
}
