using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Diagnostics
{
	// Token: 0x0200029B RID: 667
	[Token(Token = "0x200029B")]
	[NativeHeader("Runtime/Export/Diagnostics/DiagnosticsUtils.bindings.h")]
	public static class Utils
	{
		// Token: 0x06000F6E RID: 3950
		[Token(Token = "0x6000F6E")]
		[Address(RVA = "0x5989400", Offset = "0x5988000", VA = "0x185989400")]
		[FreeFunction("DiagnosticsUtils_Bindings::ForceCrash", ThrowsException = true)]
		[MethodImpl(4096)]
		public static extern void ForceCrash(ForcedCrashCategory crashCategory);
	}
}
