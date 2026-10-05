using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000320 RID: 800
	[Token(Token = "0x2000320")]
	internal class DHParametersHelper
	{
		// Token: 0x06001AE0 RID: 6880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x52A3A10", Offset = "0x52A2610", VA = "0x1852A3A10")]
		private static BigInteger[] ConstructBigPrimeProducts(int[] primeProducts)
		{
			return null;
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x52A3B30", Offset = "0x52A2730", VA = "0x1852A3B30")]
		internal static BigInteger[] GenerateSafePrimes(int size, int certainty, SecureRandom random)
		{
			return null;
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE2")]
		[Address(RVA = "0x52A40C0", Offset = "0x52A2CC0", VA = "0x1852A40C0")]
		internal static BigInteger SelectGenerator(BigInteger p, BigInteger q, SecureRandom random)
		{
			return null;
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DHParametersHelper()
		{
		}

		// Token: 0x04000E41 RID: 3649
		[Token(Token = "0x4000E41")]
		[FieldOffset(Offset = "0x0")]
		private static readonly BigInteger Six;

		// Token: 0x04000E42 RID: 3650
		[Token(Token = "0x4000E42")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[][] primeLists;

		// Token: 0x04000E43 RID: 3651
		[Token(Token = "0x4000E43")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] primeProducts;

		// Token: 0x04000E44 RID: 3652
		[Token(Token = "0x4000E44")]
		[FieldOffset(Offset = "0x18")]
		private static readonly BigInteger[] BigPrimeProducts;
	}
}
