using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace Mono.Btls
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	internal class X509CertificateImplBtls : X509Certificate2ImplUnix
	{
		// Token: 0x0600031C RID: 796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x50E4E00", Offset = "0x50E3A00", VA = "0x1850E4E00")]
		internal X509CertificateImplBtls(MonoBtlsX509 x509)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x50E4E50", Offset = "0x50E3A50", VA = "0x1850E4E50")]
		private X509CertificateImplBtls(X509CertificateImplBtls other)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x50E4F10", Offset = "0x50E3B10", VA = "0x1850E4F10")]
		internal X509CertificateImplBtls(byte[] data, MonoBtlsX509Format format)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x50E4F60", Offset = "0x50E3B60", VA = "0x1850E4F60")]
		internal X509CertificateImplBtls(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x17000081")]
		public override bool IsValid
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x50E5200", Offset = "0x50E3E00", VA = "0x1850E5200", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000082")]
		internal MonoBtlsX509 X509
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x50E5240", Offset = "0x50E3E40", VA = "0x1850E5240")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000083")]
		internal MonoBtlsKey NativePrivateKey
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x50E5220", Offset = "0x50E3E20", VA = "0x1850E5220")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x50E42D0", Offset = "0x50E2ED0", VA = "0x1850E42D0", Slot = "6")]
		public override X509CertificateImpl Clone()
		{
			return null;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x50E4490", Offset = "0x50E3090", VA = "0x1850E4490", Slot = "34")]
		protected override byte[] GetRawCertData()
		{
			return null;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000084")]
		internal override X509CertificateImplCollection IntermediateCertificates
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x20BBCF0", Offset = "0x20BA8F0", VA = "0x1820BBCF0", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x50E43D0", Offset = "0x50E2FD0", VA = "0x1850E43D0", Slot = "22")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x17000085")]
		public override bool HasPrivateKey
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x50E51F0", Offset = "0x50E3DF0", VA = "0x1850E51F0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000086")]
		public override AsymmetricAlgorithm PrivateKey
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x50E4460", Offset = "0x50E3060", VA = "0x1850E4460", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x50E5260", Offset = "0x50E3E60", VA = "0x1850E5260", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x50E4460", Offset = "0x50E3060", VA = "0x1850E4460", Slot = "18")]
		public override RSA GetRSAPrivateKey()
		{
			return null;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x50E4410", Offset = "0x50E3010", VA = "0x1850E4410", Slot = "19")]
		public override DSA GetDSAPrivateKey()
		{
			return null;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x50E4A90", Offset = "0x50E3690", VA = "0x1850E4A90")]
		private void Import(byte[] data)
		{
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x50E45C0", Offset = "0x50E31C0", VA = "0x1850E45C0")]
		private void ImportPkcs12(byte[] data, SafePasswordHandle password)
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x50E44D0", Offset = "0x50E30D0", VA = "0x1850E44D0")]
		private void ImportAuthenticode(byte[] data)
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x50E4AF0", Offset = "0x50E36F0", VA = "0x1850E4AF0", Slot = "32")]
		public override bool Verify(X509Certificate2 thisCertificate)
		{
			return default(bool);
		}

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0xB0")]
		private MonoBtlsX509 x509;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0xB8")]
		private MonoBtlsKey nativePrivateKey;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0xC0")]
		private X509CertificateImplCollection intermediateCerts;
	}
}
