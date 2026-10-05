using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000278 RID: 632
	[Token(Token = "0x2000278")]
	public abstract class SignatureAlgorithm
	{
		// Token: 0x0600154F RID: 5455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600154F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected SignatureAlgorithm()
		{
		}

		// Token: 0x04000BEC RID: 3052
		[Token(Token = "0x4000BEC")]
		public const byte anonymous = 0;

		// Token: 0x04000BED RID: 3053
		[Token(Token = "0x4000BED")]
		public const byte rsa = 1;

		// Token: 0x04000BEE RID: 3054
		[Token(Token = "0x4000BEE")]
		public const byte dsa = 2;

		// Token: 0x04000BEF RID: 3055
		[Token(Token = "0x4000BEF")]
		public const byte ecdsa = 3;
	}
}
