using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200025A RID: 602
	[Token(Token = "0x200025A")]
	public abstract class ECPointFormat
	{
		// Token: 0x060014C5 RID: 5317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ECPointFormat()
		{
		}

		// Token: 0x04000AF9 RID: 2809
		[Token(Token = "0x4000AF9")]
		public const byte uncompressed = 0;

		// Token: 0x04000AFA RID: 2810
		[Token(Token = "0x4000AFA")]
		public const byte ansiX962_compressed_prime = 1;

		// Token: 0x04000AFB RID: 2811
		[Token(Token = "0x4000AFB")]
		public const byte ansiX962_compressed_char2 = 2;
	}
}
