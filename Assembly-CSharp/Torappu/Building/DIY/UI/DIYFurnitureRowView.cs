using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200198F RID: 6543
	[Token(Token = "0x200198F")]
	public class DIYFurnitureRowView : DIYFurnitureVerticalListElementView
	{
		// Token: 0x0600A41C RID: 42012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A41C")]
		[Address(RVA = "0x31DC8F0", Offset = "0x31DB4F0", VA = "0x1831DC8F0")]
		public void OnInit(List<DIYItemViewData> itemViewDatas, DIYViewListModel.DIYViewListThemeState themeState, bool firstRow = true)
		{
		}

		// Token: 0x0600A41D RID: 42013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A41D")]
		[Address(RVA = "0x31DD0D0", Offset = "0x31DBCD0", VA = "0x1831DD0D0")]
		private void _UpdateItemView(List<DIYItemViewData> itemViewDatas, bool firstRow)
		{
		}

		// Token: 0x0600A41E RID: 42014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A41E")]
		[Address(RVA = "0x31DCD70", Offset = "0x31DB970", VA = "0x1831DCD70")]
		private void _AppendNewItemView(List<DIYItemViewData> itemViewDatas, int begin, int count, bool firstRow)
		{
		}

		// Token: 0x0600A41F RID: 42015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A41F")]
		[Address(RVA = "0x31DCF50", Offset = "0x31DBB50", VA = "0x1831DCF50")]
		private void _FillWithEmptyView()
		{
		}

		// Token: 0x0600A420 RID: 42016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A420")]
		[Address(RVA = "0x31DD2A0", Offset = "0x31DBEA0", VA = "0x1831DD2A0")]
		public DIYFurnitureRowView()
		{
		}

		// Token: 0x04009B32 RID: 39730
		[Token(Token = "0x4009B32")]
		private const int LIST_VIEW_COLUMN_COUNT = 6;

		// Token: 0x04009B33 RID: 39731
		[Token(Token = "0x4009B33")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04009B34 RID: 39732
		[Token(Token = "0x4009B34")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DIYRecycleElementView _prefab;

		// Token: 0x04009B35 RID: 39733
		[Token(Token = "0x4009B35")]
		[FieldOffset(Offset = "0x30")]
		private List<DIYRecycleElementView> m_furnitureItemViews;

		// Token: 0x04009B36 RID: 39734
		[Token(Token = "0x4009B36")]
		[FieldOffset(Offset = "0x38")]
		private DIYRecycleElementView.ElementType m_elementType;

		// Token: 0x04009B37 RID: 39735
		[Token(Token = "0x4009B37")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_needEmptyItem;

		// Token: 0x04009B38 RID: 39736
		[Token(Token = "0x4009B38")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Func<DIYItemViewData, bool> furnitureSelected;

		// Token: 0x04009B39 RID: 39737
		[Token(Token = "0x4009B39")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Func<DIYItemViewData, bool> infoButtonPressed;

		// Token: 0x04009B3A RID: 39738
		[Token(Token = "0x4009B3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04009B3B RID: 39739
		[Token(Token = "0x4009B3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateItemView;

		// Token: 0x04009B3C RID: 39740
		[Token(Token = "0x4009B3C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__AppendNewItemView;

		// Token: 0x04009B3D RID: 39741
		[Token(Token = "0x4009B3D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FillWithEmptyView;

		// Token: 0x04009B3E RID: 39742
		[Token(Token = "0x4009B3E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
