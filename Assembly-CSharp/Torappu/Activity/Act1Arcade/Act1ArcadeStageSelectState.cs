using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007989 RID: 31113
	[Token(Token = "0x2007989")]
	public class Act1ArcadeStageSelectState : UIPopupState, IValueMsgReceiver
	{
		// Token: 0x0602BA68 RID: 178792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA68")]
		[Address(RVA = "0x278FDB0", Offset = "0x278E9B0", VA = "0x18278FDB0")]
		private void _OnClickBack()
		{
		}

		// Token: 0x0602BA69 RID: 178793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA69")]
		[Address(RVA = "0x278F550", Offset = "0x278E150", VA = "0x18278F550")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BA6A RID: 178794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA6A")]
		[Address(RVA = "0x278F7C0", Offset = "0x278E3C0", VA = "0x18278F7C0")]
		private void _InitStageItems(Act1ArcadeStageSelectViewModel stageSelectModel)
		{
		}

		// Token: 0x0602BA6B RID: 178795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA6B")]
		[Address(RVA = "0x278D2B0", Offset = "0x278BEB0", VA = "0x18278D2B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BA6C RID: 178796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA6C")]
		[Address(RVA = "0x278D570", Offset = "0x278C170", VA = "0x18278D570", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BA6D RID: 178797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA6D")]
		[Address(RVA = "0x278E0E0", Offset = "0x278CCE0", VA = "0x18278E0E0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602BA6E RID: 178798 RVA: 0x000DCC20 File Offset: 0x000DAE20
		[Token(Token = "0x602BA6E")]
		[Address(RVA = "0x278FA60", Offset = "0x278E660", VA = "0x18278FA60")]
		private bool _IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x0602BA6F RID: 178799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA6F")]
		[Address(RVA = "0x278E1A0", Offset = "0x278CDA0", VA = "0x18278E1A0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602BA70 RID: 178800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA70")]
		[Address(RVA = "0x278FBA0", Offset = "0x278E7A0", VA = "0x18278FBA0")]
		private void _JumpToBadgeState(IStateBean stateBean)
		{
		}

		// Token: 0x0602BA71 RID: 178801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA71")]
		[Address(RVA = "0x278FCD0", Offset = "0x278E8D0", VA = "0x18278FCD0")]
		private void _NotifyToast(string toastStr)
		{
		}

		// Token: 0x0602BA72 RID: 178802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA72")]
		[Address(RVA = "0x278DA80", Offset = "0x278C680", VA = "0x18278DA80", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602BA73 RID: 178803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA73")]
		[Address(RVA = "0x278F3B0", Offset = "0x278DFB0", VA = "0x18278F3B0")]
		private void _EventOnZoneTagClicked(string selectZoneId)
		{
		}

		// Token: 0x0602BA74 RID: 178804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA74")]
		[Address(RVA = "0x278F240", Offset = "0x278DE40", VA = "0x18278F240")]
		private void _EventOnStageTagClicked(string selectStageId)
		{
		}

		// Token: 0x0602BA75 RID: 178805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA75")]
		[Address(RVA = "0x278E8D0", Offset = "0x278D4D0", VA = "0x18278E8D0")]
		private void _EventOnEnterStageClicked()
		{
		}

		// Token: 0x0602BA76 RID: 178806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA76")]
		[Address(RVA = "0x278E780", Offset = "0x278D380", VA = "0x18278E780")]
		private void _EventOnEnemyHandBookClicked()
		{
		}

		// Token: 0x0602BA77 RID: 178807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA77")]
		[Address(RVA = "0x278EDD0", Offset = "0x278D9D0", VA = "0x18278EDD0")]
		private void _EventOnMapClicked()
		{
		}

		// Token: 0x0602BA78 RID: 178808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA78")]
		[Address(RVA = "0x278E5A0", Offset = "0x278D1A0", VA = "0x18278E5A0")]
		private void _EventOnBadgeClicked()
		{
		}

		// Token: 0x0602BA79 RID: 178809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA79")]
		[Address(RVA = "0x278EFF0", Offset = "0x278DBF0", VA = "0x18278EFF0")]
		private void _EventOnScoreInfoClicked()
		{
		}

		// Token: 0x0602BA7A RID: 178810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA7A")]
		[Address(RVA = "0x278E300", Offset = "0x278CF00", VA = "0x18278E300", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602BA7B RID: 178811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA7B")]
		[Address(RVA = "0x278D310", Offset = "0x278BF10", VA = "0x18278D310", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602BA7C RID: 178812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA7C")]
		[Address(RVA = "0x278E440", Offset = "0x278D040", VA = "0x18278E440", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0602BA7D RID: 178813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA7D")]
		[Address(RVA = "0x278D450", Offset = "0x278C050", VA = "0x18278D450", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0602BA7E RID: 178814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA7E")]
		[Address(RVA = "0x278FE60", Offset = "0x278EA60", VA = "0x18278FE60")]
		public Act1ArcadeStageSelectState()
		{
		}

		// Token: 0x0602BA81 RID: 178817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA81")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602BA82 RID: 178818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA82")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602BA83 RID: 178819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA83")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403F24D RID: 258637
		[Token(Token = "0x403F24D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<Act1ArcadeStageZoneEntryItemView> _zoneEntryItemViews;

		// Token: 0x0403F24E RID: 258638
		[Token(Token = "0x403F24E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<Act1ArcadeStageTagItemView> _stageTagItemViews;

		// Token: 0x0403F24F RID: 258639
		[Token(Token = "0x403F24F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1ArcadeStageDetailView _stageDetailView;

		// Token: 0x0403F250 RID: 258640
		[Token(Token = "0x403F250")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1ArcadeStageSelectBottomInfoView _bottomInfoView;

		// Token: 0x0403F251 RID: 258641
		[Token(Token = "0x403F251")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403F252 RID: 258642
		[Token(Token = "0x403F252")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _leaveAnim;

		// Token: 0x0403F253 RID: 258643
		[Token(Token = "0x403F253")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CanvasGroup _rootGroup;

		// Token: 0x0403F254 RID: 258644
		[Token(Token = "0x403F254")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Act1ArcadeToast _notifyToastPrefab;

		// Token: 0x0403F255 RID: 258645
		[Token(Token = "0x403F255")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x0403F256 RID: 258646
		[Token(Token = "0x403F256")]
		[FieldOffset(Offset = "0xB4")]
		private int m_dialogInst;

		// Token: 0x0403F257 RID: 258647
		[Token(Token = "0x403F257")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_blockClick;

		// Token: 0x0403F258 RID: 258648
		[Token(Token = "0x403F258")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_animTween;

		// Token: 0x0403F259 RID: 258649
		[Token(Token = "0x403F259")]
		[FieldOffset(Offset = "0xC8")]
		private Act1ArcadeStageSelectStateBean m_stateBean;

		// Token: 0x0403F25A RID: 258650
		[Token(Token = "0x403F25A")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isFromBattle;

		// Token: 0x0403F25B RID: 258651
		[Token(Token = "0x403F25B")]
		[FieldOffset(Offset = "0xD4")]
		private int m_scoreInfoInstId;

		// Token: 0x0403F25C RID: 258652
		[Token(Token = "0x403F25C")]
		[NonSerialized]
		public const int MSG_ZONE_TAG_CLICK = 0;

		// Token: 0x0403F25D RID: 258653
		[Token(Token = "0x403F25D")]
		[NonSerialized]
		public const int MSG_STAGE_TAG_CLICK = 1;

		// Token: 0x0403F25E RID: 258654
		[Token(Token = "0x403F25E")]
		[NonSerialized]
		public const int MSG_ENTER_STAGE_CLICK = 2;

		// Token: 0x0403F25F RID: 258655
		[Token(Token = "0x403F25F")]
		[NonSerialized]
		public const int MSG_ENEMY_HANDBOOK_CLICK = 3;

		// Token: 0x0403F260 RID: 258656
		[Token(Token = "0x403F260")]
		[NonSerialized]
		public const int MSG_MAP_CLICK = 4;

		// Token: 0x0403F261 RID: 258657
		[Token(Token = "0x403F261")]
		[NonSerialized]
		public const int MSG_BADGE_CLICK = 5;

		// Token: 0x0403F262 RID: 258658
		[Token(Token = "0x403F262")]
		[NonSerialized]
		public const int MSG_SCORE_INFO_CLICK = 6;

		// Token: 0x0403F263 RID: 258659
		[Token(Token = "0x403F263")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnClickBack;

		// Token: 0x0403F264 RID: 258660
		[Token(Token = "0x403F264")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F265 RID: 258661
		[Token(Token = "0x403F265")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitStageItems;

		// Token: 0x0403F266 RID: 258662
		[Token(Token = "0x403F266")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403F267 RID: 258663
		[Token(Token = "0x403F267")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403F268 RID: 258664
		[Token(Token = "0x403F268")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403F269 RID: 258665
		[Token(Token = "0x403F269")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsUIStable;

		// Token: 0x0403F26A RID: 258666
		[Token(Token = "0x403F26A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403F26B RID: 258667
		[Token(Token = "0x403F26B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__JumpToBadgeState;

		// Token: 0x0403F26C RID: 258668
		[Token(Token = "0x403F26C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__NotifyToast;

		// Token: 0x0403F26D RID: 258669
		[Token(Token = "0x403F26D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403F26E RID: 258670
		[Token(Token = "0x403F26E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnZoneTagClicked;

		// Token: 0x0403F26F RID: 258671
		[Token(Token = "0x403F26F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnStageTagClicked;

		// Token: 0x0403F270 RID: 258672
		[Token(Token = "0x403F270")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EventOnEnterStageClicked;

		// Token: 0x0403F271 RID: 258673
		[Token(Token = "0x403F271")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EventOnEnemyHandBookClicked;

		// Token: 0x0403F272 RID: 258674
		[Token(Token = "0x403F272")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnMapClicked;

		// Token: 0x0403F273 RID: 258675
		[Token(Token = "0x403F273")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnBadgeClicked;

		// Token: 0x0403F274 RID: 258676
		[Token(Token = "0x403F274")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EventOnScoreInfoClicked;

		// Token: 0x0403F275 RID: 258677
		[Token(Token = "0x403F275")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403F276 RID: 258678
		[Token(Token = "0x403F276")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403F277 RID: 258679
		[Token(Token = "0x403F277")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0403F278 RID: 258680
		[Token(Token = "0x403F278")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0403F279 RID: 258681
		[Token(Token = "0x403F279")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
