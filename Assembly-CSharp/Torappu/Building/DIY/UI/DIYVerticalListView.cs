using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019AE RID: 6574
	[Token(Token = "0x20019AE")]
	public class DIYVerticalListView : DIYListView
	{
		// Token: 0x0600A526 RID: 42278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A526")]
		[Address(RVA = "0x31FA810", Offset = "0x31F9410", VA = "0x1831FA810", Slot = "4")]
		public override void Render(DIYViewListData data, DIYViewListData funcData, DIYFurnitureExpandViewList.DIYViewDataOptions options)
		{
		}

		// Token: 0x0600A527 RID: 42279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A527")]
		[Address(RVA = "0x31FB1C0", Offset = "0x31F9DC0", VA = "0x1831FB1C0")]
		private void _RenderWithoutTitle(DIYViewListData data, DIYViewListModel.DIYViewListThemeState themeState)
		{
		}

		// Token: 0x0600A528 RID: 42280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A528")]
		[Address(RVA = "0x31FAF00", Offset = "0x31F9B00", VA = "0x1831FAF00")]
		private void _RenderWithGroupTitle(DIYViewListData data, DIYViewListData funcData)
		{
		}

		// Token: 0x0600A529 RID: 42281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A529")]
		[Address(RVA = "0x31FABA0", Offset = "0x31F97A0", VA = "0x1831FABA0")]
		private void _RenderWithFuncTitle(DIYViewListData data, DIYViewListData funcData)
		{
		}

		// Token: 0x0600A52A RID: 42282 RVA: 0x000400F8 File Offset: 0x0003E2F8
		[Token(Token = "0x600A52A")]
		[Address(RVA = "0x31FA3F0", Offset = "0x31F8FF0", VA = "0x1831FA3F0", Slot = "5")]
		public override int GetCurrIndex()
		{
			return 0;
		}

		// Token: 0x0600A52B RID: 42283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A52B")]
		[Address(RVA = "0x31FB2F0", Offset = "0x31F9EF0", VA = "0x1831FB2F0")]
		public DIYVerticalListView()
		{
		}

		// Token: 0x04009C82 RID: 40066
		[Token(Token = "0x4009C82")]
		private const int LIST_VIEW_COLUMN_COUNT = 6;

		// Token: 0x04009C83 RID: 40067
		[Token(Token = "0x4009C83")]
		private const int FOCUS_POS_OFFSET = 20;

		// Token: 0x04009C84 RID: 40068
		[Token(Token = "0x4009C84")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _layout;

		// Token: 0x04009C85 RID: 40069
		[Token(Token = "0x4009C85")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x04009C86 RID: 40070
		[Token(Token = "0x4009C86")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04009C87 RID: 40071
		[Token(Token = "0x4009C87")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04009C88 RID: 40072
		[Token(Token = "0x4009C88")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DIYFurnitureRowView _rowPrefab;

		// Token: 0x04009C89 RID: 40073
		[Token(Token = "0x4009C89")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private DIYFurnitureTitleView _titlePrefab;

		// Token: 0x04009C8A RID: 40074
		[Token(Token = "0x4009C8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04009C8B RID: 40075
		[Token(Token = "0x4009C8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderWithoutTitle;

		// Token: 0x04009C8C RID: 40076
		[Token(Token = "0x4009C8C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderWithGroupTitle;

		// Token: 0x04009C8D RID: 40077
		[Token(Token = "0x4009C8D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderWithFuncTitle;

		// Token: 0x04009C8E RID: 40078
		[Token(Token = "0x4009C8E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCurrIndex;

		// Token: 0x04009C8F RID: 40079
		[Token(Token = "0x4009C8F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
