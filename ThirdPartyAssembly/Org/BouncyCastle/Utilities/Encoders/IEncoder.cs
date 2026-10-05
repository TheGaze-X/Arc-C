using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x0200014B RID: 331
	[Token(Token = "0x200014B")]
	public interface IEncoder
	{
		// Token: 0x060007C1 RID: 1985
		[Token(Token = "0x60007C1")]
		int Encode(byte[] data, int off, int length, Stream outStream);

		// Token: 0x060007C2 RID: 1986
		[Token(Token = "0x60007C2")]
		int Decode(byte[] data, int off, int length, Stream outStream);

		// Token: 0x060007C3 RID: 1987
		[Token(Token = "0x60007C3")]
		int DecodeString(string data, Stream outStream);
	}
}
