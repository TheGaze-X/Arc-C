using System;
using Il2CppDummyDll;

namespace Mono.Math.Prime.Generator
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	internal abstract class PrimeGeneratorBase
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600023F RID: 575 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x17000037")]
		public virtual ConfidenceFactor Confidence
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "4")]
			get
			{
				return ConfidenceFactor.ExtraLow;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000240 RID: 576 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000038")]
		public virtual PrimalityTest PrimalityTest
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x4AD0230", Offset = "0x4ACEE30", VA = "0x184AD0230", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000241 RID: 577 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x17000039")]
		public virtual int TrialDivisionBounds
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x4AA0CA0", Offset = "0x4A9F8A0", VA = "0x184AA0CA0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000242 RID: 578
		[Token(Token = "0x6000242")]
		public abstract BigInteger GenerateNewPrime(int bits);

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected PrimeGeneratorBase()
		{
		}
	}
}
