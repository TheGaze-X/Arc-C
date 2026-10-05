using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math.EC.Endo;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Field;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200017C RID: 380
	[Token(Token = "0x200017C")]
	public class ECAlgorithms
	{
		// Token: 0x06000A37 RID: 2615 RVA: 0x00007380 File Offset: 0x00005580
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x549B4D0", Offset = "0x549A0D0", VA = "0x18549B4D0")]
		public static bool IsF2mCurve(ECCurve c)
		{
			return default(bool);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00007398 File Offset: 0x00005598
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x549B620", Offset = "0x549A220", VA = "0x18549B620")]
		public static bool IsF2mField(IFiniteField field)
		{
			return default(bool);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x000073B0 File Offset: 0x000055B0
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x549B740", Offset = "0x549A340", VA = "0x18549B740")]
		public static bool IsFpCurve(ECCurve c)
		{
			return default(bool);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x000073C8 File Offset: 0x000055C8
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x549B7C0", Offset = "0x549A3C0", VA = "0x18549B7C0")]
		public static bool IsFpField(IFiniteField field)
		{
			return default(bool);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x549BEB0", Offset = "0x549AAB0", VA = "0x18549BEB0")]
		public static ECPoint SumOfMultiplies(ECPoint[] ps, BigInteger[] ks)
		{
			return null;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x549C290", Offset = "0x549AE90", VA = "0x18549C290")]
		public static ECPoint SumOfTwoMultiplies(ECPoint P, BigInteger a, ECPoint Q, BigInteger b)
		{
			return null;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x549BDA0", Offset = "0x549A9A0", VA = "0x18549BDA0")]
		public static ECPoint ShamirsTrick(ECPoint P, BigInteger k, ECPoint Q, BigInteger l)
		{
			return null;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x549B3C0", Offset = "0x5499FC0", VA = "0x18549B3C0")]
		public static ECPoint ImportPoint(ECCurve c, ECPoint p)
		{
			return null;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x549B810", Offset = "0x549A410", VA = "0x18549B810")]
		public static void MontgomeryTrick(ECFieldElement[] zs, int off, int len)
		{
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x549B830", Offset = "0x549A430", VA = "0x18549B830")]
		public static void MontgomeryTrick(ECFieldElement[] zs, int off, int len, ECFieldElement scale)
		{
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x549BC10", Offset = "0x549A810", VA = "0x18549BC10")]
		public static ECPoint ReferenceMultiply(ECPoint p, BigInteger k)
		{
			return null;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x549C750", Offset = "0x549B350", VA = "0x18549C750")]
		public static ECPoint ValidatePoint(ECPoint p)
		{
			return null;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x5499200", Offset = "0x5497E00", VA = "0x185499200")]
		internal static ECPoint ImplShamirsTrickJsf(ECPoint P, BigInteger k, ECPoint Q, BigInteger l)
		{
			return null;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x5499F80", Offset = "0x5498B80", VA = "0x185499F80")]
		internal static ECPoint ImplShamirsTrickWNaf(ECPoint P, BigInteger k, ECPoint Q, BigInteger l)
		{
			return null;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x5499930", Offset = "0x5498530", VA = "0x185499930")]
		internal static ECPoint ImplShamirsTrickWNaf(ECPoint P, BigInteger k, ECPointMap pointMapQ, BigInteger l)
		{
			return null;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x5499C70", Offset = "0x5498870", VA = "0x185499C70")]
		private static ECPoint ImplShamirsTrickWNaf(ECPoint[] preCompP, ECPoint[] preCompNegP, byte[] wnafP, ECPoint[] preCompQ, ECPoint[] preCompNegQ, byte[] wnafQ)
		{
			return null;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x549A940", Offset = "0x5499540", VA = "0x18549A940")]
		internal static ECPoint ImplSumOfMultiplies(ECPoint[] ps, BigInteger[] ks)
		{
			return null;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x549A2E0", Offset = "0x5498EE0", VA = "0x18549A2E0")]
		internal static ECPoint ImplSumOfMultipliesGlv(ECPoint[] ps, BigInteger[] ks, GlvEndomorphism glvEndomorphism)
		{
			return null;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x549AFA0", Offset = "0x5499BA0", VA = "0x18549AFA0")]
		internal static ECPoint ImplSumOfMultiplies(ECPoint[] ps, ECPointMap pointMap, BigInteger[] ks)
		{
			return null;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x549AC00", Offset = "0x5499800", VA = "0x18549AC00")]
		private static ECPoint ImplSumOfMultiplies(bool[] negs, WNafPreCompInfo[] infos, byte[][] wnafs)
		{
			return null;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ECAlgorithms()
		{
		}
	}
}
