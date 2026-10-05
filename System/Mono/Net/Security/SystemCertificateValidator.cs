using System;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	internal static class SystemCertificateValidator
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		internal static bool NeedsChain(MonoTlsSettings settings)
		{
			return default(bool);
		}

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x0")]
		private static bool is_macosx;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x4")]
		private static X509KeyUsageFlags s_flags;
	}
}
