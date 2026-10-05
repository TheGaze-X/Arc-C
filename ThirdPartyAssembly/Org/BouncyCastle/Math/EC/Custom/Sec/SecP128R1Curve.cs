using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200019F RID: 415
	[Token(Token = "0x200019F")]
	internal class SecP128R1Curve : AbstractFpCurve
	{
		// Token: 0x06000BEA RID: 3050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x54B7430", Offset = "0x54B6030", VA = "0x1854B7430")]
		public SecP128R1Curve()
		{
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x54B7100", Offset = "0x54B5D00", VA = "0x1854B7100", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00007C38 File Offset: 0x00005E38
		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x1C58490", Offset = "0x1C57090", VA = "0x181C58490", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013A")]
		public virtual BigInteger Q
		{
			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x54B7720", Offset = "0x54B6320", VA = "0x1854B7720", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013B")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00007C50 File Offset: 0x00005E50
		[Token(Token = "0x1700013C")]
		public override int FieldSize
		{
			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0x54B76C0", Offset = "0x54B62C0", VA = "0x1854B76C0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x54B7300", Offset = "0x54B5F00", VA = "0x1854B7300", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x54B7150", Offset = "0x54B5D50", VA = "0x1854B7150", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x54B7250", Offset = "0x54B5E50", VA = "0x1854B7250", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger q;

		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x400087D")]
		private const int SecP128R1_DEFAULT_COORDS = 2;

		// Token: 0x0400087E RID: 2174
		[Token(Token = "0x400087E")]
		[FieldOffset(Offset = "0x50")]
		protected readonly SecP128R1Point m_infinity;
	}
}
