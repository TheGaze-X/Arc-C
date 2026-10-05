using System;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine
{
	// Token: 0x02000131 RID: 305
	[Token(Token = "0x2000131")]
	public sealed class StaticBatchingUtility
	{
		// Token: 0x06000A86 RID: 2694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x596FDF0", Offset = "0x596E9F0", VA = "0x18596FDF0")]
		public static void Combine(GameObject staticBatchRoot)
		{
		}

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x0")]
		internal static ProfilerMarker s_CombineMarker;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x8")]
		internal static ProfilerMarker s_SortMarker;

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x10")]
		internal static ProfilerMarker s_MakeBatchMarker;
	}
}
