using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200023F RID: 575
	[Token(Token = "0x200023F")]
	public class AlwaysValidVerifyer : ICertificateVerifyer
	{
		// Token: 0x0600141C RID: 5148 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		[Token(Token = "0x600141C")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
		public bool IsValid(Uri targetUri, X509CertificateStructure[] certs)
		{
			return default(bool);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600141D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AlwaysValidVerifyer()
		{
		}
	}
}
