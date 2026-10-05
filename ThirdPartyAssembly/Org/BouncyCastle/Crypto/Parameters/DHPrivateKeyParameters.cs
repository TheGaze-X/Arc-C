using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002C7 RID: 711
	[Token(Token = "0x20002C7")]
	public class DHPrivateKeyParameters : DHKeyParameters
	{
		// Token: 0x06001867 RID: 6247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001867")]
		[Address(RVA = "0x5283D60", Offset = "0x5282960", VA = "0x185283D60")]
		public DHPrivateKeyParameters(BigInteger x, DHParameters parameters)
		{
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001868")]
		[Address(RVA = "0x5283CF0", Offset = "0x52828F0", VA = "0x185283CF0")]
		public DHPrivateKeyParameters(BigInteger x, DHParameters parameters, DerObjectIdentifier algorithmOid)
		{
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034D")]
		public BigInteger X
		{
			[Token(Token = "0x6001869")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		[Token(Token = "0x600186A")]
		[Address(RVA = "0x5283B10", Offset = "0x5282710", VA = "0x185283B10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		[Token(Token = "0x600186B")]
		[Address(RVA = "0x5283A70", Offset = "0x5282670", VA = "0x185283A70")]
		protected bool Equals(DHPrivateKeyParameters other)
		{
			return default(bool);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		[Token(Token = "0x600186C")]
		[Address(RVA = "0x5283C50", Offset = "0x5282850", VA = "0x185283C50", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D00 RID: 3328
		[Token(Token = "0x4000D00")]
		[FieldOffset(Offset = "0x28")]
		private readonly BigInteger x;
	}
}
