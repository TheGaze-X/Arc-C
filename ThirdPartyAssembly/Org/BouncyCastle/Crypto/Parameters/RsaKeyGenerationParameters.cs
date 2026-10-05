using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002ED RID: 749
	[Token(Token = "0x20002ED")]
	public class RsaKeyGenerationParameters : KeyGenerationParameters
	{
		// Token: 0x0600192C RID: 6444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600192C")]
		[Address(RVA = "0x5295C70", Offset = "0x5294870", VA = "0x185295C70")]
		public RsaKeyGenerationParameters(BigInteger publicExponent, SecureRandom random, int strength, int certainty)
		{
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000388")]
		public BigInteger PublicExponent
		{
			[Token(Token = "0x600192D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		[Token(Token = "0x17000389")]
		public int Certainty
		{
			[Token(Token = "0x600192E")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		[Token(Token = "0x600192F")]
		[Address(RVA = "0x5295B10", Offset = "0x5294710", VA = "0x185295B10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x0000C408 File Offset: 0x0000A608
		[Token(Token = "0x6001930")]
		[Address(RVA = "0x5295C00", Offset = "0x5294800", VA = "0x185295C00", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D48 RID: 3400
		[Token(Token = "0x4000D48")]
		[FieldOffset(Offset = "0x20")]
		private readonly BigInteger publicExponent;

		// Token: 0x04000D49 RID: 3401
		[Token(Token = "0x4000D49")]
		[FieldOffset(Offset = "0x28")]
		private readonly int certainty;
	}
}
