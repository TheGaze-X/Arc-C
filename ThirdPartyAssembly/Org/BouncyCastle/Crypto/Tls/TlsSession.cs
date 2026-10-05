using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002A7 RID: 679
	[Token(Token = "0x20002A7")]
	public interface TlsSession
	{
		// Token: 0x060016ED RID: 5869
		[Token(Token = "0x60016ED")]
		SessionParameters ExportSessionParameters();

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060016EE RID: 5870
		[Token(Token = "0x17000328")]
		byte[] SessionID { [Token(Token = "0x60016EE")] get; }

		// Token: 0x060016EF RID: 5871
		[Token(Token = "0x60016EF")]
		void Invalidate();

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060016F0 RID: 5872
		[Token(Token = "0x17000329")]
		bool IsResumable { [Token(Token = "0x60016F0")] get; }
	}
}
