using System;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;
using Mono.Security.Interface;

namespace Mono
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	internal class SystemCertificateProvider : ISystemCertificateProvider
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x4F5E970", Offset = "0x4F5D570", VA = "0x184F5E970")]
		private static X509PalImpl GetX509Pal()
		{
			return null;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x4F5E7D0", Offset = "0x4F5D3D0", VA = "0x184F5E7D0")]
		private static void EnsureInitialized()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public X509PalImpl X509Pal
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x4F5F0D0", Offset = "0x4F5DCD0", VA = "0x184F5F0D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x4F5EBB0", Offset = "0x4F5D7B0", VA = "0x184F5EBB0", Slot = "4")]
		public X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = CertificateImportFlags.None)
		{
			return null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x4F5EF40", Offset = "0x4F5DB40", VA = "0x184F5EF40", Slot = "5")]
		private X509CertificateImpl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags)
		{
			return null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x4F5EC60", Offset = "0x4F5D860", VA = "0x184F5EC60")]
		public X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = CertificateImportFlags.None)
		{
			return null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x4F5F030", Offset = "0x4F5DC30", VA = "0x184F5F030", Slot = "6")]
		private X509CertificateImpl Import(X509Certificate cert, CertificateImportFlags importFlags)
		{
			return null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x4F5ED50", Offset = "0x4F5D950", VA = "0x184F5ED50")]
		public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags = CertificateImportFlags.None)
		{
			return null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SystemCertificateProvider()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private static MonoTlsProvider provider;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x8")]
		private static int initialized;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		private static X509PalImpl x509pal;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x18")]
		private static object syncRoot;
	}
}
