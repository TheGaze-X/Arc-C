using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CommonInviteDialog;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F1B RID: 28443
	[Token(Token = "0x2006F1B")]
	public class ActMultiV3EntryState : PopupFadeState, IValueMsgReceiver, IPopupCustomActive, ICompDialogCallBack
	{
		// Token: 0x06028661 RID: 165473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028661")]
		[Address(RVA = "0x23B33E0", Offset = "0x23B1FE0", VA = "0x1823B33E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028662 RID: 165474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028662")]
		[Address(RVA = "0x23B2FE0", Offset = "0x23B1BE0", VA = "0x1823B2FE0")]
		private Tween _GetAnimationTween(UIAnimationLocation animationLocation, bool isInverse = false)
		{
			return null;
		}

		// Token: 0x06028663 RID: 165475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028663")]
		[Address(RVA = "0x23B30E0", Offset = "0x23B1CE0", VA = "0x1823B30E0")]
		private Tween _GetEntryAnimTween()
		{
			return null;
		}

		// Token: 0x06028664 RID: 165476 RVA: 0x000D1BF8 File Offset: 0x000CFDF8
		[Token(Token = "0x6028664")]
		[Address(RVA = "0x23B3900", Offset = "0x23B2500", VA = "0x1823B3900")]
		private bool _IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x06028665 RID: 165477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028665")]
		[Address(RVA = "0x23AFC60", Offset = "0x23AE860", VA = "0x1823AFC60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06028666 RID: 165478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028666")]
		[Address(RVA = "0x23AFFE0", Offset = "0x23AEBE0", VA = "0x1823AFFE0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028667 RID: 165479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028667")]
		[Address(RVA = "0x23B10D0", Offset = "0x23AFCD0", VA = "0x1823B10D0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06028668 RID: 165480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028668")]
		[Address(RVA = "0x23B1060", Offset = "0x23AFC60", VA = "0x1823B1060", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x06028669 RID: 165481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028669")]
		[Address(RVA = "0x23B0150", Offset = "0x23AED50", VA = "0x1823B0150", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602866A RID: 165482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602866A")]
		[Address(RVA = "0x23B4FE0", Offset = "0x23B3BE0", VA = "0x1823B4FE0")]
		private void _StopCoroutineIfNeed()
		{
		}

		// Token: 0x0602866B RID: 165483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602866B")]
		[Address(RVA = "0x23B4CF0", Offset = "0x23B38F0", VA = "0x1823B4CF0")]
		private void _RaiseAVGSignalIfNeed()
		{
		}

		// Token: 0x0602866C RID: 165484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602866C")]
		[Address(RVA = "0x23B54C0", Offset = "0x23B40C0", VA = "0x1823B54C0")]
		private IEnumerator _WaitForTransFinishCoroutine()
		{
			return null;
		}

		// Token: 0x0602866D RID: 165485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602866D")]
		[Address(RVA = "0x23B19D0", Offset = "0x23B05D0", VA = "0x1823B19D0")]
		public void UpdateDataOnGetInfo()
		{
		}

		// Token: 0x0602866E RID: 165486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602866E")]
		[Address(RVA = "0x23AFB70", Offset = "0x23AE770", VA = "0x1823AFB70")]
		public void EffectOnPage(ActMultiV3EntryState.ShowStatus showStatus, bool fastMode)
		{
		}

		// Token: 0x0602866F RID: 165487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602866F")]
		[Address(RVA = "0x23B1310", Offset = "0x23AFF10", VA = "0x1823B1310", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06028670 RID: 165488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028670")]
		[Address(RVA = "0x23B4570", Offset = "0x23B3170", VA = "0x1823B4570")]
		private void _OnJumpToMedalGroupDisplayState(IStateBean stateBean)
		{
		}

		// Token: 0x06028671 RID: 165489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028671")]
		[Address(RVA = "0x23B46D0", Offset = "0x23B32D0", VA = "0x1823B46D0")]
		private void _OnJumpToRewardDetailState(IStateBean stateBean)
		{
		}

		// Token: 0x06028672 RID: 165490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028672")]
		[Address(RVA = "0x23B4940", Offset = "0x23B3540", VA = "0x1823B4940")]
		private void _OnJumpToStageListState(IStateBean stateBean)
		{
		}

		// Token: 0x06028673 RID: 165491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028673")]
		[Address(RVA = "0x23B4470", Offset = "0x23B3070", VA = "0x1823B4470")]
		private void _OnJumpToMatchState(IStateBean stateBean)
		{
		}

		// Token: 0x06028674 RID: 165492 RVA: 0x000D1C10 File Offset: 0x000CFE10
		[Token(Token = "0x6028674")]
		[Address(RVA = "0x23AFA30", Offset = "0x23AE630", VA = "0x1823AFA30", Slot = "32")]
		public bool CustomSetActive(bool active)
		{
			return default(bool);
		}

		// Token: 0x06028675 RID: 165493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028675")]
		[Address(RVA = "0x23B01C0", Offset = "0x23AEDC0", VA = "0x1823B01C0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06028676 RID: 165494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028676")]
		[Address(RVA = "0x23B1C60", Offset = "0x23B0860", VA = "0x1823B1C60")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x06028677 RID: 165495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028677")]
		[Address(RVA = "0x23B22E0", Offset = "0x23B0EE0", VA = "0x1823B22E0")]
		private void _EventOnBtnManualClicked()
		{
		}

		// Token: 0x06028678 RID: 165496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028678")]
		[Address(RVA = "0x23B2790", Offset = "0x23B1390", VA = "0x1823B2790")]
		private void _EventOnBtnRewardClicked()
		{
		}

		// Token: 0x06028679 RID: 165497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028679")]
		[Address(RVA = "0x23B24E0", Offset = "0x23B10E0", VA = "0x1823B24E0")]
		private void _EventOnBtnMilestoneClicked()
		{
		}

		// Token: 0x0602867A RID: 165498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602867A")]
		[Address(RVA = "0x23B2420", Offset = "0x23B1020", VA = "0x1823B2420")]
		private void _EventOnBtnMedalClicked()
		{
		}

		// Token: 0x0602867B RID: 165499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602867B")]
		[Address(RVA = "0x23B2880", Offset = "0x23B1480", VA = "0x1823B2880")]
		private void _EventOnBtnSquadClicked()
		{
		}

		// Token: 0x0602867C RID: 165500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602867C")]
		[Address(RVA = "0x23B2A00", Offset = "0x23B1600", VA = "0x1823B2A00")]
		private void _EventOnBtnStageClicked()
		{
		}

		// Token: 0x0602867D RID: 165501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602867D")]
		[Address(RVA = "0x23B2AF0", Offset = "0x23B16F0", VA = "0x1823B2AF0")]
		private void _EventOnBtnTeamMatchClicked()
		{
		}

		// Token: 0x0602867E RID: 165502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602867E")]
		[Address(RVA = "0x23B50F0", Offset = "0x23B3CF0", VA = "0x1823B50F0")]
		private void _TryTriggerTeamTutorial()
		{
		}

		// Token: 0x0602867F RID: 165503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602867F")]
		[Address(RVA = "0x23B5410", Offset = "0x23B4010", VA = "0x1823B5410")]
		private IEnumerator _WaitForFinishEnterRoom()
		{
			return null;
		}

		// Token: 0x06028680 RID: 165504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028680")]
		[Address(RVA = "0x23B2620", Offset = "0x23B1220", VA = "0x1823B2620")]
		private void _EventOnBtnQuickMatchClicked()
		{
		}

		// Token: 0x06028681 RID: 165505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028681")]
		[Address(RVA = "0x23B1A90", Offset = "0x23B0690", VA = "0x1823B1A90")]
		private void _ClearQuickMatchTrackpoint()
		{
		}

		// Token: 0x06028682 RID: 165506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028682")]
		[Address(RVA = "0x23B4E70", Offset = "0x23B3A70", VA = "0x1823B4E70")]
		private void _ShowSquadCountNotEnoughDialog()
		{
		}

		// Token: 0x06028683 RID: 165507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028683")]
		[Address(RVA = "0x23B2E70", Offset = "0x23B1A70", VA = "0x1823B2E70")]
		private void _EventOnInputTeamIdChanged(string inputVal)
		{
		}

		// Token: 0x06028684 RID: 165508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028684")]
		[Address(RVA = "0x23B1D70", Offset = "0x23B0970", VA = "0x1823B1D70")]
		private void _EventOnBtnCreateTeamClicked()
		{
		}

		// Token: 0x06028685 RID: 165509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028685")]
		[Address(RVA = "0x23B2220", Offset = "0x23B0E20", VA = "0x1823B2220")]
		private void _EventOnBtnJoinTeamClicked()
		{
		}

		// Token: 0x06028686 RID: 165510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028686")]
		[Address(RVA = "0x23B3A80", Offset = "0x23B2680", VA = "0x1823B3A80")]
		private void _JoinTeamImpl(string teamId)
		{
		}

		// Token: 0x06028687 RID: 165511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028687")]
		[Address(RVA = "0x23B2CA0", Offset = "0x23B18A0", VA = "0x1823B2CA0")]
		private void _EventOnBtnTrainingRoomClicked()
		{
		}

		// Token: 0x06028688 RID: 165512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028688")]
		[Address(RVA = "0x23B2050", Offset = "0x23B0C50", VA = "0x1823B2050")]
		private void _EventOnBtnInviteClicked()
		{
		}

		// Token: 0x06028689 RID: 165513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028689")]
		[Address(RVA = "0x23B3DD0", Offset = "0x23B29D0", VA = "0x1823B3DD0")]
		private void _OnCreateTeamRespHandle(ActMultiV3CreateTeamResponse resp)
		{
		}

		// Token: 0x0602868A RID: 165514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602868A")]
		[Address(RVA = "0x23B4AC0", Offset = "0x23B36C0", VA = "0x1823B4AC0")]
		private void _OnSendJoinTeamRequest(string teamId)
		{
		}

		// Token: 0x0602868B RID: 165515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602868B")]
		[Address(RVA = "0x23B4110", Offset = "0x23B2D10", VA = "0x1823B4110")]
		private void _OnJoinTeamRespHandle(ActMultiV3JoinTeamResponse resp)
		{
		}

		// Token: 0x0602868C RID: 165516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602868C")]
		[Address(RVA = "0x23AFCC0", Offset = "0x23AE8C0", VA = "0x1823AFCC0", Slot = "33")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0602868D RID: 165517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602868D")]
		[Address(RVA = "0x23B3280", Offset = "0x23B1E80", VA = "0x1823B3280")]
		private void _HandleInviteDialogCallback(CommonInviteDialog.Output output)
		{
		}

		// Token: 0x0602868E RID: 165518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602868E")]
		[Address(RVA = "0x23B5570", Offset = "0x23B4170", VA = "0x1823B5570")]
		public ActMultiV3EntryState()
		{
		}

		// Token: 0x06028696 RID: 165526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028696")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06028697 RID: 165527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028697")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06028698 RID: 165528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028698")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x06028699 RID: 165529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028699")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0602869A RID: 165530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602869A")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403970D RID: 235277
		[Token(Token = "0x403970D")]
		[NonSerialized]
		public const int ON_BTN_MANUAL_CLICKED = 0;

		// Token: 0x0403970E RID: 235278
		[Token(Token = "0x403970E")]
		[NonSerialized]
		public const int ON_BTN_MILESTONE_CLICKED = 1;

		// Token: 0x0403970F RID: 235279
		[Token(Token = "0x403970F")]
		[NonSerialized]
		public const int ON_BTN_REWARD_CLICKED = 2;

		// Token: 0x04039710 RID: 235280
		[Token(Token = "0x4039710")]
		[NonSerialized]
		public const int ON_BTN_SQUAD_CLICKED = 3;

		// Token: 0x04039711 RID: 235281
		[Token(Token = "0x4039711")]
		[NonSerialized]
		public const int ON_BTN_STAGE_CLICKED = 4;

		// Token: 0x04039712 RID: 235282
		[Token(Token = "0x4039712")]
		[NonSerialized]
		public const int ON_BTN_TEAM_MATCH_CLICKED = 5;

		// Token: 0x04039713 RID: 235283
		[Token(Token = "0x4039713")]
		[NonSerialized]
		public const int ON_BTN_QUICK_MATCH_CLICKED = 6;

		// Token: 0x04039714 RID: 235284
		[Token(Token = "0x4039714")]
		[NonSerialized]
		public const int ON_BTN_MEDAL_CLICKED = 7;

		// Token: 0x04039715 RID: 235285
		[Token(Token = "0x4039715")]
		[NonSerialized]
		public const int ON_INPUT_TEAM_ID_CHANGED = 8;

		// Token: 0x04039716 RID: 235286
		[Token(Token = "0x4039716")]
		[NonSerialized]
		public const int ON_BTN_CREATE_TEAM_CLICKED = 9;

		// Token: 0x04039717 RID: 235287
		[Token(Token = "0x4039717")]
		[NonSerialized]
		public const int ON_BTN_JOIN_TEAM_CLICKED = 10;

		// Token: 0x04039718 RID: 235288
		[Token(Token = "0x4039718")]
		[NonSerialized]
		public const int ON_BTN_TRAINING_ROOM_CLICKED = 11;

		// Token: 0x04039719 RID: 235289
		[Token(Token = "0x4039719")]
		[NonSerialized]
		public const int ON_BTN_INVITE_CLICKED = 12;

		// Token: 0x0403971A RID: 235290
		[Token(Token = "0x403971A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403971B RID: 235291
		[Token(Token = "0x403971B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActMultiV3EntryView _view;

		// Token: 0x0403971C RID: 235292
		[Token(Token = "0x403971C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animEntry;

		// Token: 0x0403971D RID: 235293
		[Token(Token = "0x403971D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _animExit;

		// Token: 0x0403971E RID: 235294
		[Token(Token = "0x403971E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _animMainToRoom;

		// Token: 0x0403971F RID: 235295
		[Token(Token = "0x403971F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _animRoomToMain;

		// Token: 0x04039720 RID: 235296
		[Token(Token = "0x4039720")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _animMainToMatch;

		// Token: 0x04039721 RID: 235297
		[Token(Token = "0x4039721")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ActMultiV3EntryJoinRoomMask _joinRoomMask;

		// Token: 0x04039722 RID: 235298
		[Token(Token = "0x4039722")]
		[FieldOffset(Offset = "0xD8")]
		private ActMultiV3EntryProperty m_property;

		// Token: 0x04039723 RID: 235299
		[Token(Token = "0x4039723")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_inited;

		// Token: 0x04039724 RID: 235300
		[Token(Token = "0x4039724")]
		[FieldOffset(Offset = "0xE8")]
		private string m_actId;

		// Token: 0x04039725 RID: 235301
		[Token(Token = "0x4039725")]
		[FieldOffset(Offset = "0xF0")]
		private UIStateTransitionTween<ActMultiV3EntryState.ShowStatus> m_transitionTween;

		// Token: 0x04039726 RID: 235302
		[Token(Token = "0x4039726")]
		[FieldOffset(Offset = "0xF8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039727 RID: 235303
		[Token(Token = "0x4039727")]
		[FieldOffset(Offset = "0x108")]
		private Coroutine m_entryHomeRoutedCoroutine;

		// Token: 0x04039728 RID: 235304
		[Token(Token = "0x4039728")]
		[FieldOffset(Offset = "0x110")]
		private Coroutine m_teamViewRoutedCoroutine;

		// Token: 0x04039729 RID: 235305
		[Token(Token = "0x4039729")]
		[FieldOffset(Offset = "0x118")]
		private ActMultiV3EntryPage m_page;

		// Token: 0x0403972A RID: 235306
		[Token(Token = "0x403972A")]
		[FieldOffset(Offset = "0x120")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x0403972B RID: 235307
		[Token(Token = "0x403972B")]
		[FieldOffset(Offset = "0x128")]
		private int m_squadNotEnoughConfirmDialog;

		// Token: 0x0403972C RID: 235308
		[Token(Token = "0x403972C")]
		[FieldOffset(Offset = "0x12C")]
		private int m_invitedDialog;

		// Token: 0x0403972D RID: 235309
		[Token(Token = "0x403972D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403972E RID: 235310
		[Token(Token = "0x403972E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetAnimationTween;

		// Token: 0x0403972F RID: 235311
		[Token(Token = "0x403972F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetEntryAnimTween;

		// Token: 0x04039730 RID: 235312
		[Token(Token = "0x4039730")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__IsUIStable;

		// Token: 0x04039731 RID: 235313
		[Token(Token = "0x4039731")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04039732 RID: 235314
		[Token(Token = "0x4039732")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04039733 RID: 235315
		[Token(Token = "0x4039733")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04039734 RID: 235316
		[Token(Token = "0x4039734")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04039735 RID: 235317
		[Token(Token = "0x4039735")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04039736 RID: 235318
		[Token(Token = "0x4039736")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__StopCoroutineIfNeed;

		// Token: 0x04039737 RID: 235319
		[Token(Token = "0x4039737")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RaiseAVGSignalIfNeed;

		// Token: 0x04039738 RID: 235320
		[Token(Token = "0x4039738")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__WaitForTransFinishCoroutine;

		// Token: 0x04039739 RID: 235321
		[Token(Token = "0x4039739")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateDataOnGetInfo;

		// Token: 0x0403973A RID: 235322
		[Token(Token = "0x403973A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EffectOnPage;

		// Token: 0x0403973B RID: 235323
		[Token(Token = "0x403973B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403973C RID: 235324
		[Token(Token = "0x403973C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnJumpToMedalGroupDisplayState;

		// Token: 0x0403973D RID: 235325
		[Token(Token = "0x403973D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnJumpToRewardDetailState;

		// Token: 0x0403973E RID: 235326
		[Token(Token = "0x403973E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnJumpToStageListState;

		// Token: 0x0403973F RID: 235327
		[Token(Token = "0x403973F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnJumpToMatchState;

		// Token: 0x04039740 RID: 235328
		[Token(Token = "0x4039740")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CustomSetActive;

		// Token: 0x04039741 RID: 235329
		[Token(Token = "0x4039741")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04039742 RID: 235330
		[Token(Token = "0x4039742")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x04039743 RID: 235331
		[Token(Token = "0x4039743")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__EventOnBtnManualClicked;

		// Token: 0x04039744 RID: 235332
		[Token(Token = "0x4039744")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__EventOnBtnRewardClicked;

		// Token: 0x04039745 RID: 235333
		[Token(Token = "0x4039745")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__EventOnBtnMilestoneClicked;

		// Token: 0x04039746 RID: 235334
		[Token(Token = "0x4039746")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__EventOnBtnMedalClicked;

		// Token: 0x04039747 RID: 235335
		[Token(Token = "0x4039747")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__EventOnBtnSquadClicked;

		// Token: 0x04039748 RID: 235336
		[Token(Token = "0x4039748")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__EventOnBtnStageClicked;

		// Token: 0x04039749 RID: 235337
		[Token(Token = "0x4039749")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__EventOnBtnTeamMatchClicked;

		// Token: 0x0403974A RID: 235338
		[Token(Token = "0x403974A")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__TryTriggerTeamTutorial;

		// Token: 0x0403974B RID: 235339
		[Token(Token = "0x403974B")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__WaitForFinishEnterRoom;

		// Token: 0x0403974C RID: 235340
		[Token(Token = "0x403974C")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__EventOnBtnQuickMatchClicked;

		// Token: 0x0403974D RID: 235341
		[Token(Token = "0x403974D")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__ClearQuickMatchTrackpoint;

		// Token: 0x0403974E RID: 235342
		[Token(Token = "0x403974E")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__ShowSquadCountNotEnoughDialog;

		// Token: 0x0403974F RID: 235343
		[Token(Token = "0x403974F")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__EventOnInputTeamIdChanged;

		// Token: 0x04039750 RID: 235344
		[Token(Token = "0x4039750")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__EventOnBtnCreateTeamClicked;

		// Token: 0x04039751 RID: 235345
		[Token(Token = "0x4039751")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__EventOnBtnJoinTeamClicked;

		// Token: 0x04039752 RID: 235346
		[Token(Token = "0x4039752")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__JoinTeamImpl;

		// Token: 0x04039753 RID: 235347
		[Token(Token = "0x4039753")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__EventOnBtnTrainingRoomClicked;

		// Token: 0x04039754 RID: 235348
		[Token(Token = "0x4039754")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__EventOnBtnInviteClicked;

		// Token: 0x04039755 RID: 235349
		[Token(Token = "0x4039755")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__OnCreateTeamRespHandle;

		// Token: 0x04039756 RID: 235350
		[Token(Token = "0x4039756")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__OnSendJoinTeamRequest;

		// Token: 0x04039757 RID: 235351
		[Token(Token = "0x4039757")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__OnJoinTeamRespHandle;

		// Token: 0x04039758 RID: 235352
		[Token(Token = "0x4039758")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04039759 RID: 235353
		[Token(Token = "0x4039759")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__HandleInviteDialogCallback;

		// Token: 0x0403975A RID: 235354
		[Token(Token = "0x403975A")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F1C RID: 28444
		[Token(Token = "0x2006F1C")]
		public enum ShowStatus
		{
			// Token: 0x0403975C RID: 235356
			[Token(Token = "0x403975C")]
			ENTRY,
			// Token: 0x0403975D RID: 235357
			[Token(Token = "0x403975D")]
			MAIN,
			// Token: 0x0403975E RID: 235358
			[Token(Token = "0x403975E")]
			ROOM,
			// Token: 0x0403975F RID: 235359
			[Token(Token = "0x403975F")]
			MATCH
		}
	}
}
