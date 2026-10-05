using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000189 RID: 393
	[Token(Token = "0x2000189")]
	public class FpPoint : AbstractFpPoint
	{
		// Token: 0x06000B37 RID: 2871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x54ACCC0", Offset = "0x54AB8C0", VA = "0x1854ACCC0")]
		public FpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x54ACD60", Offset = "0x54AB960", VA = "0x1854ACD60")]
		public FpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x5498500", Offset = "0x5497100", VA = "0x185498500")]
		internal FpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x54AA150", Offset = "0x54A8D50", VA = "0x1854AA150", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x54AA560", Offset = "0x54A9160", VA = "0x1854AA560", Slot = "14")]
		public override ECFieldElement GetZCoord(int index)
		{
			return null;
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x54A9250", Offset = "0x54A7E50", VA = "0x1854A9250", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x54AC130", Offset = "0x54AAD30", VA = "0x1854AC130", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x54ABC20", Offset = "0x54AA820", VA = "0x1854ABC20", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x54AA850", Offset = "0x54A9450", VA = "0x1854AA850", Slot = "34")]
		public override ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x54AAD60", Offset = "0x54A9960", VA = "0x1854AAD60", Slot = "30")]
		public override ECPoint TimesPow2(int e)
		{
			return null;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x54ACC70", Offset = "0x54AB870", VA = "0x1854ACC70", Slot = "35")]
		protected virtual ECFieldElement Two(ECFieldElement x)
		{
			return null;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x54AACE0", Offset = "0x54A98E0", VA = "0x1854AACE0", Slot = "36")]
		protected virtual ECFieldElement Three(ECFieldElement x)
		{
			return null;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x54AA410", Offset = "0x54A9010", VA = "0x1854AA410", Slot = "37")]
		protected virtual ECFieldElement Four(ECFieldElement x)
		{
			return null;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x54AA390", Offset = "0x54A8F90", VA = "0x1854AA390", Slot = "38")]
		protected virtual ECFieldElement Eight(ECFieldElement x)
		{
			return null;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x54AA290", Offset = "0x54A8E90", VA = "0x1854AA290", Slot = "39")]
		protected virtual ECFieldElement DoubleProductFromSquares(ECFieldElement a, ECFieldElement b, ECFieldElement aSquared, ECFieldElement bSquared)
		{
			return null;
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x54AA610", Offset = "0x54A9210", VA = "0x1854AA610", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x54A9F40", Offset = "0x54A8B40", VA = "0x1854A9F40", Slot = "40")]
		protected virtual ECFieldElement CalculateJacobianModifiedW(ECFieldElement Z, ECFieldElement ZSquared)
		{
			return null;
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x54AA490", Offset = "0x54A9090", VA = "0x1854AA490", Slot = "41")]
		protected virtual ECFieldElement GetJacobianModifiedW()
		{
			return null;
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x54AB660", Offset = "0x54AA260", VA = "0x1854AB660", Slot = "42")]
		protected virtual FpPoint TwiceJacobianModified(bool calculateW)
		{
			return null;
		}
	}
}
