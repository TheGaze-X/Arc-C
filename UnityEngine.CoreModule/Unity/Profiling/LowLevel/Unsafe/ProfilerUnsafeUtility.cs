using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Profiling.LowLevel.Unsafe
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[NativeHeader("Runtime/Profiler/ScriptBindings/ProfilerUnsafeUtility.bindings.h")]
	[UsedByNativeCode]
	public static class ProfilerUnsafeUtility
	{
		// Token: 0x06000015 RID: 21 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x5936650", Offset = "0x5935250", VA = "0x185936650")]
		[ThreadSafe]
		public static ProfilerCategoryDescription GetCategoryDescription(ushort categoryId)
		{
			return default(ProfilerCategoryDescription);
		}

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5936550", Offset = "0x5935150", VA = "0x185936550")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr CreateMarker(string name, ushort categoryId, MarkerFlags flags, int metadataCount);

		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5936510", Offset = "0x5935110", VA = "0x185936510")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void BeginSample(IntPtr markerPtr);

		// Token: 0x06000018 RID: 24
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x59365C0", Offset = "0x59351C0", VA = "0x1859365C0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void EndSample(IntPtr markerPtr);

		// Token: 0x06000019 RID: 25 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x59366B0", Offset = "0x59352B0", VA = "0x1859366B0")]
		internal unsafe static string Utf8ToString(byte* chars, int charsLen)
		{
			return null;
		}

		// Token: 0x0600001A RID: 26
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x5936600", Offset = "0x5935200", VA = "0x185936600")]
		[MethodImpl(4096)]
		private static extern void GetCategoryDescription_Injected(ushort categoryId, out ProfilerCategoryDescription ret);
	}
}
