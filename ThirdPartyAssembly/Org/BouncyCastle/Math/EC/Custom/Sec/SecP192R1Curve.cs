using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001B1 RID: 433
	[Token(Token = "0x20001B1")]
	internal class SecP192R1Curve : AbstractFpCurve
	{
		// Token: 0x06000CEB RID: 3307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x54C7B00", Offset = "0x54C6700", VA = "0x1854C7B00")]
		public SecP192R1Curve()
		{
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x54C77D0", Offset = "0x54C63D0", VA = "0x1854C77D0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00008028 File Offset: 0x00006228
		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x1C58490", Offset = "0x1C57090", VA = "0x181C58490", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000159")]
		public virtual BigInteger Q
		{
			[Token(Token = "0x6000CEE")]
			[Address(RVA = "0x54C7DF0", Offset = "0x54C69F0", VA = "0x1854C7DF0", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015A")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000CEF")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00008040 File Offset: 0x00006240
		[Token(Token = "0x1700015B")]
		public override int FieldSize
		{
			[Token(Token = "0x6000CF0")]
			[Address(RVA = "0x54C7D90", Offset = "0x54C6990", VA = "0x1854C7D90", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF1")]
		[Address(RVA = "0x54C79D0", Offset = "0x54C65D0", VA = "0x1854C79D0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0x54C78D0", Offset = "0x54C64D0", VA = "0x1854C78D0", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x54C7820", Offset = "0x54C6420", VA = "0x1854C7820", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x040008AA RID: 2218
		[Token(Token = "0x40008AA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger q;

		// Token: 0x040008AB RID: 2219
		[Token(Token = "0x40008AB")]
		private const int SecP192R1_DEFAULT_COORDS = 2;

		// Token: 0x040008AC RID: 2220
		[Token(Token = "0x40008AC")]
		[FieldOffset(Offset = "0x50")]
		protected readonly SecP192R1Point m_infinity;
	}
}
