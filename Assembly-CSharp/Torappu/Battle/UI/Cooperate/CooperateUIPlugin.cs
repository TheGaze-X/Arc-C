using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using Torappu.Battle.GameMode;
using Torappu.Multiplayer;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x02003420 RID: 13344
	[Token(Token = "0x2003420")]
	public class CooperateUIPlugin : UIController.Plugin
	{
		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x06015529 RID: 87337 RVA: 0x0008B428 File Offset: 0x00089628
		[Token(Token = "0x17003282")]
		public override bool isPaused
		{
			[Token(Token = "0x6015529")]
			[Address(RVA = "0xDCD140", Offset = "0xDCBD40", VA = "0x180DCD140", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601552A RID: 87338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601552A")]
		[Address(RVA = "0xDC7C80", Offset = "0xDC6880", VA = "0x180DC7C80", Slot = "11")]
		public override void OnCreate(UIController uiController)
		{
		}

		// Token: 0x0601552B RID: 87339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601552B")]
		[Address(RVA = "0xDC8640", Offset = "0xDC7240", VA = "0x180DC8640", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x0601552C RID: 87340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601552C")]
		[Address(RVA = "0xDC7E30", Offset = "0xDC6A30", VA = "0x180DC7E30", Slot = "18")]
		public override void OnFixedUpdate(FP deltaTime)
		{
		}

		// Token: 0x0601552D RID: 87341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601552D")]
		[Address(RVA = "0xDC88D0", Offset = "0xDC74D0", VA = "0x180DC88D0", Slot = "13")]
		public override void OnUIStateChanged(IUIStateNode stateNode)
		{
		}

		// Token: 0x0601552E RID: 87342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601552E")]
		[Address(RVA = "0xDC8040", Offset = "0xDC6C40", VA = "0x180DC8040", Slot = "15")]
		public override void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x0601552F RID: 87343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601552F")]
		[Address(RVA = "0xDC83B0", Offset = "0xDC6FB0", VA = "0x180DC83B0", Slot = "16")]
		public override void OnGameReady()
		{
		}

		// Token: 0x06015530 RID: 87344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015530")]
		[Address(RVA = "0xDC9140", Offset = "0xDC7D40", VA = "0x180DC9140", Slot = "21")]
		public override void UpdateGameInfo()
		{
		}

		// Token: 0x06015531 RID: 87345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015531")]
		[Address(RVA = "0xDC8300", Offset = "0xDC6F00", VA = "0x180DC8300", Slot = "19")]
		public override void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x06015532 RID: 87346 RVA: 0x0008B440 File Offset: 0x00089640
		[Token(Token = "0x6015532")]
		[Address(RVA = "0xDC76D0", Offset = "0xDC62D0", VA = "0x180DC76D0", Slot = "22")]
		public override bool HookGameReadyStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06015533 RID: 87347 RVA: 0x0008B458 File Offset: 0x00089658
		[Token(Token = "0x6015533")]
		[Address(RVA = "0xDC77C0", Offset = "0xDC63C0", VA = "0x180DC77C0", Slot = "23")]
		public override bool HookGameStartStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x06015534 RID: 87348 RVA: 0x0008B470 File Offset: 0x00089670
		[Token(Token = "0x6015534")]
		[Address(RVA = "0xDC7570", Offset = "0xDC6170", VA = "0x180DC7570", Slot = "24")]
		public override bool HookBattleFailedStateSwitch(BattleFailedStateParam param)
		{
			return default(bool);
		}

		// Token: 0x06015535 RID: 87349 RVA: 0x0008B488 File Offset: 0x00089688
		[Token(Token = "0x6015535")]
		[Address(RVA = "0xDC7830", Offset = "0xDC6430", VA = "0x180DC7830", Slot = "27")]
		public override bool HookOnBattleFinishServiceStateEnter()
		{
			return default(bool);
		}

		// Token: 0x06015536 RID: 87350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015536")]
		[Address(RVA = "0xDC9090", Offset = "0xDC7C90", VA = "0x180DC9090", Slot = "43")]
		public override void UpdateDisableMask(BattleFunctionDisableMask mask)
		{
		}

		// Token: 0x06015537 RID: 87351 RVA: 0x0008B4A0 File Offset: 0x000896A0
		[Token(Token = "0x6015537")]
		[Address(RVA = "0xDC78F0", Offset = "0xDC64F0", VA = "0x180DC78F0", Slot = "46")]
		public override bool HookPredefinedUILocation(Camera uiCam, PredefinedLocation location, out Vector3 worldPos)
		{
			return default(bool);
		}

		// Token: 0x06015538 RID: 87352 RVA: 0x0008B4B8 File Offset: 0x000896B8
		[Token(Token = "0x6015538")]
		[Address(RVA = "0xDC8980", Offset = "0xDC7580", VA = "0x180DC8980")]
		public bool RegistTask(ObjectPtr<Buff> buff, CoopStageType type)
		{
			return default(bool);
		}

		// Token: 0x06015539 RID: 87353 RVA: 0x0008B4D0 File Offset: 0x000896D0
		[Token(Token = "0x6015539")]
		[Address(RVA = "0xDC9270", Offset = "0xDC7E70", VA = "0x180DC9270")]
		public bool UpdateProgressBuff(ObjectPtr<Buff> buff)
		{
			return default(bool);
		}

		// Token: 0x0601553A RID: 87354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601553A")]
		[Address(RVA = "0xDC8C00", Offset = "0xDC7800", VA = "0x180DC8C00")]
		public void SetStageTimer(FP time)
		{
		}

		// Token: 0x0601553B RID: 87355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601553B")]
		[Address(RVA = "0xDC8EF0", Offset = "0xDC7AF0", VA = "0x180DC8EF0")]
		public void StopTimerAnim()
		{
		}

		// Token: 0x0601553C RID: 87356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601553C")]
		[Address(RVA = "0xDC8E60", Offset = "0xDC7A60", VA = "0x180DC8E60")]
		public void StageEndAnim()
		{
		}

		// Token: 0x0601553D RID: 87357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601553D")]
		[Address(RVA = "0xDC7430", Offset = "0xDC6030", VA = "0x180DC7430")]
		public void GetProgress(int curScore)
		{
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0601553E RID: 87358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003283")]
		public UICooperatePinMarkCard pinMarkCard
		{
			[Token(Token = "0x601553E")]
			[Address(RVA = "0xDCD200", Offset = "0xDCBE00", VA = "0x180DCD200")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601553F RID: 87359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601553F")]
		[Address(RVA = "0xDC8D30", Offset = "0xDC7930", VA = "0x180DC8D30")]
		public void ShowHint(UICooperateHintPanel.HintType type)
		{
		}

		// Token: 0x06015540 RID: 87360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015540")]
		[Address(RVA = "0xDC74D0", Offset = "0xDC60D0", VA = "0x180DC74D0")]
		public void HideHint(UICooperateHintPanel.HintType type)
		{
		}

		// Token: 0x06015541 RID: 87361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015541")]
		[Address(RVA = "0xDC7150", Offset = "0xDC5D50", VA = "0x180DC7150")]
		public void AddResultNormalTarget(TargetInfo target)
		{
		}

		// Token: 0x06015542 RID: 87362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015542")]
		[Address(RVA = "0xDC8A60", Offset = "0xDC7660", VA = "0x180DC8A60")]
		public void SendMapMarkRequest(GameMarkData param)
		{
		}

		// Token: 0x06015543 RID: 87363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015543")]
		[Address(RVA = "0xDC8B30", Offset = "0xDC7730", VA = "0x180DC8B30")]
		public void SetSpeedColor(bool speedUp, bool mateSpeedUp)
		{
		}

		// Token: 0x06015544 RID: 87364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015544")]
		[Address(RVA = "0xDC8DD0", Offset = "0xDC79D0", VA = "0x180DC8DD0")]
		public void ShowSystemPanel()
		{
		}

		// Token: 0x06015545 RID: 87365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015545")]
		[Address(RVA = "0xDC7A90", Offset = "0xDC6690", VA = "0x180DC7A90")]
		public void OnCancelGiveUp()
		{
		}

		// Token: 0x06015546 RID: 87366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015546")]
		[Address(RVA = "0xDC87D0", Offset = "0xDC73D0", VA = "0x180DC87D0")]
		public void OnRealResume()
		{
		}

		// Token: 0x06015547 RID: 87367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015547")]
		[Address(RVA = "0xDC72B0", Offset = "0xDC5EB0", VA = "0x180DC72B0")]
		public void ClosePauseConfirmPanel()
		{
		}

		// Token: 0x06015548 RID: 87368 RVA: 0x0008B4E8 File Offset: 0x000896E8
		[Token(Token = "0x6015548")]
		[Address(RVA = "0xDC7340", Offset = "0xDC5F40", VA = "0x180DC7340")]
		public GameModeFactory.CooperateGameMode.CooperateIdentityInfo GetIdentityInfo()
		{
			return default(GameModeFactory.CooperateGameMode.CooperateIdentityInfo);
		}

		// Token: 0x06015549 RID: 87369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015549")]
		[Address(RVA = "0xDC8F80", Offset = "0xDC7B80", VA = "0x180DC8F80")]
		public void SwitchOutFromUICooperateBattleStartState()
		{
		}

		// Token: 0x0601554A RID: 87370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601554A")]
		[Address(RVA = "0xDC8CA0", Offset = "0xDC78A0", VA = "0x180DC8CA0")]
		public void ShowEmoticonExpandPanel()
		{
		}

		// Token: 0x0601554B RID: 87371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601554B")]
		[Address(RVA = "0xDCB450", Offset = "0xDCA050", VA = "0x180DCB450")]
		private void _PreloadAssets()
		{
		}

		// Token: 0x0601554C RID: 87372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601554C")]
		[Address(RVA = "0xDC97C0", Offset = "0xDC83C0", VA = "0x180DC97C0")]
		private void _InitLayout()
		{
		}

		// Token: 0x0601554D RID: 87373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601554D")]
		[Address(RVA = "0xDCBD40", Offset = "0xDCA940", VA = "0x180DCBD40")]
		private void _RegisterMultiplayerListener()
		{
		}

		// Token: 0x0601554E RID: 87374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601554E")]
		[Address(RVA = "0xDCC7A0", Offset = "0xDCB3A0", VA = "0x180DCC7A0")]
		private void _UnRegisterMultiplayerListener()
		{
		}

		// Token: 0x0601554F RID: 87375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601554F")]
		[Address(RVA = "0xDCA440", Offset = "0xDC9040", VA = "0x180DCA440")]
		private void _OnGetFinishGame(object arg)
		{
		}

		// Token: 0x06015550 RID: 87376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015550")]
		[Address(RVA = "0xDCC620", Offset = "0xDCB220", VA = "0x180DCC620")]
		private void _SetPauseButtonActive(object arg)
		{
		}

		// Token: 0x06015551 RID: 87377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015551")]
		[Address(RVA = "0xDC9A90", Offset = "0xDC8690", VA = "0x180DC9A90")]
		private void _OnAcceptPause(object arg)
		{
		}

		// Token: 0x06015552 RID: 87378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015552")]
		[Address(RVA = "0xDCAF40", Offset = "0xDC9B40", VA = "0x180DCAF40")]
		private void _OnRefusePause(object arg)
		{
		}

		// Token: 0x06015553 RID: 87379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015553")]
		[Address(RVA = "0xDCB0E0", Offset = "0xDC9CE0", VA = "0x180DCB0E0")]
		private void _OnResumePause(object arg)
		{
		}

		// Token: 0x06015554 RID: 87380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015554")]
		[Address(RVA = "0xDCB250", Offset = "0xDC9E50", VA = "0x180DCB250")]
		private void _OnSpeedStateChanged(object arg)
		{
		}

		// Token: 0x06015555 RID: 87381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015555")]
		[Address(RVA = "0xDCB180", Offset = "0xDC9D80", VA = "0x180DCB180")]
		private void _OnSkipResting(object arg)
		{
		}

		// Token: 0x06015556 RID: 87382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015556")]
		[Address(RVA = "0xDCB040", Offset = "0xDC9C40", VA = "0x180DCB040")]
		private void _OnRestingStart(object arg)
		{
		}

		// Token: 0x06015557 RID: 87383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015557")]
		[Address(RVA = "0xDC9EB0", Offset = "0xDC8AB0", VA = "0x180DC9EB0")]
		private void _OnBeforeNextStage(object arg)
		{
		}

		// Token: 0x06015558 RID: 87384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015558")]
		[Address(RVA = "0xDCA070", Offset = "0xDC8C70", VA = "0x180DCA070")]
		private void _OnDefenceOrFootballWaveFinished(object arg)
		{
		}

		// Token: 0x06015559 RID: 87385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015559")]
		[Address(RVA = "0xDCAEA0", Offset = "0xDC9AA0", VA = "0x180DCAEA0")]
		private void _OnReceivePinMark(object arg)
		{
		}

		// Token: 0x0601555A RID: 87386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601555A")]
		[Address(RVA = "0xDCAC80", Offset = "0xDC9880", VA = "0x180DCAC80")]
		private void _OnReceiveBoatPinMark(object arg)
		{
		}

		// Token: 0x0601555B RID: 87387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601555B")]
		[Address(RVA = "0xDC9DB0", Offset = "0xDC89B0", VA = "0x180DC9DB0")]
		private void _OnBeforeFirstWave(object arg)
		{
		}

		// Token: 0x0601555C RID: 87388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601555C")]
		[Address(RVA = "0xDCA4E0", Offset = "0xDC90E0", VA = "0x180DCA4E0")]
		private void _OnGetNormolProgress(object arg)
		{
		}

		// Token: 0x0601555D RID: 87389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601555D")]
		[Address(RVA = "0xDCA190", Offset = "0xDC8D90", VA = "0x180DCA190")]
		private void _OnFootballManualTick(FP deltaTime)
		{
		}

		// Token: 0x0601555E RID: 87390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601555E")]
		[Address(RVA = "0xDC9600", Offset = "0xDC8200", VA = "0x180DC9600")]
		private void _HandlePlayerStatusChangedResponse(object arg)
		{
		}

		// Token: 0x0601555F RID: 87391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601555F")]
		[Address(RVA = "0xDC9330", Offset = "0xDC7F30", VA = "0x180DC9330")]
		private void _HandleMapMarkResponse(object arg)
		{
		}

		// Token: 0x06015560 RID: 87392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015560")]
		[Address(RVA = "0xDC93C0", Offset = "0xDC7FC0", VA = "0x180DC93C0")]
		private void _HandleMultiplayerBattleStart(object arg)
		{
		}

		// Token: 0x06015561 RID: 87393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015561")]
		[Address(RVA = "0xDC7220", Offset = "0xDC5E20", VA = "0x180DC7220")]
		public void CheatHandle(object arg)
		{
		}

		// Token: 0x06015562 RID: 87394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015562")]
		[Address(RVA = "0xDC9450", Offset = "0xDC8050", VA = "0x180DC9450")]
		private void _HandleMultiplayerBattleStatusChanged(object arg)
		{
		}

		// Token: 0x06015563 RID: 87395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015563")]
		[Address(RVA = "0xDCAB80", Offset = "0xDC9780", VA = "0x180DCAB80")]
		private void _OnRealPaused()
		{
		}

		// Token: 0x06015564 RID: 87396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015564")]
		[Address(RVA = "0xDC99A0", Offset = "0xDC85A0", VA = "0x180DC99A0")]
		private void _NextFrameInPause(object arg)
		{
		}

		// Token: 0x06015565 RID: 87397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015565")]
		[Address(RVA = "0xDCAE00", Offset = "0xDC9A00", VA = "0x180DCAE00")]
		private void _OnReceiveCostRequest(object arg)
		{
		}

		// Token: 0x06015566 RID: 87398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015566")]
		[Address(RVA = "0xDCAA50", Offset = "0xDC9650", VA = "0x180DCAA50")]
		private void _OnPlayerDead(object arg)
		{
		}

		// Token: 0x06015567 RID: 87399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015567")]
		[Address(RVA = "0xDC9CB0", Offset = "0xDC88B0", VA = "0x180DC9CB0")]
		private void _OnAllPlayerRevive(object arg)
		{
		}

		// Token: 0x06015568 RID: 87400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015568")]
		[Address(RVA = "0xDCA630", Offset = "0xDC9230", VA = "0x180DCA630")]
		private void _OnMateOnlineStateChanged(object arg)
		{
		}

		// Token: 0x06015569 RID: 87401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015569")]
		[Address(RVA = "0xDCA800", Offset = "0xDC9400", VA = "0x180DCA800")]
		private void _OnPauseRequest(object arg)
		{
		}

		// Token: 0x0601556A RID: 87402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601556A")]
		[Address(RVA = "0xDCC700", Offset = "0xDCB300", VA = "0x180DCC700")]
		private void _SetPunishInfo(bool punish)
		{
		}

		// Token: 0x0601556B RID: 87403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601556B")]
		[Address(RVA = "0xDCB3C0", Offset = "0xDC9FC0", VA = "0x180DCB3C0")]
		private void _OpenPauseConfirmPanel()
		{
		}

		// Token: 0x0601556C RID: 87404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601556C")]
		[Address(RVA = "0xDCC580", Offset = "0xDCB180", VA = "0x180DCC580")]
		private void _ResetPauseWaitTimer(PlayerSide side)
		{
		}

		// Token: 0x0601556D RID: 87405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601556D")]
		[Address(RVA = "0xDC98E0", Offset = "0xDC84E0", VA = "0x180DC98E0")]
		private void _MarkPauseWaitInvalid(bool reject = false, PlayerSide side = PlayerSide.DEFAULT)
		{
		}

		// Token: 0x0601556E RID: 87406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601556E")]
		[Address(RVA = "0xDCD0C0", Offset = "0xDCBCC0", VA = "0x180DCD0C0")]
		public CooperateUIPlugin()
		{
		}

		// Token: 0x06015570 RID: 87408 RVA: 0x0008B500 File Offset: 0x00089700
		[Token(Token = "0x6015570")]
		[Address(RVA = "0xDC9080", Offset = "0xDC7C80", VA = "0x180DC9080")]
		private bool <>xLuaBaseProxy_get_isPaused()
		{
			return default(bool);
		}

		// Token: 0x06015571 RID: 87409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015571")]
		[Address(RVA = "0x7D2480", Offset = "0x7D1080", VA = "0x1807D2480")]
		private void <>xLuaBaseProxy_OnCreate(UIController P0)
		{
		}

		// Token: 0x06015572 RID: 87410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015572")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x06015573 RID: 87411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015573")]
		[Address(RVA = "0xDC64B0", Offset = "0xDC50B0", VA = "0x180DC64B0")]
		private void <>xLuaBaseProxy_OnFixedUpdate(FP P0)
		{
		}

		// Token: 0x06015574 RID: 87412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015574")]
		[Address(RVA = "0x7D24D0", Offset = "0x7D10D0", VA = "0x1807D24D0")]
		private void <>xLuaBaseProxy_OnUIStateChanged(IUIStateNode P0)
		{
		}

		// Token: 0x06015575 RID: 87413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015575")]
		[Address(RVA = "0x7D2490", Offset = "0x7D1090", VA = "0x1807D2490")]
		private void <>xLuaBaseProxy_OnGameInit(LevelData.Options P0)
		{
		}

		// Token: 0x06015576 RID: 87414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015576")]
		[Address(RVA = "0x9CCDF0", Offset = "0x9CB9F0", VA = "0x1809CCDF0")]
		private void <>xLuaBaseProxy_OnGameReady()
		{
		}

		// Token: 0x06015577 RID: 87415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015577")]
		[Address(RVA = "0x7D24E0", Offset = "0x7D10E0", VA = "0x1807D24E0")]
		private void <>xLuaBaseProxy_UpdateGameInfo()
		{
		}

		// Token: 0x06015578 RID: 87416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015578")]
		[Address(RVA = "0x7D24A0", Offset = "0x7D10A0", VA = "0x1807D24A0")]
		private void <>xLuaBaseProxy_OnGameOver(BattleController.GameResult P0)
		{
		}

		// Token: 0x06015579 RID: 87417 RVA: 0x0008B518 File Offset: 0x00089718
		[Token(Token = "0x6015579")]
		[Address(RVA = "0x9CCDA0", Offset = "0x9CB9A0", VA = "0x1809CCDA0")]
		private bool <>xLuaBaseProxy_HookGameReadyStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x0601557A RID: 87418 RVA: 0x0008B530 File Offset: 0x00089730
		[Token(Token = "0x601557A")]
		[Address(RVA = "0xD69530", Offset = "0xD68130", VA = "0x180D69530")]
		private bool <>xLuaBaseProxy_HookGameStartStateSwitch()
		{
			return default(bool);
		}

		// Token: 0x0601557B RID: 87419 RVA: 0x0008B548 File Offset: 0x00089748
		[Token(Token = "0x601557B")]
		[Address(RVA = "0x960A10", Offset = "0x95F610", VA = "0x180960A10")]
		private bool <>xLuaBaseProxy_HookBattleFailedStateSwitch(BattleFailedStateParam P0)
		{
			return default(bool);
		}

		// Token: 0x0601557C RID: 87420 RVA: 0x0008B560 File Offset: 0x00089760
		[Token(Token = "0x601557C")]
		[Address(RVA = "0xD9C400", Offset = "0xD9B000", VA = "0x180D9C400")]
		private bool <>xLuaBaseProxy_HookOnBattleFinishServiceStateEnter()
		{
			return default(bool);
		}

		// Token: 0x0601557D RID: 87421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601557D")]
		[Address(RVA = "0xDC9070", Offset = "0xDC7C70", VA = "0x180DC9070")]
		private void <>xLuaBaseProxy_UpdateDisableMask(BattleFunctionDisableMask P0)
		{
		}

		// Token: 0x0601557E RID: 87422 RVA: 0x0008B578 File Offset: 0x00089778
		[Token(Token = "0x601557E")]
		[Address(RVA = "0xD51FB0", Offset = "0xD50BB0", VA = "0x180D51FB0")]
		private bool <>xLuaBaseProxy_HookPredefinedUILocation(Camera P0, PredefinedLocation P1, out Vector3 P2)
		{
			return default(bool);
		}

		// Token: 0x0401980D RID: 104461
		[Token(Token = "0x401980D")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 CARD_LIST_OFFSET_MIN;

		// Token: 0x0401980E RID: 104462
		[Token(Token = "0x401980E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly UIStateEnum UI_STATE_BATTLE_START;

		// Token: 0x0401980F RID: 104463
		[Token(Token = "0x401980F")]
		[FieldOffset(Offset = "0xC")]
		public static readonly UIStateEnum UI_STATE_PIN_MARK;

		// Token: 0x04019810 RID: 104464
		[Token(Token = "0x4019810")]
		[FieldOffset(Offset = "0x10")]
		public static readonly UIStateEnum UI_STATE_BATTLE_FAILED;

		// Token: 0x04019811 RID: 104465
		[Token(Token = "0x4019811")]
		[FieldOffset(Offset = "0x14")]
		public static readonly UIStateEnum UI_STATE_SCORE_A_GOAL;

		// Token: 0x04019812 RID: 104466
		[Token(Token = "0x4019812")]
		[FieldOffset(Offset = "0x18")]
		public static readonly UIStateEnum UI_STAGE_WAVE_START;

		// Token: 0x04019813 RID: 104467
		[Token(Token = "0x4019813")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly UIStateEnum UI_STAGE_SHOW_IDENTITY_BUFF;

		// Token: 0x04019814 RID: 104468
		[Token(Token = "0x4019814")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Color UNSTABLE_BLUR_COLOR;

		// Token: 0x04019815 RID: 104469
		[Token(Token = "0x4019815")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<UIStateNode> _states;

		// Token: 0x04019816 RID: 104470
		[Token(Token = "0x4019816")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICooperateCostHandlePanel _costHandlePanel;

		// Token: 0x04019817 RID: 104471
		[Token(Token = "0x4019817")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICooperateBattleMenuSystemPanel _systemPanel;

		// Token: 0x04019818 RID: 104472
		[Token(Token = "0x4019818")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICooperateBattleTopBar _topBarStatus;

		// Token: 0x04019819 RID: 104473
		[Token(Token = "0x4019819")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UICooperateHintPanel _hintPanel;

		// Token: 0x0401981A RID: 104474
		[Token(Token = "0x401981A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICooperateRestingPanel _restingPanel;

		// Token: 0x0401981B RID: 104475
		[Token(Token = "0x401981B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UICooperateBattleUnstablePanel _unstablePanel;

		// Token: 0x0401981C RID: 104476
		[Token(Token = "0x401981C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICooperatePinMarkCard _pinMarkCard;

		// Token: 0x0401981D RID: 104477
		[Token(Token = "0x401981D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UICooperateBattleEmoticonController _emoticonCtrl;

		// Token: 0x0401981E RID: 104478
		[Token(Token = "0x401981E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _bottomMask;

		// Token: 0x0401981F RID: 104479
		[Token(Token = "0x401981F")]
		[FieldOffset(Offset = "0x78")]
		private GameModeFactory.CooperateGameMode m_gameMode;

		// Token: 0x04019820 RID: 104480
		[Token(Token = "0x4019820")]
		[FieldOffset(Offset = "0x80")]
		private UICooperateBattleTopBar m_topBarStatus;

		// Token: 0x04019821 RID: 104481
		[Token(Token = "0x4019821")]
		[FieldOffset(Offset = "0x88")]
		private UICooperateBattleMenuSystemPanel m_menuSystemPanel;

		// Token: 0x04019822 RID: 104482
		[Token(Token = "0x4019822")]
		[FieldOffset(Offset = "0x90")]
		private UICooperateHintPanel m_hintPanel;

		// Token: 0x04019823 RID: 104483
		[Token(Token = "0x4019823")]
		[FieldOffset(Offset = "0x98")]
		private UICooperateRestingPanel m_restingPanel;

		// Token: 0x04019824 RID: 104484
		[Token(Token = "0x4019824")]
		[FieldOffset(Offset = "0xA0")]
		private UICooperateCostHandlePanel m_costHandlePanel;

		// Token: 0x04019825 RID: 104485
		[Token(Token = "0x4019825")]
		[FieldOffset(Offset = "0xA8")]
		private UICooperateBattleUnstablePanel m_unstablePanel;

		// Token: 0x04019826 RID: 104486
		[Token(Token = "0x4019826")]
		[FieldOffset(Offset = "0xB0")]
		private UICooperatePinMarkCard m_pinMarkCard;

		// Token: 0x04019827 RID: 104487
		[Token(Token = "0x4019827")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject m_bottomMask;

		// Token: 0x04019828 RID: 104488
		[Token(Token = "0x4019828")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isMultiPlayerLocal;

		// Token: 0x04019829 RID: 104489
		[Token(Token = "0x4019829")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isPaused;

		// Token: 0x0401982A RID: 104490
		[Token(Token = "0x401982A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401982B RID: 104491
		[Token(Token = "0x401982B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x0401982C RID: 104492
		[Token(Token = "0x401982C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x0401982D RID: 104493
		[Token(Token = "0x401982D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnUIStateChanged;

		// Token: 0x0401982E RID: 104494
		[Token(Token = "0x401982E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x0401982F RID: 104495
		[Token(Token = "0x401982F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x04019830 RID: 104496
		[Token(Token = "0x4019830")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x04019831 RID: 104497
		[Token(Token = "0x4019831")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x04019832 RID: 104498
		[Token(Token = "0x4019832")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_HookGameReadyStateSwitch;

		// Token: 0x04019833 RID: 104499
		[Token(Token = "0x4019833")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_HookGameStartStateSwitch;

		// Token: 0x04019834 RID: 104500
		[Token(Token = "0x4019834")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_HookBattleFailedStateSwitch;

		// Token: 0x04019835 RID: 104501
		[Token(Token = "0x4019835")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_HookOnBattleFinishServiceStateEnter;

		// Token: 0x04019836 RID: 104502
		[Token(Token = "0x4019836")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_UpdateDisableMask;

		// Token: 0x04019837 RID: 104503
		[Token(Token = "0x4019837")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_HookPredefinedUILocation;

		// Token: 0x04019838 RID: 104504
		[Token(Token = "0x4019838")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_RegistTask;

		// Token: 0x04019839 RID: 104505
		[Token(Token = "0x4019839")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_UpdateProgressBuff;

		// Token: 0x0401983A RID: 104506
		[Token(Token = "0x401983A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SetStageTimer;

		// Token: 0x0401983B RID: 104507
		[Token(Token = "0x401983B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_StopTimerAnim;

		// Token: 0x0401983C RID: 104508
		[Token(Token = "0x401983C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_StageEndAnim;

		// Token: 0x0401983D RID: 104509
		[Token(Token = "0x401983D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetProgress;

		// Token: 0x0401983E RID: 104510
		[Token(Token = "0x401983E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_pinMarkCard;

		// Token: 0x0401983F RID: 104511
		[Token(Token = "0x401983F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_ShowHint;

		// Token: 0x04019840 RID: 104512
		[Token(Token = "0x4019840")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_HideHint;

		// Token: 0x04019841 RID: 104513
		[Token(Token = "0x4019841")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_AddResultNormalTarget;

		// Token: 0x04019842 RID: 104514
		[Token(Token = "0x4019842")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_SendMapMarkRequest;

		// Token: 0x04019843 RID: 104515
		[Token(Token = "0x4019843")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_SetSpeedColor;

		// Token: 0x04019844 RID: 104516
		[Token(Token = "0x4019844")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_ShowSystemPanel;

		// Token: 0x04019845 RID: 104517
		[Token(Token = "0x4019845")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnCancelGiveUp;

		// Token: 0x04019846 RID: 104518
		[Token(Token = "0x4019846")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_OnRealResume;

		// Token: 0x04019847 RID: 104519
		[Token(Token = "0x4019847")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_ClosePauseConfirmPanel;

		// Token: 0x04019848 RID: 104520
		[Token(Token = "0x4019848")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_GetIdentityInfo;

		// Token: 0x04019849 RID: 104521
		[Token(Token = "0x4019849")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_SwitchOutFromUICooperateBattleStartState;

		// Token: 0x0401984A RID: 104522
		[Token(Token = "0x401984A")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_ShowEmoticonExpandPanel;

		// Token: 0x0401984B RID: 104523
		[Token(Token = "0x401984B")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__PreloadAssets;

		// Token: 0x0401984C RID: 104524
		[Token(Token = "0x401984C")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__InitLayout;

		// Token: 0x0401984D RID: 104525
		[Token(Token = "0x401984D")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__RegisterMultiplayerListener;

		// Token: 0x0401984E RID: 104526
		[Token(Token = "0x401984E")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__UnRegisterMultiplayerListener;

		// Token: 0x0401984F RID: 104527
		[Token(Token = "0x401984F")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__OnGetFinishGame;

		// Token: 0x04019850 RID: 104528
		[Token(Token = "0x4019850")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__SetPauseButtonActive;

		// Token: 0x04019851 RID: 104529
		[Token(Token = "0x4019851")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__OnAcceptPause;

		// Token: 0x04019852 RID: 104530
		[Token(Token = "0x4019852")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__OnRefusePause;

		// Token: 0x04019853 RID: 104531
		[Token(Token = "0x4019853")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__OnResumePause;

		// Token: 0x04019854 RID: 104532
		[Token(Token = "0x4019854")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__OnSpeedStateChanged;

		// Token: 0x04019855 RID: 104533
		[Token(Token = "0x4019855")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__OnSkipResting;

		// Token: 0x04019856 RID: 104534
		[Token(Token = "0x4019856")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__OnRestingStart;

		// Token: 0x04019857 RID: 104535
		[Token(Token = "0x4019857")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__OnBeforeNextStage;

		// Token: 0x04019858 RID: 104536
		[Token(Token = "0x4019858")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__OnDefenceOrFootballWaveFinished;

		// Token: 0x04019859 RID: 104537
		[Token(Token = "0x4019859")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__OnReceivePinMark;

		// Token: 0x0401985A RID: 104538
		[Token(Token = "0x401985A")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__OnReceiveBoatPinMark;

		// Token: 0x0401985B RID: 104539
		[Token(Token = "0x401985B")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__OnBeforeFirstWave;

		// Token: 0x0401985C RID: 104540
		[Token(Token = "0x401985C")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__OnGetNormolProgress;

		// Token: 0x0401985D RID: 104541
		[Token(Token = "0x401985D")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__OnFootballManualTick;

		// Token: 0x0401985E RID: 104542
		[Token(Token = "0x401985E")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__HandlePlayerStatusChangedResponse;

		// Token: 0x0401985F RID: 104543
		[Token(Token = "0x401985F")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__HandleMapMarkResponse;

		// Token: 0x04019860 RID: 104544
		[Token(Token = "0x4019860")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__HandleMultiplayerBattleStart;

		// Token: 0x04019861 RID: 104545
		[Token(Token = "0x4019861")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_CheatHandle;

		// Token: 0x04019862 RID: 104546
		[Token(Token = "0x4019862")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__HandleMultiplayerBattleStatusChanged;

		// Token: 0x04019863 RID: 104547
		[Token(Token = "0x4019863")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__OnRealPaused;

		// Token: 0x04019864 RID: 104548
		[Token(Token = "0x4019864")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__NextFrameInPause;

		// Token: 0x04019865 RID: 104549
		[Token(Token = "0x4019865")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__OnReceiveCostRequest;

		// Token: 0x04019866 RID: 104550
		[Token(Token = "0x4019866")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0__OnPlayerDead;

		// Token: 0x04019867 RID: 104551
		[Token(Token = "0x4019867")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__OnAllPlayerRevive;

		// Token: 0x04019868 RID: 104552
		[Token(Token = "0x4019868")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__OnMateOnlineStateChanged;

		// Token: 0x04019869 RID: 104553
		[Token(Token = "0x4019869")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0__OnPauseRequest;

		// Token: 0x0401986A RID: 104554
		[Token(Token = "0x401986A")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0__SetPunishInfo;

		// Token: 0x0401986B RID: 104555
		[Token(Token = "0x401986B")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0__OpenPauseConfirmPanel;

		// Token: 0x0401986C RID: 104556
		[Token(Token = "0x401986C")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0__ResetPauseWaitTimer;

		// Token: 0x0401986D RID: 104557
		[Token(Token = "0x401986D")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0__MarkPauseWaitInvalid;

		// Token: 0x0401986E RID: 104558
		[Token(Token = "0x401986E")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
