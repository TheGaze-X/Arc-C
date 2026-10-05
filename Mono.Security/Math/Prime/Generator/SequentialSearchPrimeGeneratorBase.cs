using System;
using Il2CppDummyDll;

namespace Mono.Math.Prime.Generator
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
	{
		// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x4AA60E0", Offset = "0x4AA4CE0", VA = "0x184AA60E0", Slot = "8")]
		protected virtual BigInteger GenerateSearchBase(int bits, object context)
		{
			return null;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x4AA6090", Offset = "0x4AA4C90", VA = "0x184AA6090", Slot = "7")]
		public override BigInteger GenerateNewPrime(int bits)
		{
			return null;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x4AA5C90", Offset = "0x4AA4890", VA = "0x184AA5C90", Slot = "9")]
		public virtual BigInteger GenerateNewPrime(int bits, object context)
		{
			return null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
		protected virtual bool IsPrimeAcceptable(BigInteger bi, object context)
		{
			return default(bool);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SequentialSearchPrimeGeneratorBase()
		{
		}
	}
}
