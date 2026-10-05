using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200017C RID: 380
	[Token(Token = "0x200017C")]
	internal class ListViewDragger : DragEventsProcessor
	{
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000255")]
		protected BaseVerticalCollectionView targetView
		{
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x5AE6860", Offset = "0x5AE5460", VA = "0x185AE6860")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000256")]
		protected ScrollView targetScrollView
		{
			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x5AE6830", Offset = "0x5AE5430", VA = "0x185AE6830")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000257")]
		public ICollectionDragAndDropController dragAndDropController
		{
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x5AE30B0", Offset = "0x5AE1CB0", VA = "0x185AE30B0")]
		public ListViewDragger(BaseVerticalCollectionView listView)
		{
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00005B98 File Offset: 0x00003D98
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x5AE3D00", Offset = "0x5AE2900", VA = "0x185AE3D00", Slot = "6")]
		protected override bool CanStartDrag(Vector3 pointerPosition)
		{
			return default(bool);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x5AE5DD0", Offset = "0x5AE49D0", VA = "0x185AE5DD0", Slot = "7")]
		protected internal override StartDragArgs StartDrag(Vector3 pointerPosition)
		{
			return default(StartDragArgs);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x5AE64B0", Offset = "0x5AE50B0", VA = "0x185AE64B0", Slot = "8")]
		protected internal override void UpdateDrag(Vector3 pointerPosition)
		{
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x5AE4820", Offset = "0x5AE3420", VA = "0x185AE4820")]
		private DragVisualMode GetVisualMode(Vector3 pointerPosition, ref ListViewDragger.DragPosition dragPosition)
		{
			return DragVisualMode.None;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x5AE5690", Offset = "0x5AE4290", VA = "0x185AE5690", Slot = "9")]
		protected internal override void OnDrop(Vector3 pointerPosition)
		{
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x5AE4960", Offset = "0x5AE3560", VA = "0x185AE4960")]
		internal void HandleDragAndScroll(Vector2 pointerPosition)
		{
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x5AE3520", Offset = "0x5AE2120", VA = "0x185AE3520")]
		protected void ApplyDragAndDropUI(ListViewDragger.DragPosition dragPosition)
		{
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x5AE6000", Offset = "0x5AE4C00", VA = "0x185AE6000", Slot = "11")]
		protected virtual bool TryGetDragPosition(Vector2 pointerPosition, ref ListViewDragger.DragPosition dragPosition)
		{
			return default(bool);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x5AE5390", Offset = "0x5AE3F90", VA = "0x185AE5390")]
		private void HandleTreePosition(Vector2 pointerPosition, ref ListViewDragger.DragPosition dragPosition)
		{
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x5AE4C60", Offset = "0x5AE3860", VA = "0x185AE4C60")]
		private void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(ref ListViewDragger.DragPosition dragPosition, Vector2 pointerPosition)
		{
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x5AE4410", Offset = "0x5AE3010", VA = "0x185AE4410")]
		private void GetPreviousAndNextItemsIgnoringDraggedItems(int insertAtIndex, out int previousItemId, out int nextItemId)
		{
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x5AE54B0", Offset = "0x5AE40B0", VA = "0x185AE54B0")]
		protected DragAndDropArgs MakeDragAndDropArgs(ListViewDragger.DragPosition dragPosition)
		{
			return default(DragAndDropArgs);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x5AE4300", Offset = "0x5AE2F00", VA = "0x185AE4300")]
		private float GetHoverBarTopPosition(ReusableCollectionItem item)
		{
			return 0f;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x5AE5870", Offset = "0x5AE4470", VA = "0x185AE5870")]
		private void PlaceHoverBarAtElement(ReusableCollectionItem item)
		{
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x5AE59B0", Offset = "0x5AE45B0", VA = "0x185AE59B0")]
		private void PlaceHoverBarAt(float top, float indentationPadding = -1f, float siblingBottom = -1f)
		{
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x5AE3F00", Offset = "0x5AE2B00", VA = "0x185AE3F00", Slot = "10")]
		protected override void ClearDragAndDropUI(bool dragCancelled)
		{
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x5AE4610", Offset = "0x5AE3210", VA = "0x185AE4610")]
		protected ReusableCollectionItem GetRecycledItem(Vector3 pointerPosition)
		{
			return null;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x5AE63E0", Offset = "0x5AE4FE0", VA = "0x185AE63E0")]
		[CompilerGenerated]
		private void <ApplyDragAndDropUI>g__GeometryChangedCallback|26_0(GeometryChangedEvent e)
		{
		}

		// Token: 0x040005E8 RID: 1512
		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x30")]
		private ListViewDragger.DragPosition m_LastDragPosition;

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x40005E9")]
		[FieldOffset(Offset = "0x50")]
		private VisualElement m_DragHoverBar;

		// Token: 0x040005EA RID: 1514
		[Token(Token = "0x40005EA")]
		[FieldOffset(Offset = "0x58")]
		private VisualElement m_DragHoverItemMarker;

		// Token: 0x040005EB RID: 1515
		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0x60")]
		private VisualElement m_DragHoverSiblingMarker;

		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x68")]
		private float m_LeftIndentation;

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x6C")]
		private float m_SiblingBottom;

		// Token: 0x0200017D RID: 381
		[Token(Token = "0x200017D")]
		internal struct DragPosition : IEquatable<ListViewDragger.DragPosition>
		{
			// Token: 0x06000AB7 RID: 2743 RVA: 0x00005C28 File Offset: 0x00003E28
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x5ADA1C0", Offset = "0x5AD8DC0", VA = "0x185ADA1C0", Slot = "4")]
			public bool Equals(ListViewDragger.DragPosition other)
			{
				return default(bool);
			}

			// Token: 0x06000AB8 RID: 2744 RVA: 0x00005C40 File Offset: 0x00003E40
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x5ADA0F0", Offset = "0x5AD8CF0", VA = "0x185ADA0F0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06000AB9 RID: 2745 RVA: 0x00005C58 File Offset: 0x00003E58
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x5ADA240", Offset = "0x5AD8E40", VA = "0x185ADA240", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x040005EF RID: 1519
			[Token(Token = "0x40005EF")]
			[FieldOffset(Offset = "0x0")]
			public int insertAtIndex;

			// Token: 0x040005F0 RID: 1520
			[Token(Token = "0x40005F0")]
			[FieldOffset(Offset = "0x4")]
			public int parentId;

			// Token: 0x040005F1 RID: 1521
			[Token(Token = "0x40005F1")]
			[FieldOffset(Offset = "0x8")]
			public int childIndex;

			// Token: 0x040005F2 RID: 1522
			[Token(Token = "0x40005F2")]
			[FieldOffset(Offset = "0x10")]
			public ReusableCollectionItem recycledItem;

			// Token: 0x040005F3 RID: 1523
			[Token(Token = "0x40005F3")]
			[FieldOffset(Offset = "0x18")]
			public DragAndDropPosition dropPosition;
		}
	}
}
