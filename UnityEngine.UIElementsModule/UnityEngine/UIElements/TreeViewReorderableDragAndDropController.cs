using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements
{
	// Token: 0x02000181 RID: 385
	[Token(Token = "0x2000181")]
	internal class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController
	{
		// Token: 0x06000ACA RID: 2762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x5AECA80", Offset = "0x5AEB680", VA = "0x185AECA80")]
		public TreeViewReorderableDragAndDropController(TreeView view)
		{
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x5AEBC40", Offset = "0x5AEA840", VA = "0x185AEBC40", Slot = "16")]
		protected override int CompareId(int id1, int id2)
		{
			return 0;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00005D00 File Offset: 0x00003F00
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x5AEC9B0", Offset = "0x5AEB5B0", VA = "0x185AEC9B0", Slot = "15")]
		public override StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false)
		{
			return default(StartDragArgs);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00005D18 File Offset: 0x00003F18
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x5AEC300", Offset = "0x5AEAF00", VA = "0x185AEC300", Slot = "17")]
		public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args)
		{
			return DragVisualMode.None;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x5AEC3D0", Offset = "0x5AEAFD0", VA = "0x185AEC3D0", Slot = "18")]
		public override void OnDrop(IListDragAndDropArgs args)
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x5AEC290", Offset = "0x5AEAE90", VA = "0x185AEC290", Slot = "19")]
		public override void DragCleanup()
		{
		}

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x40005FD")]
		[FieldOffset(Offset = "0x28")]
		protected TreeViewReorderableDragAndDropController.DropData m_DropData;

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40005FE")]
		[FieldOffset(Offset = "0x30")]
		protected readonly TreeView m_TreeView;

		// Token: 0x02000182 RID: 386
		[Token(Token = "0x2000182")]
		protected class DropData
		{
			// Token: 0x06000AD0 RID: 2768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DropData()
			{
			}

			// Token: 0x040005FF RID: 1535
			[Token(Token = "0x40005FF")]
			[FieldOffset(Offset = "0x10")]
			public int[] draggedIds;
		}

		// Token: 0x02000183 RID: 387
		[Token(Token = "0x2000183")]
		private struct TreeItemState
		{
			// Token: 0x06000AD1 RID: 2769 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
			public TreeItemState(int parentId, int childIndex)
			{
			}

			// Token: 0x04000600 RID: 1536
			[Token(Token = "0x4000600")]
			[FieldOffset(Offset = "0x0")]
			public int parentId;

			// Token: 0x04000601 RID: 1537
			[Token(Token = "0x4000601")]
			[FieldOffset(Offset = "0x4")]
			public int childIndex;
		}
	}
}
