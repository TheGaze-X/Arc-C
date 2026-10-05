using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	internal class FixedHeightVirtualizationController<T> : VerticalVirtualizationController<T> where T : ReusableCollectionItem, new()
	{
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x1700015F")]
		private float resolvedItemHeight
		{
			[Token(Token = "0x600069F")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x60006A0")]
		protected override bool VisibleItemPredicate(T i)
		{
			return default(bool);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A1")]
		public FixedHeightVirtualizationController(BaseVerticalCollectionView collectionView)
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x60006A2")]
		public override int GetIndexFromPosition(Vector2 position)
		{
			return 0;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x60006A3")]
		public override float GetExpectedItemHeight(int index)
		{
			return 0f;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x60006A4")]
		public override float GetExpectedContentHeight()
		{
			return 0f;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A5")]
		public override void ScrollToItem(int index)
		{
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A6")]
		public override void Resize(Vector2 size)
		{
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A7")]
		public override void OnScroll(Vector2 scrollOffset)
		{
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60006A8")]
		internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1)
		{
			return null;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A9")]
		internal override void EndDrag(int dropIndex)
		{
		}
	}
}
