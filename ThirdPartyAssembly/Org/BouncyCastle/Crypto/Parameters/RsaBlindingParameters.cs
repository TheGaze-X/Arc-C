using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002EC RID: 748
	[Token(Token = "0x20002EC")]
	public class RsaBlindingParameters : ICipherParameters
	{
		// Token: 0x06001929 RID: 6441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001929")]
		[Address(RVA = "0x5294740", Offset = "0x5293340", VA = "0x185294740")]
		public RsaBlindingParameters(RsaKeyParameters publicKey, BigInteger blindingFactor)
		{
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000386")]
		public RsaKeyParameters PublicKey
		{
			[Token(Token = "0x600192A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000387")]
		public BigInteger BlindingFactor
		{
			[Token(Token = "0x600192B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D46 RID: 3398
		[Token(Token = "0x4000D46")]
		[FieldOffset(Offset = "0x10")]
		private readonly RsaKeyParameters publicKey;

		// Token: 0x04000D47 RID: 3399
		[Token(Token = "0x4000D47")]
		[FieldOffset(Offset = "0x18")]
		private readonly BigInteger blindingFactor;
	}
}
