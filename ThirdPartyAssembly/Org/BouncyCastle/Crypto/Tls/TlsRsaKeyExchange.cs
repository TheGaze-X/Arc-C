using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002A1 RID: 673
	[Token(Token = "0x20002A1")]
	public class TlsRsaKeyExchange : AbstractTlsKeyExchange
	{
		// Token: 0x060016C4 RID: 5828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C4")]
		[Address(RVA = "0x5273310", Offset = "0x5271F10", VA = "0x185273310")]
		public TlsRsaKeyExchange(IList supportedSignatureAlgorithms)
		{
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C5")]
		[Address(RVA = "0x5273170", Offset = "0x5271D70", VA = "0x185273170", Slot = "21")]
		public override void SkipServerCredentials()
		{
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C6")]
		[Address(RVA = "0x5272F90", Offset = "0x5271B90", VA = "0x185272F90", Slot = "23")]
		public override void ProcessServerCredentials(TlsCredentials serverCredentials)
		{
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C7")]
		[Address(RVA = "0x5272CD0", Offset = "0x52718D0", VA = "0x185272CD0", Slot = "22")]
		public override void ProcessServerCertificate(Certificate serverCertificate)
		{
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C8")]
		[Address(RVA = "0x52731C0", Offset = "0x5271DC0", VA = "0x1852731C0", Slot = "28")]
		public override void ValidateCertificateRequest(CertificateRequest certificateRequest)
		{
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016C9")]
		[Address(RVA = "0x5272AA0", Offset = "0x52716A0", VA = "0x185272AA0", Slot = "30")]
		public override void ProcessClientCredentials(TlsCredentials clientCredentials)
		{
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016CA")]
		[Address(RVA = "0x5272A00", Offset = "0x5271600", VA = "0x185272A00", Slot = "32")]
		public override void GenerateClientKeyExchange(Stream output)
		{
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016CB")]
		[Address(RVA = "0x5272B30", Offset = "0x5271730", VA = "0x185272B30", Slot = "33")]
		public override void ProcessClientKeyExchange(Stream input)
		{
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CC")]
		[Address(RVA = "0x5272A30", Offset = "0x5271630", VA = "0x185272A30", Slot = "34")]
		public override byte[] GeneratePremasterSecret()
		{
			return null;
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016CD")]
		[Address(RVA = "0x5273290", Offset = "0x5271E90", VA = "0x185273290", Slot = "35")]
		protected virtual RsaKeyParameters ValidateRsaPublicKey(RsaKeyParameters key)
		{
			return null;
		}

		// Token: 0x04000C73 RID: 3187
		[Token(Token = "0x4000C73")]
		[FieldOffset(Offset = "0x28")]
		protected AsymmetricKeyParameter mServerPublicKey;

		// Token: 0x04000C74 RID: 3188
		[Token(Token = "0x4000C74")]
		[FieldOffset(Offset = "0x30")]
		protected RsaKeyParameters mRsaServerPublicKey;

		// Token: 0x04000C75 RID: 3189
		[Token(Token = "0x4000C75")]
		[FieldOffset(Offset = "0x38")]
		protected TlsEncryptionCredentials mServerCredentials;

		// Token: 0x04000C76 RID: 3190
		[Token(Token = "0x4000C76")]
		[FieldOffset(Offset = "0x40")]
		protected byte[] mPremasterSecret;
	}
}
