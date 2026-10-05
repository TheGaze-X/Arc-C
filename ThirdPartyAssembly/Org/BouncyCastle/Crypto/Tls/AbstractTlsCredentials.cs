using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000236 RID: 566
	[Token(Token = "0x2000236")]
	public abstract class AbstractTlsCredentials : TlsCredentials
	{
		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060013CD RID: 5069
		[Token(Token = "0x170002C3")]
		public abstract Certificate Certificate { [Token(Token = "0x60013CD")] get; }

		// Token: 0x060013CE RID: 5070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013CE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AbstractTlsCredentials()
		{
		}
	}
}
