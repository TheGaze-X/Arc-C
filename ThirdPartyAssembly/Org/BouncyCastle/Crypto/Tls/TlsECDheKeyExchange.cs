using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000293 RID: 659
	[Token(Token = "0x2000293")]
	public class TlsECDheKeyExchange : TlsECDHKeyExchange
	{
		// Token: 0x06001617 RID: 5655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001617")]
		[Address(RVA = "0x525BB90", Offset = "0x525A790", VA = "0x18525BB90")]
		public TlsECDheKeyExchange(int keyExchange, IList supportedSignatureAlgorithms, int[] namedCurves, byte[] clientECPointFormats, byte[] serverECPointFormats)
		{
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001618")]
		[Address(RVA = "0x525B690", Offset = "0x525A290", VA = "0x18525B690", Slot = "23")]
		public override void ProcessServerCredentials(TlsCredentials serverCredentials)
		{
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001619")]
		[Address(RVA = "0x525B1D0", Offset = "0x5259DD0", VA = "0x18525B1D0", Slot = "25")]
		public override byte[] GenerateServerKeyExchange()
		{
			return null;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161A")]
		[Address(RVA = "0x525B7E0", Offset = "0x525A3E0", VA = "0x18525B7E0", Slot = "27")]
		public override void ProcessServerKeyExchange(Stream input)
		{
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161B")]
		[Address(RVA = "0x525BAC0", Offset = "0x525A6C0", VA = "0x18525BAC0", Slot = "28")]
		public override void ValidateCertificateRequest(CertificateRequest certificateRequest)
		{
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161C")]
		[Address(RVA = "0x525B600", Offset = "0x525A200", VA = "0x18525B600", Slot = "30")]
		public override void ProcessClientCredentials(TlsCredentials clientCredentials)
		{
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161D")]
		[Address(RVA = "0x525B510", Offset = "0x525A110", VA = "0x18525B510", Slot = "35")]
		protected virtual ISigner InitVerifyer(TlsSigner tlsSigner, SignatureAndHashAlgorithm algorithm, SecurityParameters securityParameters)
		{
			return null;
		}

		// Token: 0x04000C2E RID: 3118
		[Token(Token = "0x4000C2E")]
		[FieldOffset(Offset = "0x68")]
		protected TlsSignerCredentials mServerCredentials;
	}
}
