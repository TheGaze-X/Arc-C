using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	[NativeClass(null)]
	[RequiredByNativeCode]
	[ExtensionOfNativeClass]
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	[StructLayout(0)]
	public class ScriptableObject : Object
	{
		// Token: 0x060009DB RID: 2523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x596C9D0", Offset = "0x596B5D0", VA = "0x18596C9D0")]
		public ScriptableObject()
		{
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x596C900", Offset = "0x596B500", VA = "0x18596C900")]
		public static ScriptableObject CreateInstance(Type type)
		{
			return null;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009DD")]
		public static T CreateInstance<T>() where T : ScriptableObject
		{
			return null;
		}

		// Token: 0x060009DE RID: 2526
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x596C990", Offset = "0x596B590", VA = "0x18596C990")]
		[NativeMethod(IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void CreateScriptableObject([Writable] ScriptableObject self);

		// Token: 0x060009DF RID: 2527
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x596C940", Offset = "0x596B540", VA = "0x18596C940")]
		[FreeFunction("Scripting::CreateScriptableObjectWithType")]
		[MethodImpl(4096)]
		internal static extern ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset);
	}
}
