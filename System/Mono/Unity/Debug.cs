using System;
using Il2CppDummyDll;
using Mono.Security.Interface;

namespace Mono.Unity
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	internal static class Debug
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4F4F8B0", Offset = "0x4F4E4B0", VA = "0x184F4F8B0")]
		public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4F4F790", Offset = "0x4F4E390", VA = "0x184F4F790")]
		public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
		}
	}
}
