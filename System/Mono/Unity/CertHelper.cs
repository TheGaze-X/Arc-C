using System;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace Mono.Unity
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	internal static class CertHelper
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x4F4E740", Offset = "0x4F4D340", VA = "0x184F4E740")]
		public unsafe static void AddCertificatesToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, UnityTls.unitytls_errorstate* errorState)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4F4E530", Offset = "0x4F4D130", VA = "0x184F4E530")]
		public unsafe static void AddCertificateToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509Certificate certificate, UnityTls.unitytls_errorstate* errorState)
		{
		}
	}
}
