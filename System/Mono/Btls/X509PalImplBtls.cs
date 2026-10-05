using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;
using Mono.Security.Interface;

namespace Mono.Btls
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	internal class X509PalImplBtls : X509PalImpl
	{
		// Token: 0x0600033A RID: 826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x50E6290", Offset = "0x50E4E90", VA = "0x1850E6290")]
		public X509PalImplBtls(MonoTlsProvider provider)
		{
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008B")]
		private MonoBtlsProvider Provider
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x50E6260", Offset = "0x50E4E60", VA = "0x1850E6260", Slot = "4")]
		public override X509CertificateImpl Import(byte[] data)
		{
			return null;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x50E6210", Offset = "0x50E4E10", VA = "0x1850E6210", Slot = "5")]
		public override X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags)
		{
			return null;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x50E6240", Offset = "0x50E4E40", VA = "0x1850E6240", Slot = "6")]
		public override X509Certificate2Impl Import(X509Certificate cert)
		{
			return null;
		}
	}
}
