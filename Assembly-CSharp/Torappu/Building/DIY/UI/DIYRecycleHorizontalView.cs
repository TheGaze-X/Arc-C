using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019B6 RID: 6582
	[Token(Token = "0x20019B6")]
	public class DIYRecycleHorizontalView : DIYListView
	{
		// Token: 0x0600A556 RID: 42326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A556")]
		[Address(RVA = "0x31F6DF0", Offset = "0x31F59F0", VA = "0x1831F6DF0", Slot = "4")]
		public override void Render(DIYViewListData data, DIYViewListData funcData, DIYFurnitureExpandViewList.DIYViewDataOptions options)
		{
		}

		// Token: 0x0600A557 RID: 42327 RVA: 0x00040140 File Offset: 0x0003E340
		[Token(Token = "0x600A557")]
		[Address(RVA = "0x31F69E0", Offset = "0x31F55E0", VA = "0x1831F69E0", Slot = "5")]
		public override int GetCurrIndex()
		{
			return 0;
		}

		// Token: 0x0600A558 RID: 42328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A558")]
		[Address(RVA = "0x31F7570", Offset = "0x31F6170", VA = "0x1831F7570")]
		private void _InitIfNot(DIYViewListData data, DIYViewListData funcData)
		{
		}

		// Token: 0x0600A559 RID: 42329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A559")]
		[Address(RVA = "0x31F73D0", Offset = "0x31F5FD0", VA = "0x1831F73D0")]
		private void _FocusToIndex(int index)
		{
		}

		// Token: 0x0600A55A RID: 42330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A55A")]
		[Address(RVA = "0x31F7820", Offset = "0x31F6420", VA = "0x1831F7820")]
		public DIYRecycleHorizontalView()
		{
		}

		// Token: 0x04009CE9 RID: 40169
		[Token(Token = "0x4009CE9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DIYRecycleElementView _prefab;

		// Token: 0x04009CEA RID: 40170
		[Token(Token = "0x4009CEA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DIYRecycleElementView _emptyPrefab;

		// Token: 0x04009CEB RID: 40171
		[Token(Token = "0x4009CEB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _layout;

		// Token: 0x04009CEC RID: 40172
		[Token(Token = "0x4009CEC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04009CED RID: 40173
		[Token(Token = "0x4009CED")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x04009CEE RID: 40174
		[Token(Token = "0x4009CEE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04009CEF RID: 40175
		[Token(Token = "0x4009CEF")]
		[FieldOffset(Offset = "0x60")]
		private DIYRecycleHorizontalAdapter m_adapter;

		// Token: 0x04009CF0 RID: 40176
		[Token(Token = "0x4009CF0")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x04009CF1 RID: 40177
		[Token(Token = "0x4009CF1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04009CF2 RID: 40178
		[Token(Token = "0x4009CF2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCurrIndex;

		// Token: 0x04009CF3 RID: 40179
		[Token(Token = "0x4009CF3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04009CF4 RID: 40180
		[Token(Token = "0x4009CF4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FocusToIndex;

		// Token: 0x04009CF5 RID: 40181
		[Token(Token = "0x4009CF5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
