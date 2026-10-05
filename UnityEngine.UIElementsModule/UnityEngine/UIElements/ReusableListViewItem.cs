using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	internal class ReusableListViewItem : ReusableCollectionItem
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000166")]
		public override VisualElement rootElement
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x55F8120", Offset = "0x55F6D20", VA = "0x1855F8120", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x5ABCA20", Offset = "0x5ABB620", VA = "0x185ABCA20")]
		public void Init(VisualElement item, bool usesAnimatedDragger)
		{
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x5ABCF20", Offset = "0x5ABBB20", VA = "0x185ABCF20")]
		private void UpdateHierarchy(bool usesAnimatedDragger)
		{
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x5ABCD80", Offset = "0x5ABB980", VA = "0x185ABCD80")]
		public void UpdateDragHandle(bool needsDragHandle)
		{
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x5ABCA60", Offset = "0x5ABB660", VA = "0x185ABCA60", Slot = "6")]
		public override void PreAttachElement()
		{
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x5ABC820", Offset = "0x5ABB420", VA = "0x185ABC820", Slot = "7")]
		public override void DetachElement()
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x5ABCBE0", Offset = "0x5ABB7E0", VA = "0x185ABCBE0", Slot = "9")]
		public override void SetDragGhost(bool dragGhost)
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x5ABC630", Offset = "0x5ABB230", VA = "0x185ABC630")]
		public ReusableListViewItem()
		{
		}

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0x40")]
		private VisualElement m_Container;

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x48")]
		private VisualElement m_DragHandle;

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x50")]
		private VisualElement m_ItemContainer;
	}
}
