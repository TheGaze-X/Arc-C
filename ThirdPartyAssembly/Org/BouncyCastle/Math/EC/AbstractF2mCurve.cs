using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math.Field;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	public abstract class AbstractF2mCurve : ECCurve
	{
		// Token: 0x06000A86 RID: 2694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x5496D40", Offset = "0x5495940", VA = "0x185496D40")]
		public static BigInteger Inverse(int m, int[] ks, BigInteger x)
		{
			return null;
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x5496390", Offset = "0x5494F90", VA = "0x185496390")]
		private static IFiniteField BuildField(int m, int k1, int k2, int k3)
		{
			return null;
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x54971F0", Offset = "0x5495DF0", VA = "0x1854971F0")]
		protected AbstractF2mCurve(int m, int k1, int k2, int k3)
		{
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x000074A0 File Offset: 0x000056A0
		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x5496DE0", Offset = "0x54959E0", VA = "0x185496DE0", Slot = "6")]
		public override bool IsValidFieldElement(BigInteger x)
		{
			return default(bool);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x5496620", Offset = "0x5495220", VA = "0x185496620", Slot = "11")]
		public override ECPoint CreatePoint(BigInteger x, BigInteger y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x54968A0", Offset = "0x54954A0", VA = "0x1854968A0", Slot = "33")]
		protected override ECPoint DecompressPoint(int yTilde, BigInteger X1)
		{
			return null;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x5496E50", Offset = "0x5495A50", VA = "0x185496E50")]
		private ECFieldElement SolveQuadradicEquation(ECFieldElement beta)
		{
			return null;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x5496C40", Offset = "0x5495840", VA = "0x185496C40", Slot = "37")]
		internal virtual BigInteger[] GetSi()
		{
			return null;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x000074B8 File Offset: 0x000056B8
		[Token(Token = "0x170000FC")]
		public virtual bool IsKoblitz
		{
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x5497250", Offset = "0x5495E50", VA = "0x185497250", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		[FieldOffset(Offset = "0x50")]
		private BigInteger[] si;
	}
}
