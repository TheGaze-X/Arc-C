using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	public static class RandomFactory
	{
		// Token: 0x060006AC RID: 1708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x5525720", Offset = "0x5524320", VA = "0x185525720")]
		public static Random Create(RandomFactory.AlgorithmType algorithm = RandomFactory.AlgorithmType.DEFAULT)
		{
			return null;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x5525950", Offset = "0x5524550", VA = "0x185525950")]
		public static Random Create(int seed, RandomFactory.AlgorithmType algorithm = RandomFactory.AlgorithmType.DEFAULT)
		{
			return null;
		}

		// Token: 0x0200010E RID: 270
		[Token(Token = "0x200010E")]
		public enum AlgorithmType
		{
			// Token: 0x040005CB RID: 1483
			[Token(Token = "0x40005CB")]
			DEFAULT,
			// Token: 0x040005CC RID: 1484
			[Token(Token = "0x40005CC")]
			LCG,
			// Token: 0x040005CD RID: 1485
			[Token(Token = "0x40005CD")]
			MERSENNE_TWISTER,
			// Token: 0x040005CE RID: 1486
			[Token(Token = "0x40005CE")]
			MOTHER_OF_ALL,
			// Token: 0x040005CF RID: 1487
			[Token(Token = "0x40005CF")]
			RANROT_B,
			// Token: 0x040005D0 RID: 1488
			[Token(Token = "0x40005D0")]
			SFMT,
			// Token: 0x040005D1 RID: 1489
			[Token(Token = "0x40005D1")]
			WELL,
			// Token: 0x040005D2 RID: 1490
			[Token(Token = "0x40005D2")]
			XORSHIFT
		}
	}
}
