using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002DD RID: 733
	[Token(Token = "0x20002DD")]
	public class Gost3410PublicKeyParameters : Gost3410KeyParameters
	{
		// Token: 0x060018F1 RID: 6385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x528E720", Offset = "0x528D320", VA = "0x18528E720")]
		public Gost3410PublicKeyParameters(BigInteger y, Gost3410Parameters parameters)
		{
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F2")]
		[Address(RVA = "0x528E810", Offset = "0x528D410", VA = "0x18528E810")]
		public Gost3410PublicKeyParameters(BigInteger y, DerObjectIdentifier publicKeyParamSet)
		{
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000373")]
		public BigInteger Y
		{
			[Token(Token = "0x60018F3")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D2A RID: 3370
		[Token(Token = "0x4000D2A")]
		[FieldOffset(Offset = "0x28")]
		private readonly BigInteger y;
	}
}
