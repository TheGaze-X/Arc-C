using System;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace Mono
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	internal abstract class X509PalImpl
	{
		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		public abstract X509CertificateImpl Import(byte[] data);

		// Token: 0x06000018 RID: 24
		[Token(Token = "0x6000018")]
		public abstract X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags);

		// Token: 0x06000019 RID: 25
		[Token(Token = "0x6000019")]
		public abstract X509Certificate2Impl Import(X509Certificate cert);

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x4F67A50", Offset = "0x4F66650", VA = "0x184F67A50")]
		private static byte[] PEM(string type, byte[] data)
		{
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4F67360", Offset = "0x4F65F60", VA = "0x184F67360")]
		protected static byte[] ConvertData(byte[] data)
		{
			return null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4F67860", Offset = "0x4F66460", VA = "0x184F67860")]
		internal X509Certificate2Impl ImportFallback(byte[] data)
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4F679C0", Offset = "0x4F665C0", VA = "0x184F679C0")]
		internal X509Certificate2Impl ImportFallback(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			return null;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x17000007")]
		public bool SupportsLegacyBasicConstraintsExtension
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x4F67530", Offset = "0x4F66130", VA = "0x184F67530")]
		public X509ContentType GetCertContentType(byte[] rawData)
		{
			return X509ContentType.Unknown;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected X509PalImpl()
		{
		}

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] signedData;
	}
}
