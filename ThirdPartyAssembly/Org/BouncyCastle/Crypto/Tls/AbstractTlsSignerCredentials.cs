using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200023C RID: 572
	[Token(Token = "0x200023C")]
	public abstract class AbstractTlsSignerCredentials : AbstractTlsCredentials, TlsSignerCredentials, TlsCredentials
	{
		// Token: 0x06001413 RID: 5139
		[Token(Token = "0x6001413")]
		public abstract byte[] GenerateCertificateSignature(byte[] hash);

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C9")]
		public virtual SignatureAndHashAlgorithm SignatureAndHashAlgorithm
		{
			[Token(Token = "0x6001414")]
			[Address(RVA = "0x5240F30", Offset = "0x523FB30", VA = "0x185240F30", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001415")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AbstractTlsSignerCredentials()
		{
		}
	}
}
