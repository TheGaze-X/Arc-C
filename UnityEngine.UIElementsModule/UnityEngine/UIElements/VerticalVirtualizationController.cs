using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Pool;

namespace UnityEngine.UIElements
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	internal abstract class VerticalVirtualizationController<T> : CollectionVirtualizationController where T : ReusableCollectionItem, new()
	{
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000167")]
		public override IEnumerable<ReusableCollectionItem> activeItems
		{
			[Token(Token = "0x60006C6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x17000168")]
		internal int itemsCount
		{
			[Token(Token = "0x60006C7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x60006C8")]
		protected virtual bool VisibleItemPredicate(T i)
		{
			return default(bool);
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000169")]
		internal T firstVisibleItem
		{
			[Token(Token = "0x60006C9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700016A")]
		internal T lastVisibleItem
		{
			[Token(Token = "0x60006CA")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x1700016B")]
		public override int visibleItemCount
		{
			[Token(Token = "0x60006CB")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700016C")]
		protected SerializedVirtualizationData serializedData
		{
			[Token(Token = "0x60006CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00004DB8 File Offset: 0x00002FB8
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016D")]
		public override int firstVisibleIndex
		{
			[Token(Token = "0x60006CD")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60006CE")]
			protected set
			{
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x1700016E")]
		protected float lastHeight
		{
			[Token(Token = "0x60006CF")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x1700016F")]
		protected virtual bool alwaysRebindOnRefresh
		{
			[Token(Token = "0x60006D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D1")]
		protected VerticalVirtualizationController(BaseVerticalCollectionView collectionView)
		{
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D2")]
		public override void Refresh(bool rebuild)
		{
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D3")]
		protected void Setup(T recycledItem, int newIndex)
		{
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D4")]
		public override void OnFocus(VisualElement leafTarget)
		{
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D5")]
		public override void OnBlur(VisualElement willFocus)
		{
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D6")]
		private void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex)
		{
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D7")]
		public override void UpdateBackground()
		{
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D8")]
		internal override void StartDragItem(ReusableCollectionItem item)
		{
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D9")]
		internal override void EndDrag(int dropIndex)
		{
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60006DA")]
		internal virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1)
		{
			return null;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006DB")]
		internal virtual void ReleaseItem(int activeItemsIndex)
		{
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x60006DC")]
		protected int GetDraggedIndex()
		{
			return 0;
		}

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x0")]
		private readonly ObjectPool<T> m_Pool;

		// Token: 0x04000351 RID: 849
		[Token(Token = "0x4000351")]
		[FieldOffset(Offset = "0x0")]
		protected BaseVerticalCollectionView m_CollectionView;

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x0")]
		protected List<T> m_ActiveItems;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x0")]
		protected T m_DraggedItem;

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x0")]
		private int m_LastFocusedElementIndex;

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x0")]
		private List<int> m_LastFocusedElementTreeChildIndexes;

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x0")]
		protected readonly Func<T, bool> m_VisibleItemPredicateDelegate;

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x0")]
		protected List<T> m_ScrollInsertionList;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x0")]
		private VisualElement m_EmptyRows;
	}
}
