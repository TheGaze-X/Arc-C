using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200028E RID: 654
	[Token(Token = "0x200028E")]
	public class TlsDHKeyExchange : AbstractTlsKeyExchange
	{
		// Token: 0x060015BC RID: 5564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BC")]
		[Address(RVA = "0x5256ED0", Offset = "0x5255AD0", VA = "0x185256ED0")]
		public TlsDHKeyExchange(int keyExchange, IList supportedSignatureAlgorithms, DHParameters dhParameters)
		{
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BD")]
		[Address(RVA = "0x52566D0", Offset = "0x52552D0", VA = "0x1852566D0", Slot = "20")]
		public override void Init(TlsContext context)
		{
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x5256CC0", Offset = "0x52558C0", VA = "0x185256CC0", Slot = "21")]
		public override void SkipServerCredentials()
		{
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x5256920", Offset = "0x5255520", VA = "0x185256920", Slot = "22")]
		public override void ProcessServerCertificate(Certificate serverCertificate)
		{
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x0000B100 File Offset: 0x00009300
		[Token(Token = "0x17000318")]
		public override bool RequiresServerKeyExchange
		{
			[Token(Token = "0x60015C0")]
			[Address(RVA = "0x5257060", Offset = "0x5255C60", VA = "0x185257060", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C1")]
		[Address(RVA = "0x5256D10", Offset = "0x5255910", VA = "0x185256D10", Slot = "28")]
		public override void ValidateCertificateRequest(CertificateRequest certificateRequest)
		{
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C2")]
		[Address(RVA = "0x5256730", Offset = "0x5255330", VA = "0x185256730", Slot = "30")]
		public override void ProcessClientCredentials(TlsCredentials clientCredentials)
		{
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C3")]
		[Address(RVA = "0x5256490", Offset = "0x5255090", VA = "0x185256490", Slot = "32")]
		public override void GenerateClientKeyExchange(Stream output)
		{
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "31")]
		public override void ProcessClientCertificate(Certificate clientCertificate)
		{
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C5")]
		[Address(RVA = "0x5256850", Offset = "0x5255450", VA = "0x185256850", Slot = "33")]
		public override void ProcessClientKeyExchange(Stream input)
		{
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x5256550", Offset = "0x5255150", VA = "0x185256550", Slot = "34")]
		public override byte[] GeneratePremasterSecret()
		{
			return null;
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x0000B118 File Offset: 0x00009318
		[Token(Token = "0x17000319")]
		protected virtual int MinimumPrimeBits
		{
			[Token(Token = "0x60015C7")]
			[Address(RVA = "0x5257050", Offset = "0x5255C50", VA = "0x185257050", Slot = "35")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x5256DE0", Offset = "0x52559E0", VA = "0x185256DE0", Slot = "36")]
		protected virtual DHParameters ValidateDHParameters(DHParameters parameters)
		{
			return null;
		}

		// Token: 0x04000C1C RID: 3100
		[Token(Token = "0x4000C1C")]
		[FieldOffset(Offset = "0x28")]
		protected TlsSigner mTlsSigner;

		// Token: 0x04000C1D RID: 3101
		[Token(Token = "0x4000C1D")]
		[FieldOffset(Offset = "0x30")]
		protected DHParameters mDHParameters;

		// Token: 0x04000C1E RID: 3102
		[Token(Token = "0x4000C1E")]
		[FieldOffset(Offset = "0x38")]
		protected AsymmetricKeyParameter mServerPublicKey;

		// Token: 0x04000C1F RID: 3103
		[Token(Token = "0x4000C1F")]
		[FieldOffset(Offset = "0x40")]
		protected TlsAgreementCredentials mAgreementCredentials;

		// Token: 0x04000C20 RID: 3104
		[Token(Token = "0x4000C20")]
		[FieldOffset(Offset = "0x48")]
		protected DHPrivateKeyParameters mDHAgreePrivateKey;

		// Token: 0x04000C21 RID: 3105
		[Token(Token = "0x4000C21")]
		[FieldOffset(Offset = "0x50")]
		protected DHPublicKeyParameters mDHAgreePublicKey;
	}
}
