using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200637E RID: 25470
	[Token(Token = "0x200637E")]
	public class AutoChessShopSkillAndModuleEditCharListView : AutoChessShopBaseCharListView
	{
		// Token: 0x170056BF RID: 22207
		// (get) Token: 0x06024BDE RID: 150494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056BF")]
		public override AutoChessShopLevelCharGroupItemView groupCharChessItemPrefab
		{
			[Token(Token = "0x6024BDE")]
			[Address(RVA = "0x1FA3640", Offset = "0x1FA2240", VA = "0x181FA3640", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024BDF RID: 150495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BDF")]
		[Address(RVA = "0x1FA2D70", Offset = "0x1FA1970", VA = "0x181FA2D70")]
		public void Init(AutoChessShopPage page)
		{
		}

		// Token: 0x06024BE0 RID: 150496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BE0")]
		[Address(RVA = "0x1FA2DF0", Offset = "0x1FA19F0", VA = "0x181FA2DF0")]
		public void Render(AutoChessShopLevelCharGroupListViewModel listViewModel, AutoChessShopBaseCharListView.FocusParams focusParams)
		{
		}

		// Token: 0x06024BE1 RID: 150497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BE1")]
		[Address(RVA = "0x1FA30F0", Offset = "0x1FA1CF0", VA = "0x181FA30F0")]
		public void ResetViewSeqCache()
		{
		}

		// Token: 0x06024BE2 RID: 150498 RVA: 0x000C55C8 File Offset: 0x000C37C8
		[Token(Token = "0x6024BE2")]
		[Address(RVA = "0x1FA2CF0", Offset = "0x1FA18F0", VA = "0x181FA2CF0")]
		public int GetLeftMostFocusChessInfo(out float columnIndex)
		{
			return 0;
		}

		// Token: 0x06024BE3 RID: 150499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BE3")]
		[Address(RVA = "0x1FA3150", Offset = "0x1FA1D50", VA = "0x181FA3150")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024BE4 RID: 150500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BE4")]
		[Address(RVA = "0x1FA33D0", Offset = "0x1FA1FD0", VA = "0x181FA33D0")]
		private void _TryStartScrollCo(AutoChessShopBaseCharListView.FocusParams focusParams)
		{
		}

		// Token: 0x06024BE5 RID: 150501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024BE5")]
		[Address(RVA = "0x1FA32E0", Offset = "0x1FA1EE0", VA = "0x181FA32E0")]
		private IEnumerator _TryScrollToPos(AutoChessShopBaseCharListView.FocusParams focusParams)
		{
			return null;
		}

		// Token: 0x06024BE6 RID: 150502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BE6")]
		[Address(RVA = "0x1FA35A0", Offset = "0x1FA21A0", VA = "0x181FA35A0")]
		public AutoChessShopSkillAndModuleEditCharListView()
		{
		}

		// Token: 0x06024BE7 RID: 150503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024BE7")]
		[Address(RVA = "0x1F9F340", Offset = "0x1F9DF40", VA = "0x181F9F340")]
		private AutoChessShopLevelCharGroupItemView <>xLuaBaseProxy_get_groupCharChessItemPrefab()
		{
			return null;
		}

		// Token: 0x04033534 RID: 210228
		[Token(Token = "0x4033534")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessShopLevelCharGroupItemView _groupItemViewPrefab;

		// Token: 0x04033535 RID: 210229
		[Token(Token = "0x4033535")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _recycleLayoutList;

		// Token: 0x04033536 RID: 210230
		[Token(Token = "0x4033536")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x04033537 RID: 210231
		[Token(Token = "0x4033537")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x04033538 RID: 210232
		[Token(Token = "0x4033538")]
		[FieldOffset(Offset = "0x40")]
		private AutoChessShopCharListRecycleAdapter m_adapter;

		// Token: 0x04033539 RID: 210233
		[Token(Token = "0x4033539")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0403353A RID: 210234
		[Token(Token = "0x403353A")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine m_scrollToGroupCoroutine;

		// Token: 0x0403353B RID: 210235
		[Token(Token = "0x403353B")]
		[FieldOffset(Offset = "0x58")]
		private AutoChessShopPage m_page;

		// Token: 0x0403353C RID: 210236
		[Token(Token = "0x403353C")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_focusTween;

		// Token: 0x0403353D RID: 210237
		[Token(Token = "0x403353D")]
		[FieldOffset(Offset = "0x68")]
		private int m_cachedRefreshSequenceNum;

		// Token: 0x0403353E RID: 210238
		[Token(Token = "0x403353E")]
		[FieldOffset(Offset = "0x70")]
		private AutoChessShopBaseCharListView.FocusCoreLogic m_focusLogic;

		// Token: 0x0403353F RID: 210239
		[Token(Token = "0x403353F")]
		private const float CHAR_CARD_BOUNDS_MARGIN = 28f;

		// Token: 0x04033540 RID: 210240
		[Token(Token = "0x4033540")]
		private const float GROUP_VIEW_HEADER_WIDTH = 120f;

		// Token: 0x04033541 RID: 210241
		[Token(Token = "0x4033541")]
		private const float GROUP_VIEW_ELEMENT_WIDTH = 208f;

		// Token: 0x04033542 RID: 210242
		[Token(Token = "0x4033542")]
		private const float GROUP_VIEW_ELEMENT_SPACING = 28f;

		// Token: 0x04033543 RID: 210243
		[Token(Token = "0x4033543")]
		private const float FOCUS_TWEEN_DUR = 0.6f;

		// Token: 0x04033544 RID: 210244
		[Token(Token = "0x4033544")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupCharChessItemPrefab;

		// Token: 0x04033545 RID: 210245
		[Token(Token = "0x4033545")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04033546 RID: 210246
		[Token(Token = "0x4033546")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033547 RID: 210247
		[Token(Token = "0x4033547")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetViewSeqCache;

		// Token: 0x04033548 RID: 210248
		[Token(Token = "0x4033548")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetLeftMostFocusChessInfo;

		// Token: 0x04033549 RID: 210249
		[Token(Token = "0x4033549")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403354A RID: 210250
		[Token(Token = "0x403354A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryStartScrollCo;

		// Token: 0x0403354B RID: 210251
		[Token(Token = "0x403354B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryScrollToPos;

		// Token: 0x0403354C RID: 210252
		[Token(Token = "0x403354C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
