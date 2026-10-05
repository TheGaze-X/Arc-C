using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079F9 RID: 31225
	[Token(Token = "0x20079F9")]
	public class Act13sideMissionState : PopupFadeState, IBaseActStateHolder, IHotfixable
	{
		// Token: 0x0602BC51 RID: 179281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC51")]
		[Address(RVA = "0x27B7FE0", Offset = "0x27B6BE0", VA = "0x1827B7FE0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BC52 RID: 179282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC52")]
		[Address(RVA = "0x27B8CC0", Offset = "0x27B78C0", VA = "0x1827B8CC0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602BC53 RID: 179283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC53")]
		[Address(RVA = "0x27B8110", Offset = "0x27B6D10", VA = "0x1827B8110")]
		public void OnDailyMissionSelect()
		{
		}

		// Token: 0x0602BC54 RID: 179284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC54")]
		[Address(RVA = "0x27B8920", Offset = "0x27B7520", VA = "0x1827B8920")]
		public void OnLongTermMissionSelect()
		{
		}

		// Token: 0x0602BC55 RID: 179285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC55")]
		[Address(RVA = "0x27B8F00", Offset = "0x27B7B00", VA = "0x1827B8F00")]
		public void SelectGroupId(string groupId)
		{
		}

		// Token: 0x0602BC56 RID: 179286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC56")]
		[Address(RVA = "0x27B94F0", Offset = "0x27B80F0", VA = "0x1827B94F0")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x0602BC57 RID: 179287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC57")]
		[Address(RVA = "0x27B8380", Offset = "0x27B6F80", VA = "0x1827B8380", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BC58 RID: 179288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC58")]
		[Address(RVA = "0x27B8890", Offset = "0x27B7490", VA = "0x1827B8890", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602BC59 RID: 179289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC59")]
		[Address(RVA = "0x27B8C30", Offset = "0x27B7830", VA = "0x1827B8C30", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602BC5A RID: 179290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC5A")]
		[Address(RVA = "0x27B8BC0", Offset = "0x27B77C0", VA = "0x1827B8BC0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0602BC5B RID: 179291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC5B")]
		[Address(RVA = "0x27B7D40", Offset = "0x27B6940", VA = "0x1827B7D40", Slot = "31")]
		public void BindController(TemplateActivityController controller)
		{
		}

		// Token: 0x0602BC5C RID: 179292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC5C")]
		[Address(RVA = "0x27BAF40", Offset = "0x27B9B40", VA = "0x1827BAF40")]
		private void _TriggerTutorialCoroutine()
		{
		}

		// Token: 0x0602BC5D RID: 179293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC5D")]
		[Address(RVA = "0x27BAE90", Offset = "0x27B9A90", VA = "0x1827BAE90")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x0602BC5E RID: 179294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC5E")]
		[Address(RVA = "0x27BB1A0", Offset = "0x27B9DA0", VA = "0x1827BB1A0")]
		private IEnumerator _WaitAndTrigTutorial()
		{
			return null;
		}

		// Token: 0x0602BC5F RID: 179295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC5F")]
		[Address(RVA = "0x27BA390", Offset = "0x27B8F90", VA = "0x1827BA390")]
		private void _PlayAgendaAnimIfNeed()
		{
		}

		// Token: 0x0602BC60 RID: 179296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC60")]
		[Address(RVA = "0x27BB0B0", Offset = "0x27B9CB0", VA = "0x1827BB0B0")]
		private void _UpdateDailyMissionProp()
		{
		}

		// Token: 0x0602BC61 RID: 179297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC61")]
		[Address(RVA = "0x27BAAA0", Offset = "0x27B96A0", VA = "0x1827BAAA0")]
		private void _ShowFilterRewardList(Act13SideDailyMissionCommitResponse commitResponse, Act13SideData.OrgData orgData)
		{
		}

		// Token: 0x0602BC62 RID: 179298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC62")]
		[Address(RVA = "0x27B9610", Offset = "0x27B8210", VA = "0x1827B9610")]
		private void _JumpToPrestigePromoteState()
		{
		}

		// Token: 0x0602BC63 RID: 179299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC63")]
		[Address(RVA = "0x27BA6F0", Offset = "0x27B92F0", VA = "0x1827BA6F0")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onAfterItemShow)
		{
			return null;
		}

		// Token: 0x0602BC64 RID: 179300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC64")]
		[Address(RVA = "0x27BA7D0", Offset = "0x27B93D0", VA = "0x1827BA7D0")]
		private void _SendDailyFlagRecover(string flag, Action onComplete)
		{
		}

		// Token: 0x0602BC65 RID: 179301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC65")]
		[Address(RVA = "0x27B9450", Offset = "0x27B8050", VA = "0x1827B9450")]
		private void _AddMissionPoolStateToTop(bool showRefreshAnim)
		{
		}

		// Token: 0x0602BC66 RID: 179302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC66")]
		[Address(RVA = "0x27B8040", Offset = "0x27B6C40", VA = "0x1827B8040")]
		public void OnBtnCloseAgedaAnim()
		{
		}

		// Token: 0x0602BC67 RID: 179303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC67")]
		[Address(RVA = "0x27B9780", Offset = "0x27B8380", VA = "0x1827B9780")]
		private void _NavToDailyMissionPoolState()
		{
		}

		// Token: 0x0602BC68 RID: 179304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC68")]
		[Address(RVA = "0x27B9890", Offset = "0x27B8490", VA = "0x1827B9890")]
		private void _NavToStage(string stageId)
		{
		}

		// Token: 0x0602BC69 RID: 179305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC69")]
		[Address(RVA = "0x27BA000", Offset = "0x27B8C00", VA = "0x1827BA000")]
		private void _OnDailyMissionCommit(int boardIdx)
		{
		}

		// Token: 0x0602BC6A RID: 179306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC6A")]
		[Address(RVA = "0x27B9950", Offset = "0x27B8550", VA = "0x1827B9950")]
		private void _OnDailyMissionCancelWithDialog(int boardIdx)
		{
		}

		// Token: 0x0602BC6B RID: 179307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC6B")]
		[Address(RVA = "0x27B9D70", Offset = "0x27B8970", VA = "0x1827B9D70")]
		private void _OnDailyMissionCancel(int boardIdx)
		{
		}

		// Token: 0x0602BC6C RID: 179308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC6C")]
		[Address(RVA = "0x27BB250", Offset = "0x27B9E50", VA = "0x1827BB250")]
		public Act13sideMissionState()
		{
		}

		// Token: 0x0602BC76 RID: 179318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BC76")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602BC77 RID: 179319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC77")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602BC78 RID: 179320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC78")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0602BC79 RID: 179321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC79")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602BC7A RID: 179322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC7A")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0403F531 RID: 259377
		[Token(Token = "0x403F531")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act13sideDailyMissionListView _dailyMissionView;

		// Token: 0x0403F532 RID: 259378
		[Token(Token = "0x403F532")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act13sideNormalMissionOneView _missionOneView;

		// Token: 0x0403F533 RID: 259379
		[Token(Token = "0x403F533")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act13sideMissionStateBtn _missionbtn;

		// Token: 0x0403F534 RID: 259380
		[Token(Token = "0x403F534")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Act13sideMissionStateBtn _dailyMissionBtn;

		// Token: 0x0403F535 RID: 259381
		[Token(Token = "0x403F535")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _animDailyMission;

		// Token: 0x0403F536 RID: 259382
		[Token(Token = "0x403F536")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _animDailyMissionDelay;

		// Token: 0x0403F537 RID: 259383
		[Token(Token = "0x403F537")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("agenda Recover")]
		private UIAnimationLocation _animAgendaRecover;

		// Token: 0x0403F538 RID: 259384
		[Token(Token = "0x403F538")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("agenda Recover")]
		private GameObject _agendaAnimGo;

		// Token: 0x0403F539 RID: 259385
		[Token(Token = "0x403F539")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("agenda Recover")]
		private Text _textRecover;

		// Token: 0x0403F53A RID: 259386
		[Token(Token = "0x403F53A")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("agenda Recover")]
		private Text _textAgenda;

		// Token: 0x0403F53B RID: 259387
		[Token(Token = "0x403F53B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("agenda Recover")]
		private Text _textAgendaMax;

		// Token: 0x0403F53C RID: 259388
		[Token(Token = "0x403F53C")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("agenda Recover")]
		private Text _textMaxHint;

		// Token: 0x0403F53D RID: 259389
		[Token(Token = "0x403F53D")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("agenda Recover")]
		private GameObject _maxHintGo;

		// Token: 0x0403F53E RID: 259390
		[Token(Token = "0x403F53E")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private string _guidebookSubsignal;

		// Token: 0x0403F53F RID: 259391
		[Token(Token = "0x403F53F")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403F540 RID: 259392
		[Token(Token = "0x403F540")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private CanvasGroup _dailyCanvas;

		// Token: 0x0403F541 RID: 259393
		[Token(Token = "0x403F541")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private CanvasGroup _longTermCanvas;

		// Token: 0x0403F542 RID: 259394
		[Token(Token = "0x403F542")]
		private const float ALPHA_DURATION = 0.4f;

		// Token: 0x0403F543 RID: 259395
		[Token(Token = "0x403F543")]
		private const string FLAG_AGENDA = "agenda";

		// Token: 0x0403F544 RID: 259396
		[Token(Token = "0x403F544")]
		private const string FLAG_MISSION = "mission";

		// Token: 0x0403F545 RID: 259397
		[Token(Token = "0x403F545")]
		[FieldOffset(Offset = "0x108")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403F546 RID: 259398
		[Token(Token = "0x403F546")]
		[FieldOffset(Offset = "0x110")]
		private TemplateActivityController m_cacheController;

		// Token: 0x0403F547 RID: 259399
		[Token(Token = "0x403F547")]
		[FieldOffset(Offset = "0x118")]
		private Act13sideMissionStateBean m_stateBean;

		// Token: 0x0403F548 RID: 259400
		[Token(Token = "0x403F548")]
		[FieldOffset(Offset = "0x120")]
		private string m_cacheGroupId;

		// Token: 0x0403F549 RID: 259401
		[Token(Token = "0x403F549")]
		[FieldOffset(Offset = "0x128")]
		private bool m_showAgendaAnim;

		// Token: 0x0403F54A RID: 259402
		[Token(Token = "0x403F54A")]
		[FieldOffset(Offset = "0x129")]
		private bool m_showMissionRefreshAnim;

		// Token: 0x0403F54B RID: 259403
		[Token(Token = "0x403F54B")]
		[FieldOffset(Offset = "0x12A")]
		private bool m_isDailyMissionAnim;

		// Token: 0x0403F54C RID: 259404
		[Token(Token = "0x403F54C")]
		[FieldOffset(Offset = "0x130")]
		private Act13sideMissionState.PrestigePromoteParam m_promoteParam;

		// Token: 0x0403F54D RID: 259405
		[Token(Token = "0x403F54D")]
		[FieldOffset(Offset = "0x138")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0403F54E RID: 259406
		[Token(Token = "0x403F54E")]
		[FieldOffset(Offset = "0x140")]
		private Tween m_doTween;

		// Token: 0x0403F54F RID: 259407
		[Token(Token = "0x403F54F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403F550 RID: 259408
		[Token(Token = "0x403F550")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403F551 RID: 259409
		[Token(Token = "0x403F551")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDailyMissionSelect;

		// Token: 0x0403F552 RID: 259410
		[Token(Token = "0x403F552")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnLongTermMissionSelect;

		// Token: 0x0403F553 RID: 259411
		[Token(Token = "0x403F553")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SelectGroupId;

		// Token: 0x0403F554 RID: 259412
		[Token(Token = "0x403F554")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0403F555 RID: 259413
		[Token(Token = "0x403F555")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403F556 RID: 259414
		[Token(Token = "0x403F556")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403F557 RID: 259415
		[Token(Token = "0x403F557")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403F558 RID: 259416
		[Token(Token = "0x403F558")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0403F559 RID: 259417
		[Token(Token = "0x403F559")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_BindController;

		// Token: 0x0403F55A RID: 259418
		[Token(Token = "0x403F55A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TriggerTutorialCoroutine;

		// Token: 0x0403F55B RID: 259419
		[Token(Token = "0x403F55B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0403F55C RID: 259420
		[Token(Token = "0x403F55C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__WaitAndTrigTutorial;

		// Token: 0x0403F55D RID: 259421
		[Token(Token = "0x403F55D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__PlayAgendaAnimIfNeed;

		// Token: 0x0403F55E RID: 259422
		[Token(Token = "0x403F55E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateDailyMissionProp;

		// Token: 0x0403F55F RID: 259423
		[Token(Token = "0x403F55F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ShowFilterRewardList;

		// Token: 0x0403F560 RID: 259424
		[Token(Token = "0x403F560")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__JumpToPrestigePromoteState;

		// Token: 0x0403F561 RID: 259425
		[Token(Token = "0x403F561")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403F562 RID: 259426
		[Token(Token = "0x403F562")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SendDailyFlagRecover;

		// Token: 0x0403F563 RID: 259427
		[Token(Token = "0x403F563")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__AddMissionPoolStateToTop;

		// Token: 0x0403F564 RID: 259428
		[Token(Token = "0x403F564")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnBtnCloseAgedaAnim;

		// Token: 0x0403F565 RID: 259429
		[Token(Token = "0x403F565")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__NavToDailyMissionPoolState;

		// Token: 0x0403F566 RID: 259430
		[Token(Token = "0x403F566")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__NavToStage;

		// Token: 0x0403F567 RID: 259431
		[Token(Token = "0x403F567")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnDailyMissionCommit;

		// Token: 0x0403F568 RID: 259432
		[Token(Token = "0x403F568")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnDailyMissionCancelWithDialog;

		// Token: 0x0403F569 RID: 259433
		[Token(Token = "0x403F569")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnDailyMissionCancel;

		// Token: 0x0403F56A RID: 259434
		[Token(Token = "0x403F56A")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020079FA RID: 31226
		[Token(Token = "0x20079FA")]
		public class PrestigePromoteParam
		{
			// Token: 0x0602BC7B RID: 179323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BC7B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PrestigePromoteParam()
			{
			}

			// Token: 0x0403F56B RID: 259435
			[Token(Token = "0x403F56B")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403F56C RID: 259436
			[Token(Token = "0x403F56C")]
			[FieldOffset(Offset = "0x18")]
			public string orgId;

			// Token: 0x0403F56D RID: 259437
			[Token(Token = "0x403F56D")]
			[FieldOffset(Offset = "0x20")]
			public Act13SideData.PrestigeRank laskRank;

			// Token: 0x0403F56E RID: 259438
			[Token(Token = "0x403F56E")]
			[FieldOffset(Offset = "0x24")]
			public Act13SideData.PrestigeRank currentRank;
		}
	}
}
