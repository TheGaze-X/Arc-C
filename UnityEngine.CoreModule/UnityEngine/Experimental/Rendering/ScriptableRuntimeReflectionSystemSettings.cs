using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020002B4 RID: 692
	[Token(Token = "0x20002B4")]
	[NativeHeader("Runtime/Camera/ScriptableRuntimeReflectionSystem.h")]
	[RequiredByNativeCode]
	public static class ScriptableRuntimeReflectionSystemSettings
	{
		// Token: 0x17000303 RID: 771
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000303")]
		private static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system
		{
			[Token(Token = "0x6000FA0")]
			[Address(RVA = "0x5986F70", Offset = "0x5985B70", VA = "0x185986F70")]
			[RequiredByNativeCode]
			set
			{
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000304")]
		private static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance
		{
			[Token(Token = "0x6000FA1")]
			[Address(RVA = "0x5986F20", Offset = "0x5985B20", VA = "0x185986F20")]
			[RequiredByNativeCode]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FA2 RID: 4002
		[Token(Token = "0x6000FA2")]
		[Address(RVA = "0x5986E70", Offset = "0x5985A70", VA = "0x185986E70")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		[StaticAccessor("ScriptableRuntimeReflectionSystem", StaticAccessorType.DoubleColon)]
		[MethodImpl(4096)]
		private static extern void ScriptingDirtyReflectionSystemInstance();

		// Token: 0x04000887 RID: 2183
		[Token(Token = "0x4000887")]
		[FieldOffset(Offset = "0x0")]
		private static ScriptableRuntimeReflectionSystemWrapper s_Instance;
	}
}
