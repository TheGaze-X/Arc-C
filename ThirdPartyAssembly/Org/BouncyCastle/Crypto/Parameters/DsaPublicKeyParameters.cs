using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002CE RID: 718
	[Token(Token = "0x20002CE")]
	public class DsaPublicKeyParameters : DsaKeyParameters
	{
		// Token: 0x0600188E RID: 6286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188E")]
		[Address(RVA = "0x5286520", Offset = "0x5285120", VA = "0x185286520")]
		public DsaPublicKeyParameters(BigInteger y, DsaParameters parameters)
		{
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000357")]
		public BigInteger Y
		{
			[Token(Token = "0x600188F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0000BF70 File Offset: 0x0000A170
		[Token(Token = "0x6001890")]
		[Address(RVA = "0x52863E0", Offset = "0x5284FE0", VA = "0x1852863E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0000BF88 File Offset: 0x0000A188
		[Token(Token = "0x6001891")]
		[Address(RVA = "0x52861F0", Offset = "0x5284DF0", VA = "0x1852861F0")]
		protected bool Equals(DsaPublicKeyParameters other)
		{
			return default(bool);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		[Token(Token = "0x6001892")]
		[Address(RVA = "0x5286290", Offset = "0x5284E90", VA = "0x185286290", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D0B RID: 3339
		[Token(Token = "0x4000D0B")]
		[FieldOffset(Offset = "0x20")]
		private readonly BigInteger y;
	}
}
