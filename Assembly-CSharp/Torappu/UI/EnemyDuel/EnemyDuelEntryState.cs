using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F89 RID: 20361
	[Token(Token = "0x2004F89")]
	public class EnemyDuelEntryState : PopupFadeState, IValueMsgReceiver, ICompDialogCallBack, IHotfixable
	{
		// Token: 0x0601E45A RID: 123994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E45A")]
		[Address(RVA = "0x17FE060", Offset = "0x17FCC60", VA = "0x1817FE060", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E45B RID: 123995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E45B")]
		[Address(RVA = "0x17FE520", Offset = "0x17FD120", VA = "0x1817FE520", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x170046E8 RID: 18152
		// (get) Token: 0x0601E45C RID: 123996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046E8")]
		public string actId
		{
			[Token(Token = "0x601E45C")]
			[Address(RVA = "0x1801DA0", Offset = "0x18009A0", VA = "0x181801DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E45D RID: 123997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E45D")]
		[Address(RVA = "0x17FFAB0", Offset = "0x17FE6B0", VA = "0x1817FFAB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E45E RID: 123998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E45E")]
		[Address(RVA = "0x17FF490", Offset = "0x17FE090", VA = "0x1817FF490")]
		private void _BuildDynLoopAnimHolder()
		{
		}

		// Token: 0x0601E45F RID: 123999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E45F")]
		[Address(RVA = "0x17FE280", Offset = "0x17FCE80", VA = "0x1817FE280", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E460 RID: 124000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E460")]
		[Address(RVA = "0x17FF360", Offset = "0x17FDF60", VA = "0x1817FF360")]
		private void _BindBackRT(RenderTexture texture)
		{
		}

		// Token: 0x0601E461 RID: 124001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E461")]
		[Address(RVA = "0x1801900", Offset = "0x1800500", VA = "0x181801900")]
		private void _UnBindBackRT()
		{
		}

		// Token: 0x0601E462 RID: 124002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E462")]
		[Address(RVA = "0x17FEEB0", Offset = "0x17FDAB0", VA = "0x1817FEEB0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601E463 RID: 124003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E463")]
		[Address(RVA = "0x17FE180", Offset = "0x17FCD80", VA = "0x1817FE180")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601E464 RID: 124004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E464")]
		[Address(RVA = "0x17FF0A0", Offset = "0x17FDCA0", VA = "0x1817FF0A0")]
		public void TriggerEntryAnim(Action onAnimFinish)
		{
		}

		// Token: 0x0601E465 RID: 124005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E465")]
		[Address(RVA = "0x17FEF20", Offset = "0x17FDB20", VA = "0x1817FEF20")]
		public void ResetEntryAnim(bool isShow)
		{
		}

		// Token: 0x0601E466 RID: 124006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E466")]
		[Address(RVA = "0x17FFF40", Offset = "0x17FEB40", VA = "0x1817FFF40")]
		private void _OnEnterAnimEndOpenWnd()
		{
		}

		// Token: 0x0601E467 RID: 124007 RVA: 0x000AE120 File Offset: 0x000AC320
		[Token(Token = "0x601E467")]
		[Address(RVA = "0x17FF7F0", Offset = "0x17FE3F0", VA = "0x1817FF7F0")]
		private bool _CheckIfAnimPlaying()
		{
			return default(bool);
		}

		// Token: 0x0601E468 RID: 124008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E468")]
		[Address(RVA = "0x17FF750", Offset = "0x17FE350", VA = "0x1817FF750")]
		private void _CancelTweenIfNeeded()
		{
		}

		// Token: 0x0601E469 RID: 124009 RVA: 0x000AE138 File Offset: 0x000AC338
		[Token(Token = "0x601E469")]
		[Address(RVA = "0x17FF860", Offset = "0x17FE460", VA = "0x1817FF860")]
		private bool _CheckNeedAutoShow()
		{
			return default(bool);
		}

		// Token: 0x0601E46A RID: 124010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E46A")]
		[Address(RVA = "0x1801880", Offset = "0x1800480", VA = "0x181801880")]
		private void _TryConsumeGuideBookAutoShow()
		{
		}

		// Token: 0x0601E46B RID: 124011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E46B")]
		[Address(RVA = "0x17FE0C0", Offset = "0x17FCCC0", VA = "0x1817FE0C0", Slot = "32")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601E46C RID: 124012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E46C")]
		[Address(RVA = "0x18019C0", Offset = "0x18005C0", VA = "0x1818019C0")]
		private void _UpdateData()
		{
		}

		// Token: 0x0601E46D RID: 124013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E46D")]
		private void _OnDialogClick<TDialog, TDialogParam>(string dialogPath, TDialogParam dialogParam, int dialogInstIn, out int dialogInstOut) where TDialog : UICompDialog<TDialogParam> where TDialogParam : class
		{
		}

		// Token: 0x0601E46E RID: 124014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E46E")]
		[Address(RVA = "0x17FFC40", Offset = "0x17FE840", VA = "0x1817FFC40")]
		private void _OnBackClickImpl()
		{
		}

		// Token: 0x0601E46F RID: 124015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E46F")]
		[Address(RVA = "0x18005B0", Offset = "0x17FF1B0", VA = "0x1818005B0")]
		private void _OnMainWindowClick()
		{
		}

		// Token: 0x0601E470 RID: 124016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E470")]
		[Address(RVA = "0x1801140", Offset = "0x17FFD40", VA = "0x181801140")]
		private void _OnOpenMainWindow()
		{
		}

		// Token: 0x0601E471 RID: 124017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E471")]
		[Address(RVA = "0x1800F80", Offset = "0x17FFB80", VA = "0x181800F80")]
		private void _OnMusicWindowClick()
		{
		}

		// Token: 0x0601E472 RID: 124018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E472")]
		[Address(RVA = "0x18006A0", Offset = "0x17FF2A0", VA = "0x1818006A0")]
		private void _OnMainWindowCloseClick()
		{
		}

		// Token: 0x0601E473 RID: 124019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E473")]
		[Address(RVA = "0x1801060", Offset = "0x17FFC60", VA = "0x181801060")]
		private void _OnMusicWindowCloseClick()
		{
		}

		// Token: 0x0601E474 RID: 124020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E474")]
		[Address(RVA = "0x1800470", Offset = "0x17FF070", VA = "0x181800470")]
		private void _OnHomeClick()
		{
		}

		// Token: 0x0601E475 RID: 124021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E475")]
		[Address(RVA = "0x1800CD0", Offset = "0x17FF8D0", VA = "0x181800CD0")]
		private void _OnMileStoneClick()
		{
		}

		// Token: 0x0601E476 RID: 124022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E476")]
		[Address(RVA = "0x1800090", Offset = "0x17FEC90", VA = "0x181800090")]
		private void _OnEnterRoomClick()
		{
		}

		// Token: 0x0601E477 RID: 124023 RVA: 0x000AE150 File Offset: 0x000AC350
		[Token(Token = "0x601E477")]
		[Address(RVA = "0x17FF900", Offset = "0x17FE500", VA = "0x1817FF900")]
		private bool _CheckPassPreposedMode()
		{
			return default(bool);
		}

		// Token: 0x0601E478 RID: 124024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E478")]
		[Address(RVA = "0x1801570", Offset = "0x1800170", VA = "0x181801570")]
		private void _ResetAllWnd(bool isMainShow, bool isMusicShow)
		{
		}

		// Token: 0x0601E479 RID: 124025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E479")]
		[Address(RVA = "0x1800B20", Offset = "0x17FF720", VA = "0x181800B20")]
		private void _OnMedalClick()
		{
		}

		// Token: 0x0601E47A RID: 124026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E47A")]
		[Address(RVA = "0x17FFD40", Offset = "0x17FE940", VA = "0x1817FFD40")]
		private void _OnCreateRoomClick()
		{
		}

		// Token: 0x0601E47B RID: 124027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E47B")]
		[Address(RVA = "0x1800780", Offset = "0x17FF380", VA = "0x181800780")]
		private void _OnMatchClick()
		{
		}

		// Token: 0x0601E47C RID: 124028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E47C")]
		[Address(RVA = "0x1801210", Offset = "0x17FFE10", VA = "0x181801210")]
		private void _PlayLoopAnims()
		{
		}

		// Token: 0x0601E47D RID: 124029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E47D")]
		[Address(RVA = "0x1801670", Offset = "0x1800270", VA = "0x181801670")]
		private void _StopLoopAnimsIfNeeded()
		{
		}

		// Token: 0x0601E47E RID: 124030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E47E")]
		[Address(RVA = "0x1801BC0", Offset = "0x18007C0", VA = "0x181801BC0")]
		public EnemyDuelEntryState()
		{
		}

		// Token: 0x0601E47F RID: 124031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E47F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601E480 RID: 124032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E480")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04028652 RID: 165458
		[Token(Token = "0x4028652")]
		private const string GUIDE_SUB_SIGNAL = "entry";

		// Token: 0x04028653 RID: 165459
		[Token(Token = "0x4028653")]
		private const int INPUT_MAX_CNT = 80;

		// Token: 0x04028654 RID: 165460
		[Token(Token = "0x4028654")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _backBtnRt;

		// Token: 0x04028655 RID: 165461
		[Token(Token = "0x4028655")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private EnemyDuelEntryView _enemyDuelEntryView;

		// Token: 0x04028656 RID: 165462
		[Token(Token = "0x4028656")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _enterOpenMainDelay;

		// Token: 0x04028657 RID: 165463
		[Token(Token = "0x4028657")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _enterShowGuideBookDelay;

		// Token: 0x04028658 RID: 165464
		[Token(Token = "0x4028658")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04028659 RID: 165465
		[Token(Token = "0x4028659")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation[] _loopAnims;

		// Token: 0x0402865A RID: 165466
		[Token(Token = "0x402865A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private EnemyDuelEntryTimeLineView _timeLineView;

		// Token: 0x0402865B RID: 165467
		[Token(Token = "0x402865B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _frontLoopAnimContainer;

		// Token: 0x0402865C RID: 165468
		[Token(Token = "0x402865C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RectTransform _backLoopAnimContainer;

		// Token: 0x0402865D RID: 165469
		[Token(Token = "0x402865D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private RawImage _bgRtImage;

		// Token: 0x0402865E RID: 165470
		[Token(Token = "0x402865E")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x0402865F RID: 165471
		[Token(Token = "0x402865F")]
		[FieldOffset(Offset = "0xC8")]
		private string m_actId;

		// Token: 0x04028660 RID: 165472
		[Token(Token = "0x4028660")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_animTween;

		// Token: 0x04028661 RID: 165473
		[Token(Token = "0x4028661")]
		[FieldOffset(Offset = "0xD8")]
		private List<Tween> m_loopTweens;

		// Token: 0x04028662 RID: 165474
		[Token(Token = "0x4028662")]
		[FieldOffset(Offset = "0xE0")]
		private int m_dailyDialog;

		// Token: 0x04028663 RID: 165475
		[Token(Token = "0x4028663")]
		[FieldOffset(Offset = "0xE4")]
		private int m_rewardDialog;

		// Token: 0x04028664 RID: 165476
		[Token(Token = "0x4028664")]
		[FieldOffset(Offset = "0xE8")]
		private EnemyDuelEntryPage m_page;

		// Token: 0x04028665 RID: 165477
		[Token(Token = "0x4028665")]
		[FieldOffset(Offset = "0xF0")]
		private EnemyDuelEntryStateBean m_stateBean;

		// Token: 0x04028666 RID: 165478
		[Token(Token = "0x4028666")]
		[FieldOffset(Offset = "0xF8")]
		private EnemyDuelEntryAnimHolder m_backLoopHolder;

		// Token: 0x04028667 RID: 165479
		[Token(Token = "0x4028667")]
		[FieldOffset(Offset = "0x100")]
		private EnemyDuelEntryAnimHolder m_frontLoopHolder;

		// Token: 0x04028668 RID: 165480
		[Token(Token = "0x4028668")]
		[FieldOffset(Offset = "0x108")]
		private EnemyDuelEntryAnimHolder m_spineLoopHolder;

		// Token: 0x04028669 RID: 165481
		[Token(Token = "0x4028669")]
		[NonSerialized]
		public const int ON_BACK_CLICK = 0;

		// Token: 0x0402866A RID: 165482
		[Token(Token = "0x402866A")]
		[NonSerialized]
		public const int ON_MAIN_WINDOW_CLICK = 1;

		// Token: 0x0402866B RID: 165483
		[Token(Token = "0x402866B")]
		[NonSerialized]
		public const int ON_MUSIC_WINDOW_CLICK = 2;

		// Token: 0x0402866C RID: 165484
		[Token(Token = "0x402866C")]
		[NonSerialized]
		public const int ON_MAIN_WINDOW_CLOSE_CLICK = 3;

		// Token: 0x0402866D RID: 165485
		[Token(Token = "0x402866D")]
		[NonSerialized]
		public const int ON_MUSIC_WINDOW_CLOSE_CLICK = 4;

		// Token: 0x0402866E RID: 165486
		[Token(Token = "0x402866E")]
		[NonSerialized]
		public const int ON_HOME_CLICK = 5;

		// Token: 0x0402866F RID: 165487
		[Token(Token = "0x402866F")]
		[NonSerialized]
		public const int ON_MILESTONE_CLICK = 6;

		// Token: 0x04028670 RID: 165488
		[Token(Token = "0x4028670")]
		[NonSerialized]
		public const int ON_DAILY_CLICK = 7;

		// Token: 0x04028671 RID: 165489
		[Token(Token = "0x4028671")]
		[NonSerialized]
		public const int ON_ENTER_ROOM_CLICK = 8;

		// Token: 0x04028672 RID: 165490
		[Token(Token = "0x4028672")]
		[NonSerialized]
		public const int ON_CREATE_ROOM_CLICK = 9;

		// Token: 0x04028673 RID: 165491
		[Token(Token = "0x4028673")]
		[NonSerialized]
		public const int ON_MATCH_CLICK = 10;

		// Token: 0x04028674 RID: 165492
		[Token(Token = "0x4028674")]
		[NonSerialized]
		public const int ON_REWARD_CLICK = 11;

		// Token: 0x04028675 RID: 165493
		[Token(Token = "0x4028675")]
		[NonSerialized]
		public const int ON_MEDAL_CLICK = 12;

		// Token: 0x04028676 RID: 165494
		[Token(Token = "0x4028676")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04028677 RID: 165495
		[Token(Token = "0x4028677")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04028678 RID: 165496
		[Token(Token = "0x4028678")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04028679 RID: 165497
		[Token(Token = "0x4028679")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402867A RID: 165498
		[Token(Token = "0x402867A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__BuildDynLoopAnimHolder;

		// Token: 0x0402867B RID: 165499
		[Token(Token = "0x402867B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402867C RID: 165500
		[Token(Token = "0x402867C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__BindBackRT;

		// Token: 0x0402867D RID: 165501
		[Token(Token = "0x402867D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UnBindBackRT;

		// Token: 0x0402867E RID: 165502
		[Token(Token = "0x402867E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402867F RID: 165503
		[Token(Token = "0x402867F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04028680 RID: 165504
		[Token(Token = "0x4028680")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TriggerEntryAnim;

		// Token: 0x04028681 RID: 165505
		[Token(Token = "0x4028681")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ResetEntryAnim;

		// Token: 0x04028682 RID: 165506
		[Token(Token = "0x4028682")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnEnterAnimEndOpenWnd;

		// Token: 0x04028683 RID: 165507
		[Token(Token = "0x4028683")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CheckIfAnimPlaying;

		// Token: 0x04028684 RID: 165508
		[Token(Token = "0x4028684")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CancelTweenIfNeeded;

		// Token: 0x04028685 RID: 165509
		[Token(Token = "0x4028685")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CheckNeedAutoShow;

		// Token: 0x04028686 RID: 165510
		[Token(Token = "0x4028686")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__TryConsumeGuideBookAutoShow;

		// Token: 0x04028687 RID: 165511
		[Token(Token = "0x4028687")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04028688 RID: 165512
		[Token(Token = "0x4028688")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x04028689 RID: 165513
		[Token(Token = "0x4028689")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnDialogClick;

		// Token: 0x0402868A RID: 165514
		[Token(Token = "0x402868A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnBackClickImpl;

		// Token: 0x0402868B RID: 165515
		[Token(Token = "0x402868B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnMainWindowClick;

		// Token: 0x0402868C RID: 165516
		[Token(Token = "0x402868C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnOpenMainWindow;

		// Token: 0x0402868D RID: 165517
		[Token(Token = "0x402868D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnMusicWindowClick;

		// Token: 0x0402868E RID: 165518
		[Token(Token = "0x402868E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnMainWindowCloseClick;

		// Token: 0x0402868F RID: 165519
		[Token(Token = "0x402868F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnMusicWindowCloseClick;

		// Token: 0x04028690 RID: 165520
		[Token(Token = "0x4028690")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnHomeClick;

		// Token: 0x04028691 RID: 165521
		[Token(Token = "0x4028691")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnMileStoneClick;

		// Token: 0x04028692 RID: 165522
		[Token(Token = "0x4028692")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnEnterRoomClick;

		// Token: 0x04028693 RID: 165523
		[Token(Token = "0x4028693")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CheckPassPreposedMode;

		// Token: 0x04028694 RID: 165524
		[Token(Token = "0x4028694")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__ResetAllWnd;

		// Token: 0x04028695 RID: 165525
		[Token(Token = "0x4028695")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__OnMedalClick;

		// Token: 0x04028696 RID: 165526
		[Token(Token = "0x4028696")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__OnCreateRoomClick;

		// Token: 0x04028697 RID: 165527
		[Token(Token = "0x4028697")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnMatchClick;

		// Token: 0x04028698 RID: 165528
		[Token(Token = "0x4028698")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__PlayLoopAnims;

		// Token: 0x04028699 RID: 165529
		[Token(Token = "0x4028699")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__StopLoopAnimsIfNeeded;

		// Token: 0x0402869A RID: 165530
		[Token(Token = "0x402869A")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F8A RID: 20362
		[Token(Token = "0x2004F8A")]
		public class EnterRoomConfig : CommonInputDialogServiceConfirmConfig<EnemyDuelJoinTeamRequest, EnemyDuelJoinTeamResponse>
		{
			// Token: 0x0601E481 RID: 124033 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E481")]
			[Address(RVA = "0x180A2E0", Offset = "0x1808EE0", VA = "0x18180A2E0", Slot = "7")]
			protected override EnemyDuelJoinTeamRequest ParseRequest(ValueBundle param, string inputText)
			{
				return null;
			}

			// Token: 0x170046E9 RID: 18153
			// (get) Token: 0x0601E482 RID: 124034 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170046E9")]
			protected override string serviceCode
			{
				[Token(Token = "0x601E482")]
				[Address(RVA = "0x180A580", Offset = "0x1809180", VA = "0x18180A580", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601E483 RID: 124035 RVA: 0x000AE168 File Offset: 0x000AC368
			[Token(Token = "0x601E483")]
			[Address(RVA = "0x180A000", Offset = "0x1808C00", VA = "0x18180A000", Slot = "9")]
			protected override bool OnValidateResponse(ValueBundle param, string inputText, EnemyDuelJoinTeamResponse response)
			{
				return default(bool);
			}

			// Token: 0x0601E484 RID: 124036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E484")]
			[Address(RVA = "0x180A3D0", Offset = "0x1808FD0", VA = "0x18180A3D0")]
			private void _HandleResult(EnemyDuelJoinTeamResponse.JoinResultType result)
			{
			}

			// Token: 0x0601E485 RID: 124037 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E485")]
			[Address(RVA = "0x1809F90", Offset = "0x1808B90", VA = "0x181809F90", Slot = "10")]
			public override string OnInputFieldValueChange(string input)
			{
				return null;
			}

			// Token: 0x0601E486 RID: 124038 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E486")]
			[Address(RVA = "0x1809E10", Offset = "0x1808A10", VA = "0x181809E10", Slot = "11")]
			public override string OnInputFieldEndEdit(string input)
			{
				return null;
			}

			// Token: 0x0601E487 RID: 124039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E487")]
			[Address(RVA = "0x180A510", Offset = "0x1809110", VA = "0x18180A510")]
			public EnterRoomConfig()
			{
			}

			// Token: 0x0402869B RID: 165531
			[Token(Token = "0x402869B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ParseRequest;

			// Token: 0x0402869C RID: 165532
			[Token(Token = "0x402869C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_serviceCode;

			// Token: 0x0402869D RID: 165533
			[Token(Token = "0x402869D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnValidateResponse;

			// Token: 0x0402869E RID: 165534
			[Token(Token = "0x402869E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__HandleResult;

			// Token: 0x0402869F RID: 165535
			[Token(Token = "0x402869F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnInputFieldValueChange;

			// Token: 0x040286A0 RID: 165536
			[Token(Token = "0x40286A0")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnInputFieldEndEdit;

			// Token: 0x040286A1 RID: 165537
			[Token(Token = "0x40286A1")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
