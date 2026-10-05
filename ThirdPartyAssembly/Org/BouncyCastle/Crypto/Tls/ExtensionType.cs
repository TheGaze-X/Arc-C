using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200025D RID: 605
	[Token(Token = "0x200025D")]
	public abstract class ExtensionType
	{
		// Token: 0x060014C9 RID: 5321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ExtensionType()
		{
		}

		// Token: 0x04000B1E RID: 2846
		[Token(Token = "0x4000B1E")]
		public const int server_name = 0;

		// Token: 0x04000B1F RID: 2847
		[Token(Token = "0x4000B1F")]
		public const int max_fragment_length = 1;

		// Token: 0x04000B20 RID: 2848
		[Token(Token = "0x4000B20")]
		public const int client_certificate_url = 2;

		// Token: 0x04000B21 RID: 2849
		[Token(Token = "0x4000B21")]
		public const int trusted_ca_keys = 3;

		// Token: 0x04000B22 RID: 2850
		[Token(Token = "0x4000B22")]
		public const int truncated_hmac = 4;

		// Token: 0x04000B23 RID: 2851
		[Token(Token = "0x4000B23")]
		public const int status_request = 5;

		// Token: 0x04000B24 RID: 2852
		[Token(Token = "0x4000B24")]
		public const int user_mapping = 6;

		// Token: 0x04000B25 RID: 2853
		[Token(Token = "0x4000B25")]
		public const int client_authz = 7;

		// Token: 0x04000B26 RID: 2854
		[Token(Token = "0x4000B26")]
		public const int server_authz = 8;

		// Token: 0x04000B27 RID: 2855
		[Token(Token = "0x4000B27")]
		public const int cert_type = 9;

		// Token: 0x04000B28 RID: 2856
		[Token(Token = "0x4000B28")]
		public const int supported_groups = 10;

		// Token: 0x04000B29 RID: 2857
		[Token(Token = "0x4000B29")]
		public const int elliptic_curves = 10;

		// Token: 0x04000B2A RID: 2858
		[Token(Token = "0x4000B2A")]
		public const int ec_point_formats = 11;

		// Token: 0x04000B2B RID: 2859
		[Token(Token = "0x4000B2B")]
		public const int srp = 12;

		// Token: 0x04000B2C RID: 2860
		[Token(Token = "0x4000B2C")]
		public const int signature_algorithms = 13;

		// Token: 0x04000B2D RID: 2861
		[Token(Token = "0x4000B2D")]
		public const int use_srtp = 14;

		// Token: 0x04000B2E RID: 2862
		[Token(Token = "0x4000B2E")]
		public const int heartbeat = 15;

		// Token: 0x04000B2F RID: 2863
		[Token(Token = "0x4000B2F")]
		public const int application_layer_protocol_negotiation = 16;

		// Token: 0x04000B30 RID: 2864
		[Token(Token = "0x4000B30")]
		public const int status_request_v2 = 17;

		// Token: 0x04000B31 RID: 2865
		[Token(Token = "0x4000B31")]
		public const int signed_certificate_timestamp = 18;

		// Token: 0x04000B32 RID: 2866
		[Token(Token = "0x4000B32")]
		public const int client_certificate_type = 19;

		// Token: 0x04000B33 RID: 2867
		[Token(Token = "0x4000B33")]
		public const int server_certificate_type = 20;

		// Token: 0x04000B34 RID: 2868
		[Token(Token = "0x4000B34")]
		public const int padding = 21;

		// Token: 0x04000B35 RID: 2869
		[Token(Token = "0x4000B35")]
		public const int encrypt_then_mac = 22;

		// Token: 0x04000B36 RID: 2870
		[Token(Token = "0x4000B36")]
		public const int extended_master_secret = 23;

		// Token: 0x04000B37 RID: 2871
		[Token(Token = "0x4000B37")]
		public const int session_ticket = 35;

		// Token: 0x04000B38 RID: 2872
		[Token(Token = "0x4000B38")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int negotiated_ff_dhe_groups;

		// Token: 0x04000B39 RID: 2873
		[Token(Token = "0x4000B39")]
		public const int renegotiation_info = 65281;
	}
}
