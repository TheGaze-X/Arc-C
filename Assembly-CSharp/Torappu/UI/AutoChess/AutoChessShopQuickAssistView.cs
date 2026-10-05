using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006371 RID: 25457
	[Token(Token = "0x2006371")]
	public class AutoChessShopQuickAssistView : DataBinder<AutoChessShopQuickAssistViewProperty>
	{
		// Token: 0x06024BA4 RID: 150436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BA4")]
		[Address(RVA = "0x1FA1C20", Offset = "0x1FA0820", VA = "0x181FA1C20")]
		public void Init(AutoChessShopPage page)
		{
		}

		// Token: 0x06024BA5 RID: 150437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BA5")]
		[Address(RVA = "0x1FA1CA0", Offset = "0x1FA08A0", VA = "0x181FA1CA0", Slot = "7")]
		public override void OnValueChanged(AutoChessShopQuickAssistViewProperty property)
		{
		}

		// Token: 0x06024BA6 RID: 150438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BA6")]
		[Address(RVA = "0x1FA2520", Offset = "0x1FA1120", VA = "0x181FA2520")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024BA7 RID: 150439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BA7")]
		[Address(RVA = "0x1FA27C0", Offset = "0x1FA13C0", VA = "0x181FA27C0")]
		private void _TryStartScrollCo(float pos, bool isFastMode)
		{
		}

		// Token: 0x06024BA8 RID: 150440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024BA8")]
		[Address(RVA = "0x1FA2BD0", Offset = "0x1FA17D0", VA = "0x181FA2BD0")]
		private IEnumerator _WaitForLayoutReady()
		{
			return null;
		}

		// Token: 0x06024BA9 RID: 150441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024BA9")]
		[Address(RVA = "0x1FA26E0", Offset = "0x1FA12E0", VA = "0x181FA26E0")]
		private IEnumerator _TryScrollToPos(float pos, bool isFastMode)
		{
			return null;
		}

		// Token: 0x06024BAA RID: 150442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BAA")]
		[Address(RVA = "0x1FA2270", Offset = "0x1FA0E70", VA = "0x181FA2270")]
		private void _FocusToPos(float pos, bool fastMode = false)
		{
		}

		// Token: 0x06024BAB RID: 150443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BAB")]
		[Address(RVA = "0x1FA2970", Offset = "0x1FA1570", VA = "0x181FA2970")]
		private void _TryStartTutorial()
		{
		}

		// Token: 0x06024BAC RID: 150444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024BAC")]
		[Address(RVA = "0x1FA2B20", Offset = "0x1FA1720", VA = "0x181FA2B20")]
		private IEnumerator _TutorialOnly_TryRaiseAVGSignal()
		{
			return null;
		}

		// Token: 0x06024BAD RID: 150445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024BAD")]
		[Address(RVA = "0x1FA2C80", Offset = "0x1FA1880", VA = "0x181FA2C80")]
		public AutoChessShopQuickAssistView()
		{
		}

		// Token: 0x040334B0 RID: 210096
		[Token(Token = "0x40334B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtAssistInfo;

		// Token: 0x040334B1 RID: 210097
		[Token(Token = "0x40334B1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AutoChessShopQuickAssistTitleWithItemView _titleWithItemViewPrefab;

		// Token: 0x040334B2 RID: 210098
		[Token(Token = "0x40334B2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutoChessShopQuickAssistOnlyItemView _onlyItemViewPrefab;

		// Token: 0x040334B3 RID: 210099
		[Token(Token = "0x40334B3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _recycleLayoutList;

		// Token: 0x040334B4 RID: 210100
		[Token(Token = "0x40334B4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x040334B5 RID: 210101
		[Token(Token = "0x40334B5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x040334B6 RID: 210102
		[Token(Token = "0x40334B6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UILayoutDimensionListener _dimensionListener;

		// Token: 0x040334B7 RID: 210103
		[Token(Token = "0x40334B7")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x040334B8 RID: 210104
		[Token(Token = "0x40334B8")]
		[FieldOffset(Offset = "0x60")]
		private AutoChessShopQuickAssistView.AutoChessShopAssistListRecycleAdapter m_adapter;

		// Token: 0x040334B9 RID: 210105
		[Token(Token = "0x40334B9")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine m_scrollToGroupCoroutine;

		// Token: 0x040334BA RID: 210106
		[Token(Token = "0x40334BA")]
		[FieldOffset(Offset = "0x70")]
		private int m_cachedEnterSequenceNum;

		// Token: 0x040334BB RID: 210107
		[Token(Token = "0x40334BB")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_focusTween;

		// Token: 0x040334BC RID: 210108
		[Token(Token = "0x40334BC")]
		private const float FOCUS_TWEEN_DURATION = 0.23f;

		// Token: 0x040334BD RID: 210109
		[Token(Token = "0x40334BD")]
		[FieldOffset(Offset = "0x80")]
		private AutoChessShopPage m_page;

		// Token: 0x040334BE RID: 210110
		[Token(Token = "0x40334BE")]
		[FieldOffset(Offset = "0x88")]
		private bool m_rendered;

		// Token: 0x040334BF RID: 210111
		[Token(Token = "0x40334BF")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x040334C0 RID: 210112
		[Token(Token = "0x40334C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040334C1 RID: 210113
		[Token(Token = "0x40334C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040334C2 RID: 210114
		[Token(Token = "0x40334C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040334C3 RID: 210115
		[Token(Token = "0x40334C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryStartScrollCo;

		// Token: 0x040334C4 RID: 210116
		[Token(Token = "0x40334C4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__WaitForLayoutReady;

		// Token: 0x040334C5 RID: 210117
		[Token(Token = "0x40334C5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryScrollToPos;

		// Token: 0x040334C6 RID: 210118
		[Token(Token = "0x40334C6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FocusToPos;

		// Token: 0x040334C7 RID: 210119
		[Token(Token = "0x40334C7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryStartTutorial;

		// Token: 0x040334C8 RID: 210120
		[Token(Token = "0x40334C8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryRaiseAVGSignal;

		// Token: 0x040334C9 RID: 210121
		[Token(Token = "0x40334C9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006372 RID: 25458
		[Token(Token = "0x2006372")]
		private struct ChessCacheInfo
		{
			// Token: 0x040334CA RID: 210122
			[Token(Token = "0x40334CA")]
			[FieldOffset(Offset = "0x0")]
			public bool isAssisting;

			// Token: 0x040334CB RID: 210123
			[Token(Token = "0x40334CB")]
			[FieldOffset(Offset = "0x8")]
			public string friendUid;

			// Token: 0x040334CC RID: 210124
			[Token(Token = "0x40334CC")]
			[FieldOffset(Offset = "0x10")]
			public bool canAssistMore;
		}

		// Token: 0x02006373 RID: 25459
		[Token(Token = "0x2006373")]
		private class AutoChessShopAssistListRecycleAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x06024BAE RID: 150446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BAE")]
			[Address(RVA = "0x1F9EE40", Offset = "0x1F9DA40", VA = "0x181F9EE40")]
			public AutoChessShopAssistListRecycleAdapter(AutoChessShopQuickAssistView closure)
			{
			}

			// Token: 0x06024BAF RID: 150447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024BAF")]
			[Address(RVA = "0x1F9E380", Offset = "0x1F9CF80", VA = "0x181F9E380", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x06024BB0 RID: 150448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BB0")]
			[Address(RVA = "0x1F9E4B0", Offset = "0x1F9D0B0", VA = "0x181F9E4B0")]
			public void RebuildList(AutoChessShopQuickAssistViewModel viewModel)
			{
			}

			// Token: 0x06024BB1 RID: 150449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BB1")]
			[Address(RVA = "0x1F9E800", Offset = "0x1F9D400", VA = "0x181F9E800")]
			public void TryRefreshCharCardViewsInfos(AutoChessShopQuickAssistViewModel viewModel)
			{
			}

			// Token: 0x06024BB2 RID: 150450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024BB2")]
			[Address(RVA = "0x1F9EC20", Offset = "0x1F9D820", VA = "0x181F9EC20")]
			private void _RefreshCacheDict(List<IAutoChessShopQuickAssistListItemViewModel> viewModelList)
			{
			}

			// Token: 0x040334CD RID: 210125
			[Token(Token = "0x40334CD")]
			[FieldOffset(Offset = "0x18")]
			private AutoChessShopQuickAssistView m_closure;

			// Token: 0x040334CE RID: 210126
			[Token(Token = "0x40334CE")]
			[FieldOffset(Offset = "0x20")]
			private List<UIRecycleLayoutAdapter.IVirtualView> m_views;

			// Token: 0x040334CF RID: 210127
			[Token(Token = "0x40334CF")]
			[FieldOffset(Offset = "0x28")]
			private ListDict<string, AutoChessShopQuickAssistView.ChessCacheInfo> m_cachedDict;

			// Token: 0x040334D0 RID: 210128
			[Token(Token = "0x40334D0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040334D1 RID: 210129
			[Token(Token = "0x40334D1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x040334D2 RID: 210130
			[Token(Token = "0x40334D2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildList;

			// Token: 0x040334D3 RID: 210131
			[Token(Token = "0x40334D3")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_TryRefreshCharCardViewsInfos;

			// Token: 0x040334D4 RID: 210132
			[Token(Token = "0x40334D4")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__RefreshCacheDict;
		}
	}
}
