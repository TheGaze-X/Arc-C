using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	public class TMP_UpdateRegistry
	{
		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000172")]
		public static TMP_UpdateRegistry instance
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x58DBBE0", Offset = "0x58DA7E0", VA = "0x1858DBBE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x58DBA50", Offset = "0x58DA650", VA = "0x1858DBA50")]
		protected TMP_UpdateRegistry()
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x58DB770", Offset = "0x58DA370", VA = "0x1858DB770")]
		public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00004860 File Offset: 0x00002A60
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x58DAFD0", Offset = "0x58D9BD0", VA = "0x1858DAFD0")]
		private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			return default(bool);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x58DB740", Offset = "0x58DA340", VA = "0x1858DB740")]
		public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x58DAE50", Offset = "0x58D9A50", VA = "0x1858DAE50")]
		private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			return default(bool);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x58DB3F0", Offset = "0x58D9FF0", VA = "0x1858DB3F0")]
		private void PerformUpdateForCanvasRendererObjects()
		{
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x58DB6E0", Offset = "0x58DA2E0", VA = "0x1858DB6E0")]
		private void PerformUpdateForMeshRendererObjects()
		{
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x58DB7A0", Offset = "0x58DA3A0", VA = "0x1858DB7A0")]
		public static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x58DB2A0", Offset = "0x58D9EA0", VA = "0x1858DB2A0")]
		private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x58DB150", Offset = "0x58D9D50", VA = "0x1858DB150")]
		private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
		}

		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		[FieldOffset(Offset = "0x0")]
		private static TMP_UpdateRegistry s_Instance;

		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<ICanvasElement> m_LayoutRebuildQueue;

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<int> m_LayoutQueueLookup;

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<ICanvasElement> m_GraphicRebuildQueue;

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<int> m_GraphicQueueLookup;
	}
}
