using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	[NativeHeader("Runtime/Utilities/PropertyName.h")]
	internal class PropertyNameUtils
	{
		// Token: 0x060008BF RID: 2239 RVA: 0x00005A00 File Offset: 0x00003C00
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x59503F0", Offset = "0x594EFF0", VA = "0x1859503F0")]
		[FreeFunction(IsThreadSafe = true)]
		public static PropertyName PropertyNameFromString([Unmarshalled] string name)
		{
			return default(PropertyName);
		}

		// Token: 0x060008C0 RID: 2240
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x59503A0", Offset = "0x594EFA0", VA = "0x1859503A0")]
		[MethodImpl(4096)]
		private static extern void PropertyNameFromString_Injected(string name, out PropertyName ret);
	}
}
