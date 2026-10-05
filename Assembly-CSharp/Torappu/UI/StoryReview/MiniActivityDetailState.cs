using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048DB RID: 18651
	[Token(Token = "0x20048DB")]
	public class MiniActivityDetailState : PopupFadeState
	{
		// Token: 0x0601C225 RID: 115237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C225")]
		[Address(RVA = "0x159D210", Offset = "0x159BE10", VA = "0x18159D210", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x170042D3 RID: 17107
		// (get) Token: 0x0601C226 RID: 115238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042D3")]
		public override IStateCacheHandler cacheHandler
		{
			[Token(Token = "0x601C226")]
			[Address(RVA = "0x159EFA0", Offset = "0x159DBA0", VA = "0x18159EFA0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C227 RID: 115239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C227")]
		[Address(RVA = "0x159D390", Offset = "0x159BF90", VA = "0x18159D390", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C228 RID: 115240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C228")]
		[Address(RVA = "0x159D8D0", Offset = "0x159C4D0", VA = "0x18159D8D0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601C229 RID: 115241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C229")]
		[Address(RVA = "0x159E940", Offset = "0x159D540", VA = "0x18159E940")]
		private void _RegisterToReviewState(IStateBean stateBean)
		{
		}

		// Token: 0x0601C22A RID: 115242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C22A")]
		[Address(RVA = "0x159DF10", Offset = "0x159CB10", VA = "0x18159DF10")]
		private void _OnBackToReviewState(bool? showTrial)
		{
		}

		// Token: 0x0601C22B RID: 115243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C22B")]
		[Address(RVA = "0x159EB30", Offset = "0x159D730", VA = "0x18159EB30")]
		private void _UpdateTrialPanel()
		{
		}

		// Token: 0x0601C22C RID: 115244 RVA: 0x000A7610 File Offset: 0x000A5810
		[Token(Token = "0x601C22C")]
		[Address(RVA = "0x159DBD0", Offset = "0x159C7D0", VA = "0x18159DBD0")]
		private bool _IsRewardAllCollected(string actId)
		{
			return default(bool);
		}

		// Token: 0x0601C22D RID: 115245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C22D")]
		[Address(RVA = "0x159D270", Offset = "0x159BE70", VA = "0x18159D270")]
		public void OnBtnNavTrial()
		{
		}

		// Token: 0x0601C22E RID: 115246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C22E")]
		[Address(RVA = "0x159D300", Offset = "0x159BF00", VA = "0x18159D300")]
		public void OnBtnRule()
		{
		}

		// Token: 0x0601C22F RID: 115247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C22F")]
		[Address(RVA = "0x159E020", Offset = "0x159CC20", VA = "0x18159E020")]
		private void _OnScrollRectTween(float pos)
		{
		}

		// Token: 0x0601C230 RID: 115248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C230")]
		[Address(RVA = "0x159DE80", Offset = "0x159CA80", VA = "0x18159DE80")]
		private void _OnBackClick()
		{
		}

		// Token: 0x0601C231 RID: 115249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C231")]
		[Address(RVA = "0x159E380", Offset = "0x159CF80", VA = "0x18159E380")]
		private void _OnStoryRead(string storyId)
		{
		}

		// Token: 0x0601C232 RID: 115250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C232")]
		[Address(RVA = "0x159E2C0", Offset = "0x159CEC0", VA = "0x18159E2C0")]
		private void _OnStoryReadSuc()
		{
		}

		// Token: 0x0601C233 RID: 115251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C233")]
		[Address(RVA = "0x159E0A0", Offset = "0x159CCA0", VA = "0x18159E0A0")]
		private void _OnStoryClicked(string storyTextId)
		{
		}

		// Token: 0x0601C234 RID: 115252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C234")]
		[Address(RVA = "0x159E600", Offset = "0x159D200", VA = "0x18159E600")]
		private void _OnUnlockClicked(string storyId)
		{
		}

		// Token: 0x0601C235 RID: 115253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C235")]
		[Address(RVA = "0x159E450", Offset = "0x159D050", VA = "0x18159E450")]
		private void _OnStoryUnlock(StoryReviewViewModel viewModel)
		{
		}

		// Token: 0x0601C236 RID: 115254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C236")]
		[Address(RVA = "0x159E520", Offset = "0x159D120", VA = "0x18159E520")]
		private void _OnStoryUnlocked()
		{
		}

		// Token: 0x0601C237 RID: 115255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C237")]
		[Address(RVA = "0x159EEF0", Offset = "0x159DAF0", VA = "0x18159EEF0")]
		public MiniActivityDetailState()
		{
		}

		// Token: 0x0601C23A RID: 115258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C23A")]
		[Address(RVA = "0x12DC030", Offset = "0x12DAC30", VA = "0x1812DC030")]
		private IStateCacheHandler <>xLuaBaseProxy_get_cacheHandler()
		{
			return null;
		}

		// Token: 0x0601C23B RID: 115259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C23B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601C23C RID: 115260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C23C")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04024C80 RID: 150656
		[Token(Token = "0x4024C80")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04024C81 RID: 150657
		[Token(Token = "0x4024C81")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MiniReviewDetailBinder _miniStoryDetailBinder;

		// Token: 0x04024C82 RID: 150658
		[Token(Token = "0x4024C82")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04024C83 RID: 150659
		[Token(Token = "0x4024C83")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _maskPanel;

		// Token: 0x04024C84 RID: 150660
		[Token(Token = "0x4024C84")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _chapterTitleImage;

		// Token: 0x04024C85 RID: 150661
		[Token(Token = "0x4024C85")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _chapterBg;

		// Token: 0x04024C86 RID: 150662
		[Token(Token = "0x4024C86")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _trialParentGo;

		// Token: 0x04024C87 RID: 150663
		[Token(Token = "0x4024C87")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _trialPanelGo;

		// Token: 0x04024C88 RID: 150664
		[Token(Token = "0x4024C88")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _trialWaitingGo;

		// Token: 0x04024C89 RID: 150665
		[Token(Token = "0x4024C89")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _trialOpenGo;

		// Token: 0x04024C8A RID: 150666
		[Token(Token = "0x4024C8A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _textTrialCountDown;

		// Token: 0x04024C8B RID: 150667
		[Token(Token = "0x4024C8B")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _textTrialCaption;

		// Token: 0x04024C8C RID: 150668
		[Token(Token = "0x4024C8C")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UICommonTrackPoint _newTrialTrackPoint;

		// Token: 0x04024C8D RID: 150669
		[Token(Token = "0x4024C8D")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UICommonTrackPoint _collectTrialTrackPoint;

		// Token: 0x04024C8E RID: 150670
		[Token(Token = "0x4024C8E")]
		[FieldOffset(Offset = "0xE0")]
		private ActivityReviewDetailStateBean m_stateBean;

		// Token: 0x04024C8F RID: 150671
		[Token(Token = "0x4024C8F")]
		[FieldOffset(Offset = "0xE8")]
		private bool? m_showTrial;

		// Token: 0x04024C90 RID: 150672
		[Token(Token = "0x4024C90")]
		[FieldOffset(Offset = "0xF0")]
		private StateCacheHandler<MiniActivityDetailState.StateRuntime> m_cacheHandler;

		// Token: 0x04024C91 RID: 150673
		[Token(Token = "0x4024C91")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_backToStage;

		// Token: 0x04024C92 RID: 150674
		[Token(Token = "0x4024C92")]
		[FieldOffset(Offset = "0xFC")]
		private StoryReviewPage.FastExit m_fastExit;

		// Token: 0x04024C93 RID: 150675
		[Token(Token = "0x4024C93")]
		private const float SCROLL_DURATION = 0.5f;

		// Token: 0x04024C94 RID: 150676
		[Token(Token = "0x4024C94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04024C95 RID: 150677
		[Token(Token = "0x4024C95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cacheHandler;

		// Token: 0x04024C96 RID: 150678
		[Token(Token = "0x4024C96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04024C97 RID: 150679
		[Token(Token = "0x4024C97")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04024C98 RID: 150680
		[Token(Token = "0x4024C98")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RegisterToReviewState;

		// Token: 0x04024C99 RID: 150681
		[Token(Token = "0x4024C99")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnBackToReviewState;

		// Token: 0x04024C9A RID: 150682
		[Token(Token = "0x4024C9A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateTrialPanel;

		// Token: 0x04024C9B RID: 150683
		[Token(Token = "0x4024C9B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__IsRewardAllCollected;

		// Token: 0x04024C9C RID: 150684
		[Token(Token = "0x4024C9C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBtnNavTrial;

		// Token: 0x04024C9D RID: 150685
		[Token(Token = "0x4024C9D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnBtnRule;

		// Token: 0x04024C9E RID: 150686
		[Token(Token = "0x4024C9E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnScrollRectTween;

		// Token: 0x04024C9F RID: 150687
		[Token(Token = "0x4024C9F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnBackClick;

		// Token: 0x04024CA0 RID: 150688
		[Token(Token = "0x4024CA0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnStoryRead;

		// Token: 0x04024CA1 RID: 150689
		[Token(Token = "0x4024CA1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnStoryReadSuc;

		// Token: 0x04024CA2 RID: 150690
		[Token(Token = "0x4024CA2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnStoryClicked;

		// Token: 0x04024CA3 RID: 150691
		[Token(Token = "0x4024CA3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnUnlockClicked;

		// Token: 0x04024CA4 RID: 150692
		[Token(Token = "0x4024CA4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnStoryUnlock;

		// Token: 0x04024CA5 RID: 150693
		[Token(Token = "0x4024CA5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnStoryUnlocked;

		// Token: 0x04024CA6 RID: 150694
		[Token(Token = "0x4024CA6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020048DC RID: 18652
		[Token(Token = "0x20048DC")]
		public struct StateRuntime
		{
			// Token: 0x04024CA7 RID: 150695
			[Token(Token = "0x4024CA7")]
			[FieldOffset(Offset = "0x0")]
			public float detailScrollPos;

			// Token: 0x04024CA8 RID: 150696
			[Token(Token = "0x4024CA8")]
			[FieldOffset(Offset = "0x4")]
			public bool backToStage;

			// Token: 0x04024CA9 RID: 150697
			[Token(Token = "0x4024CA9")]
			[FieldOffset(Offset = "0x8")]
			public StoryReviewPage.FastExit fastExit;
		}
	}
}
