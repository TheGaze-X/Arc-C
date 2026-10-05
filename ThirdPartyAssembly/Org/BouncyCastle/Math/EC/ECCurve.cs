using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math.EC.Endo;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Field;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	public abstract class ECCurve
	{
		// Token: 0x06000A4C RID: 2636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x549D610", Offset = "0x549C210", VA = "0x18549D610")]
		public static int[] GetAllCoordinateSystems()
		{
			return null;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		protected ECCurve(IFiniteField field)
		{
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000A4E RID: 2638
		[Token(Token = "0x170000F1")]
		public abstract int FieldSize { [Token(Token = "0x6000A4E")] get; }

		// Token: 0x06000A4F RID: 2639
		[Token(Token = "0x6000A4F")]
		public abstract ECFieldElement FromBigInteger(BigInteger x);

		// Token: 0x06000A50 RID: 2640
		[Token(Token = "0x6000A50")]
		public abstract bool IsValidFieldElement(BigInteger x);

		// Token: 0x06000A51 RID: 2641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x549CAD0", Offset = "0x549B6D0", VA = "0x18549CAD0", Slot = "7")]
		public virtual ECCurve.Config Configure()
		{
			return null;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x549E290", Offset = "0x549CE90", VA = "0x18549E290", Slot = "8")]
		public virtual ECPoint ValidatePoint(BigInteger x, BigInteger y)
		{
			return null;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x549E360", Offset = "0x549CF60", VA = "0x18549E360", Slot = "9")]
		public virtual ECPoint ValidatePoint(BigInteger x, BigInteger y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x549CC60", Offset = "0x549B860", VA = "0x18549CC60", Slot = "10")]
		public virtual ECPoint CreatePoint(BigInteger x, BigInteger y)
		{
			return null;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x549CCC0", Offset = "0x549B8C0", VA = "0x18549CCC0", Slot = "11")]
		public virtual ECPoint CreatePoint(BigInteger x, BigInteger y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000A56 RID: 2646
		[Token(Token = "0x6000A56")]
		protected abstract ECCurve CloneCurve();

		// Token: 0x06000A57 RID: 2647
		[Token(Token = "0x6000A57")]
		protected internal abstract ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression);

		// Token: 0x06000A58 RID: 2648
		[Token(Token = "0x6000A58")]
		protected internal abstract ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression);

		// Token: 0x06000A59 RID: 2649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x549CB90", Offset = "0x549B790", VA = "0x18549CB90", Slot = "15")]
		protected virtual ECMultiplier CreateDefaultMultiplier()
		{
			return null;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x000073E0 File Offset: 0x000055E0
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x549E280", Offset = "0x549CE80", VA = "0x18549E280", Slot = "16")]
		public virtual bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x549D910", Offset = "0x549C510", VA = "0x18549D910", Slot = "17")]
		public virtual PreCompInfo GetPreCompInfo(ECPoint point, string name)
		{
			return null;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x549E0A0", Offset = "0x549CCA0", VA = "0x18549E0A0", Slot = "18")]
		public virtual void SetPreCompInfo(ECPoint point, string name, PreCompInfo preCompInfo)
		{
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x549DAE0", Offset = "0x549C6E0", VA = "0x18549DAE0", Slot = "19")]
		public virtual ECPoint ImportPoint(ECPoint p)
		{
			return null;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x549E030", Offset = "0x549CC30", VA = "0x18549E030", Slot = "20")]
		public virtual void NormalizeAll(ECPoint[] points)
		{
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x549DCA0", Offset = "0x549C8A0", VA = "0x18549DCA0", Slot = "21")]
		public virtual void NormalizeAll(ECPoint[] points, int off, int len, ECFieldElement iso)
		{
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000A60 RID: 2656
		[Token(Token = "0x170000F2")]
		public abstract ECPoint Infinity { [Token(Token = "0x6000A60")] get; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F3")]
		public virtual IFiniteField Field
		{
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F4")]
		public virtual ECFieldElement A
		{
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F5")]
		public virtual ECFieldElement B
		{
			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F6")]
		public virtual BigInteger Order
		{
			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F7")]
		public virtual BigInteger Cofactor
		{
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x000073F8 File Offset: 0x000055F8
		[Token(Token = "0x170000F8")]
		public virtual int CoordinateSystem
		{
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70", Slot = "28")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x549C7F0", Offset = "0x549B3F0", VA = "0x18549C7F0", Slot = "29")]
		protected virtual void CheckPoint(ECPoint point)
		{
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x549CA60", Offset = "0x549B660", VA = "0x18549CA60", Slot = "30")]
		protected virtual void CheckPoints(ECPoint[] points)
		{
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x549C8A0", Offset = "0x549B4A0", VA = "0x18549C8A0", Slot = "31")]
		protected virtual void CheckPoints(ECPoint[] points, int off, int len)
		{
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00007410 File Offset: 0x00005610
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x549D3A0", Offset = "0x549BFA0", VA = "0x18549D3A0", Slot = "32")]
		public virtual bool Equals(ECCurve other)
		{
			return default(bool);
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00007428 File Offset: 0x00005628
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x549D550", Offset = "0x549C150", VA = "0x18549D550", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00007440 File Offset: 0x00005640
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x549D670", Offset = "0x549C270", VA = "0x18549D670", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A6D RID: 2669
		[Token(Token = "0x6000A6D")]
		protected abstract ECPoint DecompressPoint(int yTilde, BigInteger X1);

		// Token: 0x06000A6E RID: 2670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "34")]
		public virtual ECEndomorphism GetEndomorphism()
		{
			return null;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x549D830", Offset = "0x549C430", VA = "0x18549D830", Slot = "35")]
		public virtual ECMultiplier GetMultiplier()
		{
			return null;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x549CDA0", Offset = "0x549B9A0", VA = "0x18549CDA0", Slot = "36")]
		public virtual ECPoint DecodePoint(byte[] encoded)
		{
			return null;
		}

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		public const int COORD_AFFINE = 0;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		public const int COORD_HOMOGENEOUS = 1;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		public const int COORD_JACOBIAN = 2;

		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		public const int COORD_JACOBIAN_CHUDNOVSKY = 3;

		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x400082E")]
		public const int COORD_JACOBIAN_MODIFIED = 4;

		// Token: 0x0400082F RID: 2095
		[Token(Token = "0x400082F")]
		public const int COORD_LAMBDA_AFFINE = 5;

		// Token: 0x04000830 RID: 2096
		[Token(Token = "0x4000830")]
		public const int COORD_LAMBDA_PROJECTIVE = 6;

		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x4000831")]
		public const int COORD_SKEWED = 7;

		// Token: 0x04000832 RID: 2098
		[Token(Token = "0x4000832")]
		[FieldOffset(Offset = "0x10")]
		protected readonly IFiniteField m_field;

		// Token: 0x04000833 RID: 2099
		[Token(Token = "0x4000833")]
		[FieldOffset(Offset = "0x18")]
		protected ECFieldElement m_a;

		// Token: 0x04000834 RID: 2100
		[Token(Token = "0x4000834")]
		[FieldOffset(Offset = "0x20")]
		protected ECFieldElement m_b;

		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x4000835")]
		[FieldOffset(Offset = "0x28")]
		protected BigInteger m_order;

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		[FieldOffset(Offset = "0x30")]
		protected BigInteger m_cofactor;

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x38")]
		protected int m_coord;

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x40")]
		protected ECEndomorphism m_endomorphism;

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x48")]
		protected ECMultiplier m_multiplier;

		// Token: 0x0200017E RID: 382
		[Token(Token = "0x200017E")]
		public class Config
		{
			// Token: 0x06000A71 RID: 2673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x5499190", Offset = "0x5497D90", VA = "0x185499190")]
			internal Config(ECCurve outer, int coord, ECEndomorphism endomorphism, ECMultiplier multiplier)
			{
			}

			// Token: 0x06000A72 RID: 2674 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x5499180", Offset = "0x5497D80", VA = "0x185499180")]
			public ECCurve.Config SetCoordinateSystem(int coord)
			{
				return null;
			}

			// Token: 0x06000A73 RID: 2675 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x46B3FE0", Offset = "0x46B2BE0", VA = "0x1846B3FE0")]
			public ECCurve.Config SetEndomorphism(ECEndomorphism endomorphism)
			{
				return null;
			}

			// Token: 0x06000A74 RID: 2676 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x3736E20", Offset = "0x3735A20", VA = "0x183736E20")]
			public ECCurve.Config SetMultiplier(ECMultiplier multiplier)
			{
				return null;
			}

			// Token: 0x06000A75 RID: 2677 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x5499000", Offset = "0x5497C00", VA = "0x185499000")]
			public ECCurve Create()
			{
				return null;
			}

			// Token: 0x0400083A RID: 2106
			[Token(Token = "0x400083A")]
			[FieldOffset(Offset = "0x10")]
			protected ECCurve outer;

			// Token: 0x0400083B RID: 2107
			[Token(Token = "0x400083B")]
			[FieldOffset(Offset = "0x18")]
			protected int coord;

			// Token: 0x0400083C RID: 2108
			[Token(Token = "0x400083C")]
			[FieldOffset(Offset = "0x20")]
			protected ECEndomorphism endomorphism;

			// Token: 0x0400083D RID: 2109
			[Token(Token = "0x400083D")]
			[FieldOffset(Offset = "0x28")]
			protected ECMultiplier multiplier;
		}
	}
}
