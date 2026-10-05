using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200029A RID: 666
	[Token(Token = "0x200029A")]
	public interface TlsKeyExchange
	{
		// Token: 0x0600165E RID: 5726
		[Token(Token = "0x600165E")]
		void Init(TlsContext context);

		// Token: 0x0600165F RID: 5727
		[Token(Token = "0x600165F")]
		void SkipServerCredentials();

		// Token: 0x06001660 RID: 5728
		[Token(Token = "0x6001660")]
		void ProcessServerCredentials(TlsCredentials serverCredentials);

		// Token: 0x06001661 RID: 5729
		[Token(Token = "0x6001661")]
		void ProcessServerCertificate(Certificate serverCertificate);

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06001662 RID: 5730
		[Token(Token = "0x1700031F")]
		bool RequiresServerKeyExchange { [Token(Token = "0x6001662")] get; }

		// Token: 0x06001663 RID: 5731
		[Token(Token = "0x6001663")]
		byte[] GenerateServerKeyExchange();

		// Token: 0x06001664 RID: 5732
		[Token(Token = "0x6001664")]
		void SkipServerKeyExchange();

		// Token: 0x06001665 RID: 5733
		[Token(Token = "0x6001665")]
		void ProcessServerKeyExchange(Stream input);

		// Token: 0x06001666 RID: 5734
		[Token(Token = "0x6001666")]
		void ValidateCertificateRequest(CertificateRequest certificateRequest);

		// Token: 0x06001667 RID: 5735
		[Token(Token = "0x6001667")]
		void SkipClientCredentials();

		// Token: 0x06001668 RID: 5736
		[Token(Token = "0x6001668")]
		void ProcessClientCredentials(TlsCredentials clientCredentials);

		// Token: 0x06001669 RID: 5737
		[Token(Token = "0x6001669")]
		void ProcessClientCertificate(Certificate clientCertificate);

		// Token: 0x0600166A RID: 5738
		[Token(Token = "0x600166A")]
		void GenerateClientKeyExchange(Stream output);

		// Token: 0x0600166B RID: 5739
		[Token(Token = "0x600166B")]
		void ProcessClientKeyExchange(Stream input);

		// Token: 0x0600166C RID: 5740
		[Token(Token = "0x600166C")]
		byte[] GeneratePremasterSecret();
	}
}
