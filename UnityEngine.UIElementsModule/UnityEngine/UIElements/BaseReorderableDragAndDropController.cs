using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200016C RID: 364
	[Token(Token = "0x200016C")]
	internal abstract class BaseReorderableDragAndDropController : ICollectionDragAndDropController, IDragAndDropController<IListDragAndDropArgs>, IReorderable
	{
		// Token: 0x06000A4C RID: 2636 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "9")]
		public IEnumerable<int> GetSortedSelectedIds()
		{
			return null;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x5AD7620", Offset = "0x5AD6220", VA = "0x185AD7620")]
		public BaseReorderableDragAndDropController(BaseVerticalCollectionView view)
		{
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x00005A78 File Offset: 0x00003C78
		// (set) Token: 0x06000A4F RID: 2639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023A")]
		public virtual bool enableReordering
		{
			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00005A90 File Offset: 0x00003C90
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x5AD7120", Offset = "0x5AD5D20", VA = "0x185AD7120", Slot = "14")]
		public virtual bool CanStartDrag(IEnumerable<int> itemIndices)
		{
			return default(bool);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x5AD7180", Offset = "0x5AD5D80", VA = "0x185AD7180", Slot = "15")]
		public virtual StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false)
		{
			return default(StartDragArgs);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x5AD7160", Offset = "0x5AD5D60", VA = "0x185AD7160", Slot = "16")]
		protected virtual int CompareId(int id1, int id2)
		{
			return 0;
		}

		// Token: 0x06000A53 RID: 2643
		[Token(Token = "0x6000A53")]
		public abstract DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args);

		// Token: 0x06000A54 RID: 2644
		[Token(Token = "0x6000A54")]
		public abstract void OnDrop(IListDragAndDropArgs args);

		// Token: 0x06000A55 RID: 2645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
		public virtual void DragCleanup()
		{
		}

		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x40005C3")]
		[FieldOffset(Offset = "0x10")]
		protected readonly BaseVerticalCollectionView m_View;

		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		[FieldOffset(Offset = "0x18")]
		protected List<int> m_SortedSelectedIds;
	}
}
