using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	internal class SecP256R1Curve : AbstractFpCurve
	{
		// Token: 0x06000DE0 RID: 3552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x51EC320", Offset = "0x51EAF20", VA = "0x1851EC320")]
		public SecP256R1Curve()
		{
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x51EBFF0", Offset = "0x51EABF0", VA = "0x1851EBFF0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00008418 File Offset: 0x00006618
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x1C58490", Offset = "0x1C57090", VA = "0x181C58490", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000175")]
		public virtual BigInteger Q
		{
			[Token(Token = "0x6000DE3")]
			[Address(RVA = "0x51EC610", Offset = "0x51EB210", VA = "0x1851EC610", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000176")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000DE4")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x00008430 File Offset: 0x00006630
		[Token(Token = "0x17000177")]
		public override int FieldSize
		{
			[Token(Token = "0x6000DE5")]
			[Address(RVA = "0x51EC5B0", Offset = "0x51EB1B0", VA = "0x1851EC5B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x51EC1F0", Offset = "0x51EADF0", VA = "0x1851EC1F0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x51EC040", Offset = "0x51EAC40", VA = "0x1851EC040", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x51EC140", Offset = "0x51EAD40", VA = "0x1851EC140", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x40008D5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger q;

		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x40008D6")]
		private const int SecP256R1_DEFAULT_COORDS = 2;

		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x40008D7")]
		[FieldOffset(Offset = "0x50")]
		protected readonly SecP256R1Point m_infinity;
	}
}
