using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000251 RID: 593
	[Token(Token = "0x2000251")]
	public interface DatagramTransport
	{
		// Token: 0x0600147F RID: 5247
		[Token(Token = "0x600147F")]
		int GetReceiveLimit();

		// Token: 0x06001480 RID: 5248
		[Token(Token = "0x6001480")]
		int GetSendLimit();

		// Token: 0x06001481 RID: 5249
		[Token(Token = "0x6001481")]
		int Receive(byte[] buf, int off, int len, int waitMillis);

		// Token: 0x06001482 RID: 5250
		[Token(Token = "0x6001482")]
		void Send(byte[] buf, int off, int len);

		// Token: 0x06001483 RID: 5251
		[Token(Token = "0x6001483")]
		void Close();
	}
}
