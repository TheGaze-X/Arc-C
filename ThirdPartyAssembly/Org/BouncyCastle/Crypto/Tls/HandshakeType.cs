using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200025F RID: 607
	[Token(Token = "0x200025F")]
	public abstract class HandshakeType
	{
		// Token: 0x060014CD RID: 5325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014CD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected HandshakeType()
		{
		}

		// Token: 0x04000B3F RID: 2879
		[Token(Token = "0x4000B3F")]
		public const byte hello_request = 0;

		// Token: 0x04000B40 RID: 2880
		[Token(Token = "0x4000B40")]
		public const byte client_hello = 1;

		// Token: 0x04000B41 RID: 2881
		[Token(Token = "0x4000B41")]
		public const byte server_hello = 2;

		// Token: 0x04000B42 RID: 2882
		[Token(Token = "0x4000B42")]
		public const byte certificate = 11;

		// Token: 0x04000B43 RID: 2883
		[Token(Token = "0x4000B43")]
		public const byte server_key_exchange = 12;

		// Token: 0x04000B44 RID: 2884
		[Token(Token = "0x4000B44")]
		public const byte certificate_request = 13;

		// Token: 0x04000B45 RID: 2885
		[Token(Token = "0x4000B45")]
		public const byte server_hello_done = 14;

		// Token: 0x04000B46 RID: 2886
		[Token(Token = "0x4000B46")]
		public const byte certificate_verify = 15;

		// Token: 0x04000B47 RID: 2887
		[Token(Token = "0x4000B47")]
		public const byte client_key_exchange = 16;

		// Token: 0x04000B48 RID: 2888
		[Token(Token = "0x4000B48")]
		public const byte finished = 20;

		// Token: 0x04000B49 RID: 2889
		[Token(Token = "0x4000B49")]
		public const byte certificate_url = 21;

		// Token: 0x04000B4A RID: 2890
		[Token(Token = "0x4000B4A")]
		public const byte certificate_status = 22;

		// Token: 0x04000B4B RID: 2891
		[Token(Token = "0x4000B4B")]
		public const byte hello_verify_request = 3;

		// Token: 0x04000B4C RID: 2892
		[Token(Token = "0x4000B4C")]
		public const byte supplemental_data = 23;

		// Token: 0x04000B4D RID: 2893
		[Token(Token = "0x4000B4D")]
		public const byte session_ticket = 4;
	}
}
