using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity.AutoChess;
using Torappu.UI.AutoChess.Server;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006236 RID: 25142
	[Token(Token = "0x2006236")]
	public class AutoChessPrepareController : PageSingleComponent, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x06024458 RID: 148568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024458")]
		[Address(RVA = "0x1F083C0", Offset = "0x1F06FC0", VA = "0x181F083C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x06024459 RID: 148569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024459")]
		[Address(RVA = "0x1F094B0", Offset = "0x1F080B0", VA = "0x181F094B0", Slot = "7")]
		protected override void OnStart()
		{
		}

		// Token: 0x0602445A RID: 148570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602445A")]
		[Address(RVA = "0x1F09D00", Offset = "0x1F08900", VA = "0x181F09D00")]
		private void Update()
		{
		}

		// Token: 0x0602445B RID: 148571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602445B")]
		[Address(RVA = "0x1F08770", Offset = "0x1F07370", VA = "0x181F08770", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0602445C RID: 148572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602445C")]
		[Address(RVA = "0x1F0ECE0", Offset = "0x1F0D8E0", VA = "0x181F0ECE0")]
		private void _LoadModelData()
		{
		}

		// Token: 0x0602445D RID: 148573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602445D")]
		[Address(RVA = "0x1F11CD0", Offset = "0x1F108D0", VA = "0x181F11CD0")]
		private void _SendSyncInfoRequestFromBattle()
		{
		}

		// Token: 0x0602445E RID: 148574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602445E")]
		[Address(RVA = "0x1F0DCB0", Offset = "0x1F0C8B0", VA = "0x181F0DCB0")]
		private void _HandleSyncInfoResponse(ActAutoChessSyncInfoResponse response)
		{
		}

		// Token: 0x0602445F RID: 148575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602445F")]
		[Address(RVA = "0x1F09810", Offset = "0x1F08410", VA = "0x181F09810")]
		public AutoChessPrepareModel RegisterHandler(IAutoChessPrepareStateHandler handler)
		{
			return null;
		}

		// Token: 0x06024460 RID: 148576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024460")]
		[Address(RVA = "0x1F0F0B0", Offset = "0x1F0DCB0", VA = "0x181F0F0B0")]
		private void _NotifyDataChanged(AutoChessPrepareModel model)
		{
		}

		// Token: 0x06024461 RID: 148577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024461")]
		[Address(RVA = "0x1F11750", Offset = "0x1F10350", VA = "0x181F11750")]
		private void _RouteToProperState(AutoChessPrepareStateViewType toType)
		{
		}

		// Token: 0x06024462 RID: 148578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024462")]
		[Address(RVA = "0x1F0A060", Offset = "0x1F08C60", VA = "0x181F0A060")]
		private void _ClearStateTransCoroutine()
		{
		}

		// Token: 0x06024463 RID: 148579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024463")]
		[Address(RVA = "0x1F0F8E0", Offset = "0x1F0E4E0", VA = "0x181F0F8E0")]
		private void _OnRouteStable()
		{
		}

		// Token: 0x06024464 RID: 148580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024464")]
		[Address(RVA = "0x1F11670", Offset = "0x1F10270", VA = "0x181F11670")]
		private IEnumerator _RouteToProperStateCoroutine(AutoChessPrepareStateViewType from, AutoChessPrepareStateViewType to)
		{
			return null;
		}

		// Token: 0x06024465 RID: 148581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024465")]
		[Address(RVA = "0x1F0D200", Offset = "0x1F0BE00", VA = "0x181F0D200")]
		private Type _GetStateTypeFromViewType(AutoChessPrepareStateViewType viewType)
		{
			return null;
		}

		// Token: 0x06024466 RID: 148582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024466")]
		[Address(RVA = "0x1F0CF80", Offset = "0x1F0BB80", VA = "0x181F0CF80")]
		private IEnumerator _GetRegisteredStateRouteCoroutine(AutoChessPrepareStateViewType from, AutoChessPrepareStateViewType to)
		{
			return null;
		}

		// Token: 0x06024467 RID: 148583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024467")]
		[Address(RVA = "0x1F102F0", Offset = "0x1F0EEF0", VA = "0x181F102F0")]
		private void _RegisterStateRouteCoroutine(AutoChessPrepareStateViewType from, AutoChessPrepareStateViewType to, AutoChessPrepareController.StateRouteCoroutineProvider coroutineProvider)
		{
		}

		// Token: 0x06024468 RID: 148584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024468")]
		[Address(RVA = "0x1F10460", Offset = "0x1F0F060", VA = "0x181F10460")]
		private void _RegisterStateRouteCoroutines()
		{
		}

		// Token: 0x06024469 RID: 148585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024469")]
		[Address(RVA = "0x1F115A0", Offset = "0x1F101A0", VA = "0x181F115A0")]
		private IEnumerator _RoomMatchSuccDelayIfNeed(AutoChessPrepareStateViewType from, AutoChessPrepareStateViewType to)
		{
			return null;
		}

		// Token: 0x0602446A RID: 148586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602446A")]
		[Address(RVA = "0x1F0A210", Offset = "0x1F08E10", VA = "0x181F0A210")]
		private IEnumerator _EnterRoomDelay(AutoChessPrepareStateViewType from, AutoChessPrepareStateViewType to)
		{
			return null;
		}

		// Token: 0x0602446B RID: 148587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602446B")]
		[Address(RVA = "0x1F0CE90", Offset = "0x1F0BA90", VA = "0x181F0CE90")]
		private UISimpleCompDialog.Builder _GenSimpleDialogBuilder(int type)
		{
			return null;
		}

		// Token: 0x0602446C RID: 148588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602446C")]
		[Address(RVA = "0x1F09990", Offset = "0x1F08590", VA = "0x181F09990")]
		public void StartTrainingMode()
		{
		}

		// Token: 0x0602446D RID: 148589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602446D")]
		[Address(RVA = "0x1F07C00", Offset = "0x1F06800", VA = "0x181F07C00")]
		public void CreateTeam(string modeId, bool isPrecise, bool isMatch = true)
		{
		}

		// Token: 0x0602446E RID: 148590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602446E")]
		[Address(RVA = "0x1F08140", Offset = "0x1F06D40", VA = "0x181F08140")]
		public void JoinTeam(string teamId)
		{
		}

		// Token: 0x0602446F RID: 148591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602446F")]
		[Address(RVA = "0x1F09B30", Offset = "0x1F08730", VA = "0x181F09B30")]
		public void TryJoinInvitation()
		{
		}

		// Token: 0x06024470 RID: 148592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024470")]
		[Address(RVA = "0x1F09580", Offset = "0x1F08180", VA = "0x181F09580")]
		public void ReconnectBattle(ActAutoChessSyncInfoBattleInfo battleInfo)
		{
		}

		// Token: 0x06024471 RID: 148593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024471")]
		[Address(RVA = "0x1F0FF30", Offset = "0x1F0EB30", VA = "0x181F0FF30")]
		private void _ReconnectBattleDone(bool suc)
		{
		}

		// Token: 0x06024472 RID: 148594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024472")]
		[Address(RVA = "0x1F0F6D0", Offset = "0x1F0E2D0", VA = "0x181F0F6D0")]
		private void _OnJoinTeamRespHandle(AutoChessServiceCommonResultType res, AutoChessTeamInfo team)
		{
		}

		// Token: 0x06024473 RID: 148595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024473")]
		[Address(RVA = "0x1F0EA10", Offset = "0x1F0D610", VA = "0x181F0EA10")]
		private void _JoinTeamService(AutoChessTeamInfo team, bool needClosePageWhenFail = false)
		{
		}

		// Token: 0x06024474 RID: 148596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024474")]
		[Address(RVA = "0x1F12020", Offset = "0x1F10C20", VA = "0x181F12020")]
		private void _ShowCommonExceptionResultToast(AutoChessServiceCommonResultType res)
		{
		}

		// Token: 0x06024475 RID: 148597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024475")]
		[Address(RVA = "0x1F0FC80", Offset = "0x1F0E880", VA = "0x181F0FC80")]
		private void _OnTrainingModeJoinTeamDone(bool suc)
		{
		}

		// Token: 0x06024476 RID: 148598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024476")]
		[Address(RVA = "0x1F0F5C0", Offset = "0x1F0E1C0", VA = "0x181F0F5C0")]
		private void _OnJoinTeamDone(bool suc, bool needClosePageWhenFail)
		{
		}

		// Token: 0x06024477 RID: 148599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024477")]
		[Address(RVA = "0x1F105D0", Offset = "0x1F0F1D0", VA = "0x181F105D0")]
		private void _RegisterSvrEvent()
		{
		}

		// Token: 0x06024478 RID: 148600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024478")]
		[Address(RVA = "0x1F12D70", Offset = "0x1F11970", VA = "0x181F12D70")]
		private void _UnRegisterSvrEvent()
		{
		}

		// Token: 0x06024479 RID: 148601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024479")]
		[Address(RVA = "0x1F0E4C0", Offset = "0x1F0D0C0", VA = "0x181F0E4C0")]
		private void _HandleTeamLeaveRet(object arg)
		{
		}

		// Token: 0x0602447A RID: 148602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602447A")]
		[Address(RVA = "0x1F0DDE0", Offset = "0x1F0C9E0", VA = "0x181F0DDE0")]
		private void _HandleTeamChangedRet(object arg)
		{
		}

		// Token: 0x0602447B RID: 148603 RVA: 0x000C3A98 File Offset: 0x000C1C98
		[Token(Token = "0x602447B")]
		[Address(RVA = "0x1F0F040", Offset = "0x1F0DC40", VA = "0x181F0F040")]
		private bool _NeedBackToPageToRefresh(AutoChessTeamState teamState)
		{
			return default(bool);
		}

		// Token: 0x0602447C RID: 148604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602447C")]
		[Address(RVA = "0x1F09EE0", Offset = "0x1F08AE0", VA = "0x181F09EE0")]
		private IEnumerator _BackToPageAndRefresh()
		{
			return null;
		}

		// Token: 0x0602447D RID: 148605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602447D")]
		[Address(RVA = "0x1F10220", Offset = "0x1F0EE20", VA = "0x181F10220")]
		private void _RefreshTeamInfo()
		{
		}

		// Token: 0x0602447E RID: 148606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602447E")]
		[Address(RVA = "0x1F0A120", Offset = "0x1F08D20", VA = "0x181F0A120")]
		private void _EnsureMatchingDialog(AutoChessTeamState state)
		{
		}

		// Token: 0x0602447F RID: 148607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602447F")]
		[Address(RVA = "0x1F0D390", Offset = "0x1F0BF90", VA = "0x181F0D390")]
		private void _HandleGetNameCardRet(object arg)
		{
		}

		// Token: 0x06024480 RID: 148608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024480")]
		[Address(RVA = "0x1F0E060", Offset = "0x1F0CC60", VA = "0x181F0E060")]
		private void _HandleTeamDisconnectExceptionRet(object arg)
		{
		}

		// Token: 0x06024481 RID: 148609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024481")]
		[Address(RVA = "0x1F09E10", Offset = "0x1F08A10", VA = "0x181F09E10")]
		private IEnumerator _BackToPageAndCheckDisconnect(AutoChessTeamLost lostData)
		{
			return null;
		}

		// Token: 0x06024482 RID: 148610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024482")]
		[Address(RVA = "0x1F0FA30", Offset = "0x1F0E630", VA = "0x181F0FA30")]
		private void _OnTeamDisconnect(AutoChessTeamLost lostData)
		{
		}

		// Token: 0x06024483 RID: 148611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024483")]
		[Address(RVA = "0x1F0D890", Offset = "0x1F0C490", VA = "0x181F0D890")]
		private void _HandleSceneStartRet(object arg)
		{
		}

		// Token: 0x06024484 RID: 148612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024484")]
		[Address(RVA = "0x1F0DA20", Offset = "0x1F0C620", VA = "0x181F0DA20")]
		private void _HandleSceneStartSucRet(object arg)
		{
		}

		// Token: 0x06024485 RID: 148613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024485")]
		[Address(RVA = "0x1F0D5D0", Offset = "0x1F0C1D0", VA = "0x181F0D5D0")]
		private void _HandleMatchRet(object arg)
		{
		}

		// Token: 0x06024486 RID: 148614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024486")]
		[Address(RVA = "0x1F0D7C0", Offset = "0x1F0C3C0", VA = "0x181F0D7C0")]
		private void _HandleSceneSettleLikeRet(object arg)
		{
		}

		// Token: 0x06024487 RID: 148615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024487")]
		[Address(RVA = "0x1F0D6D0", Offset = "0x1F0C2D0", VA = "0x181F0D6D0")]
		private void _HandleSceneLostRet(object arg)
		{
		}

		// Token: 0x06024488 RID: 148616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024488")]
		[Address(RVA = "0x1F10CF0", Offset = "0x1F0F8F0", VA = "0x181F10CF0")]
		private void _RequestGetNameCard(string uid)
		{
		}

		// Token: 0x06024489 RID: 148617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024489")]
		[Address(RVA = "0x1F10ED0", Offset = "0x1F0FAD0", VA = "0x181F10ED0")]
		private void _RequestKick(string uid)
		{
		}

		// Token: 0x0602448A RID: 148618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602448A")]
		[Address(RVA = "0x1F108D0", Offset = "0x1F0F4D0", VA = "0x181F108D0")]
		private void _RequestBackTeam()
		{
		}

		// Token: 0x0602448B RID: 148619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602448B")]
		[Address(RVA = "0x1F10FA0", Offset = "0x1F0FBA0", VA = "0x181F10FA0")]
		private void _RequestLeaveBattle()
		{
		}

		// Token: 0x0602448C RID: 148620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602448C")]
		[Address(RVA = "0x1F11040", Offset = "0x1F0FC40", VA = "0x181F11040")]
		private void _RequestReadyInRoom(bool ready)
		{
		}

		// Token: 0x0602448D RID: 148621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602448D")]
		[Address(RVA = "0x1F11260", Offset = "0x1F0FE60", VA = "0x181F11260")]
		private void _RequestSetModeId(string modeId)
		{
		}

		// Token: 0x0602448E RID: 148622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602448E")]
		[Address(RVA = "0x1F11330", Offset = "0x1F0FF30", VA = "0x181F11330")]
		private void _RequestSetRangeMode(AutoChessMatchModeRange modeRange)
		{
		}

		// Token: 0x0602448F RID: 148623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602448F")]
		[Address(RVA = "0x1F111A0", Offset = "0x1F0FDA0", VA = "0x181F111A0")]
		private void _RequestSetMatchFlag(bool matchFlag)
		{
		}

		// Token: 0x06024490 RID: 148624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024490")]
		[Address(RVA = "0x1F10A40", Offset = "0x1F0F640", VA = "0x181F10A40")]
		private void _RequestEnemyAssignReady()
		{
		}

		// Token: 0x06024491 RID: 148625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024491")]
		[Address(RVA = "0x1F114C0", Offset = "0x1F100C0", VA = "0x181F114C0")]
		private void _RequestSkipChooseBand()
		{
		}

		// Token: 0x06024492 RID: 148626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024492")]
		[Address(RVA = "0x1F10970", Offset = "0x1F0F570", VA = "0x181F10970")]
		private void _RequestChooseBand(string bandId)
		{
		}

		// Token: 0x06024493 RID: 148627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024493")]
		[Address(RVA = "0x1F11100", Offset = "0x1F0FD00", VA = "0x181F11100")]
		private void _RequestRoomCancelMatch()
		{
		}

		// Token: 0x06024494 RID: 148628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024494")]
		[Address(RVA = "0x1F113F0", Offset = "0x1F0FFF0", VA = "0x181F113F0")]
		private void _RequestSettleLikeOther(string uid)
		{
		}

		// Token: 0x06024495 RID: 148629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024495")]
		[Address(RVA = "0x1F08830", Offset = "0x1F07430", VA = "0x181F08830", Slot = "12")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06024496 RID: 148630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024496")]
		[Address(RVA = "0x1F0AC70", Offset = "0x1F09870", VA = "0x181F0AC70")]
		private void _EventOnExit()
		{
		}

		// Token: 0x06024497 RID: 148631 RVA: 0x000C3AB0 File Offset: 0x000C1CB0
		[Token(Token = "0x6024497")]
		[Address(RVA = "0x1F0E890", Offset = "0x1F0D490", VA = "0x181F0E890")]
		private bool _IsFirstLeaveTeam()
		{
			return default(bool);
		}

		// Token: 0x06024498 RID: 148632 RVA: 0x000C3AC8 File Offset: 0x000C1CC8
		[Token(Token = "0x6024498")]
		[Address(RVA = "0x1F0CAD0", Offset = "0x1F0B6D0", VA = "0x181F0CAD0")]
		private AutoChessConfirmDialogConfig _GenCommonLeaveConfirmDialogConfig(string infoId)
		{
			return default(AutoChessConfirmDialogConfig);
		}

		// Token: 0x06024499 RID: 148633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024499")]
		[Address(RVA = "0x1F0A530", Offset = "0x1F09130", VA = "0x181F0A530")]
		private void _EventOnCheckNameCard(string uid)
		{
		}

		// Token: 0x0602449A RID: 148634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602449A")]
		[Address(RVA = "0x1F0A2E0", Offset = "0x1F08EE0", VA = "0x181F0A2E0")]
		private void _EventOnAddFriend(string uid)
		{
		}

		// Token: 0x0602449B RID: 148635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602449B")]
		[Address(RVA = "0x1F0DB40", Offset = "0x1F0C740", VA = "0x181F0DB40")]
		private void _HandleSendFriendResponse(SendFriendResponse resp)
		{
		}

		// Token: 0x0602449C RID: 148636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602449C")]
		[Address(RVA = "0x1F0C490", Offset = "0x1F0B090", VA = "0x181F0C490")]
		private void _EventOnShowSimpleDialog(int msgVal)
		{
		}

		// Token: 0x0602449D RID: 148637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602449D")]
		[Address(RVA = "0x1F0B1D0", Offset = "0x1F09DD0", VA = "0x181F0B1D0")]
		private void _EventOnRoomKick(string uid)
		{
		}

		// Token: 0x0602449E RID: 148638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602449E")]
		[Address(RVA = "0x1F0B420", Offset = "0x1F0A020", VA = "0x181F0B420")]
		private void _EventOnRoomReady(bool ready)
		{
		}

		// Token: 0x0602449F RID: 148639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602449F")]
		[Address(RVA = "0x1F0B9F0", Offset = "0x1F0A5F0", VA = "0x181F0B9F0")]
		private void _EventOnRoomStartMatch()
		{
		}

		// Token: 0x060244A0 RID: 148640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244A0")]
		[Address(RVA = "0x1F0B910", Offset = "0x1F0A510", VA = "0x181F0B910")]
		private void _EventOnRoomStartGame()
		{
		}

		// Token: 0x060244A1 RID: 148641 RVA: 0x000C3AE0 File Offset: 0x000C1CE0
		[Token(Token = "0x60244A1")]
		[Address(RVA = "0x1F12A90", Offset = "0x1F11690", VA = "0x181F12A90")]
		private bool _TryOpenMatchingDialog(ref int instId)
		{
			return default(bool);
		}

		// Token: 0x060244A2 RID: 148642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244A2")]
		[Address(RVA = "0x1F0B670", Offset = "0x1F0A270", VA = "0x181F0B670")]
		private void _EventOnRoomSetModeId(string modeId)
		{
		}

		// Token: 0x060244A3 RID: 148643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244A3")]
		[Address(RVA = "0x1F0B7C0", Offset = "0x1F0A3C0", VA = "0x181F0B7C0")]
		private void _EventOnRoomSetRangeMode(bool isPrecise)
		{
		}

		// Token: 0x060244A4 RID: 148644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244A4")]
		[Address(RVA = "0x1F0B540", Offset = "0x1F0A140", VA = "0x181F0B540")]
		private void _EventOnRoomSetMatchFlag(bool matchFlag)
		{
		}

		// Token: 0x060244A5 RID: 148645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244A5")]
		[Address(RVA = "0x1F0B0B0", Offset = "0x1F09CB0", VA = "0x181F0B0B0")]
		private void _EventOnRoomCancelMatch()
		{
		}

		// Token: 0x060244A6 RID: 148646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244A6")]
		[Address(RVA = "0x1F0AA70", Offset = "0x1F09670", VA = "0x181F0AA70")]
		private void _EventOnEnemyAssignReady()
		{
		}

		// Token: 0x060244A7 RID: 148647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244A7")]
		[Address(RVA = "0x1F0C650", Offset = "0x1F0B250", VA = "0x181F0C650")]
		private void _EventOnSkipChooseBand()
		{
		}

		// Token: 0x060244A8 RID: 148648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244A8")]
		[Address(RVA = "0x1F0A7D0", Offset = "0x1F093D0", VA = "0x181F0A7D0")]
		private void _EventOnChooseBand(string bandId)
		{
		}

		// Token: 0x060244A9 RID: 148649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244A9")]
		[Address(RVA = "0x1F0BAC0", Offset = "0x1F0A6C0", VA = "0x181F0BAC0")]
		private void _EventOnSettleGameBackToHome(bool needShowToast)
		{
		}

		// Token: 0x060244AA RID: 148650 RVA: 0x000C3AF8 File Offset: 0x000C1CF8
		[Token(Token = "0x60244AA")]
		[Address(RVA = "0x1F09F90", Offset = "0x1F08B90", VA = "0x181F09F90")]
		private bool _CheckCrossDaysAndResync()
		{
			return default(bool);
		}

		// Token: 0x060244AB RID: 148651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244AB")]
		[Address(RVA = "0x1F11A90", Offset = "0x1F10690", VA = "0x181F11A90")]
		private void _SendLeaveTeamReq()
		{
		}

		// Token: 0x060244AC RID: 148652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244AC")]
		[Address(RVA = "0x1F0BCD0", Offset = "0x1F0A8D0", VA = "0x181F0BCD0")]
		private void _EventOnSettleGameBackToRoom()
		{
		}

		// Token: 0x060244AD RID: 148653 RVA: 0x000C3B10 File Offset: 0x000C1D10
		[Token(Token = "0x60244AD")]
		[Address(RVA = "0x1F0C7D0", Offset = "0x1F0B3D0", VA = "0x181F0C7D0")]
		private AutoChessConfirmDialogConfig _GenBackToHomeConfirmDialogConfig(string infoId)
		{
			return default(AutoChessConfirmDialogConfig);
		}

		// Token: 0x060244AE RID: 148654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244AE")]
		[Address(RVA = "0x1F0C040", Offset = "0x1F0AC40", VA = "0x181F0C040")]
		private void _EventOnSettleGameContinueMatch()
		{
		}

		// Token: 0x060244AF RID: 148655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244AF")]
		[Address(RVA = "0x1F0C180", Offset = "0x1F0AD80", VA = "0x181F0C180")]
		private void _EventOnSettleGameLikeOther(string uid)
		{
		}

		// Token: 0x060244B0 RID: 148656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244B0")]
		[Address(RVA = "0x1F11B10", Offset = "0x1F10710", VA = "0x181F11B10")]
		private void _SendSettleLikeReq(string actId, string uid)
		{
		}

		// Token: 0x060244B1 RID: 148657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244B1")]
		[Address(RVA = "0x1F0C120", Offset = "0x1F0AD20", VA = "0x181F0C120")]
		private void _EventOnSettleGameFail()
		{
		}

		// Token: 0x060244B2 RID: 148658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244B2")]
		[Address(RVA = "0x1F07F20", Offset = "0x1F06B20", VA = "0x181F07F20", Slot = "13")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x060244B3 RID: 148659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244B3")]
		[Address(RVA = "0x1F0D4F0", Offset = "0x1F0C0F0", VA = "0x181F0D4F0")]
		private void _HandleLeaveDlg(int confirm)
		{
		}

		// Token: 0x060244B4 RID: 148660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244B4")]
		[Address(RVA = "0x1F0EC40", Offset = "0x1F0D840", VA = "0x181F0EC40")]
		private void _LeavePreparePage()
		{
		}

		// Token: 0x060244B5 RID: 148661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244B5")]
		[Address(RVA = "0x1F0D450", Offset = "0x1F0C050", VA = "0x181F0D450")]
		private void _HandleKillConfirm()
		{
		}

		// Token: 0x060244B6 RID: 148662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244B6")]
		[Address(RVA = "0x1F09750", Offset = "0x1F08350", VA = "0x181F09750")]
		public void RegisterBusinessEventListener(AutoChessPrepareController.BusinessEvent eventType, EventPool.EventCallbackDelegate listener)
		{
		}

		// Token: 0x060244B7 RID: 148663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244B7")]
		[Address(RVA = "0x1F09C40", Offset = "0x1F08840", VA = "0x181F09C40")]
		public void UnRegisterBusinessEventListener(AutoChessPrepareController.BusinessEvent eventType, EventPool.EventCallbackDelegate listener)
		{
		}

		// Token: 0x060244B8 RID: 148664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60244B8")]
		[Address(RVA = "0x1F07EB0", Offset = "0x1F06AB0", VA = "0x181F07EB0")]
		public AutoChessServiceTeamInfo GetTeamInfo()
		{
			return null;
		}

		// Token: 0x060244B9 RID: 148665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244B9")]
		[Address(RVA = "0x1F0E540", Offset = "0x1F0D140", VA = "0x181F0E540")]
		private void _InitController()
		{
		}

		// Token: 0x060244BA RID: 148666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244BA")]
		[Address(RVA = "0x1F0F2B0", Offset = "0x1F0DEB0", VA = "0x181F0F2B0")]
		private void _OnBeforeTransition(Type stateType, Type toType, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x060244BB RID: 148667 RVA: 0x000C3B28 File Offset: 0x000C1D28
		[Token(Token = "0x60244BB")]
		[Address(RVA = "0x1F0D060", Offset = "0x1F0BC60", VA = "0x181F0D060")]
		private AutoChessOuterTopMenu.ShowType _GetStateTopMenuType(Type type)
		{
			return AutoChessOuterTopMenu.ShowType.NONE;
		}

		// Token: 0x060244BC RID: 148668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244BC")]
		[Address(RVA = "0x1F11EE0", Offset = "0x1F10AE0", VA = "0x181F11EE0")]
		private void _SetTopMenuShowInfo(AutoChessOuterTopMenu.ShowType showType)
		{
		}

		// Token: 0x060244BD RID: 148669 RVA: 0x000C3B40 File Offset: 0x000C1D40
		[Token(Token = "0x60244BD")]
		private bool _CheckUIStable<TState>()
		{
			return default(bool);
		}

		// Token: 0x060244BE RID: 148670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244BE")]
		[Address(RVA = "0x1F0FDD0", Offset = "0x1F0E9D0", VA = "0x181F0FDD0")]
		private void _OpenNameCardPageInRoom()
		{
		}

		// Token: 0x060244BF RID: 148671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244BF")]
		[Address(RVA = "0x1F12150", Offset = "0x1F10D50", VA = "0x181F12150")]
		private void _StartMultiBattle()
		{
		}

		// Token: 0x060244C0 RID: 148672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244C0")]
		[Address(RVA = "0x1F12370", Offset = "0x1F10F70", VA = "0x181F12370")]
		private void _StartTrainingBattle()
		{
		}

		// Token: 0x060244C1 RID: 148673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244C1")]
		[Address(RVA = "0x1F12670", Offset = "0x1F11270", VA = "0x181F12670")]
		private void _TriggerMultiStartBattleMaxWaitCoroutine()
		{
		}

		// Token: 0x060244C2 RID: 148674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244C2")]
		[Address(RVA = "0x1F125D0", Offset = "0x1F111D0", VA = "0x181F125D0")]
		private void _StopMultiBattleStartMaxWaitCoroutine()
		{
		}

		// Token: 0x060244C3 RID: 148675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60244C3")]
		[Address(RVA = "0x1F12CC0", Offset = "0x1F118C0", VA = "0x181F12CC0")]
		private IEnumerator _TryStartMultiBattleAfterMaxWaitTime()
		{
			return null;
		}

		// Token: 0x060244C4 RID: 148676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244C4")]
		[Address(RVA = "0x1F10AF0", Offset = "0x1F0F6F0", VA = "0x181F10AF0")]
		private void _RequestFriendSimpleDatas()
		{
		}

		// Token: 0x060244C5 RID: 148677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60244C5")]
		[Address(RVA = "0x1F0CC80", Offset = "0x1F0B880", VA = "0x181F0CC80")]
		private string _GenLostAlertInfoData(AutoChessTeamLostReason lostReason)
		{
			return null;
		}

		// Token: 0x060244C6 RID: 148678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244C6")]
		[Address(RVA = "0x1F127A0", Offset = "0x1F113A0", VA = "0x181F127A0")]
		private void _TryAlertNotification(string alertInfo)
		{
		}

		// Token: 0x060244C7 RID: 148679 RVA: 0x000C3B58 File Offset: 0x000C1D58
		[Token(Token = "0x60244C7")]
		[Address(RVA = "0x1F0C950", Offset = "0x1F0B550", VA = "0x181F0C950")]
		private AutoChessConfirmDialogConfig _GenCommonAlertConfirmDialogConfig(string infoId)
		{
			return default(AutoChessConfirmDialogConfig);
		}

		// Token: 0x060244C8 RID: 148680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244C8")]
		[Address(RVA = "0x1F13070", Offset = "0x1F11C70", VA = "0x181F13070")]
		public AutoChessPrepareController()
		{
		}

		// Token: 0x060244CC RID: 148684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244CC")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x060244CD RID: 148685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244CD")]
		[Address(RVA = "0xF53770", Offset = "0xF52370", VA = "0x180F53770")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x060244CE RID: 148686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60244CE")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0403270B RID: 206603
		[Token(Token = "0x403270B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x0403270C RID: 206604
		[Token(Token = "0x403270C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AutoChessOuterTopMenu _topMenu;

		// Token: 0x0403270D RID: 206605
		[Token(Token = "0x403270D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _reconnectMaskContainer;

		// Token: 0x0403270E RID: 206606
		[Token(Token = "0x403270E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _reconnectMaskCanvasGroup;

		// Token: 0x0403270F RID: 206607
		[Token(Token = "0x403270F")]
		[FieldOffset(Offset = "0x40")]
		private string m_actId;

		// Token: 0x04032710 RID: 206608
		[Token(Token = "0x4032710")]
		[FieldOffset(Offset = "0x48")]
		private bool m_eventRegistered;

		// Token: 0x04032711 RID: 206609
		[Token(Token = "0x4032711")]
		[FieldOffset(Offset = "0x50")]
		private AutoChessPreparePage m_page;

		// Token: 0x04032712 RID: 206610
		[Token(Token = "0x4032712")]
		[FieldOffset(Offset = "0x58")]
		private int m_leaveConfirmInstId;

		// Token: 0x04032713 RID: 206611
		[Token(Token = "0x4032713")]
		[FieldOffset(Offset = "0x5C")]
		private int m_settleBackToRoomFailConfirmDlgInstId;

		// Token: 0x04032714 RID: 206612
		[Token(Token = "0x4032714")]
		[FieldOffset(Offset = "0x60")]
		private int m_matchingDlgInstId;

		// Token: 0x04032715 RID: 206613
		[Token(Token = "0x4032715")]
		[FieldOffset(Offset = "0x64")]
		private int m_matchCanceldDlgInstId;

		// Token: 0x04032716 RID: 206614
		[Token(Token = "0x4032716")]
		[FieldOffset(Offset = "0x68")]
		private int m_reconnectFailedDlgInstId;

		// Token: 0x04032717 RID: 206615
		[Token(Token = "0x4032717")]
		[FieldOffset(Offset = "0x70")]
		private string m_cacheFriendRequestUID;

		// Token: 0x04032718 RID: 206616
		[Token(Token = "0x4032718")]
		[FieldOffset(Offset = "0x78")]
		private int m_kickConfirmInstId;

		// Token: 0x04032719 RID: 206617
		[Token(Token = "0x4032719")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_killedButStillInTeam;

		// Token: 0x0403271A RID: 206618
		[Token(Token = "0x403271A")]
		[FieldOffset(Offset = "0x80")]
		private AutoChessPrepareModel m_model;

		// Token: 0x0403271B RID: 206619
		[Token(Token = "0x403271B")]
		[FieldOffset(Offset = "0x88")]
		private AutoChessPrepareStateViewType m_lastStateViewType;

		// Token: 0x0403271C RID: 206620
		[Token(Token = "0x403271C")]
		[FieldOffset(Offset = "0x90")]
		private StateEngine.OnStateChangeListener m_stateChangeListener;

		// Token: 0x0403271D RID: 206621
		[Token(Token = "0x403271D")]
		[FieldOffset(Offset = "0x98")]
		private List<IAutoChessPrepareStateHandler> m_stateHandlers;

		// Token: 0x0403271E RID: 206622
		[Token(Token = "0x403271E")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine m_multiStartBattleMaxWaitCoroutine;

		// Token: 0x0403271F RID: 206623
		[Token(Token = "0x403271F")]
		[FieldOffset(Offset = "0xA8")]
		private Coroutine m_stateTransCoroutine;

		// Token: 0x04032720 RID: 206624
		[Token(Token = "0x4032720")]
		[FieldOffset(Offset = "0xB0")]
		private Coroutine m_backToPageCoroutine;

		// Token: 0x04032721 RID: 206625
		[Token(Token = "0x4032721")]
		[FieldOffset(Offset = "0xB8")]
		private LatchUtils.InvokeWhenUnlock m_battleStartLatch;

		// Token: 0x04032722 RID: 206626
		[Token(Token = "0x4032722")]
		[FieldOffset(Offset = "0xC0")]
		private EventPool<AutoChessPrepareController.BusinessEvent> m_businessEventPool;

		// Token: 0x04032723 RID: 206627
		[Token(Token = "0x4032723")]
		[FieldOffset(Offset = "0xC8")]
		private EnumIntDictionary<AutoChessPrepareStateViewType, EnumIntDictionary<AutoChessPrepareStateViewType, AutoChessPrepareController.StateRouteCoroutineProvider>> m_registerStateTransCoroutines;

		// Token: 0x04032724 RID: 206628
		[Token(Token = "0x4032724")]
		[FieldOffset(Offset = "0xD0")]
		private FadeSwitchTween m_reconnectMaskTween;

		// Token: 0x04032725 RID: 206629
		[Token(Token = "0x4032725")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_isReconnecting;

		// Token: 0x04032726 RID: 206630
		[Token(Token = "0x4032726")]
		[FieldOffset(Offset = "0xD9")]
		private bool m_isMatchingTimeout;

		// Token: 0x04032727 RID: 206631
		[Token(Token = "0x4032727")]
		[FieldOffset(Offset = "0xDA")]
		private bool m_isLoadModelFromBattle;

		// Token: 0x04032728 RID: 206632
		[Token(Token = "0x4032728")]
		private const float MULTI_START_BATTLE_MAX_WAIT = 3f;

		// Token: 0x04032729 RID: 206633
		[Token(Token = "0x4032729")]
		private const float MATCH_SUCC_DELAY = 2f;

		// Token: 0x0403272A RID: 206634
		[Token(Token = "0x403272A")]
		private const float ENTER_ROOM_DELAY = 0.5f;

		// Token: 0x0403272B RID: 206635
		[Token(Token = "0x403272B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403272C RID: 206636
		[Token(Token = "0x403272C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0403272D RID: 206637
		[Token(Token = "0x403272D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403272E RID: 206638
		[Token(Token = "0x403272E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403272F RID: 206639
		[Token(Token = "0x403272F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadModelData;

		// Token: 0x04032730 RID: 206640
		[Token(Token = "0x4032730")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendSyncInfoRequestFromBattle;

		// Token: 0x04032731 RID: 206641
		[Token(Token = "0x4032731")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleSyncInfoResponse;

		// Token: 0x04032732 RID: 206642
		[Token(Token = "0x4032732")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RegisterHandler;

		// Token: 0x04032733 RID: 206643
		[Token(Token = "0x4032733")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__NotifyDataChanged;

		// Token: 0x04032734 RID: 206644
		[Token(Token = "0x4032734")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RouteToProperState;

		// Token: 0x04032735 RID: 206645
		[Token(Token = "0x4032735")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ClearStateTransCoroutine;

		// Token: 0x04032736 RID: 206646
		[Token(Token = "0x4032736")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnRouteStable;

		// Token: 0x04032737 RID: 206647
		[Token(Token = "0x4032737")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RouteToProperStateCoroutine;

		// Token: 0x04032738 RID: 206648
		[Token(Token = "0x4032738")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetStateTypeFromViewType;

		// Token: 0x04032739 RID: 206649
		[Token(Token = "0x4032739")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetRegisteredStateRouteCoroutine;

		// Token: 0x0403273A RID: 206650
		[Token(Token = "0x403273A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RegisterStateRouteCoroutine;

		// Token: 0x0403273B RID: 206651
		[Token(Token = "0x403273B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RegisterStateRouteCoroutines;

		// Token: 0x0403273C RID: 206652
		[Token(Token = "0x403273C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RoomMatchSuccDelayIfNeed;

		// Token: 0x0403273D RID: 206653
		[Token(Token = "0x403273D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EnterRoomDelay;

		// Token: 0x0403273E RID: 206654
		[Token(Token = "0x403273E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GenSimpleDialogBuilder;

		// Token: 0x0403273F RID: 206655
		[Token(Token = "0x403273F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_StartTrainingMode;

		// Token: 0x04032740 RID: 206656
		[Token(Token = "0x4032740")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CreateTeam;

		// Token: 0x04032741 RID: 206657
		[Token(Token = "0x4032741")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_JoinTeam;

		// Token: 0x04032742 RID: 206658
		[Token(Token = "0x4032742")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_TryJoinInvitation;

		// Token: 0x04032743 RID: 206659
		[Token(Token = "0x4032743")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ReconnectBattle;

		// Token: 0x04032744 RID: 206660
		[Token(Token = "0x4032744")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ReconnectBattleDone;

		// Token: 0x04032745 RID: 206661
		[Token(Token = "0x4032745")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnJoinTeamRespHandle;

		// Token: 0x04032746 RID: 206662
		[Token(Token = "0x4032746")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__JoinTeamService;

		// Token: 0x04032747 RID: 206663
		[Token(Token = "0x4032747")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__ShowCommonExceptionResultToast;

		// Token: 0x04032748 RID: 206664
		[Token(Token = "0x4032748")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__OnTrainingModeJoinTeamDone;

		// Token: 0x04032749 RID: 206665
		[Token(Token = "0x4032749")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__OnJoinTeamDone;

		// Token: 0x0403274A RID: 206666
		[Token(Token = "0x403274A")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__RegisterSvrEvent;

		// Token: 0x0403274B RID: 206667
		[Token(Token = "0x403274B")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__UnRegisterSvrEvent;

		// Token: 0x0403274C RID: 206668
		[Token(Token = "0x403274C")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__HandleTeamLeaveRet;

		// Token: 0x0403274D RID: 206669
		[Token(Token = "0x403274D")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__HandleTeamChangedRet;

		// Token: 0x0403274E RID: 206670
		[Token(Token = "0x403274E")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__NeedBackToPageToRefresh;

		// Token: 0x0403274F RID: 206671
		[Token(Token = "0x403274F")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__BackToPageAndRefresh;

		// Token: 0x04032750 RID: 206672
		[Token(Token = "0x4032750")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__RefreshTeamInfo;

		// Token: 0x04032751 RID: 206673
		[Token(Token = "0x4032751")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__EnsureMatchingDialog;

		// Token: 0x04032752 RID: 206674
		[Token(Token = "0x4032752")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__HandleGetNameCardRet;

		// Token: 0x04032753 RID: 206675
		[Token(Token = "0x4032753")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__HandleTeamDisconnectExceptionRet;

		// Token: 0x04032754 RID: 206676
		[Token(Token = "0x4032754")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__BackToPageAndCheckDisconnect;

		// Token: 0x04032755 RID: 206677
		[Token(Token = "0x4032755")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__OnTeamDisconnect;

		// Token: 0x04032756 RID: 206678
		[Token(Token = "0x4032756")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__HandleSceneStartRet;

		// Token: 0x04032757 RID: 206679
		[Token(Token = "0x4032757")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__HandleSceneStartSucRet;

		// Token: 0x04032758 RID: 206680
		[Token(Token = "0x4032758")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__HandleMatchRet;

		// Token: 0x04032759 RID: 206681
		[Token(Token = "0x4032759")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__HandleSceneSettleLikeRet;

		// Token: 0x0403275A RID: 206682
		[Token(Token = "0x403275A")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__HandleSceneLostRet;

		// Token: 0x0403275B RID: 206683
		[Token(Token = "0x403275B")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__RequestGetNameCard;

		// Token: 0x0403275C RID: 206684
		[Token(Token = "0x403275C")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__RequestKick;

		// Token: 0x0403275D RID: 206685
		[Token(Token = "0x403275D")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__RequestBackTeam;

		// Token: 0x0403275E RID: 206686
		[Token(Token = "0x403275E")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__RequestLeaveBattle;

		// Token: 0x0403275F RID: 206687
		[Token(Token = "0x403275F")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__RequestReadyInRoom;

		// Token: 0x04032760 RID: 206688
		[Token(Token = "0x4032760")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__RequestSetModeId;

		// Token: 0x04032761 RID: 206689
		[Token(Token = "0x4032761")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__RequestSetRangeMode;

		// Token: 0x04032762 RID: 206690
		[Token(Token = "0x4032762")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__RequestSetMatchFlag;

		// Token: 0x04032763 RID: 206691
		[Token(Token = "0x4032763")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__RequestEnemyAssignReady;

		// Token: 0x04032764 RID: 206692
		[Token(Token = "0x4032764")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__RequestSkipChooseBand;

		// Token: 0x04032765 RID: 206693
		[Token(Token = "0x4032765")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__RequestChooseBand;

		// Token: 0x04032766 RID: 206694
		[Token(Token = "0x4032766")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__RequestRoomCancelMatch;

		// Token: 0x04032767 RID: 206695
		[Token(Token = "0x4032767")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__RequestSettleLikeOther;

		// Token: 0x04032768 RID: 206696
		[Token(Token = "0x4032768")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04032769 RID: 206697
		[Token(Token = "0x4032769")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__EventOnExit;

		// Token: 0x0403276A RID: 206698
		[Token(Token = "0x403276A")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__IsFirstLeaveTeam;

		// Token: 0x0403276B RID: 206699
		[Token(Token = "0x403276B")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__GenCommonLeaveConfirmDialogConfig;

		// Token: 0x0403276C RID: 206700
		[Token(Token = "0x403276C")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__EventOnCheckNameCard;

		// Token: 0x0403276D RID: 206701
		[Token(Token = "0x403276D")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__EventOnAddFriend;

		// Token: 0x0403276E RID: 206702
		[Token(Token = "0x403276E")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0__HandleSendFriendResponse;

		// Token: 0x0403276F RID: 206703
		[Token(Token = "0x403276F")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__EventOnShowSimpleDialog;

		// Token: 0x04032770 RID: 206704
		[Token(Token = "0x4032770")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__EventOnRoomKick;

		// Token: 0x04032771 RID: 206705
		[Token(Token = "0x4032771")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0__EventOnRoomReady;

		// Token: 0x04032772 RID: 206706
		[Token(Token = "0x4032772")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0__EventOnRoomStartMatch;

		// Token: 0x04032773 RID: 206707
		[Token(Token = "0x4032773")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0__EventOnRoomStartGame;

		// Token: 0x04032774 RID: 206708
		[Token(Token = "0x4032774")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0__TryOpenMatchingDialog;

		// Token: 0x04032775 RID: 206709
		[Token(Token = "0x4032775")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0__EventOnRoomSetModeId;

		// Token: 0x04032776 RID: 206710
		[Token(Token = "0x4032776")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0__EventOnRoomSetRangeMode;

		// Token: 0x04032777 RID: 206711
		[Token(Token = "0x4032777")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0__EventOnRoomSetMatchFlag;

		// Token: 0x04032778 RID: 206712
		[Token(Token = "0x4032778")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0__EventOnRoomCancelMatch;

		// Token: 0x04032779 RID: 206713
		[Token(Token = "0x4032779")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0__EventOnEnemyAssignReady;

		// Token: 0x0403277A RID: 206714
		[Token(Token = "0x403277A")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0__EventOnSkipChooseBand;

		// Token: 0x0403277B RID: 206715
		[Token(Token = "0x403277B")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0__EventOnChooseBand;

		// Token: 0x0403277C RID: 206716
		[Token(Token = "0x403277C")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0__EventOnSettleGameBackToHome;

		// Token: 0x0403277D RID: 206717
		[Token(Token = "0x403277D")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0__CheckCrossDaysAndResync;

		// Token: 0x0403277E RID: 206718
		[Token(Token = "0x403277E")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0__SendLeaveTeamReq;

		// Token: 0x0403277F RID: 206719
		[Token(Token = "0x403277F")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0__EventOnSettleGameBackToRoom;

		// Token: 0x04032780 RID: 206720
		[Token(Token = "0x4032780")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0__GenBackToHomeConfirmDialogConfig;

		// Token: 0x04032781 RID: 206721
		[Token(Token = "0x4032781")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0__EventOnSettleGameContinueMatch;

		// Token: 0x04032782 RID: 206722
		[Token(Token = "0x4032782")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0__EventOnSettleGameLikeOther;

		// Token: 0x04032783 RID: 206723
		[Token(Token = "0x4032783")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0__SendSettleLikeReq;

		// Token: 0x04032784 RID: 206724
		[Token(Token = "0x4032784")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0__EventOnSettleGameFail;

		// Token: 0x04032785 RID: 206725
		[Token(Token = "0x4032785")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04032786 RID: 206726
		[Token(Token = "0x4032786")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0__HandleLeaveDlg;

		// Token: 0x04032787 RID: 206727
		[Token(Token = "0x4032787")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0__LeavePreparePage;

		// Token: 0x04032788 RID: 206728
		[Token(Token = "0x4032788")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0__HandleKillConfirm;

		// Token: 0x04032789 RID: 206729
		[Token(Token = "0x4032789")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_RegisterBusinessEventListener;

		// Token: 0x0403278A RID: 206730
		[Token(Token = "0x403278A")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_UnRegisterBusinessEventListener;

		// Token: 0x0403278B RID: 206731
		[Token(Token = "0x403278B")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_GetTeamInfo;

		// Token: 0x0403278C RID: 206732
		[Token(Token = "0x403278C")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0__InitController;

		// Token: 0x0403278D RID: 206733
		[Token(Token = "0x403278D")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0__OnBeforeTransition;

		// Token: 0x0403278E RID: 206734
		[Token(Token = "0x403278E")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0__GetStateTopMenuType;

		// Token: 0x0403278F RID: 206735
		[Token(Token = "0x403278F")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0__SetTopMenuShowInfo;

		// Token: 0x04032790 RID: 206736
		[Token(Token = "0x4032790")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0__CheckUIStable;

		// Token: 0x04032791 RID: 206737
		[Token(Token = "0x4032791")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0__OpenNameCardPageInRoom;

		// Token: 0x04032792 RID: 206738
		[Token(Token = "0x4032792")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0__StartMultiBattle;

		// Token: 0x04032793 RID: 206739
		[Token(Token = "0x4032793")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0__StartTrainingBattle;

		// Token: 0x04032794 RID: 206740
		[Token(Token = "0x4032794")]
		[FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0__TriggerMultiStartBattleMaxWaitCoroutine;

		// Token: 0x04032795 RID: 206741
		[Token(Token = "0x4032795")]
		[FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0__StopMultiBattleStartMaxWaitCoroutine;

		// Token: 0x04032796 RID: 206742
		[Token(Token = "0x4032796")]
		[FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0__TryStartMultiBattleAfterMaxWaitTime;

		// Token: 0x04032797 RID: 206743
		[Token(Token = "0x4032797")]
		[FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0__RequestFriendSimpleDatas;

		// Token: 0x04032798 RID: 206744
		[Token(Token = "0x4032798")]
		[FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0__GenLostAlertInfoData;

		// Token: 0x04032799 RID: 206745
		[Token(Token = "0x4032799")]
		[FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0__TryAlertNotification;

		// Token: 0x0403279A RID: 206746
		[Token(Token = "0x403279A")]
		[FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0__GenCommonAlertConfirmDialogConfig;

		// Token: 0x0403279B RID: 206747
		[Token(Token = "0x403279B")]
		[FieldOffset(Offset = "0x380")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006237 RID: 25143
		[Token(Token = "0x2006237")]
		public static class Event
		{
			// Token: 0x0403279C RID: 206748
			[Token(Token = "0x403279C")]
			public const int EXIT = 1;

			// Token: 0x0403279D RID: 206749
			[Token(Token = "0x403279D")]
			public const int SHOW_NAME_CARD = 2;

			// Token: 0x0403279E RID: 206750
			[Token(Token = "0x403279E")]
			public const int SHOW_SIMPLE_DIALOG = 3;

			// Token: 0x0403279F RID: 206751
			[Token(Token = "0x403279F")]
			public const int SOLO_MATCH_JOIN_TEAM = 4;

			// Token: 0x040327A0 RID: 206752
			[Token(Token = "0x40327A0")]
			public const int ADD_FRIEND = 5;

			// Token: 0x040327A1 RID: 206753
			[Token(Token = "0x40327A1")]
			public const int ROOM_KICK = 11;

			// Token: 0x040327A2 RID: 206754
			[Token(Token = "0x40327A2")]
			public const int ROOM_READY = 12;

			// Token: 0x040327A3 RID: 206755
			[Token(Token = "0x40327A3")]
			public const int ROOM_START_MATCH = 13;

			// Token: 0x040327A4 RID: 206756
			[Token(Token = "0x40327A4")]
			public const int ROOM_SET_MODE_ID = 14;

			// Token: 0x040327A5 RID: 206757
			[Token(Token = "0x40327A5")]
			public const int ROOM_SET_RANGE_MODE = 15;

			// Token: 0x040327A6 RID: 206758
			[Token(Token = "0x40327A6")]
			public const int ROOM_CANCEL_MATCH = 16;

			// Token: 0x040327A7 RID: 206759
			[Token(Token = "0x40327A7")]
			public const int ROOM_START_GAME = 17;

			// Token: 0x040327A8 RID: 206760
			[Token(Token = "0x40327A8")]
			public const int ROOM_SET_MATCH_FLAG = 18;

			// Token: 0x040327A9 RID: 206761
			[Token(Token = "0x40327A9")]
			public const int STAGE_INFO_ENEMY_ASSIGN_READY = 21;

			// Token: 0x040327AA RID: 206762
			[Token(Token = "0x40327AA")]
			public const int BAND_CHOOSE_SKIP_CHOOSE_BAND = 31;

			// Token: 0x040327AB RID: 206763
			[Token(Token = "0x40327AB")]
			public const int BAND_CHOOSE_CHOOSE_BAND = 32;

			// Token: 0x040327AC RID: 206764
			[Token(Token = "0x40327AC")]
			public const int SETTLE_GAME_BACK_TO_HOME = 41;

			// Token: 0x040327AD RID: 206765
			[Token(Token = "0x40327AD")]
			public const int SETTLE_GAME_BACK_TO_ROOM = 42;

			// Token: 0x040327AE RID: 206766
			[Token(Token = "0x40327AE")]
			public const int SETTLE_GAME_CONTINUE_MATCH = 43;

			// Token: 0x040327AF RID: 206767
			[Token(Token = "0x40327AF")]
			public const int SETTLE_GAME_LIKE = 44;

			// Token: 0x040327B0 RID: 206768
			[Token(Token = "0x40327B0")]
			public const int SETTLE_GAME_FAIL = 45;
		}

		// Token: 0x02006238 RID: 25144
		[Token(Token = "0x2006238")]
		public enum SimpleDialogType
		{
			// Token: 0x040327B2 RID: 206770
			[Token(Token = "0x40327B2")]
			NONE,
			// Token: 0x040327B3 RID: 206771
			[Token(Token = "0x40327B3")]
			MATCH_CANCELED,
			// Token: 0x040327B4 RID: 206772
			[Token(Token = "0x40327B4")]
			ENTER_ROOM
		}

		// Token: 0x02006239 RID: 25145
		// (Invoke) Token: 0x060244D0 RID: 148688
		[Token(Token = "0x2006239")]
		public delegate IEnumerator StateRouteCoroutineProvider(AutoChessPrepareStateViewType from, AutoChessPrepareStateViewType to);

		// Token: 0x0200623A RID: 25146
		[Token(Token = "0x200623A")]
		public enum BusinessEvent
		{
			// Token: 0x040327B6 RID: 206774
			[Token(Token = "0x40327B6")]
			MATCH_RESULT,
			// Token: 0x040327B7 RID: 206775
			[Token(Token = "0x40327B7")]
			RECEIVE_LIKE
		}
	}
}
