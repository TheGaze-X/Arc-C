using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200017F RID: 383
	[Token(Token = "0x200017F")]
	internal class ListViewDraggerAnimated : ListViewDragger
	{
		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00005C70 File Offset: 0x00003E70
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000258")]
		public bool isDragging
		{
			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x32F71F0", Offset = "0x32F5DF0", VA = "0x1832F71F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x32F7210", Offset = "0x32F5E10", VA = "0x1832F7210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000259")]
		public ReusableCollectionItem draggedItem
		{
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00005C88 File Offset: 0x00003E88
		[Token(Token = "0x1700025A")]
		protected override bool supportsDragEvents
		{
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x5AE30B0", Offset = "0x5AE1CB0", VA = "0x185AE30B0")]
		public ListViewDraggerAnimated(BaseVerticalCollectionView listView)
		{
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x5AE2060", Offset = "0x5AE0C60", VA = "0x185AE2060", Slot = "7")]
		protected internal override StartDragArgs StartDrag(Vector3 pointerPosition)
		{
			return default(StartDragArgs);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x5AE2880", Offset = "0x5AE1480", VA = "0x185AE2880", Slot = "8")]
		protected internal override void UpdateDrag(Vector3 pointerPosition)
		{
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x5AE1860", Offset = "0x5AE0460", VA = "0x185AE1860")]
		private void Animate(ReusableCollectionItem element, float paddingTop)
		{
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x5AE1C70", Offset = "0x5AE0870", VA = "0x185AE1C70", Slot = "9")]
		protected internal override void OnDrop(Vector3 pointerPosition)
		{
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		protected override void ClearDragAndDropUI(bool dragCancelled)
		{
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00005CB8 File Offset: 0x00003EB8
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x5AE2840", Offset = "0x5AE1440", VA = "0x185AE2840", Slot = "11")]
		protected override bool TryGetDragPosition(Vector2 pointerPosition, ref ListViewDragger.DragPosition dragPosition)
		{
			return default(bool);
		}

		// Token: 0x040005F4 RID: 1524
		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0x78")]
		private int m_DragStartIndex;

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x7C")]
		private int m_CurrentIndex;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x80")]
		private float m_SelectionHeight;

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x84")]
		private float m_LocalOffsetOnStart;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 m_CurrentPointerPosition;

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x98")]
		private ReusableCollectionItem m_Item;

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0xA0")]
		private ReusableCollectionItem m_OffsetItem;
	}
}
