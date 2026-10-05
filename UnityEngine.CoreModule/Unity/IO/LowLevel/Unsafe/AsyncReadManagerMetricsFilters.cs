using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[NativeConditional("ENABLE_PROFILER")]
	[RequiredByNativeCode]
	[NativeAsStruct]
	[StructLayout(0)]
	public class AsyncReadManagerMetricsFilters
	{
		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[NativeName("typeIDs")]
		internal ulong[] TypeIDs;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[NativeName("states")]
		internal ProcessingState[] States;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NativeName("readTypes")]
		internal FileReadType[] ReadTypes;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[NativeName("priorityLevels")]
		internal Priority[] PriorityLevels;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[NativeName("subsystems")]
		internal AssetLoadingSubsystem[] Subsystems;
	}
}
