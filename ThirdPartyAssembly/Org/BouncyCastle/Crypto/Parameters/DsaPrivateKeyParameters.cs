using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002CD RID: 717
	[Token(Token = "0x20002CD")]
	public class DsaPrivateKeyParameters : DsaKeyParameters
	{
		// Token: 0x06001889 RID: 6281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001889")]
		[Address(RVA = "0x5286330", Offset = "0x5284F30", VA = "0x185286330")]
		public DsaPrivateKeyParameters(BigInteger x, DsaParameters parameters)
		{
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000356")]
		public BigInteger X
		{
			[Token(Token = "0x600188A")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0000BF28 File Offset: 0x0000A128
		[Token(Token = "0x600188B")]
		[Address(RVA = "0x52860B0", Offset = "0x5284CB0", VA = "0x1852860B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0000BF40 File Offset: 0x0000A140
		[Token(Token = "0x600188C")]
		[Address(RVA = "0x52861F0", Offset = "0x5284DF0", VA = "0x1852861F0")]
		protected bool Equals(DsaPrivateKeyParameters other)
		{
			return default(bool);
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0000BF58 File Offset: 0x0000A158
		[Token(Token = "0x600188D")]
		[Address(RVA = "0x5286290", Offset = "0x5284E90", VA = "0x185286290", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D0A RID: 3338
		[Token(Token = "0x4000D0A")]
		[FieldOffset(Offset = "0x20")]
		private readonly BigInteger x;
	}
}
