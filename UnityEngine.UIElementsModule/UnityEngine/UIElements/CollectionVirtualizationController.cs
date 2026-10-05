using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	internal abstract class CollectionVirtualizationController
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000660 RID: 1632
		// (set) Token: 0x06000661 RID: 1633
		[Token(Token = "0x17000155")]
		public abstract int firstVisibleIndex { [Token(Token = "0x6000660")] get; [Token(Token = "0x6000661")] protected set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000662 RID: 1634
		[Token(Token = "0x17000156")]
		public abstract int visibleItemCount { [Token(Token = "0x6000662")] get; }

		// Token: 0x06000663 RID: 1635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		protected CollectionVirtualizationController(ScrollView scrollView)
		{
		}

		// Token: 0x06000664 RID: 1636
		[Token(Token = "0x6000664")]
		public abstract void Refresh(bool rebuild);

		// Token: 0x06000665 RID: 1637
		[Token(Token = "0x6000665")]
		public abstract void ScrollToItem(int id);

		// Token: 0x06000666 RID: 1638
		[Token(Token = "0x6000666")]
		public abstract void Resize(Vector2 size);

		// Token: 0x06000667 RID: 1639
		[Token(Token = "0x6000667")]
		public abstract void OnScroll(Vector2 offset);

		// Token: 0x06000668 RID: 1640
		[Token(Token = "0x6000668")]
		public abstract int GetIndexFromPosition(Vector2 position);

		// Token: 0x06000669 RID: 1641
		[Token(Token = "0x6000669")]
		public abstract float GetExpectedItemHeight(int index);

		// Token: 0x0600066A RID: 1642
		[Token(Token = "0x600066A")]
		public abstract float GetExpectedContentHeight();

		// Token: 0x0600066B RID: 1643
		[Token(Token = "0x600066B")]
		public abstract void OnFocus(VisualElement leafTarget);

		// Token: 0x0600066C RID: 1644
		[Token(Token = "0x600066C")]
		public abstract void OnBlur(VisualElement willFocus);

		// Token: 0x0600066D RID: 1645
		[Token(Token = "0x600066D")]
		public abstract void UpdateBackground();

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600066E RID: 1646
		[Token(Token = "0x17000157")]
		public abstract IEnumerable<ReusableCollectionItem> activeItems { [Token(Token = "0x600066E")] get; }

		// Token: 0x0600066F RID: 1647
		[Token(Token = "0x600066F")]
		internal abstract void StartDragItem(ReusableCollectionItem item);

		// Token: 0x06000670 RID: 1648
		[Token(Token = "0x6000670")]
		internal abstract void EndDrag(int dropIndex);

		// Token: 0x04000326 RID: 806
		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x10")]
		protected readonly ScrollView m_ScrollView;
	}
}
