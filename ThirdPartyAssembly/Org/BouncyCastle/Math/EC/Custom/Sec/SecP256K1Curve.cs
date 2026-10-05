using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001BD RID: 445
	[Token(Token = "0x20001BD")]
	internal class SecP256K1Curve : AbstractFpCurve
	{
		// Token: 0x06000DA5 RID: 3493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0x51E8800", Offset = "0x51E7400", VA = "0x1851E8800")]
		public SecP256K1Curve()
		{
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x51E84D0", Offset = "0x51E70D0", VA = "0x1851E84D0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00008328 File Offset: 0x00006528
		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x1C58490", Offset = "0x1C57090", VA = "0x181C58490", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016E")]
		public virtual BigInteger Q
		{
			[Token(Token = "0x6000DA8")]
			[Address(RVA = "0x51E8A80", Offset = "0x51E7680", VA = "0x1851E8A80", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016F")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000DA9")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00008340 File Offset: 0x00006540
		[Token(Token = "0x17000170")]
		public override int FieldSize
		{
			[Token(Token = "0x6000DAA")]
			[Address(RVA = "0x51E8A20", Offset = "0x51E7620", VA = "0x1851E8A20", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0x51E86D0", Offset = "0x51E72D0", VA = "0x1851E86D0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x51E85D0", Offset = "0x51E71D0", VA = "0x1851E85D0", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x51E8520", Offset = "0x51E7120", VA = "0x1851E8520", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x040008CA RID: 2250
		[Token(Token = "0x40008CA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger q;

		// Token: 0x040008CB RID: 2251
		[Token(Token = "0x40008CB")]
		private const int SECP256K1_DEFAULT_COORDS = 2;

		// Token: 0x040008CC RID: 2252
		[Token(Token = "0x40008CC")]
		[FieldOffset(Offset = "0x50")]
		protected readonly SecP256K1Point m_infinity;
	}
}
