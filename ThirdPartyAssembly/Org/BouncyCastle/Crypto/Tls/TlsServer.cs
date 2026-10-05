using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002A4 RID: 676
	[Token(Token = "0x20002A4")]
	public interface TlsServer : TlsPeer
	{
		// Token: 0x060016D9 RID: 5849
		[Token(Token = "0x60016D9")]
		void Init(TlsServerContext context);

		// Token: 0x060016DA RID: 5850
		[Token(Token = "0x60016DA")]
		void NotifyClientVersion(ProtocolVersion clientVersion);

		// Token: 0x060016DB RID: 5851
		[Token(Token = "0x60016DB")]
		void NotifyFallback(bool isFallback);

		// Token: 0x060016DC RID: 5852
		[Token(Token = "0x60016DC")]
		void NotifyOfferedCipherSuites(int[] offeredCipherSuites);

		// Token: 0x060016DD RID: 5853
		[Token(Token = "0x60016DD")]
		void NotifyOfferedCompressionMethods(byte[] offeredCompressionMethods);

		// Token: 0x060016DE RID: 5854
		[Token(Token = "0x60016DE")]
		void ProcessClientExtensions(IDictionary clientExtensions);

		// Token: 0x060016DF RID: 5855
		[Token(Token = "0x60016DF")]
		ProtocolVersion GetServerVersion();

		// Token: 0x060016E0 RID: 5856
		[Token(Token = "0x60016E0")]
		int GetSelectedCipherSuite();

		// Token: 0x060016E1 RID: 5857
		[Token(Token = "0x60016E1")]
		byte GetSelectedCompressionMethod();

		// Token: 0x060016E2 RID: 5858
		[Token(Token = "0x60016E2")]
		IDictionary GetServerExtensions();

		// Token: 0x060016E3 RID: 5859
		[Token(Token = "0x60016E3")]
		IList GetServerSupplementalData();

		// Token: 0x060016E4 RID: 5860
		[Token(Token = "0x60016E4")]
		TlsCredentials GetCredentials();

		// Token: 0x060016E5 RID: 5861
		[Token(Token = "0x60016E5")]
		CertificateStatus GetCertificateStatus();

		// Token: 0x060016E6 RID: 5862
		[Token(Token = "0x60016E6")]
		TlsKeyExchange GetKeyExchange();

		// Token: 0x060016E7 RID: 5863
		[Token(Token = "0x60016E7")]
		CertificateRequest GetCertificateRequest();

		// Token: 0x060016E8 RID: 5864
		[Token(Token = "0x60016E8")]
		void ProcessClientSupplementalData(IList clientSupplementalData);

		// Token: 0x060016E9 RID: 5865
		[Token(Token = "0x60016E9")]
		void NotifyClientCertificate(Certificate clientCertificate);

		// Token: 0x060016EA RID: 5866
		[Token(Token = "0x60016EA")]
		NewSessionTicket GetNewSessionTicket();
	}
}
