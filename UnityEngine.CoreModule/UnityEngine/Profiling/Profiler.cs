using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Profiling
{
	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000159")]
	[NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
	[NativeHeader("Runtime/Profiler/Profiler.h")]
	[NativeHeader("Runtime/Allocator/MemoryManager.h")]
	[UsedByNativeCode]
	[MovedFrom("UnityEngine")]
	[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
	[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
	public sealed class Profiler
	{
		// Token: 0x17000288 RID: 648
		// (set) Token: 0x06000C17 RID: 3095
		[Token(Token = "0x17000288")]
		public static extern int maxUsedMemory { [Token(Token = "0x6000C17")] [Address(RVA = "0x5967AE0", Offset = "0x59666E0", VA = "0x185967AE0")] [NativeMethod(Name = "ProfilerBindings::SetMaxUsedMemory", IsFreeFunction = true)] [MethodImpl(4096)] set; }

		// Token: 0x06000C18 RID: 3096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x5967970", Offset = "0x5966570", VA = "0x185967970")]
		[Conditional("ENABLE_PROFILER")]
		[MethodImpl(256)]
		public static void BeginSample(string name)
		{
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x5967A50", Offset = "0x5966650", VA = "0x185967A50")]
		[MethodImpl(256)]
		private static void ValidateArguments(string name)
		{
		}

		// Token: 0x06000C1A RID: 3098
		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x5967920", Offset = "0x5966520", VA = "0x185967920")]
		[NativeMethod(Name = "ProfilerBindings::BeginSample", IsFreeFunction = true, IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void BeginSampleImpl(string name, Object targetObject);

		// Token: 0x06000C1B RID: 3099
		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x5967A20", Offset = "0x5966620", VA = "0x185967A20")]
		[NativeMethod(Name = "ProfilerBindings::EndSample", IsFreeFunction = true, IsThreadSafe = true)]
		[Conditional("ENABLE_PROFILER")]
		[MethodImpl(4096)]
		public static extern void EndSample();
	}
}
