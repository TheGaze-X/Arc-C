using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006369 RID: 25449
	[Token(Token = "0x2006369")]
	public class AutoChessShopDetailCharListView : AutoChessShopBaseCharListView
	{
		// Token: 0x170056B2 RID: 22194
		// (get) Token: 0x06024B7C RID: 150396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056B2")]
		public override AutoChessShopLevelCharGroupItemView groupCharChessItemPrefab
		{
			[Token(Token = "0x6024B7C")]
			[Address(RVA = "0x1F9F840", Offset = "0x1F9E440", VA = "0x181F9F840", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024B7D RID: 150397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B7D")]
		[Address(RVA = "0x1F9EF60", Offset = "0x1F9DB60", VA = "0x181F9EF60")]
		public void Init(AutoChessShopPage page)
		{
		}

		// Token: 0x06024B7E RID: 150398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B7E")]
		[Address(RVA = "0x1F9EFE0", Offset = "0x1F9DBE0", VA = "0x181F9EFE0")]
		public void Render(AutoChessShopLevelCharGroupListViewModel listViewModel, AutoChessShopBaseCharListView.FocusParams focusParams)
		{
		}

		// Token: 0x06024B7F RID: 150399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B7F")]
		[Address(RVA = "0x1F9F2E0", Offset = "0x1F9DEE0", VA = "0x181F9F2E0")]
		public void ResetViewSeqCache()
		{
		}

		// Token: 0x06024B80 RID: 150400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B80")]
		[Address(RVA = "0x1F9F350", Offset = "0x1F9DF50", VA = "0x181F9F350")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024B81 RID: 150401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B81")]
		[Address(RVA = "0x1F9F5D0", Offset = "0x1F9E1D0", VA = "0x181F9F5D0")]
		private void _TryStartScrollCo(AutoChessShopBaseCharListView.FocusParams focusParams)
		{
		}

		// Token: 0x06024B82 RID: 150402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024B82")]
		[Address(RVA = "0x1F9F4E0", Offset = "0x1F9E0E0", VA = "0x181F9F4E0")]
		private IEnumerator _TryScrollToPos(AutoChessShopBaseCharListView.FocusParams focusParams)
		{
			return null;
		}

		// Token: 0x06024B83 RID: 150403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B83")]
		[Address(RVA = "0x1F9F7A0", Offset = "0x1F9E3A0", VA = "0x181F9F7A0")]
		public AutoChessShopDetailCharListView()
		{
		}

		// Token: 0x06024B84 RID: 150404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024B84")]
		[Address(RVA = "0x1F9F340", Offset = "0x1F9DF40", VA = "0x181F9F340")]
		private AutoChessShopLevelCharGroupItemView <>xLuaBaseProxy_get_groupCharChessItemPrefab()
		{
			return null;
		}

		// Token: 0x04033453 RID: 210003
		[Token(Token = "0x4033453")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessShopLevelCharGroupItemView _groupItemViewPrefab;

		// Token: 0x04033454 RID: 210004
		[Token(Token = "0x4033454")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _recycleLayoutList;

		// Token: 0x04033455 RID: 210005
		[Token(Token = "0x4033455")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x04033456 RID: 210006
		[Token(Token = "0x4033456")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x04033457 RID: 210007
		[Token(Token = "0x4033457")]
		[FieldOffset(Offset = "0x40")]
		private AutoChessShopCharListRecycleAdapter m_adapter;

		// Token: 0x04033458 RID: 210008
		[Token(Token = "0x4033458")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x04033459 RID: 210009
		[Token(Token = "0x4033459")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine m_scrollToGroupCoroutine;

		// Token: 0x0403345A RID: 210010
		[Token(Token = "0x403345A")]
		[FieldOffset(Offset = "0x58")]
		private AutoChessShopPage m_page;

		// Token: 0x0403345B RID: 210011
		[Token(Token = "0x403345B")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_focusTween;

		// Token: 0x0403345C RID: 210012
		[Token(Token = "0x403345C")]
		[FieldOffset(Offset = "0x68")]
		private int m_cachedRefreshSequenceNum;

		// Token: 0x0403345D RID: 210013
		[Token(Token = "0x403345D")]
		[FieldOffset(Offset = "0x70")]
		private AutoChessShopBaseCharListView.FocusCoreLogic m_focusLogic;

		// Token: 0x0403345E RID: 210014
		[Token(Token = "0x403345E")]
		private const float CHAR_CARD_BOUNDS_MARGIN = 28f;

		// Token: 0x0403345F RID: 210015
		[Token(Token = "0x403345F")]
		private const float GROUP_VIEW_HEADER_WIDTH = 120f;

		// Token: 0x04033460 RID: 210016
		[Token(Token = "0x4033460")]
		private const float GROUP_VIEW_ELEMENT_WIDTH = 123f;

		// Token: 0x04033461 RID: 210017
		[Token(Token = "0x4033461")]
		private const float GROUP_VIEW_ELEMENT_SPACING = 28f;

		// Token: 0x04033462 RID: 210018
		[Token(Token = "0x4033462")]
		private const float FOCUS_TWEEN_DUR = 0.6f;

		// Token: 0x04033463 RID: 210019
		[Token(Token = "0x4033463")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupCharChessItemPrefab;

		// Token: 0x04033464 RID: 210020
		[Token(Token = "0x4033464")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04033465 RID: 210021
		[Token(Token = "0x4033465")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033466 RID: 210022
		[Token(Token = "0x4033466")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetViewSeqCache;

		// Token: 0x04033467 RID: 210023
		[Token(Token = "0x4033467")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033468 RID: 210024
		[Token(Token = "0x4033468")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryStartScrollCo;

		// Token: 0x04033469 RID: 210025
		[Token(Token = "0x4033469")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryScrollToPos;

		// Token: 0x0403346A RID: 210026
		[Token(Token = "0x403346A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
