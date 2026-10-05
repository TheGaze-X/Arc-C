using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	internal class SecP192K1Curve : AbstractFpCurve
	{
		// Token: 0x06000CB0 RID: 3248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x54C4000", Offset = "0x54C2C00", VA = "0x1854C4000")]
		public SecP192K1Curve()
		{
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x54C3CD0", Offset = "0x54C28D0", VA = "0x1854C3CD0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00007F38 File Offset: 0x00006138
		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x1C58490", Offset = "0x1C57090", VA = "0x181C58490", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000152")]
		public virtual BigInteger Q
		{
			[Token(Token = "0x6000CB3")]
			[Address(RVA = "0x54C4280", Offset = "0x54C2E80", VA = "0x1854C4280", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000153")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000CB4")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00007F50 File Offset: 0x00006150
		[Token(Token = "0x17000154")]
		public override int FieldSize
		{
			[Token(Token = "0x6000CB5")]
			[Address(RVA = "0x54C4220", Offset = "0x54C2E20", VA = "0x1854C4220", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x54C3ED0", Offset = "0x54C2AD0", VA = "0x1854C3ED0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x54C3D20", Offset = "0x54C2920", VA = "0x1854C3D20", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x54C3E20", Offset = "0x54C2A20", VA = "0x1854C3E20", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x0400089F RID: 2207
		[Token(Token = "0x400089F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger q;

		// Token: 0x040008A0 RID: 2208
		[Token(Token = "0x40008A0")]
		private const int SECP192K1_DEFAULT_COORDS = 2;

		// Token: 0x040008A1 RID: 2209
		[Token(Token = "0x40008A1")]
		[FieldOffset(Offset = "0x50")]
		protected readonly SecP192K1Point m_infinity;
	}
}
