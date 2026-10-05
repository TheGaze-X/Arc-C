using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FCD RID: 20429
	[Token(Token = "0x2004FCD")]
	public class EnemyDuelBetView : DataBinder<EnemyDuelBetProperty>, ITimeWatcher
	{
		// Token: 0x0601E569 RID: 124265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E569")]
		[Address(RVA = "0x1816E60", Offset = "0x1815A60", VA = "0x181816E60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E56A RID: 124266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E56A")]
		[Address(RVA = "0x1816CA0", Offset = "0x18158A0", VA = "0x181816CA0")]
		private void Start()
		{
		}

		// Token: 0x0601E56B RID: 124267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E56B")]
		[Address(RVA = "0x1816440", Offset = "0x1815040", VA = "0x181816440")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601E56C RID: 124268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E56C")]
		[Address(RVA = "0x1816DE0", Offset = "0x18159E0", VA = "0x181816DE0", Slot = "8")]
		public void UpdateTime(float timeDelta)
		{
		}

		// Token: 0x0601E56D RID: 124269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E56D")]
		[Address(RVA = "0x18170A0", Offset = "0x1815CA0", VA = "0x1818170A0")]
		private void _UpdateCountdown(bool isInit = false)
		{
		}

		// Token: 0x0601E56E RID: 124270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E56E")]
		[Address(RVA = "0x18164C0", Offset = "0x18150C0", VA = "0x1818164C0", Slot = "7")]
		public override void OnValueChanged(EnemyDuelBetProperty property)
		{
		}

		// Token: 0x0601E56F RID: 124271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E56F")]
		[Address(RVA = "0x1816D00", Offset = "0x1815900", VA = "0x181816D00")]
		public void StopTickLoopTween()
		{
		}

		// Token: 0x0601E570 RID: 124272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E570")]
		[Address(RVA = "0x18163A0", Offset = "0x1814FA0", VA = "0x1818163A0")]
		public void OnBtnEnemyDetailRaycastClicked()
		{
		}

		// Token: 0x0601E571 RID: 124273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E571")]
		[Address(RVA = "0x18173D0", Offset = "0x1815FD0", VA = "0x1818173D0")]
		public EnemyDuelBetView()
		{
		}

		// Token: 0x0402889D RID: 166045
		[Token(Token = "0x402889D")]
		private const int MAX_BET_ROUND_COUNT = 99;

		// Token: 0x0402889E RID: 166046
		[Token(Token = "0x402889E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlBtnSkip;

		// Token: 0x0402889F RID: 166047
		[Token(Token = "0x402889F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlWatching;

		// Token: 0x040288A0 RID: 166048
		[Token(Token = "0x40288A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlCountdown;

		// Token: 0x040288A1 RID: 166049
		[Token(Token = "0x40288A1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlCountdownOut;

		// Token: 0x040288A2 RID: 166050
		[Token(Token = "0x40288A2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlClock;

		// Token: 0x040288A3 RID: 166051
		[Token(Token = "0x40288A3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Scrollbar _progressBarCountdown;

		// Token: 0x040288A4 RID: 166052
		[Token(Token = "0x40288A4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _rectTransformMark;

		// Token: 0x040288A5 RID: 166053
		[Token(Token = "0x40288A5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textCountdown;

		// Token: 0x040288A6 RID: 166054
		[Token(Token = "0x40288A6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textCountdownOut;

		// Token: 0x040288A7 RID: 166055
		[Token(Token = "0x40288A7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textRoundCount;

		// Token: 0x040288A8 RID: 166056
		[Token(Token = "0x40288A8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private EnemyDuelBetSideView _leftSideView;

		// Token: 0x040288A9 RID: 166057
		[Token(Token = "0x40288A9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private EnemyDuelBetSideView _rightSideView;

		// Token: 0x040288AA RID: 166058
		[Token(Token = "0x40288AA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject[] _spacingBet;

		// Token: 0x040288AB RID: 166059
		[Token(Token = "0x40288AB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AbstractEnemyDuelBetButton[] _betButtons;

		// Token: 0x040288AC RID: 166060
		[Token(Token = "0x40288AC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _fxBoom;

		// Token: 0x040288AD RID: 166061
		[Token(Token = "0x40288AD")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x040288AE RID: 166062
		[Token(Token = "0x40288AE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _textDescPrivate;

		// Token: 0x040288AF RID: 166063
		[Token(Token = "0x40288AF")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private CanvasGroup _canvasClock;

		// Token: 0x040288B0 RID: 166064
		[Token(Token = "0x40288B0")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _animClockLoop;

		// Token: 0x040288B1 RID: 166065
		[Token(Token = "0x40288B1")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _animCountdownTextLoop;

		// Token: 0x040288B2 RID: 166066
		[Token(Token = "0x40288B2")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAnimationLocation _animPlayerListShow;

		// Token: 0x040288B3 RID: 166067
		[Token(Token = "0x40288B3")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIAtlasImage _imgProgressBar;

		// Token: 0x040288B4 RID: 166068
		[Token(Token = "0x40288B4")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Color _colorProgressBarPrivateBet;

		// Token: 0x040288B5 RID: 166069
		[Token(Token = "0x40288B5")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _enemyDetailPnlRaycast;

		// Token: 0x040288B6 RID: 166070
		[Token(Token = "0x40288B6")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private PrefabInstHolder _topBarInstHolder;

		// Token: 0x040288B7 RID: 166071
		[Token(Token = "0x40288B7")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private EnemyDuelBetView.StandModeTips _standModeTips;

		// Token: 0x040288B8 RID: 166072
		[Token(Token = "0x40288B8")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _pnlBetBtnOperation;

		// Token: 0x040288B9 RID: 166073
		[Token(Token = "0x40288B9")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _pnlBetBtnStand;

		// Token: 0x040288BA RID: 166074
		[Token(Token = "0x40288BA")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private EnemyDuelBetView.PnlTopOperation _pnlOperation;

		// Token: 0x040288BB RID: 166075
		[Token(Token = "0x40288BB")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private EnemyDuelBetView.PnlTopStand _pnlStand;

		// Token: 0x040288BC RID: 166076
		[Token(Token = "0x40288BC")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private GameObject _pnlSword;

		// Token: 0x040288BD RID: 166077
		[Token(Token = "0x40288BD")]
		[FieldOffset(Offset = "0x138")]
		private EnemyDuelBetViewModel m_cachedViewModel;

		// Token: 0x040288BE RID: 166078
		[Token(Token = "0x40288BE")]
		[FieldOffset(Offset = "0x140")]
		private EnemyDuelBetView.PrivateBetShowTween m_privateBetShowTween;

		// Token: 0x040288BF RID: 166079
		[Token(Token = "0x40288BF")]
		[FieldOffset(Offset = "0x148")]
		private UISwitchTween m_playerListShowTween;

		// Token: 0x040288C0 RID: 166080
		[Token(Token = "0x40288C0")]
		[FieldOffset(Offset = "0x150")]
		private bool m_inited;

		// Token: 0x040288C1 RID: 166081
		[Token(Token = "0x40288C1")]
		[FieldOffset(Offset = "0x158")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040288C2 RID: 166082
		[Token(Token = "0x40288C2")]
		[FieldOffset(Offset = "0x168")]
		private int m_cachedLoadSeqNum;

		// Token: 0x040288C3 RID: 166083
		[Token(Token = "0x40288C3")]
		[FieldOffset(Offset = "0x170")]
		private CountDownStopWatch m_stopWatch;

		// Token: 0x040288C4 RID: 166084
		[Token(Token = "0x40288C4")]
		[FieldOffset(Offset = "0x178")]
		private EnemyDuelBetTopBarView m_topBarView;

		// Token: 0x040288C5 RID: 166085
		[Token(Token = "0x40288C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040288C6 RID: 166086
		[Token(Token = "0x40288C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040288C7 RID: 166087
		[Token(Token = "0x40288C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040288C8 RID: 166088
		[Token(Token = "0x40288C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x040288C9 RID: 166089
		[Token(Token = "0x40288C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateCountdown;

		// Token: 0x040288CA RID: 166090
		[Token(Token = "0x40288CA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040288CB RID: 166091
		[Token(Token = "0x40288CB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_StopTickLoopTween;

		// Token: 0x040288CC RID: 166092
		[Token(Token = "0x40288CC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBtnEnemyDetailRaycastClicked;

		// Token: 0x040288CD RID: 166093
		[Token(Token = "0x40288CD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FCE RID: 20430
		[Token(Token = "0x2004FCE")]
		private class PrivateBetShowTween : UISwitchTween
		{
			// Token: 0x0601E573 RID: 124275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E573")]
			[Address(RVA = "0x1821EF0", Offset = "0x1820AF0", VA = "0x181821EF0")]
			public PrivateBetShowTween(EnemyDuelBetView closure)
			{
			}

			// Token: 0x0601E574 RID: 124276 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E574")]
			[Address(RVA = "0x1821420", Offset = "0x1820020", VA = "0x181821420", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601E575 RID: 124277 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E575")]
			[Address(RVA = "0x18211E0", Offset = "0x181FDE0", VA = "0x1818211E0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601E576 RID: 124278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E576")]
			[Address(RVA = "0x1821170", Offset = "0x181FD70", VA = "0x181821170", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0601E577 RID: 124279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E577")]
			[Address(RVA = "0x1821100", Offset = "0x181FD00", VA = "0x181821100", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601E578 RID: 124280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E578")]
			[Address(RVA = "0x1821670", Offset = "0x1820270", VA = "0x181821670", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601E579 RID: 124281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E579")]
			[Address(RVA = "0x1821B70", Offset = "0x1820770", VA = "0x181821B70")]
			private void _PlayLoopTween()
			{
			}

			// Token: 0x0601E57A RID: 124282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E57A")]
			[Address(RVA = "0x18219F0", Offset = "0x18205F0", VA = "0x1818219F0")]
			private void _ClearLoopTween()
			{
			}

			// Token: 0x0601E57B RID: 124283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E57B")]
			[Address(RVA = "0x1821810", Offset = "0x1820410", VA = "0x181821810")]
			public void StopTickLoopTween()
			{
			}

			// Token: 0x0601E57F RID: 124287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E57F")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0601E580 RID: 124288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E580")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601E581 RID: 124289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E581")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040288CE RID: 166094
			[Token(Token = "0x40288CE")]
			[FieldOffset(Offset = "0x48")]
			private EnemyDuelBetView m_closure;

			// Token: 0x040288CF RID: 166095
			[Token(Token = "0x40288CF")]
			[FieldOffset(Offset = "0x50")]
			private UIAnimationTween m_countdownLoopTween;

			// Token: 0x040288D0 RID: 166096
			[Token(Token = "0x40288D0")]
			[FieldOffset(Offset = "0x58")]
			private UIAnimationTween m_clockLoopTween;

			// Token: 0x040288D1 RID: 166097
			[Token(Token = "0x40288D1")]
			[FieldOffset(Offset = "0x60")]
			private Tween m_tickLoopTween;

			// Token: 0x040288D2 RID: 166098
			[Token(Token = "0x40288D2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040288D3 RID: 166099
			[Token(Token = "0x40288D3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040288D4 RID: 166100
			[Token(Token = "0x40288D4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040288D5 RID: 166101
			[Token(Token = "0x40288D5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x040288D6 RID: 166102
			[Token(Token = "0x40288D6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x040288D7 RID: 166103
			[Token(Token = "0x40288D7")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x040288D8 RID: 166104
			[Token(Token = "0x40288D8")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__PlayLoopTween;

			// Token: 0x040288D9 RID: 166105
			[Token(Token = "0x40288D9")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__ClearLoopTween;

			// Token: 0x040288DA RID: 166106
			[Token(Token = "0x40288DA")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_StopTickLoopTween;
		}

		// Token: 0x02004FCF RID: 20431
		[Token(Token = "0x2004FCF")]
		[Serializable]
		private class StandModeTips : IHotfixable
		{
			// Token: 0x0601E582 RID: 124290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E582")]
			[Address(RVA = "0x1821F70", Offset = "0x1820B70", VA = "0x181821F70")]
			public void Render(EnemyDuelBetViewModel model, bool isInit)
			{
			}

			// Token: 0x0601E583 RID: 124291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E583")]
			[Address(RVA = "0x1822150", Offset = "0x1820D50", VA = "0x181822150")]
			public StandModeTips()
			{
			}

			// Token: 0x040288DB RID: 166107
			[Token(Token = "0x40288DB")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _root;

			// Token: 0x040288DC RID: 166108
			[Token(Token = "0x40288DC")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _pnlProtect;

			// Token: 0x040288DD RID: 166109
			[Token(Token = "0x40288DD")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject _pnlProtectUsed;

			// Token: 0x040288DE RID: 166110
			[Token(Token = "0x40288DE")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private GameObject _pnlProtectOff;

			// Token: 0x040288DF RID: 166111
			[Token(Token = "0x40288DF")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Text _pnlProtectDesc;

			// Token: 0x040288E0 RID: 166112
			[Token(Token = "0x40288E0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x040288E1 RID: 166113
			[Token(Token = "0x40288E1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004FD0 RID: 20432
		[Token(Token = "0x2004FD0")]
		[Serializable]
		private class PnlTopOperation : IHotfixable
		{
			// Token: 0x0601E584 RID: 124292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E584")]
			[Address(RVA = "0x1820CE0", Offset = "0x181F8E0", VA = "0x181820CE0")]
			private void _InitIfNot()
			{
			}

			// Token: 0x0601E585 RID: 124293 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E585")]
			[Address(RVA = "0x1820670", Offset = "0x181F270", VA = "0x181820670")]
			public void Render(EnemyDuelBetViewModel model, bool isInit)
			{
			}

			// Token: 0x0601E586 RID: 124294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E586")]
			[Address(RVA = "0x1820EB0", Offset = "0x181FAB0", VA = "0x181820EB0")]
			public PnlTopOperation()
			{
			}

			// Token: 0x040288E2 RID: 166114
			[Token(Token = "0x40288E2")]
			private const string MONEY_EXPECT_FORMAT = "+{0}";

			// Token: 0x040288E3 RID: 166115
			[Token(Token = "0x40288E3")]
			private const string RANK_EMPTY_DESC = "--";

			// Token: 0x040288E4 RID: 166116
			[Token(Token = "0x40288E4")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _root;

			// Token: 0x040288E5 RID: 166117
			[Token(Token = "0x40288E5")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textMoneyCount;

			// Token: 0x040288E6 RID: 166118
			[Token(Token = "0x40288E6")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textPlayerRank;

			// Token: 0x040288E7 RID: 166119
			[Token(Token = "0x40288E7")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _textMoneyExpect;

			// Token: 0x040288E8 RID: 166120
			[Token(Token = "0x40288E8")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private UIAnimationLocation _animMoneyExpect;

			// Token: 0x040288E9 RID: 166121
			[Token(Token = "0x40288E9")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private float _moneyExpectNumTweenDuration;

			// Token: 0x040288EA RID: 166122
			[Token(Token = "0x40288EA")]
			[FieldOffset(Offset = "0x44")]
			[SerializeField]
			private Color _colorEmptyRank;

			// Token: 0x040288EB RID: 166123
			[Token(Token = "0x40288EB")]
			[FieldOffset(Offset = "0x54")]
			[SerializeField]
			private Color _colorNormalRank;

			// Token: 0x040288EC RID: 166124
			[Token(Token = "0x40288EC")]
			[FieldOffset(Offset = "0x68")]
			private AnimationSwitchTween m_moneyExpectShowTween;

			// Token: 0x040288ED RID: 166125
			[Token(Token = "0x40288ED")]
			[FieldOffset(Offset = "0x70")]
			private Tween m_moneyExpectNumTween;

			// Token: 0x040288EE RID: 166126
			[Token(Token = "0x40288EE")]
			[FieldOffset(Offset = "0x78")]
			private int m_currMoneyExpectShowNum;

			// Token: 0x040288EF RID: 166127
			[Token(Token = "0x40288EF")]
			[FieldOffset(Offset = "0x7C")]
			private bool m_inited;

			// Token: 0x040288F0 RID: 166128
			[Token(Token = "0x40288F0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__InitIfNot;

			// Token: 0x040288F1 RID: 166129
			[Token(Token = "0x40288F1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x040288F2 RID: 166130
			[Token(Token = "0x40288F2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004FD1 RID: 20433
		[Token(Token = "0x2004FD1")]
		[Serializable]
		private class PnlTopStand : IHotfixable
		{
			// Token: 0x0601E58A RID: 124298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E58A")]
			[Address(RVA = "0x1820F20", Offset = "0x181FB20", VA = "0x181820F20")]
			public void Render(EnemyDuelBetViewModel model, bool isInit)
			{
			}

			// Token: 0x0601E58B RID: 124299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E58B")]
			[Address(RVA = "0x18210A0", Offset = "0x181FCA0", VA = "0x1818210A0")]
			public PnlTopStand()
			{
			}

			// Token: 0x040288F3 RID: 166131
			[Token(Token = "0x40288F3")]
			private const string TOTAL_PLAYER_NUM_FORMAT = "/{0}";

			// Token: 0x040288F4 RID: 166132
			[Token(Token = "0x40288F4")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _root;

			// Token: 0x040288F5 RID: 166133
			[Token(Token = "0x40288F5")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textTotalPlayerNum;

			// Token: 0x040288F6 RID: 166134
			[Token(Token = "0x40288F6")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textCurrPlayerNum;

			// Token: 0x040288F7 RID: 166135
			[Token(Token = "0x40288F7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x040288F8 RID: 166136
			[Token(Token = "0x40288F8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
