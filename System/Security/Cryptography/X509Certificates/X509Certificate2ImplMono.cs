using System;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	internal class X509Certificate2ImplMono : X509Certificate2ImplUnix
	{
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x17000167")]
		public override bool IsValid
		{
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x50E51F0", Offset = "0x50E3DF0", VA = "0x1850E51F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x512A2B0", Offset = "0x5128EB0", VA = "0x18512A2B0")]
		public X509Certificate2ImplMono(X509Certificate cert)
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x512A2F0", Offset = "0x5128EF0", VA = "0x18512A2F0")]
		private X509Certificate2ImplMono(X509Certificate2ImplMono other)
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x512A040", Offset = "0x5128C40", VA = "0x18512A040")]
		public X509Certificate2ImplMono(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x5129240", Offset = "0x5127E40", VA = "0x185129240", Slot = "6")]
		public override X509CertificateImpl Clone()
		{
			return null;
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000168")]
		private X509Certificate Cert
		{
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x50E5220", Offset = "0x50E3E20", VA = "0x1850E5220")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x51294D0", Offset = "0x51280D0", VA = "0x1851294D0", Slot = "34")]
		protected override byte[] GetRawCertData()
		{
			return null;
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x00004F50 File Offset: 0x00003150
		[Token(Token = "0x17000169")]
		public override bool HasPrivateKey
		{
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x512A3A0", Offset = "0x5128FA0", VA = "0x18512A3A0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016A")]
		public override AsymmetricAlgorithm PrivateKey
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x512A3E0", Offset = "0x5128FE0", VA = "0x18512A3E0", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x512A8C0", Offset = "0x51294C0", VA = "0x18512A8C0", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x5129400", Offset = "0x5128000", VA = "0x185129400", Slot = "18")]
		public override RSA GetRSAPrivateKey()
		{
			return null;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x5129330", Offset = "0x5127F30", VA = "0x185129330", Slot = "19")]
		public override DSA GetDSAPrivateKey()
		{
			return null;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x5129D60", Offset = "0x5128960", VA = "0x185129D60")]
		private X509Certificate ImportPkcs12(byte[] rawData, SafePasswordHandle password)
		{
			return null;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x5129530", Offset = "0x5128130", VA = "0x185129530")]
		private X509Certificate ImportPkcs12(byte[] rawData, string password)
		{
			return null;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00004F68 File Offset: 0x00003168
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x5129DE0", Offset = "0x51289E0", VA = "0x185129DE0", Slot = "32")]
		[MonoTODO("by default this depends on the incomplete X509Chain")]
		public override bool Verify(X509Certificate2 thisCertificate)
		{
			return default(bool);
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016B")]
		internal override X509CertificateImplCollection IntermediateCertificates
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x4E8AF0", Offset = "0x4E76F0", VA = "0x1804E8AF0", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016C")]
		internal X509Certificate MonoCertificate
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x22F8850", Offset = "0x22F7450", VA = "0x1822F8850")]
			get
			{
				return null;
			}
		}

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0xB0")]
		private X509CertificateImplCollection intermediateCerts;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0xB8")]
		private X509Certificate _cert;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x0")]
		private static string empty_error;

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] signedData;
	}
}
