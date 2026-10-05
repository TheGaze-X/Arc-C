using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	internal class DynamicHeightVirtualizationController<T> : VerticalVirtualizationController<T> where T : ReusableCollectionItem, new()
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00004B30 File Offset: 0x00002D30
		[Token(Token = "0x17000158")]
		private float defaultExpectedHeight
		{
			[Token(Token = "0x6000671")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00004B48 File Offset: 0x00002D48
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000159")]
		private float contentPadding
		{
			[Token(Token = "0x6000672")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000673")]
			set
			{
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00004B60 File Offset: 0x00002D60
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015A")]
		private float contentHeight
		{
			[Token(Token = "0x6000674")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000675")]
			set
			{
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00004B78 File Offset: 0x00002D78
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015B")]
		private int anchoredIndex
		{
			[Token(Token = "0x6000676")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000677")]
			set
			{
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00004B90 File Offset: 0x00002D90
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015C")]
		private float anchorOffset
		{
			[Token(Token = "0x6000678")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000679")]
			set
			{
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x1700015D")]
		private float viewportMaxOffset
		{
			[Token(Token = "0x600067A")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[Token(Token = "0x1700015E")]
		protected override bool alwaysRebindOnRefresh
		{
			[Token(Token = "0x600067B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067C")]
		public DynamicHeightVirtualizationController(BaseVerticalCollectionView collectionView)
		{
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067D")]
		public override void Refresh(bool rebuild)
		{
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067E")]
		public override void ScrollToItem(int index)
		{
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600067F")]
		public override void Resize(Vector2 size)
		{
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000680")]
		public override void OnScroll(Vector2 scrollOffset)
		{
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000681")]
		private void OnScrollUpdate()
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000682")]
		private void CycleItems(int firstIndex)
		{
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Token(Token = "0x6000683")]
		private bool NeedsFill()
		{
			return default(bool);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000684")]
		private void Fill()
		{
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000685")]
		private void UpdateScrollViewContainer(float previousHeight, float newHeight)
		{
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000686")]
		private void ApplyScrollViewUpdate(bool dimensionsOnly = false)
		{
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000687")]
		private void UpdateAnchor()
		{
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000688")]
		private void ScheduleFill()
		{
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000689")]
		private void ScheduleScroll()
		{
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068A")]
		private void ScheduleScrollDirectionReset()
		{
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600068B")]
		private void ResetScroll()
		{
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x600068C")]
		public override int GetIndexFromPosition(Vector2 position)
		{
			return 0;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x600068D")]
		public override float GetExpectedItemHeight(int index)
		{
			return 0f;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x600068E")]
		private int GetFirstVisibleItem(float offset)
		{
			return 0;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x600068F")]
		public override float GetExpectedContentHeight()
		{
			return 0f;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x6000690")]
		private float GetContentHeightForIndex(int lastIndex)
		{
			return 0f;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x6000691")]
		private DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo GetCachedContentHeight(int index)
		{
			return default(DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000692")]
		private void RegisterItemHeight(int index, float height)
		{
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000693")]
		private void UnregisterItemHeight(int index)
		{
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000694")]
		private void CleanItemHeightCache()
		{
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000695")]
		private void OnRecycledItemGeometryChanged(ReusableCollectionItem item)
		{
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x6000696")]
		private bool UpdateRegisteredHeight(ReusableCollectionItem item)
		{
			return default(bool);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000697")]
		internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1)
		{
			return null;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000698")]
		internal override void ReleaseItem(int activeItemsIndex)
		{
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000699")]
		internal override void StartDragItem(ReusableCollectionItem item)
		{
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069A")]
		internal override void EndDrag(int dropIndex)
		{
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069B")]
		private void HideItem(int activeItemsIndex)
		{
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069C")]
		private void MarkWaitingForLayout(T item)
		{
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x600069D")]
		private bool IsIndexOutOfBounds(int i)
		{
			return default(bool);
		}

		// Token: 0x04000327 RID: 807
		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x0")]
		private int m_HighestCachedIndex;

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<int, float> m_ItemHeightCache;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<int, DynamicHeightVirtualizationController<T>.ContentHeightCacheInfo> m_ContentHeightCache;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x0")]
		private readonly HashSet<int> m_WaitingCache;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ForcedFirstVisibleItem;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ForcedLastVisibleItem;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x0")]
		private bool m_StickToBottom;

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x0")]
		private DynamicHeightVirtualizationController<T>.VirtualizationChange m_LastChange;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x0")]
		private DynamicHeightVirtualizationController<T>.ScrollDirection m_ScrollDirection;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[FieldOffset(Offset = "0x0")]
		private Vector2 m_DelayedScrollOffset;

		// Token: 0x04000331 RID: 817
		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x0")]
		private float m_AccumulatedHeight;

		// Token: 0x04000332 RID: 818
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x0")]
		private float m_MinimumItemHeight;

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x0")]
		private Action m_FillCallback;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x0")]
		private Action m_ScrollCallback;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x0")]
		private Action m_ScrollResetCallback;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x0")]
		private Action<ReusableCollectionItem> m_GeometryChangedCallback;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x0")]
		private IVisualElementScheduledItem m_ScheduledItem;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x0")]
		private IVisualElementScheduledItem m_ScrollScheduledItem;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x0")]
		private IVisualElementScheduledItem m_ScrollResetScheduledItem;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x0")]
		private Predicate<int> m_IndexOutOfBoundsPredicate;

		// Token: 0x020000E6 RID: 230
		[Token(Token = "0x20000E6")]
		private readonly struct ContentHeightCacheInfo
		{
			// Token: 0x0600069E RID: 1694 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600069E")]
			public ContentHeightCacheInfo(float sum, int count)
			{
			}

			// Token: 0x0400033B RID: 827
			[Token(Token = "0x400033B")]
			[FieldOffset(Offset = "0x0")]
			public readonly float sum;

			// Token: 0x0400033C RID: 828
			[Token(Token = "0x400033C")]
			[FieldOffset(Offset = "0x0")]
			public readonly int count;
		}

		// Token: 0x020000E7 RID: 231
		[Token(Token = "0x20000E7")]
		private enum VirtualizationChange
		{
			// Token: 0x0400033E RID: 830
			[Token(Token = "0x400033E")]
			None,
			// Token: 0x0400033F RID: 831
			[Token(Token = "0x400033F")]
			Resize,
			// Token: 0x04000340 RID: 832
			[Token(Token = "0x4000340")]
			Scroll,
			// Token: 0x04000341 RID: 833
			[Token(Token = "0x4000341")]
			ForcedScroll
		}

		// Token: 0x020000E8 RID: 232
		[Token(Token = "0x20000E8")]
		private enum ScrollDirection
		{
			// Token: 0x04000343 RID: 835
			[Token(Token = "0x4000343")]
			Idle,
			// Token: 0x04000344 RID: 836
			[Token(Token = "0x4000344")]
			Up,
			// Token: 0x04000345 RID: 837
			[Token(Token = "0x4000345")]
			Down
		}
	}
}
