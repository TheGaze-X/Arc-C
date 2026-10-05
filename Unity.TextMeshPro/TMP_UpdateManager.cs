using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;

namespace TMPro
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	public class TMP_UpdateManager
	{
		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000171")]
		private static TMP_UpdateManager instance
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x58DAD70", Offset = "0x58D9970", VA = "0x1858DAD70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x58DAB10", Offset = "0x58D9710", VA = "0x1858DAB10")]
		private TMP_UpdateManager()
		{
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x58DA620", Offset = "0x58D9220", VA = "0x1858DA620")]
		internal static void RegisterTextObjectForUpdate(TMP_Text textObject)
		{
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x58DA070", Offset = "0x58D8C70", VA = "0x1858DA070")]
		private void InternalRegisterTextObjectForUpdate(TMP_Text textObject)
		{
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x58DA520", Offset = "0x58D9120", VA = "0x1858DA520")]
		public static void RegisterTextElementForLayoutRebuild(TMP_Text element)
		{
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x58D9FB0", Offset = "0x58D8BB0", VA = "0x1858D9FB0")]
		private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element)
		{
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x58DA420", Offset = "0x58D9020", VA = "0x1858DA420")]
		public static void RegisterTextElementForGraphicRebuild(TMP_Text element)
		{
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x58D9EF0", Offset = "0x58D8AF0", VA = "0x1858D9EF0")]
		private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element)
		{
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x58DA320", Offset = "0x58D8F20", VA = "0x1858DA320")]
		public static void RegisterTextElementForCullingUpdate(TMP_Text element)
		{
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x58D9E30", Offset = "0x58D8A30", VA = "0x1858D9E30")]
		private void InternalRegisterTextElementForCullingUpdate(TMP_Text element)
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x58DA310", Offset = "0x58D8F10", VA = "0x1858DA310")]
		private void OnCameraPreCull()
		{
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x58D9AE0", Offset = "0x58D86E0", VA = "0x1858D9AE0")]
		private void DoRebuilds()
		{
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x58DA8F0", Offset = "0x58D94F0", VA = "0x1858DA8F0")]
		internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject)
		{
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x58DA720", Offset = "0x58D9320", VA = "0x1858DA720")]
		public static void UnRegisterTextElementForRebuild(TMP_Text element)
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x58DA130", Offset = "0x58D8D30", VA = "0x1858DA130")]
		private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element)
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x58DA1D0", Offset = "0x58D8DD0", VA = "0x1858DA1D0")]
		private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element)
		{
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x58DA270", Offset = "0x58D8E70", VA = "0x1858DA270")]
		private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject)
		{
		}

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x0")]
		private static TMP_UpdateManager s_Instance;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x10")]
		private readonly HashSet<int> m_LayoutQueueLookup;

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<TMP_Text> m_LayoutRebuildQueue;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x20")]
		private readonly HashSet<int> m_GraphicQueueLookup;

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<TMP_Text> m_GraphicRebuildQueue;

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0x30")]
		private readonly HashSet<int> m_InternalUpdateLookup;

		// Token: 0x040005FB RID: 1531
		[Token(Token = "0x40005FB")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<TMP_Text> m_InternalUpdateQueue;

		// Token: 0x040005FC RID: 1532
		[Token(Token = "0x40005FC")]
		[FieldOffset(Offset = "0x40")]
		private readonly HashSet<int> m_CullingUpdateLookup;

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x40005FD")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<TMP_Text> m_CullingUpdateQueue;

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40005FE")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker k_RegisterTextObjectForUpdateMarker;

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker;

		// Token: 0x04000600 RID: 1536
		[Token(Token = "0x4000600")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker;

		// Token: 0x04000601 RID: 1537
		[Token(Token = "0x4000601")]
		[FieldOffset(Offset = "0x20")]
		private static ProfilerMarker k_UnregisterTextObjectForUpdateMarker;

		// Token: 0x04000602 RID: 1538
		[Token(Token = "0x4000602")]
		[FieldOffset(Offset = "0x28")]
		private static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker;
	}
}
