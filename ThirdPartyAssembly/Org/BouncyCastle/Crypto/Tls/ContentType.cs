using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000250 RID: 592
	[Token(Token = "0x2000250")]
	public abstract class ContentType
	{
		// Token: 0x0600147E RID: 5246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600147E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ContentType()
		{
		}

		// Token: 0x04000AE7 RID: 2791
		[Token(Token = "0x4000AE7")]
		public const byte change_cipher_spec = 20;

		// Token: 0x04000AE8 RID: 2792
		[Token(Token = "0x4000AE8")]
		public const byte alert = 21;

		// Token: 0x04000AE9 RID: 2793
		[Token(Token = "0x4000AE9")]
		public const byte handshake = 22;

		// Token: 0x04000AEA RID: 2794
		[Token(Token = "0x4000AEA")]
		public const byte application_data = 23;

		// Token: 0x04000AEB RID: 2795
		[Token(Token = "0x4000AEB")]
		public const byte heartbeat = 24;
	}
}
