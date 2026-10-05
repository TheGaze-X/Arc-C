using System;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;
using Mono;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000349 RID: 841
	[Token(Token = "0x2000349")]
	internal static class X509Helper
	{
		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700031F")]
		private static ISystemCertificateProvider CertificateProvider
		{
			[Token(Token = "0x6001BF1")]
			[Address(RVA = "0x4B6CD60", Offset = "0x4B6B960", VA = "0x184B6CD60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BF2")]
		[Address(RVA = "0x4B6CB50", Offset = "0x4B6B750", VA = "0x184B6CB50")]
		public static X509CertificateImpl InitFromCertificate(X509Certificate cert)
		{
			return null;
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BF3")]
		[Address(RVA = "0x4B6CC50", Offset = "0x4B6B850", VA = "0x184B6CC50")]
		public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl)
		{
			return null;
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x00012888 File Offset: 0x00010A88
		[Token(Token = "0x6001BF4")]
		[Address(RVA = "0x4B6CCA0", Offset = "0x4B6B8A0", VA = "0x184B6CCA0")]
		public static bool IsValid(X509CertificateImpl impl)
		{
			return default(bool);
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF5")]
		[Address(RVA = "0x4B6CCF0", Offset = "0x4B6B8F0", VA = "0x184B6CCF0")]
		internal static void ThrowIfContextInvalid(X509CertificateImpl impl)
		{
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BF6")]
		[Address(RVA = "0x4B6C8C0", Offset = "0x4B6B4C0", VA = "0x184B6C8C0")]
		internal static System.Exception GetInvalidContextException()
		{
			return null;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BF7")]
		[Address(RVA = "0x4B6CA60", Offset = "0x4B6B660", VA = "0x184B6CA60")]
		public static X509CertificateImpl Import(byte[] rawData)
		{
			return null;
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001BF8")]
		[Address(RVA = "0x4B6C940", Offset = "0x4B6B540", VA = "0x184B6C940")]
		public static X509CertificateImpl Import(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			return null;
		}
	}
}
