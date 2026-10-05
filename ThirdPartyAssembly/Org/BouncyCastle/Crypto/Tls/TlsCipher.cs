using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000282 RID: 642
	[Token(Token = "0x2000282")]
	public interface TlsCipher
	{
		// Token: 0x0600157B RID: 5499
		[Token(Token = "0x600157B")]
		int GetPlaintextLimit(int ciphertextLimit);

		// Token: 0x0600157C RID: 5500
		[Token(Token = "0x600157C")]
		byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len);

		// Token: 0x0600157D RID: 5501
		[Token(Token = "0x600157D")]
		byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len);
	}
}
