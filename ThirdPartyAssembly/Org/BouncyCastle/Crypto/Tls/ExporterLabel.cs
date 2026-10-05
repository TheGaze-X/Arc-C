using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200025C RID: 604
	[Token(Token = "0x200025C")]
	public abstract class ExporterLabel
	{
		// Token: 0x060014C7 RID: 5319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ExporterLabel()
		{
		}

		// Token: 0x04000B15 RID: 2837
		[Token(Token = "0x4000B15")]
		public const string client_finished = "client finished";

		// Token: 0x04000B16 RID: 2838
		[Token(Token = "0x4000B16")]
		public const string server_finished = "server finished";

		// Token: 0x04000B17 RID: 2839
		[Token(Token = "0x4000B17")]
		public const string master_secret = "master secret";

		// Token: 0x04000B18 RID: 2840
		[Token(Token = "0x4000B18")]
		public const string key_expansion = "key expansion";

		// Token: 0x04000B19 RID: 2841
		[Token(Token = "0x4000B19")]
		public const string client_EAP_encryption = "client EAP encryption";

		// Token: 0x04000B1A RID: 2842
		[Token(Token = "0x4000B1A")]
		public const string ttls_keying_material = "ttls keying material";

		// Token: 0x04000B1B RID: 2843
		[Token(Token = "0x4000B1B")]
		public const string ttls_challenge = "ttls challenge";

		// Token: 0x04000B1C RID: 2844
		[Token(Token = "0x4000B1C")]
		public const string dtls_srtp = "EXTRACTOR-dtls_srtp";

		// Token: 0x04000B1D RID: 2845
		[Token(Token = "0x4000B1D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string extended_master_secret;
	}
}
