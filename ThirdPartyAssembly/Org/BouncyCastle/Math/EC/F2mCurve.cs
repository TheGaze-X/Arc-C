using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000182 RID: 386
	[Token(Token = "0x2000182")]
	public class F2mCurve : AbstractF2mCurve
	{
		// Token: 0x06000A8F RID: 2703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x54A13E0", Offset = "0x549FFE0", VA = "0x1854A13E0")]
		public F2mCurve(int m, int k, BigInteger a, BigInteger b)
		{
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x54A1390", Offset = "0x549FF90", VA = "0x1854A1390")]
		public F2mCurve(int m, int k, BigInteger a, BigInteger b, BigInteger order, BigInteger cofactor)
		{
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x54A1560", Offset = "0x54A0160", VA = "0x1854A1560")]
		public F2mCurve(int m, int k1, int k2, int k3, BigInteger a, BigInteger b)
		{
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x54A10C0", Offset = "0x549FCC0", VA = "0x1854A10C0")]
		public F2mCurve(int m, int k1, int k2, int k3, BigInteger a, BigInteger b, BigInteger order, BigInteger cofactor)
		{
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x54A1420", Offset = "0x54A0020", VA = "0x1854A1420")]
		protected F2mCurve(int m, int k1, int k2, int k3, ECFieldElement a, ECFieldElement b, BigInteger order, BigInteger cofactor)
		{
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x54A0B20", Offset = "0x549F720", VA = "0x1854A0B20", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000074D0 File Offset: 0x000056D0
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x54A10B0", Offset = "0x549FCB0", VA = "0x1854A10B0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x54A0CB0", Offset = "0x549F8B0", VA = "0x1854A0CB0", Slot = "15")]
		protected override ECMultiplier CreateDefaultMultiplier()
		{
			return null;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x000074E8 File Offset: 0x000056E8
		[Token(Token = "0x170000FD")]
		public override int FieldSize
		{
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x32FB1A0", Offset = "0x32F9DA0", VA = "0x1832FB1A0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x54A0FE0", Offset = "0x549FBE0", VA = "0x1854A0FE0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x54A0E00", Offset = "0x549FA00", VA = "0x1854A0E00", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x54A0F30", Offset = "0x549FB30", VA = "0x1854A0F30", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FE")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00007500 File Offset: 0x00005700
		[Token(Token = "0x170000FF")]
		public int M
		{
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x32FB1A0", Offset = "0x32F9DA0", VA = "0x1832FB1A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00007518 File Offset: 0x00005718
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x54A1090", Offset = "0x549FC90", VA = "0x1854A1090")]
		public bool IsTrinomial()
		{
			return default(bool);
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x00007530 File Offset: 0x00005730
		[Token(Token = "0x17000100")]
		public int K1
		{
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x32FB190", Offset = "0x32F9D90", VA = "0x1832FB190")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00007548 File Offset: 0x00005748
		[Token(Token = "0x17000101")]
		public int K2
		{
			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0x4D1DE30", Offset = "0x4D1CA30", VA = "0x184D1DE30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x00007560 File Offset: 0x00005760
		[Token(Token = "0x17000102")]
		public int K3
		{
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x12905C0", Offset = "0x128F1C0", VA = "0x1812905C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000103")]
		[Obsolete("Use 'Order' property instead")]
		public BigInteger N
		{
			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000104")]
		[Obsolete("Use 'Cofactor' property instead")]
		public BigInteger H
		{
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		private const int F2M_DEFAULT_COORDS = 6;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0x58")]
		private readonly int m;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		[FieldOffset(Offset = "0x5C")]
		private readonly int k1;

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[FieldOffset(Offset = "0x60")]
		private readonly int k2;

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[FieldOffset(Offset = "0x64")]
		private readonly int k3;

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[FieldOffset(Offset = "0x68")]
		protected readonly F2mPoint m_infinity;
	}
}
