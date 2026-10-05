using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000294 RID: 660
	[Token(Token = "0x2000294")]
	public class TlsECDHKeyExchange : AbstractTlsKeyExchange
	{
		// Token: 0x0600161E RID: 5662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161E")]
		[Address(RVA = "0x525B030", Offset = "0x5259C30", VA = "0x18525B030")]
		public TlsECDHKeyExchange(int keyExchange, IList supportedSignatureAlgorithms, int[] namedCurves, byte[] clientECPointFormats, byte[] serverECPointFormats)
		{
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600161F")]
		[Address(RVA = "0x525A780", Offset = "0x5259380", VA = "0x18525A780", Slot = "20")]
		public override void Init(TlsContext context)
		{
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001620")]
		[Address(RVA = "0x525AF00", Offset = "0x5259B00", VA = "0x18525AF00", Slot = "21")]
		public override void SkipServerCredentials()
		{
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001621")]
		[Address(RVA = "0x525AA90", Offset = "0x5259690", VA = "0x18525AA90", Slot = "22")]
		public override void ProcessServerCertificate(Certificate serverCertificate)
		{
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x0000B298 File Offset: 0x00009498
		[Token(Token = "0x1700031C")]
		public override bool RequiresServerKeyExchange
		{
			[Token(Token = "0x6001622")]
			[Address(RVA = "0x525B1B0", Offset = "0x5259DB0", VA = "0x18525B1B0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001623")]
		[Address(RVA = "0x525A620", Offset = "0x5259220", VA = "0x18525A620", Slot = "25")]
		public override byte[] GenerateServerKeyExchange()
		{
			return null;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001624")]
		[Address(RVA = "0x525ADC0", Offset = "0x52599C0", VA = "0x18525ADC0", Slot = "27")]
		public override void ProcessServerKeyExchange(Stream input)
		{
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001625")]
		[Address(RVA = "0x525AF60", Offset = "0x5259B60", VA = "0x18525AF60", Slot = "28")]
		public override void ValidateCertificateRequest(CertificateRequest certificateRequest)
		{
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001626")]
		[Address(RVA = "0x525A840", Offset = "0x5259440", VA = "0x18525A840", Slot = "30")]
		public override void ProcessClientCredentials(TlsCredentials clientCredentials)
		{
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x525A380", Offset = "0x5258F80", VA = "0x18525A380", Slot = "32")]
		public override void GenerateClientKeyExchange(Stream output)
		{
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001628")]
		[Address(RVA = "0x525A7E0", Offset = "0x52593E0", VA = "0x18525A7E0", Slot = "31")]
		public override void ProcessClientCertificate(Certificate clientCertificate)
		{
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001629")]
		[Address(RVA = "0x525A9C0", Offset = "0x52595C0", VA = "0x18525A9C0", Slot = "33")]
		public override void ProcessClientKeyExchange(Stream input)
		{
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600162A")]
		[Address(RVA = "0x525A470", Offset = "0x5259070", VA = "0x18525A470", Slot = "34")]
		public override byte[] GeneratePremasterSecret()
		{
			return null;
		}

		// Token: 0x04000C2F RID: 3119
		[Token(Token = "0x4000C2F")]
		[FieldOffset(Offset = "0x28")]
		protected TlsSigner mTlsSigner;

		// Token: 0x04000C30 RID: 3120
		[Token(Token = "0x4000C30")]
		[FieldOffset(Offset = "0x30")]
		protected int[] mNamedCurves;

		// Token: 0x04000C31 RID: 3121
		[Token(Token = "0x4000C31")]
		[FieldOffset(Offset = "0x38")]
		protected byte[] mClientECPointFormats;

		// Token: 0x04000C32 RID: 3122
		[Token(Token = "0x4000C32")]
		[FieldOffset(Offset = "0x40")]
		protected byte[] mServerECPointFormats;

		// Token: 0x04000C33 RID: 3123
		[Token(Token = "0x4000C33")]
		[FieldOffset(Offset = "0x48")]
		protected AsymmetricKeyParameter mServerPublicKey;

		// Token: 0x04000C34 RID: 3124
		[Token(Token = "0x4000C34")]
		[FieldOffset(Offset = "0x50")]
		protected TlsAgreementCredentials mAgreementCredentials;

		// Token: 0x04000C35 RID: 3125
		[Token(Token = "0x4000C35")]
		[FieldOffset(Offset = "0x58")]
		protected ECPrivateKeyParameters mECAgreePrivateKey;

		// Token: 0x04000C36 RID: 3126
		[Token(Token = "0x4000C36")]
		[FieldOffset(Offset = "0x60")]
		protected ECPublicKeyParameters mECAgreePublicKey;
	}
}
