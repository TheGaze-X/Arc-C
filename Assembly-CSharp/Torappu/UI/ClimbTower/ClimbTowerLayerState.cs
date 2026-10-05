using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D02 RID: 23810
	[Token(Token = "0x2005D02")]
	public class ClimbTowerLayerState : PopupFadeState
	{
		// Token: 0x0602279C RID: 141212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602279C")]
		[Address(RVA = "0x1D07C30", Offset = "0x1D06830", VA = "0x181D07C30", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x1700511C RID: 20764
		// (get) Token: 0x0602279D RID: 141213 RVA: 0x000BD990 File Offset: 0x000BBB90
		[Token(Token = "0x1700511C")]
		public bool canClick
		{
			[Token(Token = "0x602279D")]
			[Address(RVA = "0x1D0AB70", Offset = "0x1D09770", VA = "0x181D0AB70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602279E RID: 141214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602279E")]
		[Address(RVA = "0x1D09BF0", Offset = "0x1D087F0", VA = "0x181D09BF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602279F RID: 141215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602279F")]
		[Address(RVA = "0x1D085A0", Offset = "0x1D071A0", VA = "0x181D085A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060227A0 RID: 141216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227A0")]
		[Address(RVA = "0x1D091B0", Offset = "0x1D07DB0", VA = "0x181D091B0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060227A1 RID: 141217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227A1")]
		[Address(RVA = "0x1D08FD0", Offset = "0x1D07BD0", VA = "0x181D08FD0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x060227A2 RID: 141218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227A2")]
		[Address(RVA = "0x1D0A230", Offset = "0x1D08E30", VA = "0x181D0A230")]
		private void _ResetToBegin()
		{
		}

		// Token: 0x060227A3 RID: 141219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227A3")]
		[Address(RVA = "0x1D0A490", Offset = "0x1D09090", VA = "0x181D0A490")]
		private void _ResetToEnd()
		{
		}

		// Token: 0x060227A4 RID: 141220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60227A4")]
		[Address(RVA = "0x1D0A180", Offset = "0x1D08D80", VA = "0x181D0A180")]
		private IEnumerator _PlayEntranceAnim()
		{
			return null;
		}

		// Token: 0x060227A5 RID: 141221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60227A5")]
		[Address(RVA = "0x1D09870", Offset = "0x1D08470", VA = "0x181D09870")]
		private IEnumerator _CoroutinePlayEntranceAnim()
		{
			return null;
		}

		// Token: 0x060227A6 RID: 141222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227A6")]
		[Address(RVA = "0x1D09700", Offset = "0x1D08300", VA = "0x181D09700")]
		private void _AnimSwitchLayer()
		{
		}

		// Token: 0x060227A7 RID: 141223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227A7")]
		[Address(RVA = "0x1D09670", Offset = "0x1D08270", VA = "0x181D09670")]
		private void _AnimShowBottomMenu()
		{
		}

		// Token: 0x060227A8 RID: 141224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227A8")]
		[Address(RVA = "0x1D0A710", Offset = "0x1D09310", VA = "0x181D0A710")]
		private void _TriggerTutorialCoroutine()
		{
		}

		// Token: 0x060227A9 RID: 141225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227A9")]
		[Address(RVA = "0x1D0A660", Offset = "0x1D09260", VA = "0x181D0A660")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x060227AA RID: 141226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60227AA")]
		[Address(RVA = "0x1D0A8F0", Offset = "0x1D094F0", VA = "0x181D0A8F0")]
		private IEnumerator _WaitForEntranceAnimComplete()
		{
			return null;
		}

		// Token: 0x060227AB RID: 141227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60227AB")]
		[Address(RVA = "0x1D0A840", Offset = "0x1D09440", VA = "0x181D0A840")]
		private IEnumerator _WaitAndTrigTutorial()
		{
			return null;
		}

		// Token: 0x060227AC RID: 141228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60227AC")]
		[Address(RVA = "0x1D09480", Offset = "0x1D08080", VA = "0x181D09480", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060227AD RID: 141229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227AD")]
		[Address(RVA = "0x1D09DC0", Offset = "0x1D089C0", VA = "0x181D09DC0")]
		private void _OnJumpToEnemyHandBook(IStateBean stateBean)
		{
		}

		// Token: 0x060227AE RID: 141230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227AE")]
		[Address(RVA = "0x1D09F30", Offset = "0x1D08B30", VA = "0x181D09F30")]
		private void _OnJumpToRewardDetailView(IStateBean stateBean)
		{
		}

		// Token: 0x060227AF RID: 141231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60227AF")]
		[Address(RVA = "0x1D0A5B0", Offset = "0x1D091B0", VA = "0x181D0A5B0")]
		private IEnumerator _RouteToProperState()
		{
			return null;
		}

		// Token: 0x060227B0 RID: 141232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227B0")]
		[Address(RVA = "0x1D07C90", Offset = "0x1D06890", VA = "0x181D07C90")]
		public void OnBtnBackClicked()
		{
		}

		// Token: 0x060227B1 RID: 141233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227B1")]
		[Address(RVA = "0x1D08020", Offset = "0x1D06C20", VA = "0x181D08020")]
		public void OnBtnSettleClicked()
		{
		}

		// Token: 0x060227B2 RID: 141234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227B2")]
		[Address(RVA = "0x1D083B0", Offset = "0x1D06FB0", VA = "0x181D083B0")]
		public void OnBtnUpClicked()
		{
		}

		// Token: 0x060227B3 RID: 141235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227B3")]
		[Address(RVA = "0x1D07DC0", Offset = "0x1D069C0", VA = "0x181D07DC0")]
		public void OnBtnDownClicked()
		{
		}

		// Token: 0x060227B4 RID: 141236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227B4")]
		[Address(RVA = "0x1D08C50", Offset = "0x1D07850", VA = "0x181D08C50")]
		public void OnJumpToEnemyHandbook()
		{
		}

		// Token: 0x060227B5 RID: 141237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227B5")]
		[Address(RVA = "0x1D08E30", Offset = "0x1D07A30", VA = "0x181D08E30")]
		public void OnJumpToRewardDetailView()
		{
		}

		// Token: 0x060227B6 RID: 141238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227B6")]
		[Address(RVA = "0x1D07FA0", Offset = "0x1D06BA0", VA = "0x181D07FA0")]
		public void OnBtnMapTipsClicked()
		{
		}

		// Token: 0x060227B7 RID: 141239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227B7")]
		[Address(RVA = "0x1D07F20", Offset = "0x1D06B20", VA = "0x181D07F20")]
		public void OnBtnExitMapTipsClicked()
		{
		}

		// Token: 0x060227B8 RID: 141240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227B8")]
		[Address(RVA = "0x1D09920", Offset = "0x1D08520", VA = "0x181D09920")]
		private void _EventOnMenuButtonClick()
		{
		}

		// Token: 0x060227B9 RID: 141241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227B9")]
		[Address(RVA = "0x1D08510", Offset = "0x1D07110", VA = "0x181D08510")]
		private void OnDestroy()
		{
		}

		// Token: 0x060227BA RID: 141242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227BA")]
		[Address(RVA = "0x1D0A9A0", Offset = "0x1D095A0", VA = "0x181D0A9A0")]
		public ClimbTowerLayerState()
		{
		}

		// Token: 0x060227BC RID: 141244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227BC")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060227BD RID: 141245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227BD")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060227BE RID: 141246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227BE")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x060227BF RID: 141247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60227BF")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402F63A RID: 194106
		[Token(Token = "0x402F63A")]
		private const string ANIM_SHOW_NAME = "climb_tower_layer_show";

		// Token: 0x0402F63B RID: 194107
		[Token(Token = "0x402F63B")]
		private const string ANIM_LAYER_NUM_ROLL_NAME = "climb_tower_layer_text_roll";

		// Token: 0x0402F63C RID: 194108
		[Token(Token = "0x402F63C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerLayerView _towerLayerView;

		// Token: 0x0402F63D RID: 194109
		[Token(Token = "0x402F63D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnimationWrapper _animShow;

		// Token: 0x0402F63E RID: 194110
		[Token(Token = "0x402F63E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AnimationWrapper _animLayerNumRoll;

		// Token: 0x0402F63F RID: 194111
		[Token(Token = "0x402F63F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ClimbTowerMenuButton _menuButtonPrefab;

		// Token: 0x0402F640 RID: 194112
		[Token(Token = "0x402F640")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x0402F641 RID: 194113
		[Token(Token = "0x402F641")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _mapPreviewBtn;

		// Token: 0x0402F642 RID: 194114
		[Token(Token = "0x402F642")]
		[FieldOffset(Offset = "0xA0")]
		private ClimbTowerLayerState.ClimbTowerLayerStateBean m_stateBean;

		// Token: 0x0402F643 RID: 194115
		[Token(Token = "0x402F643")]
		[FieldOffset(Offset = "0xA8")]
		private ClimbTowerLayerState.MenuAdapter m_menuAdapter;

		// Token: 0x0402F644 RID: 194116
		[Token(Token = "0x402F644")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_showMenu;

		// Token: 0x0402F645 RID: 194117
		[Token(Token = "0x402F645")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_showEffect;

		// Token: 0x0402F646 RID: 194118
		[Token(Token = "0x402F646")]
		[FieldOffset(Offset = "0xB2")]
		private bool m_inited;

		// Token: 0x0402F647 RID: 194119
		[Token(Token = "0x402F647")]
		[FieldOffset(Offset = "0xB4")]
		private ClimbTowerMenu.TweenType m_menuTweenType;

		// Token: 0x0402F648 RID: 194120
		[Token(Token = "0x402F648")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isPlayingEntrance;

		// Token: 0x0402F649 RID: 194121
		[Token(Token = "0x402F649")]
		[FieldOffset(Offset = "0xB9")]
		private ClimbTowerLayerState.EntranceConfig m_entranceConfig;

		// Token: 0x0402F64A RID: 194122
		[Token(Token = "0x402F64A")]
		[FieldOffset(Offset = "0xC0")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0402F64B RID: 194123
		[Token(Token = "0x402F64B")]
		[FieldOffset(Offset = "0xC8")]
		private List<Coroutine> m_cachedCoroutine;

		// Token: 0x0402F64C RID: 194124
		[Token(Token = "0x402F64C")]
		[FieldOffset(Offset = "0xD0")]
		private UIPopupWindow.UIBlocker m_blocker;

		// Token: 0x0402F64D RID: 194125
		[Token(Token = "0x402F64D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F64E RID: 194126
		[Token(Token = "0x402F64E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_canClick;

		// Token: 0x0402F64F RID: 194127
		[Token(Token = "0x402F64F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F650 RID: 194128
		[Token(Token = "0x402F650")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F651 RID: 194129
		[Token(Token = "0x402F651")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402F652 RID: 194130
		[Token(Token = "0x402F652")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0402F653 RID: 194131
		[Token(Token = "0x402F653")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ResetToBegin;

		// Token: 0x0402F654 RID: 194132
		[Token(Token = "0x402F654")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ResetToEnd;

		// Token: 0x0402F655 RID: 194133
		[Token(Token = "0x402F655")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayEntranceAnim;

		// Token: 0x0402F656 RID: 194134
		[Token(Token = "0x402F656")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CoroutinePlayEntranceAnim;

		// Token: 0x0402F657 RID: 194135
		[Token(Token = "0x402F657")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__AnimSwitchLayer;

		// Token: 0x0402F658 RID: 194136
		[Token(Token = "0x402F658")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__AnimShowBottomMenu;

		// Token: 0x0402F659 RID: 194137
		[Token(Token = "0x402F659")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TriggerTutorialCoroutine;

		// Token: 0x0402F65A RID: 194138
		[Token(Token = "0x402F65A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0402F65B RID: 194139
		[Token(Token = "0x402F65B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__WaitForEntranceAnimComplete;

		// Token: 0x0402F65C RID: 194140
		[Token(Token = "0x402F65C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__WaitAndTrigTutorial;

		// Token: 0x0402F65D RID: 194141
		[Token(Token = "0x402F65D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402F65E RID: 194142
		[Token(Token = "0x402F65E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandBook;

		// Token: 0x0402F65F RID: 194143
		[Token(Token = "0x402F65F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnJumpToRewardDetailView;

		// Token: 0x0402F660 RID: 194144
		[Token(Token = "0x402F660")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RouteToProperState;

		// Token: 0x0402F661 RID: 194145
		[Token(Token = "0x402F661")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnBtnBackClicked;

		// Token: 0x0402F662 RID: 194146
		[Token(Token = "0x402F662")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnBtnSettleClicked;

		// Token: 0x0402F663 RID: 194147
		[Token(Token = "0x402F663")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnBtnUpClicked;

		// Token: 0x0402F664 RID: 194148
		[Token(Token = "0x402F664")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnBtnDownClicked;

		// Token: 0x0402F665 RID: 194149
		[Token(Token = "0x402F665")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnJumpToEnemyHandbook;

		// Token: 0x0402F666 RID: 194150
		[Token(Token = "0x402F666")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnJumpToRewardDetailView;

		// Token: 0x0402F667 RID: 194151
		[Token(Token = "0x402F667")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnBtnMapTipsClicked;

		// Token: 0x0402F668 RID: 194152
		[Token(Token = "0x402F668")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnBtnExitMapTipsClicked;

		// Token: 0x0402F669 RID: 194153
		[Token(Token = "0x402F669")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__EventOnMenuButtonClick;

		// Token: 0x0402F66A RID: 194154
		[Token(Token = "0x402F66A")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402F66B RID: 194155
		[Token(Token = "0x402F66B")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D03 RID: 23811
		[Token(Token = "0x2005D03")]
		public class ClimbTowerLayerStateBean : IStateBean, IHotfixable
		{
			// Token: 0x060227C0 RID: 141248 RVA: 0x000BD9A8 File Offset: 0x000BBBA8
			[Token(Token = "0x60227C0")]
			[Address(RVA = "0x1D07AE0", Offset = "0x1D066E0", VA = "0x181D07AE0")]
			public bool MakeEnemyHandBookList()
			{
				return default(bool);
			}

			// Token: 0x060227C1 RID: 141249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60227C1")]
			[Address(RVA = "0x1D07B90", Offset = "0x1D06790", VA = "0x181D07B90")]
			public ClimbTowerLayerStateBean()
			{
			}

			// Token: 0x0402F66C RID: 194156
			[Token(Token = "0x402F66C")]
			[FieldOffset(Offset = "0x10")]
			public ClimbTowerLayerProperty property;

			// Token: 0x0402F66D RID: 194157
			[Token(Token = "0x402F66D")]
			[FieldOffset(Offset = "0x18")]
			public List<EnemyHandBookEverViewModel> enemyList;

			// Token: 0x0402F66E RID: 194158
			[Token(Token = "0x402F66E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_MakeEnemyHandBookList;

			// Token: 0x0402F66F RID: 194159
			[Token(Token = "0x402F66F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005D04 RID: 23812
		[Token(Token = "0x2005D04")]
		public class MenuAdapter : ClimbTowerMenuAdapter
		{
			// Token: 0x060227C2 RID: 141250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60227C2")]
			[Address(RVA = "0x1D11900", Offset = "0x1D10500", VA = "0x181D11900")]
			public MenuAdapter(ClimbTowerLayerState closure)
			{
			}

			// Token: 0x1700511D RID: 20765
			// (get) Token: 0x060227C3 RID: 141251 RVA: 0x000BD9C0 File Offset: 0x000BBBC0
			[Token(Token = "0x1700511D")]
			public override bool showMenu
			{
				[Token(Token = "0x60227C3")]
				[Address(RVA = "0x1D11E70", Offset = "0x1D10A70", VA = "0x181D11E70", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700511E RID: 20766
			// (get) Token: 0x060227C4 RID: 141252 RVA: 0x000BD9D8 File Offset: 0x000BBBD8
			[Token(Token = "0x1700511E")]
			public override bool showEffect
			{
				[Token(Token = "0x60227C4")]
				[Address(RVA = "0x1D11E00", Offset = "0x1D10A00", VA = "0x181D11E00", Slot = "17")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700511F RID: 20767
			// (get) Token: 0x060227C5 RID: 141253 RVA: 0x000BD9F0 File Offset: 0x000BBBF0
			[Token(Token = "0x1700511F")]
			public override ClimbTowerMenu.TweenType preferredMenuShowType
			{
				[Token(Token = "0x60227C5")]
				[Address(RVA = "0x1D11D90", Offset = "0x1D10990", VA = "0x181D11D90", Slot = "5")]
				get
				{
					return ClimbTowerMenu.TweenType.NONE;
				}
			}

			// Token: 0x17005120 RID: 20768
			// (get) Token: 0x060227C6 RID: 141254 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005120")]
			public override ClimbTowerMenuButton buttonPrefab
			{
				[Token(Token = "0x60227C6")]
				[Address(RVA = "0x1D11C20", Offset = "0x1D10820", VA = "0x181D11C20", Slot = "14")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005121 RID: 20769
			// (get) Token: 0x060227C7 RID: 141255 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005121")]
			public override IClimbTowerMenuButtonDataSource buttonDataSource
			{
				[Token(Token = "0x60227C7")]
				[Address(RVA = "0x1D11AB0", Offset = "0x1D106B0", VA = "0x181D11AB0", Slot = "15")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005122 RID: 20770
			// (get) Token: 0x060227C8 RID: 141256 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005122")]
			public override Action buttonCallback
			{
				[Token(Token = "0x60227C8")]
				[Address(RVA = "0x1D11A00", Offset = "0x1D10600", VA = "0x181D11A00", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x060227C9 RID: 141257 RVA: 0x000BDA08 File Offset: 0x000BBC08
			[Token(Token = "0x60227C9")]
			[Address(RVA = "0x1D118C0", Offset = "0x1D104C0", VA = "0x181D118C0")]
			private bool <>xLuaBaseProxy_get_showMenu()
			{
				return default(bool);
			}

			// Token: 0x060227CA RID: 141258 RVA: 0x000BDA20 File Offset: 0x000BBC20
			[Token(Token = "0x60227CA")]
			[Address(RVA = "0x1D118B0", Offset = "0x1D104B0", VA = "0x181D118B0")]
			private bool <>xLuaBaseProxy_get_showEffect()
			{
				return default(bool);
			}

			// Token: 0x060227CB RID: 141259 RVA: 0x000BDA38 File Offset: 0x000BBC38
			[Token(Token = "0x60227CB")]
			[Address(RVA = "0x1D118A0", Offset = "0x1D104A0", VA = "0x181D118A0")]
			private ClimbTowerMenu.TweenType <>xLuaBaseProxy_get_preferredMenuShowType()
			{
				return ClimbTowerMenu.TweenType.NONE;
			}

			// Token: 0x060227CC RID: 141260 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60227CC")]
			[Address(RVA = "0x1D11880", Offset = "0x1D10480", VA = "0x181D11880")]
			private ClimbTowerMenuButton <>xLuaBaseProxy_get_buttonPrefab()
			{
				return null;
			}

			// Token: 0x060227CD RID: 141261 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60227CD")]
			[Address(RVA = "0x1D11870", Offset = "0x1D10470", VA = "0x181D11870")]
			private IClimbTowerMenuButtonDataSource <>xLuaBaseProxy_get_buttonDataSource()
			{
				return null;
			}

			// Token: 0x060227CE RID: 141262 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60227CE")]
			[Address(RVA = "0x1D11860", Offset = "0x1D10460", VA = "0x181D11860")]
			private Action <>xLuaBaseProxy_get_buttonCallback()
			{
				return null;
			}

			// Token: 0x0402F670 RID: 194160
			[Token(Token = "0x402F670")]
			[FieldOffset(Offset = "0x18")]
			private ClimbTowerLayerState m_closure;

			// Token: 0x0402F671 RID: 194161
			[Token(Token = "0x402F671")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F672 RID: 194162
			[Token(Token = "0x402F672")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showMenu;

			// Token: 0x0402F673 RID: 194163
			[Token(Token = "0x402F673")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_showEffect;

			// Token: 0x0402F674 RID: 194164
			[Token(Token = "0x402F674")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_preferredMenuShowType;

			// Token: 0x0402F675 RID: 194165
			[Token(Token = "0x402F675")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_buttonPrefab;

			// Token: 0x0402F676 RID: 194166
			[Token(Token = "0x402F676")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_buttonDataSource;

			// Token: 0x0402F677 RID: 194167
			[Token(Token = "0x402F677")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_buttonCallback;
		}

		// Token: 0x02005D05 RID: 23813
		[Token(Token = "0x2005D05")]
		public struct EntranceConfig
		{
			// Token: 0x0402F678 RID: 194168
			[Token(Token = "0x402F678")]
			[FieldOffset(Offset = "0x0")]
			public bool playEntrance;

			// Token: 0x0402F679 RID: 194169
			[Token(Token = "0x402F679")]
			[FieldOffset(Offset = "0x1")]
			public bool playLayerUpdate;
		}
	}
}
