using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	public abstract class FiniteFields
	{
		// Token: 0x06000A1A RID: 2586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x54A59E0", Offset = "0x54A45E0", VA = "0x1854A59E0")]
		public static IPolynomialExtensionField GetBinaryExtensionField(int[] exponents)
		{
			return null;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x54A5C00", Offset = "0x54A4800", VA = "0x1854A5C00")]
		public static IFiniteField GetPrimeField(BigInteger characteristic)
		{
			return null;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected FiniteFields()
		{
		}

		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly IFiniteField GF_2;

		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly IFiniteField GF_3;
	}
}
