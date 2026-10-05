using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002DC RID: 732
	[Token(Token = "0x20002DC")]
	public class Gost3410PrivateKeyParameters : Gost3410KeyParameters
	{
		// Token: 0x060018EE RID: 6382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018EE")]
		[Address(RVA = "0x528E620", Offset = "0x528D220", VA = "0x18528E620")]
		public Gost3410PrivateKeyParameters(BigInteger x, Gost3410Parameters parameters)
		{
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x528E500", Offset = "0x528D100", VA = "0x18528E500")]
		public Gost3410PrivateKeyParameters(BigInteger x, DerObjectIdentifier publicKeyParamSet)
		{
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000372")]
		public BigInteger X
		{
			[Token(Token = "0x60018F0")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D29 RID: 3369
		[Token(Token = "0x4000D29")]
		[FieldOffset(Offset = "0x28")]
		private readonly BigInteger x;
	}
}
