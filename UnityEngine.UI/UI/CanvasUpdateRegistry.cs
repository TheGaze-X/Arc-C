using System;
using Il2CppDummyDll;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class CanvasUpdateRegistry
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x5A08130", Offset = "0x5A06D30", VA = "0x185A08130")]
		protected CanvasUpdateRegistry()
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000A")]
		public static CanvasUpdateRegistry instance
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x5A08450", Offset = "0x5A07050", VA = "0x185A08450")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x5A07370", Offset = "0x5A05F70", VA = "0x185A07370")]
		private bool ObjectValidForUpdate(ICanvasElement element)
		{
			return default(bool);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x5A06940", Offset = "0x5A05540", VA = "0x185A06940")]
		private void CleanInvalidItems()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x5A07570", Offset = "0x5A06170", VA = "0x185A07570")]
		private void PerformUpdate()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x5A074A0", Offset = "0x5A060A0", VA = "0x185A074A0")]
		private static int ParentCount(Transform child)
		{
			return 0;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x5A07CE0", Offset = "0x5A068E0", VA = "0x185A07CE0")]
		private static int SortLayoutList(ICanvasElement x, ICanvasElement y)
		{
			return 0;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x5A07C80", Offset = "0x5A06880", VA = "0x185A07C80")]
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x5A07DF0", Offset = "0x5A069F0", VA = "0x185A07DF0")]
		public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			return default(bool);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x5A07020", Offset = "0x5A05C20", VA = "0x185A07020")]
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			return default(bool);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x5A07C20", Offset = "0x5A06820", VA = "0x185A07C20")]
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x5A07D90", Offset = "0x5A06990", VA = "0x185A07D90")]
		public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			return default(bool);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x5A06F60", Offset = "0x5A05B60", VA = "0x185A06F60")]
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			return default(bool);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x5A07E50", Offset = "0x5A06A50", VA = "0x185A07E50")]
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x5A06B00", Offset = "0x5A05700", VA = "0x185A06B00")]
		public static void DisableCanvasElementForRebuild(ICanvasElement element)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x5A071C0", Offset = "0x5A05DC0", VA = "0x185A071C0")]
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x5A070B0", Offset = "0x5A05CB0", VA = "0x185A070B0")]
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x5A06E50", Offset = "0x5A05A50", VA = "0x185A06E50")]
		private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x5A06D40", Offset = "0x5A05940", VA = "0x185A06D40")]
		private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x5A07320", Offset = "0x5A05F20", VA = "0x185A07320")]
		public static bool IsRebuildingLayout()
		{
			return default(bool);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x5A072D0", Offset = "0x5A05ED0", VA = "0x185A072D0")]
		public static bool IsRebuildingGraphics()
		{
			return default(bool);
		}

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x0")]
		private static CanvasUpdateRegistry s_Instance;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		private bool m_PerformingLayoutUpdate;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x11")]
		private bool m_PerformingGraphicUpdate;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x18")]
		private string[] m_CanvasUpdateProfilerStrings;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x28")]
		private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Comparison<ICanvasElement> s_SortLayoutFunction;
	}
}
