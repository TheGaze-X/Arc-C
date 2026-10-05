using System;
using System.Net.Security;
using Il2CppDummyDll;
using Mono.Security.Interface;

namespace Mono.Net.Security.Private
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	internal static class CallbackHelpers
	{
		// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x4F4E460", Offset = "0x4F4D060", VA = "0x184F4E460")]
		internal static MonoRemoteCertificateValidationCallback PublicToMono(RemoteCertificateValidationCallback callback)
		{
			return null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x4F4E390", Offset = "0x4F4CF90", VA = "0x184F4E390")]
		internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback)
		{
			return null;
		}
	}
}
