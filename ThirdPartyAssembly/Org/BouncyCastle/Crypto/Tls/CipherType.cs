using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200024B RID: 587
	[Token(Token = "0x200024B")]
	public abstract class CipherType
	{
		// Token: 0x06001469 RID: 5225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001469")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected CipherType()
		{
		}

		// Token: 0x04000AD3 RID: 2771
		[Token(Token = "0x4000AD3")]
		public const int stream = 0;

		// Token: 0x04000AD4 RID: 2772
		[Token(Token = "0x4000AD4")]
		public const int block = 1;

		// Token: 0x04000AD5 RID: 2773
		[Token(Token = "0x4000AD5")]
		public const int aead = 2;
	}
}
