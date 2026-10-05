using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000289 RID: 649
	[Token(Token = "0x2000289")]
	public interface TlsContext
	{
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x060015A6 RID: 5542
		[Token(Token = "0x1700030F")]
		IRandomGenerator NonceRandomGenerator { [Token(Token = "0x60015A6")] get; }

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x060015A7 RID: 5543
		[Token(Token = "0x17000310")]
		SecureRandom SecureRandom { [Token(Token = "0x60015A7")] get; }

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x060015A8 RID: 5544
		[Token(Token = "0x17000311")]
		SecurityParameters SecurityParameters { [Token(Token = "0x60015A8")] get; }

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x060015A9 RID: 5545
		[Token(Token = "0x17000312")]
		bool IsServer { [Token(Token = "0x60015A9")] get; }

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x060015AA RID: 5546
		[Token(Token = "0x17000313")]
		ProtocolVersion ClientVersion { [Token(Token = "0x60015AA")] get; }

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x060015AB RID: 5547
		[Token(Token = "0x17000314")]
		ProtocolVersion ServerVersion { [Token(Token = "0x60015AB")] get; }

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x060015AC RID: 5548
		[Token(Token = "0x17000315")]
		TlsSession ResumableSession { [Token(Token = "0x60015AC")] get; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x060015AD RID: 5549
		// (set) Token: 0x060015AE RID: 5550
		[Token(Token = "0x17000316")]
		object UserObject { [Token(Token = "0x60015AD")] get; [Token(Token = "0x60015AE")] set; }

		// Token: 0x060015AF RID: 5551
		[Token(Token = "0x60015AF")]
		byte[] ExportKeyingMaterial(string asciiLabel, byte[] context_value, int length);
	}
}
