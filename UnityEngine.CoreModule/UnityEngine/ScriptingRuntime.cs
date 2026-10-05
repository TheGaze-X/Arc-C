using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000110 RID: 272
	[Token(Token = "0x2000110")]
	[NativeHeader("Runtime/Export/Scripting/ScriptingRuntime.h")]
	[VisibleToOtherModules]
	internal class ScriptingRuntime
	{
		// Token: 0x060009E0 RID: 2528
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x596CA40", Offset = "0x596B640", VA = "0x18596CA40")]
		[MethodImpl(4096)]
		public static extern string[] GetAllUserAssemblies();
	}
}
