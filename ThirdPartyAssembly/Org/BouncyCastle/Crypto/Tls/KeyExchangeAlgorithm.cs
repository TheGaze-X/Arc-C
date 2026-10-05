using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000265 RID: 613
	[Token(Token = "0x2000265")]
	public abstract class KeyExchangeAlgorithm
	{
		// Token: 0x060014DB RID: 5339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014DB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected KeyExchangeAlgorithm()
		{
		}

		// Token: 0x04000B5A RID: 2906
		[Token(Token = "0x4000B5A")]
		public const int NULL = 0;

		// Token: 0x04000B5B RID: 2907
		[Token(Token = "0x4000B5B")]
		public const int RSA = 1;

		// Token: 0x04000B5C RID: 2908
		[Token(Token = "0x4000B5C")]
		public const int RSA_EXPORT = 2;

		// Token: 0x04000B5D RID: 2909
		[Token(Token = "0x4000B5D")]
		public const int DHE_DSS = 3;

		// Token: 0x04000B5E RID: 2910
		[Token(Token = "0x4000B5E")]
		public const int DHE_DSS_EXPORT = 4;

		// Token: 0x04000B5F RID: 2911
		[Token(Token = "0x4000B5F")]
		public const int DHE_RSA = 5;

		// Token: 0x04000B60 RID: 2912
		[Token(Token = "0x4000B60")]
		public const int DHE_RSA_EXPORT = 6;

		// Token: 0x04000B61 RID: 2913
		[Token(Token = "0x4000B61")]
		public const int DH_DSS = 7;

		// Token: 0x04000B62 RID: 2914
		[Token(Token = "0x4000B62")]
		public const int DH_DSS_EXPORT = 8;

		// Token: 0x04000B63 RID: 2915
		[Token(Token = "0x4000B63")]
		public const int DH_RSA = 9;

		// Token: 0x04000B64 RID: 2916
		[Token(Token = "0x4000B64")]
		public const int DH_RSA_EXPORT = 10;

		// Token: 0x04000B65 RID: 2917
		[Token(Token = "0x4000B65")]
		public const int DH_anon = 11;

		// Token: 0x04000B66 RID: 2918
		[Token(Token = "0x4000B66")]
		public const int DH_anon_EXPORT = 12;

		// Token: 0x04000B67 RID: 2919
		[Token(Token = "0x4000B67")]
		public const int PSK = 13;

		// Token: 0x04000B68 RID: 2920
		[Token(Token = "0x4000B68")]
		public const int DHE_PSK = 14;

		// Token: 0x04000B69 RID: 2921
		[Token(Token = "0x4000B69")]
		public const int RSA_PSK = 15;

		// Token: 0x04000B6A RID: 2922
		[Token(Token = "0x4000B6A")]
		public const int ECDH_ECDSA = 16;

		// Token: 0x04000B6B RID: 2923
		[Token(Token = "0x4000B6B")]
		public const int ECDHE_ECDSA = 17;

		// Token: 0x04000B6C RID: 2924
		[Token(Token = "0x4000B6C")]
		public const int ECDH_RSA = 18;

		// Token: 0x04000B6D RID: 2925
		[Token(Token = "0x4000B6D")]
		public const int ECDHE_RSA = 19;

		// Token: 0x04000B6E RID: 2926
		[Token(Token = "0x4000B6E")]
		public const int ECDH_anon = 20;

		// Token: 0x04000B6F RID: 2927
		[Token(Token = "0x4000B6F")]
		public const int SRP = 21;

		// Token: 0x04000B70 RID: 2928
		[Token(Token = "0x4000B70")]
		public const int SRP_DSS = 22;

		// Token: 0x04000B71 RID: 2929
		[Token(Token = "0x4000B71")]
		public const int SRP_RSA = 23;

		// Token: 0x04000B72 RID: 2930
		[Token(Token = "0x4000B72")]
		public const int ECDHE_PSK = 24;
	}
}
