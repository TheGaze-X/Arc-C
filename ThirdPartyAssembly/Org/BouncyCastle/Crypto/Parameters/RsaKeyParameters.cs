using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002EE RID: 750
	[Token(Token = "0x20002EE")]
	public class RsaKeyParameters : AsymmetricKeyParameter
	{
		// Token: 0x06001931 RID: 6449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001931")]
		[Address(RVA = "0x5295EB0", Offset = "0x5294AB0", VA = "0x185295EB0")]
		public RsaKeyParameters(bool isPrivate, BigInteger modulus, BigInteger exponent)
		{
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038A")]
		public BigInteger Modulus
		{
			[Token(Token = "0x6001932")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001933 RID: 6451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700038B")]
		public BigInteger Exponent
		{
			[Token(Token = "0x6001933")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x0000C420 File Offset: 0x0000A620
		[Token(Token = "0x6001934")]
		[Address(RVA = "0x5295CC0", Offset = "0x52948C0", VA = "0x185295CC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x0000C438 File Offset: 0x0000A638
		[Token(Token = "0x6001935")]
		[Address(RVA = "0x5295DD0", Offset = "0x52949D0", VA = "0x185295DD0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D4A RID: 3402
		[Token(Token = "0x4000D4A")]
		[FieldOffset(Offset = "0x18")]
		private readonly BigInteger modulus;

		// Token: 0x04000D4B RID: 3403
		[Token(Token = "0x4000D4B")]
		[FieldOffset(Offset = "0x20")]
		private readonly BigInteger exponent;
	}
}
