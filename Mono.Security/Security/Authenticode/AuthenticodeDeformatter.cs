using System;
using System.Security.Cryptography;
using Il2CppDummyDll;
using Mono.Security.X509;

namespace Mono.Security.Authenticode
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	public class AuthenticodeDeformatter : AuthenticodeBase
	{
		// Token: 0x060001F9 RID: 505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x4A94DE0", Offset = "0x4A939E0", VA = "0x184A94DE0")]
		public AuthenticodeDeformatter()
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x4A94ED0", Offset = "0x4A93AD0", VA = "0x184A94ED0")]
		public AuthenticodeDeformatter(byte[] rawData)
		{
		}

		// Token: 0x1700008D RID: 141
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008D")]
		public byte[] RawData
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x4A94FE0", Offset = "0x4A93BE0", VA = "0x184A94FE0")]
			set
			{
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008E")]
		public X509Certificate SigningCertificate
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x4A91B20", Offset = "0x4A90720", VA = "0x184A91B20")]
		private bool CheckSignature()
		{
			return default(bool);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x4A93680", Offset = "0x4A92280", VA = "0x184A93680")]
		private bool CompareIssuerSerial(string issuer, byte[] serial, X509Certificate x509)
		{
			return default(bool);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x4A94270", Offset = "0x4A92E70", VA = "0x184A94270")]
		private bool VerifySignature(PKCS7.SignedData sd, byte[] calculatedMessageDigest, HashAlgorithm ha)
		{
			return default(bool);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x4A938C0", Offset = "0x4A924C0", VA = "0x184A938C0")]
		private bool VerifyCounterSignature(PKCS7.SignerInfo cs, byte[] signature)
		{
			return default(bool);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x4A937C0", Offset = "0x4A923C0", VA = "0x184A937C0")]
		private void Reset()
		{
		}

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x40")]
		private string filename;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x48")]
		private byte[] rawdata;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x50")]
		private byte[] hash;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x58")]
		private X509CertificateCollection coll;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x60")]
		private ASN1 signedHash;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x68")]
		private DateTime timestamp;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x70")]
		private X509Certificate signingCertificate;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x78")]
		private int reason;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x7C")]
		private bool trustedRoot;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x7D")]
		private bool trustedTimestampRoot;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x80")]
		private byte[] entry;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x88")]
		private X509Chain signerChain;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x90")]
		private X509Chain timestampChain;
	}
}
