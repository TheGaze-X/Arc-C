using System;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace Mono
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	internal class X509PalImplMono : X509PalImpl
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x4F67300", Offset = "0x4F65F00", VA = "0x184F67300", Slot = "4")]
		public override X509CertificateImpl Import(byte[] data)
		{
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x4F672F0", Offset = "0x4F65EF0", VA = "0x184F672F0", Slot = "5")]
		public override X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
		public override X509Certificate2Impl Import(X509Certificate cert)
		{
			return null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x4F67310", Offset = "0x4F65F10", VA = "0x184F67310")]
		public X509PalImplMono()
		{
		}
	}
}
