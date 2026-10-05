using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062F3 RID: 25331
	[Token(Token = "0x20062F3")]
	public class AutoChessSettleGameState : AutoChessPrepareBaseState, IValueMsgReceiver, ICompDialogCallBack, IAutoChessPrepareStateHandler, IHotfixable
	{
		// Token: 0x0602481F RID: 149535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602481F")]
		[Address(RVA = "0x1F5B110", Offset = "0x1F59D10", VA = "0x181F5B110", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06024820 RID: 149536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024820")]
		[Address(RVA = "0x1F5B7C0", Offset = "0x1F5A3C0", VA = "0x181F5B7C0", Slot = "31")]
		protected override void OnStateEnter()
		{
		}

		// Token: 0x06024821 RID: 149537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024821")]
		[Address(RVA = "0x1F5B510", Offset = "0x1F5A110", VA = "0x181F5B510", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06024822 RID: 149538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024822")]
		[Address(RVA = "0x1F5C140", Offset = "0x1F5AD40", VA = "0x181F5C140")]
		private void _OnPersonalViewNextBtnClick()
		{
		}

		// Token: 0x06024823 RID: 149539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024823")]
		[Address(RVA = "0x1F5C8B0", Offset = "0x1F5B4B0", VA = "0x181F5C8B0")]
		private void _OnTryReportPlayerBtnClick()
		{
		}

		// Token: 0x06024824 RID: 149540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024824")]
		[Address(RVA = "0x1F5C1F0", Offset = "0x1F5ADF0", VA = "0x181F5C1F0")]
		private void _OnReportSuc(string uid)
		{
		}

		// Token: 0x06024825 RID: 149541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024825")]
		[Address(RVA = "0x1F5B290", Offset = "0x1F59E90", VA = "0x181F5B290", Slot = "35")]
		public void OnDataChanged(AutoChessPrepareModel model)
		{
		}

		// Token: 0x06024826 RID: 149542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024826")]
		[Address(RVA = "0x1F5B170", Offset = "0x1F59D70", VA = "0x181F5B170", Slot = "33")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06024827 RID: 149543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024827")]
		[Address(RVA = "0x1F5BCB0", Offset = "0x1F5A8B0", VA = "0x181F5BCB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024828 RID: 149544 RVA: 0x000C46E0 File Offset: 0x000C28E0
		[Token(Token = "0x6024828")]
		[Address(RVA = "0x1F5CD40", Offset = "0x1F5B940", VA = "0x181F5CD40")]
		private bool _TryShowTeamView()
		{
			return default(bool);
		}

		// Token: 0x06024829 RID: 149545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024829")]
		[Address(RVA = "0x1F5CA20", Offset = "0x1F5B620", VA = "0x181F5CA20")]
		private void _SendSettleGameReq(string actId, FromBattleSource fromBattleSource)
		{
		}

		// Token: 0x0602482A RID: 149546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602482A")]
		[Address(RVA = "0x1F5C610", Offset = "0x1F5B210", VA = "0x181F5C610")]
		private void _OnSettleGameProceed(AutoChessSettleGameResponse response)
		{
		}

		// Token: 0x0602482B RID: 149547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602482B")]
		[Address(RVA = "0x1F5C460", Offset = "0x1F5B060", VA = "0x181F5C460")]
		private void _OnSettleGameFail()
		{
		}

		// Token: 0x0602482C RID: 149548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602482C")]
		[Address(RVA = "0x1F5BD50", Offset = "0x1F5A950", VA = "0x181F5BD50")]
		private void _LoadFromSettleData(AutoChessSeasonSettleGameInfo gameSettleData)
		{
		}

		// Token: 0x0602482D RID: 149549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602482D")]
		[Address(RVA = "0x1F5BA50", Offset = "0x1F5A650", VA = "0x181F5BA50")]
		private void _AutoJumpToTeamViewAfterWaitTime()
		{
		}

		// Token: 0x0602482E RID: 149550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602482E")]
		[Address(RVA = "0x1F5CC90", Offset = "0x1F5B890", VA = "0x181F5CC90")]
		private void _StopAutoJumpToTeamViewCo()
		{
		}

		// Token: 0x0602482F RID: 149551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602482F")]
		[Address(RVA = "0x1F5B980", Offset = "0x1F5A580", VA = "0x181F5B980")]
		private IEnumerator _AutoJumpToTeamViewAfterWaitTimeCo(float waitTime)
		{
			return null;
		}

		// Token: 0x06024830 RID: 149552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024830")]
		[Address(RVA = "0x1F5BEC0", Offset = "0x1F5AAC0", VA = "0x181F5BEC0")]
		private AutoChessSeasonSettleGameInfo _LoadSettleDataFromTrainingBattle(string actId)
		{
			return null;
		}

		// Token: 0x06024831 RID: 149553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024831")]
		[Address(RVA = "0x1F5CE70", Offset = "0x1F5BA70", VA = "0x181F5CE70")]
		public AutoChessSettleGameState()
		{
		}

		// Token: 0x06024832 RID: 149554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024832")]
		[Address(RVA = "0x1F25FB0", Offset = "0x1F24BB0", VA = "0x181F25FB0")]
		private void <>xLuaBaseProxy_OnStateEnter()
		{
		}

		// Token: 0x04032E3A RID: 208442
		[Token(Token = "0x4032E3A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AutoChessSettleGameView _view;

		// Token: 0x04032E3B RID: 208443
		[Token(Token = "0x4032E3B")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04032E3C RID: 208444
		[Token(Token = "0x4032E3C")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04032E3D RID: 208445
		[Token(Token = "0x4032E3D")]
		[FieldOffset(Offset = "0xA0")]
		private AutoChessSettleGameStateBean m_stateBean;

		// Token: 0x04032E3E RID: 208446
		[Token(Token = "0x4032E3E")]
		[FieldOffset(Offset = "0xA8")]
		private int m_settleGameFailConfirmInst;

		// Token: 0x04032E3F RID: 208447
		[Token(Token = "0x4032E3F")]
		[FieldOffset(Offset = "0xB0")]
		private Coroutine m_autoJumpToTeamViewWaitCoroutine;

		// Token: 0x04032E40 RID: 208448
		[Token(Token = "0x4032E40")]
		[NonSerialized]
		public const int ON_PERSONAL_VIEW_NEXT_BTN_CLICK = 1;

		// Token: 0x04032E41 RID: 208449
		[Token(Token = "0x4032E41")]
		[NonSerialized]
		public const int ON_TRY_REPORT_PLAYER_BTN_CLICK = 2;

		// Token: 0x04032E42 RID: 208450
		[Token(Token = "0x4032E42")]
		[NonSerialized]
		public const int ON_REPORT_SUC = 3;

		// Token: 0x04032E43 RID: 208451
		[Token(Token = "0x4032E43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04032E44 RID: 208452
		[Token(Token = "0x4032E44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateEnter;

		// Token: 0x04032E45 RID: 208453
		[Token(Token = "0x4032E45")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04032E46 RID: 208454
		[Token(Token = "0x4032E46")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnPersonalViewNextBtnClick;

		// Token: 0x04032E47 RID: 208455
		[Token(Token = "0x4032E47")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnTryReportPlayerBtnClick;

		// Token: 0x04032E48 RID: 208456
		[Token(Token = "0x4032E48")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnReportSuc;

		// Token: 0x04032E49 RID: 208457
		[Token(Token = "0x4032E49")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDataChanged;

		// Token: 0x04032E4A RID: 208458
		[Token(Token = "0x4032E4A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04032E4B RID: 208459
		[Token(Token = "0x4032E4B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032E4C RID: 208460
		[Token(Token = "0x4032E4C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryShowTeamView;

		// Token: 0x04032E4D RID: 208461
		[Token(Token = "0x4032E4D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SendSettleGameReq;

		// Token: 0x04032E4E RID: 208462
		[Token(Token = "0x4032E4E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnSettleGameProceed;

		// Token: 0x04032E4F RID: 208463
		[Token(Token = "0x4032E4F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnSettleGameFail;

		// Token: 0x04032E50 RID: 208464
		[Token(Token = "0x4032E50")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadFromSettleData;

		// Token: 0x04032E51 RID: 208465
		[Token(Token = "0x4032E51")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__AutoJumpToTeamViewAfterWaitTime;

		// Token: 0x04032E52 RID: 208466
		[Token(Token = "0x4032E52")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__StopAutoJumpToTeamViewCo;

		// Token: 0x04032E53 RID: 208467
		[Token(Token = "0x4032E53")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__AutoJumpToTeamViewAfterWaitTimeCo;

		// Token: 0x04032E54 RID: 208468
		[Token(Token = "0x4032E54")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__LoadSettleDataFromTrainingBattle;

		// Token: 0x04032E55 RID: 208469
		[Token(Token = "0x4032E55")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
