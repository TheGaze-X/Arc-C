using System;
using Il2CppDummyDll;

namespace Mono.Math.Prime.Generator
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	public abstract class PrimeGeneratorBase
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x17000091")]
		public virtual ConfidenceFactor Confidence
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "4")]
			get
			{
				return ConfidenceFactor.ExtraLow;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000092")]
		public virtual PrimalityTest PrimalityTest
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x4AA0B20", Offset = "0x4A9F720", VA = "0x184AA0B20", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x17000093")]
		public virtual int TrialDivisionBounds
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x4AA0CA0", Offset = "0x4A9F8A0", VA = "0x184AA0CA0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000250 RID: 592
		[Token(Token = "0x6000250")]
		public abstract BigInteger GenerateNewPrime(int bits);

		// Token: 0x06000251 RID: 593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected PrimeGeneratorBase()
		{
		}
	}
}
