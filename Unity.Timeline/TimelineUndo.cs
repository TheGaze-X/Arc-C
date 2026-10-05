using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	internal static class TimelineUndo
	{
		// Token: 0x0600034F RID: 847 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x5903D70", Offset = "0x5902970", VA = "0x185903D70")]
		public static void PushDestroyUndo(TimelineAsset timeline, Object thingToDirty, Object objectToDestroy)
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("UNITY_EDITOR")]
		public static void PushUndo(Object[] thingsToDirty, string operation)
		{
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("UNITY_EDITOR")]
		public static void PushUndo(Object thingToDirty, string operation)
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("UNITY_EDITOR")]
		public static void RegisterCreatedObjectUndo(Object thingCreated, string operation)
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x5903DF0", Offset = "0x59029F0", VA = "0x185903DF0")]
		private static string UndoName(string name)
		{
			return null;
		}
	}
}
