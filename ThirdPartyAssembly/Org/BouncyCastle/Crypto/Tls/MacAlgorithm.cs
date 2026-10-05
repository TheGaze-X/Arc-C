using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000269 RID: 617
	[Token(Token = "0x2000269")]
	public abstract class MacAlgorithm
	{
		// Token: 0x060014E2 RID: 5346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected MacAlgorithm()
		{
		}

		// Token: 0x04000B79 RID: 2937
		[Token(Token = "0x4000B79")]
		public const int cls_null = 0;

		// Token: 0x04000B7A RID: 2938
		[Token(Token = "0x4000B7A")]
		public const int md5 = 1;

		// Token: 0x04000B7B RID: 2939
		[Token(Token = "0x4000B7B")]
		public const int sha = 2;

		// Token: 0x04000B7C RID: 2940
		[Token(Token = "0x4000B7C")]
		public const int hmac_md5 = 1;

		// Token: 0x04000B7D RID: 2941
		[Token(Token = "0x4000B7D")]
		public const int hmac_sha1 = 2;

		// Token: 0x04000B7E RID: 2942
		[Token(Token = "0x4000B7E")]
		public const int hmac_sha256 = 3;

		// Token: 0x04000B7F RID: 2943
		[Token(Token = "0x4000B7F")]
		public const int hmac_sha384 = 4;

		// Token: 0x04000B80 RID: 2944
		[Token(Token = "0x4000B80")]
		public const int hmac_sha512 = 5;
	}
}
