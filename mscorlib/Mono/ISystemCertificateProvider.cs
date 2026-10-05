using System;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace Mono
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	internal interface ISystemCertificateProvider
	{
		// Token: 0x06000055 RID: 85
		[Token(Token = "0x6000055")]
		X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = CertificateImportFlags.None);

		// Token: 0x06000056 RID: 86
		[Token(Token = "0x6000056")]
		X509CertificateImpl Import(byte[] data, SafePasswordHandle password, System.Security.Cryptography.X509Certificates.X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = CertificateImportFlags.None);

		// Token: 0x06000057 RID: 87
		[Token(Token = "0x6000057")]
		X509CertificateImpl Import(System.Security.Cryptography.X509Certificates.X509Certificate cert, CertificateImportFlags importFlags = CertificateImportFlags.None);
	}
}
