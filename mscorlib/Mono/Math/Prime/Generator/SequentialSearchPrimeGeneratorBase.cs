using System;
using Il2CppDummyDll;

namespace Mono.Math.Prime.Generator
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	internal class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
	{
		// Token: 0x06000244 RID: 580 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x4AD5B50", Offset = "0x4AD4750", VA = "0x184AD5B50", Slot = "8")]
		protected virtual BigInteger GenerateSearchBase(int bits, object context)
		{
			return null;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x4AA6090", Offset = "0x4AA4C90", VA = "0x184AA6090", Slot = "7")]
		public override BigInteger GenerateNewPrime(int bits)
		{
			return null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x4AD5750", Offset = "0x4AD4350", VA = "0x184AD5750", Slot = "9")]
		public virtual BigInteger GenerateNewPrime(int bits, object context)
		{
			return null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
		protected virtual bool IsPrimeAcceptable(BigInteger bi, object context)
		{
			return default(bool);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SequentialSearchPrimeGeneratorBase()
		{
		}
	}
}
