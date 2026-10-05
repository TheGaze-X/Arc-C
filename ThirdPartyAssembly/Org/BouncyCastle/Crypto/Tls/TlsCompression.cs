using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000288 RID: 648
	[Token(Token = "0x2000288")]
	public interface TlsCompression
	{
		// Token: 0x060015A4 RID: 5540
		[Token(Token = "0x60015A4")]
		Stream Compress(Stream output);

		// Token: 0x060015A5 RID: 5541
		[Token(Token = "0x60015A5")]
		Stream Decompress(Stream output);
	}
}
