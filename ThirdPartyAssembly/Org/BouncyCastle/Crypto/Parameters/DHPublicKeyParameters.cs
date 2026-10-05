using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002C8 RID: 712
	[Token(Token = "0x20002C8")]
	public class DHPublicKeyParameters : DHKeyParameters
	{
		// Token: 0x0600186D RID: 6253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186D")]
		[Address(RVA = "0x5283EE0", Offset = "0x5282AE0", VA = "0x185283EE0")]
		public DHPublicKeyParameters(BigInteger y, DHParameters parameters)
		{
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186E")]
		[Address(RVA = "0x5283F70", Offset = "0x5282B70", VA = "0x185283F70")]
		public DHPublicKeyParameters(BigInteger y, DHParameters parameters, DerObjectIdentifier algorithmOid)
		{
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034E")]
		public BigInteger Y
		{
			[Token(Token = "0x600186F")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		[Token(Token = "0x6001870")]
		[Address(RVA = "0x5283DA0", Offset = "0x52829A0", VA = "0x185283DA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0000BE08 File Offset: 0x0000A008
		[Token(Token = "0x6001871")]
		[Address(RVA = "0x5283A70", Offset = "0x5282670", VA = "0x185283A70")]
		protected bool Equals(DHPublicKeyParameters other)
		{
			return default(bool);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0000BE20 File Offset: 0x0000A020
		[Token(Token = "0x6001872")]
		[Address(RVA = "0x5283C50", Offset = "0x5282850", VA = "0x185283C50", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D01 RID: 3329
		[Token(Token = "0x4000D01")]
		[FieldOffset(Offset = "0x28")]
		private readonly BigInteger y;
	}
}
