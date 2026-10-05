using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000284 RID: 644
	[Token(Token = "0x2000284")]
	public interface TlsClient : TlsPeer
	{
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600157F RID: 5503
		// (set) Token: 0x06001580 RID: 5504
		[Token(Token = "0x17000307")]
		List<string> HostNames { [Token(Token = "0x600157F")] get; [Token(Token = "0x6001580")] set; }

		// Token: 0x06001581 RID: 5505
		[Token(Token = "0x6001581")]
		void Init(TlsClientContext context);

		// Token: 0x06001582 RID: 5506
		[Token(Token = "0x6001582")]
		TlsSession GetSessionToResume();

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001583 RID: 5507
		[Token(Token = "0x17000308")]
		ProtocolVersion ClientHelloRecordLayerVersion { [Token(Token = "0x6001583")] get; }

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001584 RID: 5508
		[Token(Token = "0x17000309")]
		ProtocolVersion ClientVersion { [Token(Token = "0x6001584")] get; }

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001585 RID: 5509
		[Token(Token = "0x1700030A")]
		bool IsFallback { [Token(Token = "0x6001585")] get; }

		// Token: 0x06001586 RID: 5510
		[Token(Token = "0x6001586")]
		int[] GetCipherSuites();

		// Token: 0x06001587 RID: 5511
		[Token(Token = "0x6001587")]
		byte[] GetCompressionMethods();

		// Token: 0x06001588 RID: 5512
		[Token(Token = "0x6001588")]
		IDictionary GetClientExtensions();

		// Token: 0x06001589 RID: 5513
		[Token(Token = "0x6001589")]
		void NotifyServerVersion(ProtocolVersion selectedVersion);

		// Token: 0x0600158A RID: 5514
		[Token(Token = "0x600158A")]
		void NotifySessionID(byte[] sessionID);

		// Token: 0x0600158B RID: 5515
		[Token(Token = "0x600158B")]
		void NotifySelectedCipherSuite(int selectedCipherSuite);

		// Token: 0x0600158C RID: 5516
		[Token(Token = "0x600158C")]
		void NotifySelectedCompressionMethod(byte selectedCompressionMethod);

		// Token: 0x0600158D RID: 5517
		[Token(Token = "0x600158D")]
		void ProcessServerExtensions(IDictionary serverExtensions);

		// Token: 0x0600158E RID: 5518
		[Token(Token = "0x600158E")]
		void ProcessServerSupplementalData(IList serverSupplementalData);

		// Token: 0x0600158F RID: 5519
		[Token(Token = "0x600158F")]
		TlsKeyExchange GetKeyExchange();

		// Token: 0x06001590 RID: 5520
		[Token(Token = "0x6001590")]
		TlsAuthentication GetAuthentication();

		// Token: 0x06001591 RID: 5521
		[Token(Token = "0x6001591")]
		IList GetClientSupplementalData();

		// Token: 0x06001592 RID: 5522
		[Token(Token = "0x6001592")]
		void NotifyNewSessionTicket(NewSessionTicket newSessionTicket);
	}
}
