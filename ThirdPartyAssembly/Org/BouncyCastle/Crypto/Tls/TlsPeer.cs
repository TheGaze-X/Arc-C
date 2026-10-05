using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200029E RID: 670
	[Token(Token = "0x200029E")]
	public interface TlsPeer
	{
		// Token: 0x0600167C RID: 5756
		[Token(Token = "0x600167C")]
		bool ShouldUseGmtUnixTime();

		// Token: 0x0600167D RID: 5757
		[Token(Token = "0x600167D")]
		void NotifySecureRenegotiation(bool secureRenegotiation);

		// Token: 0x0600167E RID: 5758
		[Token(Token = "0x600167E")]
		TlsCompression GetCompression();

		// Token: 0x0600167F RID: 5759
		[Token(Token = "0x600167F")]
		TlsCipher GetCipher();

		// Token: 0x06001680 RID: 5760
		[Token(Token = "0x6001680")]
		void NotifyAlertRaised(byte alertLevel, byte alertDescription, string message, Exception cause);

		// Token: 0x06001681 RID: 5761
		[Token(Token = "0x6001681")]
		void NotifyAlertReceived(byte alertLevel, byte alertDescription);

		// Token: 0x06001682 RID: 5762
		[Token(Token = "0x6001682")]
		void NotifyHandshakeComplete();
	}
}
