using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000180 RID: 384
	[Token(Token = "0x2000180")]
	public class FpCurve : AbstractFpCurve
	{
		// Token: 0x06000A79 RID: 2681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x54A6430", Offset = "0x54A5030", VA = "0x1854A6430")]
		public FpCurve(BigInteger q, BigInteger a, BigInteger b)
		{
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x54A66F0", Offset = "0x54A52F0", VA = "0x1854A66F0")]
		public FpCurve(BigInteger q, BigInteger a, BigInteger b, BigInteger order, BigInteger cofactor)
		{
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x54A66C0", Offset = "0x54A52C0", VA = "0x1854A66C0")]
		protected FpCurve(BigInteger q, BigInteger r, ECFieldElement a, ECFieldElement b)
		{
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x54A65A0", Offset = "0x54A51A0", VA = "0x1854A65A0")]
		protected FpCurve(BigInteger q, BigInteger r, ECFieldElement a, ECFieldElement b, BigInteger order, BigInteger cofactor)
		{
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x54A5EC0", Offset = "0x54A4AC0", VA = "0x1854A5EC0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00007470 File Offset: 0x00005670
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x54A6420", Offset = "0x54A5020", VA = "0x1854A6420", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F9")]
		public virtual BigInteger Q
		{
			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FA")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00007488 File Offset: 0x00005688
		[Token(Token = "0x170000FB")]
		public override int FieldSize
		{
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x54A6860", Offset = "0x54A5460", VA = "0x1854A6860", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x54A6130", Offset = "0x54A4D30", VA = "0x1854A6130", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x54A6030", Offset = "0x54A4C30", VA = "0x1854A6030", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x54A5F80", Offset = "0x54A4B80", VA = "0x1854A5F80", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x54A61C0", Offset = "0x54A4DC0", VA = "0x1854A61C0", Slot = "19")]
		public override ECPoint ImportPoint(ECPoint p)
		{
			return null;
		}

		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x400083E")]
		private const int FP_DEFAULT_COORDS = 4;

		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x400083F")]
		[FieldOffset(Offset = "0x50")]
		protected readonly BigInteger m_q;

		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x4000840")]
		[FieldOffset(Offset = "0x58")]
		protected readonly BigInteger m_r;

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0x60")]
		protected readonly FpPoint m_infinity;
	}
}
