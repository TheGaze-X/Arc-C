using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200025B RID: 603
	[Token(Token = "0x200025B")]
	public abstract class EncryptionAlgorithm
	{
		// Token: 0x060014C6 RID: 5318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected EncryptionAlgorithm()
		{
		}

		// Token: 0x04000AFC RID: 2812
		[Token(Token = "0x4000AFC")]
		public const int NULL = 0;

		// Token: 0x04000AFD RID: 2813
		[Token(Token = "0x4000AFD")]
		public const int RC4_40 = 1;

		// Token: 0x04000AFE RID: 2814
		[Token(Token = "0x4000AFE")]
		public const int RC4_128 = 2;

		// Token: 0x04000AFF RID: 2815
		[Token(Token = "0x4000AFF")]
		public const int RC2_CBC_40 = 3;

		// Token: 0x04000B00 RID: 2816
		[Token(Token = "0x4000B00")]
		public const int IDEA_CBC = 4;

		// Token: 0x04000B01 RID: 2817
		[Token(Token = "0x4000B01")]
		public const int DES40_CBC = 5;

		// Token: 0x04000B02 RID: 2818
		[Token(Token = "0x4000B02")]
		public const int DES_CBC = 6;

		// Token: 0x04000B03 RID: 2819
		[Token(Token = "0x4000B03")]
		public const int cls_3DES_EDE_CBC = 7;

		// Token: 0x04000B04 RID: 2820
		[Token(Token = "0x4000B04")]
		public const int AES_128_CBC = 8;

		// Token: 0x04000B05 RID: 2821
		[Token(Token = "0x4000B05")]
		public const int AES_256_CBC = 9;

		// Token: 0x04000B06 RID: 2822
		[Token(Token = "0x4000B06")]
		public const int AES_128_GCM = 10;

		// Token: 0x04000B07 RID: 2823
		[Token(Token = "0x4000B07")]
		public const int AES_256_GCM = 11;

		// Token: 0x04000B08 RID: 2824
		[Token(Token = "0x4000B08")]
		public const int CAMELLIA_128_CBC = 12;

		// Token: 0x04000B09 RID: 2825
		[Token(Token = "0x4000B09")]
		public const int CAMELLIA_256_CBC = 13;

		// Token: 0x04000B0A RID: 2826
		[Token(Token = "0x4000B0A")]
		public const int SEED_CBC = 14;

		// Token: 0x04000B0B RID: 2827
		[Token(Token = "0x4000B0B")]
		public const int AES_128_CCM = 15;

		// Token: 0x04000B0C RID: 2828
		[Token(Token = "0x4000B0C")]
		public const int AES_128_CCM_8 = 16;

		// Token: 0x04000B0D RID: 2829
		[Token(Token = "0x4000B0D")]
		public const int AES_256_CCM = 17;

		// Token: 0x04000B0E RID: 2830
		[Token(Token = "0x4000B0E")]
		public const int AES_256_CCM_8 = 18;

		// Token: 0x04000B0F RID: 2831
		[Token(Token = "0x4000B0F")]
		public const int CAMELLIA_128_GCM = 19;

		// Token: 0x04000B10 RID: 2832
		[Token(Token = "0x4000B10")]
		public const int CAMELLIA_256_GCM = 20;

		// Token: 0x04000B11 RID: 2833
		[Token(Token = "0x4000B11")]
		public const int CHACHA20_POLY1305 = 102;

		// Token: 0x04000B12 RID: 2834
		[Token(Token = "0x4000B12")]
		[Obsolete]
		public const int AEAD_CHACHA20_POLY1305 = 102;

		// Token: 0x04000B13 RID: 2835
		[Token(Token = "0x4000B13")]
		public const int AES_128_OCB_TAGLEN96 = 103;

		// Token: 0x04000B14 RID: 2836
		[Token(Token = "0x4000B14")]
		public const int AES_256_OCB_TAGLEN96 = 104;
	}
}
