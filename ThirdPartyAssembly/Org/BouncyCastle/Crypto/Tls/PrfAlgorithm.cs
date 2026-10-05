using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200026F RID: 623
	[Token(Token = "0x200026F")]
	public abstract class PrfAlgorithm
	{
		// Token: 0x060014F4 RID: 5364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected PrfAlgorithm()
		{
		}

		// Token: 0x04000BA8 RID: 2984
		[Token(Token = "0x4000BA8")]
		public const int tls_prf_legacy = 0;

		// Token: 0x04000BA9 RID: 2985
		[Token(Token = "0x4000BA9")]
		public const int tls_prf_sha256 = 1;

		// Token: 0x04000BAA RID: 2986
		[Token(Token = "0x4000BAA")]
		public const int tls_prf_sha384 = 2;
	}
}
