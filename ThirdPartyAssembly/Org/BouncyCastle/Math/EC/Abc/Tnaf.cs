using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Abc
{
	// Token: 0x02000208 RID: 520
	[Token(Token = "0x2000208")]
	internal class Tnaf
	{
		// Token: 0x0600127C RID: 4732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127C")]
		[Address(RVA = "0x523C3C0", Offset = "0x523AFC0", VA = "0x18523C3C0")]
		public static BigInteger Norm(sbyte mu, ZTauElement lambda)
		{
			return null;
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127D")]
		[Address(RVA = "0x523C500", Offset = "0x523B100", VA = "0x18523C500")]
		public static SimpleBigDecimal Norm(sbyte mu, SimpleBigDecimal u, SimpleBigDecimal v)
		{
			return null;
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127E")]
		[Address(RVA = "0x523C9A0", Offset = "0x523B5A0", VA = "0x18523C9A0")]
		public static ZTauElement Round(SimpleBigDecimal lambda0, SimpleBigDecimal lambda1, sbyte mu)
		{
			return null;
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127F")]
		[Address(RVA = "0x523AA30", Offset = "0x5239630", VA = "0x18523AA30")]
		public static SimpleBigDecimal ApproximateDivisionByN(BigInteger k, BigInteger s, BigInteger vm, sbyte a, int m, int c)
		{
			return null;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001280")]
		[Address(RVA = "0x523CF20", Offset = "0x523BB20", VA = "0x18523CF20")]
		public static sbyte[] TauAdicNaf(sbyte mu, ZTauElement lambda)
		{
			return null;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001281")]
		[Address(RVA = "0x523D7B0", Offset = "0x523C3B0", VA = "0x18523D7B0")]
		public static AbstractF2mPoint Tau(AbstractF2mPoint p)
		{
			return null;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[Token(Token = "0x6001282")]
		[Address(RVA = "0x523AE90", Offset = "0x5239A90", VA = "0x18523AE90")]
		public static sbyte GetMu(AbstractF2mCurve curve)
		{
			return 0;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[Token(Token = "0x6001283")]
		[Address(RVA = "0x523AE30", Offset = "0x5239A30", VA = "0x18523AE30")]
		public static sbyte GetMu(ECFieldElement curveA)
		{
			return 0;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0000A410 File Offset: 0x00008610
		[Token(Token = "0x6001284")]
		[Address(RVA = "0x523AE10", Offset = "0x5239A10", VA = "0x18523AE10")]
		public static sbyte GetMu(int curveA)
		{
			return 0;
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001285")]
		[Address(RVA = "0x523ABC0", Offset = "0x52397C0", VA = "0x18523ABC0")]
		public static BigInteger[] GetLucas(sbyte mu, int k, bool doV)
		{
			return null;
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001286")]
		[Address(RVA = "0x523BB40", Offset = "0x523A740", VA = "0x18523BB40")]
		public static BigInteger GetTw(sbyte mu, int w)
		{
			return null;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001287")]
		[Address(RVA = "0x523B2C0", Offset = "0x5239EC0", VA = "0x18523B2C0")]
		public static BigInteger[] GetSi(AbstractF2mCurve curve)
		{
			return null;
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001288")]
		[Address(RVA = "0x523B7A0", Offset = "0x523A3A0", VA = "0x18523B7A0")]
		public static BigInteger[] GetSi(int fieldSize, int curveA, BigInteger cofactor)
		{
			return null;
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0000A428 File Offset: 0x00008628
		[Token(Token = "0x6001289")]
		[Address(RVA = "0x523B220", Offset = "0x5239E20", VA = "0x18523B220")]
		protected static int GetShiftsForCofactor(BigInteger h)
		{
			return 0;
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128A")]
		[Address(RVA = "0x523C690", Offset = "0x523B290", VA = "0x18523C690")]
		public static ZTauElement PartModReduction(BigInteger k, int m, sbyte a, BigInteger[] s, sbyte mu, sbyte c)
		{
			return null;
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128B")]
		[Address(RVA = "0x523BF80", Offset = "0x523AB80", VA = "0x18523BF80")]
		public static AbstractF2mPoint MultiplyRTnaf(AbstractF2mPoint p, BigInteger k)
		{
			return null;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128C")]
		[Address(RVA = "0x523C1B0", Offset = "0x523ADB0", VA = "0x18523C1B0")]
		public static AbstractF2mPoint MultiplyTnaf(AbstractF2mPoint p, ZTauElement lambda)
		{
			return null;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128D")]
		[Address(RVA = "0x523BCE0", Offset = "0x523A8E0", VA = "0x18523BCE0")]
		public static AbstractF2mPoint MultiplyFromTnaf(AbstractF2mPoint p, sbyte[] u)
		{
			return null;
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128E")]
		[Address(RVA = "0x523D350", Offset = "0x523BF50", VA = "0x18523D350")]
		public static sbyte[] TauAdicWNaf(sbyte mu, ZTauElement lambda, sbyte width, BigInteger pow2w, BigInteger tw, ZTauElement[] alpha)
		{
			return null;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128F")]
		[Address(RVA = "0x523AFF0", Offset = "0x5239BF0", VA = "0x18523AFF0")]
		public static AbstractF2mPoint[] GetPreComp(AbstractF2mPoint p, sbyte a)
		{
			return null;
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001290")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Tnaf()
		{
		}

		// Token: 0x04000940 RID: 2368
		[Token(Token = "0x4000940")]
		[FieldOffset(Offset = "0x0")]
		private static readonly BigInteger MinusOne;

		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x4000941")]
		[FieldOffset(Offset = "0x8")]
		private static readonly BigInteger MinusTwo;

		// Token: 0x04000942 RID: 2370
		[Token(Token = "0x4000942")]
		[FieldOffset(Offset = "0x10")]
		private static readonly BigInteger MinusThree;

		// Token: 0x04000943 RID: 2371
		[Token(Token = "0x4000943")]
		[FieldOffset(Offset = "0x18")]
		private static readonly BigInteger Four;

		// Token: 0x04000944 RID: 2372
		[Token(Token = "0x4000944")]
		public const sbyte Width = 4;

		// Token: 0x04000945 RID: 2373
		[Token(Token = "0x4000945")]
		public const sbyte Pow2Width = 16;

		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x4000946")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ZTauElement[] Alpha0;

		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x4000947")]
		[FieldOffset(Offset = "0x28")]
		public static readonly sbyte[][] Alpha0Tnaf;

		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ZTauElement[] Alpha1;

		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		[FieldOffset(Offset = "0x38")]
		public static readonly sbyte[][] Alpha1Tnaf;
	}
}
