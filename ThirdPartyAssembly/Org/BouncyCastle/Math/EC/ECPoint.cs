using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000186 RID: 390
	[Token(Token = "0x2000186")]
	public abstract class ECPoint
	{
		// Token: 0x06000B00 RID: 2816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x549F970", Offset = "0x549E570", VA = "0x18549F970")]
		protected static ECFieldElement[] GetInitialZCoords(ECCurve curve)
		{
			return null;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x54A07B0", Offset = "0x549F3B0", VA = "0x1854A07B0")]
		protected ECPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x54A0880", Offset = "0x549F480", VA = "0x1854A0880")]
		internal ECPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x54A0140", Offset = "0x549ED40", VA = "0x1854A0140")]
		protected internal bool SatisfiesCofactor()
		{
			return default(bool);
		}

		// Token: 0x06000B04 RID: 2820
		[Token(Token = "0x6000B04")]
		protected abstract bool SatisfiesCurveEquation();

		// Token: 0x06000B05 RID: 2821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B05")]
		[Address(RVA = "0x549F720", Offset = "0x549E320", VA = "0x18549F720")]
		public ECPoint GetDetachedPoint()
		{
			return null;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000117")]
		public virtual ECCurve Curve
		{
			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B07 RID: 2823
		[Token(Token = "0x6000B07")]
		protected abstract ECPoint Detach();

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x17000118")]
		protected virtual int CurveCoordinateSystem
		{
			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x54A09D0", Offset = "0x549F5D0", VA = "0x1854A09D0", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000119")]
		[Obsolete("Use AffineXCoord, or Normalize() and XCoord, instead")]
		public virtual ECFieldElement X
		{
			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x54A0A40", Offset = "0x549F640", VA = "0x1854A0A40", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011A")]
		[Obsolete("Use AffineYCoord, or Normalize() and YCoord, instead")]
		public virtual ECFieldElement Y
		{
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x54A0AB0", Offset = "0x549F6B0", VA = "0x1854A0AB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011B")]
		public virtual ECFieldElement AffineXCoord
		{
			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x54A0910", Offset = "0x549F510", VA = "0x1854A0910", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011C")]
		public virtual ECFieldElement AffineYCoord
		{
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x54A0970", Offset = "0x549F570", VA = "0x1854A0970", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011D")]
		public virtual ECFieldElement XCoord
		{
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011E")]
		public virtual ECFieldElement YCoord
		{
			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x549FD30", Offset = "0x549E930", VA = "0x18549FD30", Slot = "14")]
		public virtual ECFieldElement GetZCoord(int index)
		{
			return null;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x549FD70", Offset = "0x549E970", VA = "0x18549FD70", Slot = "15")]
		public virtual ECFieldElement[] GetZCoords()
		{
			return null;
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011F")]
		protected internal ECFieldElement RawXCoord
		{
			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000120")]
		protected internal ECFieldElement RawYCoord
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000121")]
		protected internal ECFieldElement[] RawZCoords
		{
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x549F190", Offset = "0x549DD90", VA = "0x18549F190", Slot = "16")]
		protected virtual void CheckNormalized()
		{
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x549FE00", Offset = "0x549EA00", VA = "0x18549FE00", Slot = "17")]
		public virtual bool IsNormalized()
		{
			return default(bool);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x549FF20", Offset = "0x549EB20", VA = "0x18549FF20", Slot = "18")]
		public virtual ECPoint Normalize()
		{
			return null;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x549FFE0", Offset = "0x549EBE0", VA = "0x18549FFE0", Slot = "19")]
		internal virtual ECPoint Normalize(ECFieldElement zInv)
		{
			return null;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x549F220", Offset = "0x549DE20", VA = "0x18549F220", Slot = "20")]
		protected virtual ECPoint CreateScaledPoint(ECFieldElement sx, ECFieldElement sy)
		{
			return null;
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x17000122")]
		public bool IsInfinity
		{
			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x54A0A20", Offset = "0x549F620", VA = "0x1854A0A20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00007818 File Offset: 0x00005A18
		[Token(Token = "0x17000123")]
		public bool IsCompressed
		{
			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00007830 File Offset: 0x00005A30
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x549FE90", Offset = "0x549EA90", VA = "0x18549FE90")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x54A0270", Offset = "0x549EE70", VA = "0x1854A0270", Slot = "21")]
		public virtual ECPoint ScaleX(ECFieldElement scale)
		{
			return null;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x54A0350", Offset = "0x549EF50", VA = "0x1854A0350", Slot = "22")]
		public virtual ECPoint ScaleY(ECFieldElement scale)
		{
			return null;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00007848 File Offset: 0x00005A48
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x549F660", Offset = "0x549E260", VA = "0x18549F660", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00007860 File Offset: 0x00005A60
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x549F350", Offset = "0x549DF50", VA = "0x18549F350", Slot = "23")]
		public virtual bool Equals(ECPoint other)
		{
			return default(bool);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00007878 File Offset: 0x00005A78
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x549F7E0", Offset = "0x549E3E0", VA = "0x18549F7E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x54A0550", Offset = "0x549F150", VA = "0x1854A0550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x549F790", Offset = "0x549E390", VA = "0x18549F790", Slot = "24")]
		public virtual byte[] GetEncoded()
		{
			return null;
		}

		// Token: 0x06000B23 RID: 2851
		[Token(Token = "0x6000B23")]
		public abstract byte[] GetEncoded(bool compressed);

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000B24 RID: 2852
		[Token(Token = "0x17000124")]
		protected internal abstract bool CompressionYTilde { [Token(Token = "0x6000B24")] get; }

		// Token: 0x06000B25 RID: 2853
		[Token(Token = "0x6000B25")]
		public abstract ECPoint Add(ECPoint b);

		// Token: 0x06000B26 RID: 2854
		[Token(Token = "0x6000B26")]
		public abstract ECPoint Subtract(ECPoint b);

		// Token: 0x06000B27 RID: 2855
		[Token(Token = "0x6000B27")]
		public abstract ECPoint Negate();

		// Token: 0x06000B28 RID: 2856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x54A0480", Offset = "0x549F080", VA = "0x1854A0480", Slot = "30")]
		public virtual ECPoint TimesPow2(int e)
		{
			return null;
		}

		// Token: 0x06000B29 RID: 2857
		[Token(Token = "0x6000B29")]
		public abstract ECPoint Twice();

		// Token: 0x06000B2A RID: 2858
		[Token(Token = "0x6000B2A")]
		public abstract ECPoint Multiply(BigInteger b);

		// Token: 0x06000B2B RID: 2859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x54A06C0", Offset = "0x549F2C0", VA = "0x1854A06C0", Slot = "33")]
		public virtual ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x54A0440", Offset = "0x549F040", VA = "0x1854A0440", Slot = "34")]
		public virtual ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[FieldOffset(Offset = "0x0")]
		protected static ECFieldElement[] EMPTY_ZS;

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[FieldOffset(Offset = "0x10")]
		protected internal readonly ECCurve m_curve;

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x18")]
		protected internal readonly ECFieldElement m_x;

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[FieldOffset(Offset = "0x20")]
		protected internal readonly ECFieldElement m_y;

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x4000857")]
		[FieldOffset(Offset = "0x28")]
		protected internal readonly ECFieldElement[] m_zs;

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x4000858")]
		[FieldOffset(Offset = "0x30")]
		protected internal readonly bool m_withCompression;

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x4000859")]
		[FieldOffset(Offset = "0x38")]
		protected internal IDictionary m_preCompTable;
	}
}
