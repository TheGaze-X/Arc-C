using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002D7 RID: 727
	[Token(Token = "0x20002D7")]
	public class ElGamalParameters : ICipherParameters
	{
		// Token: 0x060018CE RID: 6350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018CE")]
		[Address(RVA = "0x528AF20", Offset = "0x5289B20", VA = "0x18528AF20")]
		public ElGamalParameters(BigInteger p, BigInteger g)
		{
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018CF")]
		[Address(RVA = "0x528B030", Offset = "0x5289C30", VA = "0x18528B030")]
		public ElGamalParameters(BigInteger p, BigInteger g, int l)
		{
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000367")]
		public BigInteger P
		{
			[Token(Token = "0x60018D0")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000368")]
		public BigInteger G
		{
			[Token(Token = "0x60018D1")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		[Token(Token = "0x17000369")]
		public int L
		{
			[Token(Token = "0x60018D2")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		[Token(Token = "0x60018D3")]
		[Address(RVA = "0x528AC50", Offset = "0x5289850", VA = "0x18528AC50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		[Token(Token = "0x60018D4")]
		[Address(RVA = "0x528ADC0", Offset = "0x52899C0", VA = "0x18528ADC0")]
		protected bool Equals(ElGamalParameters other)
		{
			return default(bool);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		[Token(Token = "0x60018D5")]
		[Address(RVA = "0x528AE90", Offset = "0x5289A90", VA = "0x18528AE90", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D1E RID: 3358
		[Token(Token = "0x4000D1E")]
		[FieldOffset(Offset = "0x10")]
		private readonly BigInteger p;

		// Token: 0x04000D1F RID: 3359
		[Token(Token = "0x4000D1F")]
		[FieldOffset(Offset = "0x18")]
		private readonly BigInteger g;

		// Token: 0x04000D20 RID: 3360
		[Token(Token = "0x4000D20")]
		[FieldOffset(Offset = "0x20")]
		private readonly int l;
	}
}
