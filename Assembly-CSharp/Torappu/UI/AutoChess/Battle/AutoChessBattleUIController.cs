using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using Torappu.Battle.DataCenter;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006472 RID: 25714
	[Token(Token = "0x2006472")]
	public class AutoChessBattleUIController : PageSingleComponent, IValueMsgReceiver
	{
		// Token: 0x06024F72 RID: 151410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F72")]
		[Address(RVA = "0x1FC89E0", Offset = "0x1FC75E0", VA = "0x181FC89E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x06024F73 RID: 151411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F73")]
		[Address(RVA = "0x1FCA0F0", Offset = "0x1FC8CF0", VA = "0x181FCA0F0", Slot = "7")]
		protected override void OnStart()
		{
		}

		// Token: 0x06024F74 RID: 151412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F74")]
		[Address(RVA = "0x1FCA750", Offset = "0x1FC9350", VA = "0x181FCA750")]
		protected void Update()
		{
		}

		// Token: 0x06024F75 RID: 151413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F75")]
		[Address(RVA = "0x1FC8D20", Offset = "0x1FC7920", VA = "0x181FC8D20", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06024F76 RID: 151414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F76")]
		[Address(RVA = "0x1FC8DE0", Offset = "0x1FC79E0", VA = "0x181FC8DE0", Slot = "12")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06024F77 RID: 151415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F77")]
		[Address(RVA = "0x1FCFCC0", Offset = "0x1FCE8C0", VA = "0x181FCFCC0")]
		private void _OnObLeftArrowClick()
		{
		}

		// Token: 0x06024F78 RID: 151416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F78")]
		[Address(RVA = "0x1FCFFF0", Offset = "0x1FCEBF0", VA = "0x181FCFFF0")]
		private void _OnObRightArrowClick()
		{
		}

		// Token: 0x06024F79 RID: 151417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F79")]
		[Address(RVA = "0x1FD1C00", Offset = "0x1FD0800", VA = "0x181FD1C00")]
		private void _ReqChangeBattleMapLayer(bool toRight)
		{
		}

		// Token: 0x06024F7A RID: 151418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F7A")]
		[Address(RVA = "0x1FCF6F0", Offset = "0x1FCE2F0", VA = "0x181FCF6F0")]
		private void _OnCancelOb()
		{
		}

		// Token: 0x06024F7B RID: 151419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F7B")]
		[Address(RVA = "0x1FD0050", Offset = "0x1FCEC50", VA = "0x181FD0050")]
		private void _OnOpenEmoji()
		{
		}

		// Token: 0x06024F7C RID: 151420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F7C")]
		[Address(RVA = "0x1FD0150", Offset = "0x1FCED50", VA = "0x181FD0150")]
		private void _OnSendEmoji(object arg)
		{
		}

		// Token: 0x06024F7D RID: 151421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F7D")]
		[Address(RVA = "0x1FCFD20", Offset = "0x1FCE920", VA = "0x181FCFD20")]
		private void _OnObOtherPre()
		{
		}

		// Token: 0x06024F7E RID: 151422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F7E")]
		[Address(RVA = "0x1FCFDC0", Offset = "0x1FCE9C0", VA = "0x181FCFDC0")]
		private void _OnObOther(int index)
		{
		}

		// Token: 0x06024F7F RID: 151423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F7F")]
		[Address(RVA = "0x1FCFA00", Offset = "0x1FCE600", VA = "0x181FCFA00")]
		private void _OnEffectChooseConfirm(int slotId)
		{
		}

		// Token: 0x06024F80 RID: 151424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F80")]
		[Address(RVA = "0x1FCB0B0", Offset = "0x1FC9CB0", VA = "0x181FCB0B0")]
		private void _EventOnPrepReadyBtnClick()
		{
		}

		// Token: 0x06024F81 RID: 151425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F81")]
		[Address(RVA = "0x1FD0D10", Offset = "0x1FCF910", VA = "0x181FD0D10")]
		private void _OnToggleBondPanelDisplay()
		{
		}

		// Token: 0x06024F82 RID: 151426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F82")]
		[Address(RVA = "0x1FD0290", Offset = "0x1FCEE90", VA = "0x181FD0290")]
		private void _OnSetSelectedBond(string bondId)
		{
		}

		// Token: 0x06024F83 RID: 151427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F83")]
		[Address(RVA = "0x1FCF8E0", Offset = "0x1FCE4E0", VA = "0x181FCF8E0")]
		private void _OnClickPrevBond()
		{
		}

		// Token: 0x06024F84 RID: 151428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F84")]
		[Address(RVA = "0x1FCF7C0", Offset = "0x1FCE3C0", VA = "0x181FCF7C0")]
		private void _OnClickNextBond()
		{
		}

		// Token: 0x06024F85 RID: 151429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F85")]
		[Address(RVA = "0x1FD0F40", Offset = "0x1FCFB40", VA = "0x181FD0F40")]
		private void _OnToggleHUDPlayerInfo()
		{
		}

		// Token: 0x06024F86 RID: 151430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F86")]
		[Address(RVA = "0x1FD0E30", Offset = "0x1FCFA30", VA = "0x181FD0E30")]
		private void _OnToggleHUDEnemyInfo()
		{
		}

		// Token: 0x06024F87 RID: 151431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F87")]
		[Address(RVA = "0x1FCFB20", Offset = "0x1FCE720", VA = "0x181FCFB20")]
		private void _OnEquipReplaceDialogClicked(object obj)
		{
		}

		// Token: 0x06024F88 RID: 151432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F88")]
		[Address(RVA = "0x1FCFC20", Offset = "0x1FCE820", VA = "0x181FCFC20")]
		private void _OnHUDReset()
		{
		}

		// Token: 0x06024F89 RID: 151433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F89")]
		[Address(RVA = "0x1FD0AF0", Offset = "0x1FCF6F0", VA = "0x181FD0AF0")]
		private void _OnShopSel(AutoChessBattleShopSlot slot)
		{
		}

		// Token: 0x06024F8A RID: 151434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F8A")]
		[Address(RVA = "0x1FD0440", Offset = "0x1FCF040", VA = "0x181FD0440")]
		private void _OnShopBuy(int slotId)
		{
		}

		// Token: 0x06024F8B RID: 151435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F8B")]
		[Address(RVA = "0x1FD0BB0", Offset = "0x1FCF7B0", VA = "0x181FD0BB0")]
		private void _OnShopUpgrade()
		{
		}

		// Token: 0x06024F8C RID: 151436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F8C")]
		[Address(RVA = "0x1FD06F0", Offset = "0x1FCF2F0", VA = "0x181FD06F0")]
		private void _OnShopFreeze()
		{
		}

		// Token: 0x06024F8D RID: 151437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F8D")]
		[Address(RVA = "0x1FD0930", Offset = "0x1FCF530", VA = "0x181FD0930")]
		private void _OnShopRefresh()
		{
		}

		// Token: 0x06024F8E RID: 151438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F8E")]
		[Address(RVA = "0x1FD0890", Offset = "0x1FCF490", VA = "0x181FD0890")]
		private void _OnShopOpen(bool isOpen)
		{
		}

		// Token: 0x06024F8F RID: 151439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F8F")]
		[Address(RVA = "0x1FCAFF0", Offset = "0x1FC9BF0", VA = "0x181FCAFF0")]
		private void _ClearShopSel()
		{
		}

		// Token: 0x06024F90 RID: 151440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F90")]
		[Address(RVA = "0x1FCBA10", Offset = "0x1FCA610", VA = "0x181FCBA10")]
		private List<UISimpleTabPagerHandler.TabPagerDialogConfig> _GeneTabPagerDialogConfigs()
		{
			return null;
		}

		// Token: 0x06024F91 RID: 151441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F91")]
		[Address(RVA = "0x1FCD800", Offset = "0x1FCC400", VA = "0x181FCD800")]
		private object _GetSettleEndingTabInput()
		{
			return null;
		}

		// Token: 0x06024F92 RID: 151442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F92")]
		[Address(RVA = "0x1FCD2E0", Offset = "0x1FCBEE0", VA = "0x181FCD2E0")]
		private object _GetPrepareStartTabInput()
		{
			return null;
		}

		// Token: 0x06024F93 RID: 151443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F93")]
		[Address(RVA = "0x1FCCA80", Offset = "0x1FCB680", VA = "0x181FCCA80")]
		private object _GetBattleEndTabInput()
		{
			return null;
		}

		// Token: 0x06024F94 RID: 151444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F94")]
		[Address(RVA = "0x1FCCB60", Offset = "0x1FCB760", VA = "0x181FCCB60")]
		private object _GetEquipReplaceDialogTabInput()
		{
			return null;
		}

		// Token: 0x06024F95 RID: 151445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F95")]
		[Address(RVA = "0x1FCC9A0", Offset = "0x1FCB5A0", VA = "0x181FCC9A0")]
		private object _GetAnimBossPrepareDialogTabInput()
		{
			return null;
		}

		// Token: 0x06024F96 RID: 151446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F96")]
		[Address(RVA = "0x1FCD100", Offset = "0x1FCBD00", VA = "0x181FCD100")]
		private object _GetPreReadyTipHandOverflowDialogTabInput()
		{
			return null;
		}

		// Token: 0x06024F97 RID: 151447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F97")]
		[Address(RVA = "0x1FCCE90", Offset = "0x1FCBA90", VA = "0x181FCCE90")]
		private object _GetPreReadyTipGoldDialogTabInput()
		{
			return null;
		}

		// Token: 0x06024F98 RID: 151448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F98")]
		[Address(RVA = "0x1FCEF40", Offset = "0x1FCDB40", VA = "0x181FCEF40")]
		private CustomYieldInstruction _HandleTabSelfDead(ValueBundle output)
		{
			return null;
		}

		// Token: 0x06024F99 RID: 151449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F99")]
		[Address(RVA = "0x1FCED70", Offset = "0x1FCD970", VA = "0x181FCED70")]
		private CustomYieldInstruction _HandleTabPrepReadyTipHandOverflow(ValueBundle output)
		{
			return null;
		}

		// Token: 0x06024F9A RID: 151450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F9A")]
		[Address(RVA = "0x1FCEC50", Offset = "0x1FCD850", VA = "0x181FCEC50")]
		private CustomYieldInstruction _HandleTabPrepReadyTipGold(ValueBundle output)
		{
			return null;
		}

		// Token: 0x06024F9B RID: 151451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F9B")]
		[Address(RVA = "0x1FCB350", Offset = "0x1FC9F50", VA = "0x181FCB350")]
		private List<UISimpleTabPagerHandler.TabPagerDialogConfig> _GeneGiveUpTabPagerDialogConfigs()
		{
			return null;
		}

		// Token: 0x06024F9C RID: 151452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F9C")]
		[Address(RVA = "0x1FCCC40", Offset = "0x1FCB840", VA = "0x181FCCC40")]
		private object _GetGiveUpDialogTabInput()
		{
			return null;
		}

		// Token: 0x06024F9D RID: 151453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F9D")]
		[Address(RVA = "0x1FCEAB0", Offset = "0x1FCD6B0", VA = "0x181FCEAB0")]
		private CustomYieldInstruction _HandleTabGiveUpDialog(ValueBundle output)
		{
			return null;
		}

		// Token: 0x06024F9E RID: 151454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F9E")]
		[Address(RVA = "0x1FCB590", Offset = "0x1FCA190", VA = "0x181FCB590")]
		private List<UISimpleTabPagerHandler.TabPagerDialogConfig> _GeneServerLostTabPagerDialogConfigs()
		{
			return null;
		}

		// Token: 0x06024F9F RID: 151455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024F9F")]
		[Address(RVA = "0x1FCD650", Offset = "0x1FCC250", VA = "0x181FCD650")]
		private object _GetServerLostDialogTabInput()
		{
			return null;
		}

		// Token: 0x06024FA0 RID: 151456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024FA0")]
		[Address(RVA = "0x1FCF080", Offset = "0x1FCDC80", VA = "0x181FCF080")]
		private CustomYieldInstruction _HandleTabServerLostDialog(ValueBundle output)
		{
			return null;
		}

		// Token: 0x06024FA1 RID: 151457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024FA1")]
		[Address(RVA = "0x1FCB7D0", Offset = "0x1FCA3D0", VA = "0x181FCB7D0")]
		private List<UISimpleTabPagerHandler.TabPagerDialogConfig> _GeneSingleResumeTabPagerDialogConfigs()
		{
			return null;
		}

		// Token: 0x06024FA2 RID: 151458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024FA2")]
		[Address(RVA = "0x1FCD930", Offset = "0x1FCC530", VA = "0x181FCD930")]
		private object _GetSingleResumeDialogTabInput()
		{
			return null;
		}

		// Token: 0x06024FA3 RID: 151459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024FA3")]
		[Address(RVA = "0x1FCF170", Offset = "0x1FCDD70", VA = "0x181FCF170")]
		private CustomYieldInstruction _HandleTabSingleResumeDialog(ValueBundle output)
		{
			return null;
		}

		// Token: 0x06024FA4 RID: 151460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FA4")]
		[Address(RVA = "0x1FC8860", Offset = "0x1FC7460", VA = "0x181FC8860")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x06024FA5 RID: 151461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FA5")]
		[Address(RVA = "0x1FC8950", Offset = "0x1FC7550", VA = "0x181FC8950")]
		public void EventOnShowSingleResumeDialog()
		{
		}

		// Token: 0x06024FA6 RID: 151462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FA6")]
		[Address(RVA = "0x1FCF430", Offset = "0x1FCE030", VA = "0x181FCF430")]
		private void _InitBattleEvent()
		{
		}

		// Token: 0x06024FA7 RID: 151463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FA7")]
		[Address(RVA = "0x1FD1940", Offset = "0x1FD0540", VA = "0x181FD1940")]
		private void _RemoveBattleEvent()
		{
		}

		// Token: 0x06024FA8 RID: 151464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FA8")]
		[Address(RVA = "0x1FD1050", Offset = "0x1FCFC50", VA = "0x181FD1050")]
		private void _RegisterStatusTask()
		{
		}

		// Token: 0x06024FA9 RID: 151465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FA9")]
		[Address(RVA = "0x1FD16F0", Offset = "0x1FD02F0", VA = "0x181FD16F0")]
		private void _RegisterTabPagerTask(float maxDisplayTime, string tabId, AutoChessGameStateType state, AutoChessGameStatus.SubState subState)
		{
		}

		// Token: 0x06024FAA RID: 151466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FAA")]
		[Address(RVA = "0x1FCAA60", Offset = "0x1FC9660", VA = "0x181FCAA60")]
		private void _BindBattleUIViews()
		{
		}

		// Token: 0x06024FAB RID: 151467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024FAB")]
		[Address(RVA = "0x1FCDAC0", Offset = "0x1FCC6C0", VA = "0x181FCDAC0")]
		private List<Camera> _GetTabViewableCameras()
		{
			return null;
		}

		// Token: 0x06024FAC RID: 151468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FAC")]
		[Address(RVA = "0x1FCE560", Offset = "0x1FCD160", VA = "0x181FCE560")]
		private void _HandlePrepReadyTipGoldNoMore()
		{
		}

		// Token: 0x06024FAD RID: 151469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FAD")]
		[Address(RVA = "0x1FCDB50", Offset = "0x1FCC750", VA = "0x181FCDB50")]
		private void _HandleDataChanged(object arg)
		{
		}

		// Token: 0x06024FAE RID: 151470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FAE")]
		[Address(RVA = "0x1FCE750", Offset = "0x1FCD350", VA = "0x181FCE750")]
		private void _HandleRevChatMsg(object arg)
		{
		}

		// Token: 0x06024FAF RID: 151471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FAF")]
		[Address(RVA = "0x1FCE5F0", Offset = "0x1FCD1F0", VA = "0x181FCE5F0")]
		private void _HandleRevBroadcast(object arg)
		{
		}

		// Token: 0x06024FB0 RID: 151472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FB0")]
		[Address(RVA = "0x1FCE8C0", Offset = "0x1FCD4C0", VA = "0x181FCE8C0")]
		private void _HandleServerLost(object arg)
		{
		}

		// Token: 0x06024FB1 RID: 151473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FB1")]
		[Address(RVA = "0x1FCF350", Offset = "0x1FCDF50", VA = "0x181FCF350")]
		private void _HandleTutorialLockDrag(object arg)
		{
		}

		// Token: 0x06024FB2 RID: 151474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FB2")]
		[Address(RVA = "0x1FCF3C0", Offset = "0x1FCDFC0", VA = "0x181FCF3C0")]
		private void _HandleTutorialUnlockDrag(object arg)
		{
		}

		// Token: 0x06024FB3 RID: 151475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FB3")]
		[Address(RVA = "0x1FCF270", Offset = "0x1FCDE70", VA = "0x181FCF270")]
		private void _HandleTutorialBondExpandLock(object arg)
		{
		}

		// Token: 0x06024FB4 RID: 151476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FB4")]
		[Address(RVA = "0x1FCF2E0", Offset = "0x1FCDEE0", VA = "0x181FCF2E0")]
		private void _HandleTutorialBondExpandUnlock(object arg)
		{
		}

		// Token: 0x06024FB5 RID: 151477 RVA: 0x000C5EC8 File Offset: 0x000C40C8
		[Token(Token = "0x6024FB5")]
		[Address(RVA = "0x1FCAF50", Offset = "0x1FC9B50", VA = "0x181FCAF50")]
		private bool _CheckIfTutorialLock()
		{
			return default(bool);
		}

		// Token: 0x06024FB6 RID: 151478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FB6")]
		[Address(RVA = "0x1FCE3B0", Offset = "0x1FCCFB0", VA = "0x181FCE3B0")]
		private void _HandlePlayerStateChanged(AutoChessBattleUIViewModel viewModel)
		{
		}

		// Token: 0x06024FB7 RID: 151479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FB7")]
		[Address(RVA = "0x1FCE090", Offset = "0x1FCCC90", VA = "0x181FCE090")]
		private void _HandleGameStateChanged(AutoChessBattleUIViewModel viewModel)
		{
		}

		// Token: 0x06024FB8 RID: 151480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FB8")]
		[Address(RVA = "0x1FCE260", Offset = "0x1FCCE60", VA = "0x181FCE260")]
		private void _HandleIfShowEquipReplaceDialog(AutoChessBattleUIViewModel viewModel)
		{
		}

		// Token: 0x06024FB9 RID: 151481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FB9")]
		[Address(RVA = "0x1FD1D00", Offset = "0x1FD0900", VA = "0x181FD1D00")]
		private void _ShowToast(string textId)
		{
		}

		// Token: 0x06024FBA RID: 151482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FBA")]
		[Address(RVA = "0x1FD1D90", Offset = "0x1FD0990", VA = "0x181FD1D90")]
		public AutoChessBattleUIController()
		{
		}

		// Token: 0x06024FBC RID: 151484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FBC")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x06024FBD RID: 151485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FBD")]
		[Address(RVA = "0xF53770", Offset = "0xF52370", VA = "0x180F53770")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06024FBE RID: 151486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024FBE")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x04033B9F RID: 211871
		[Token(Token = "0x4033B9F")]
		private const string TAB_SETTLE_ENDING = "tab_settle_ending";

		// Token: 0x04033BA0 RID: 211872
		[Token(Token = "0x4033BA0")]
		private const string TAB_GAME_START = "tab_game_start";

		// Token: 0x04033BA1 RID: 211873
		[Token(Token = "0x4033BA1")]
		private const string TAB_PRE_START = "tab_pre_start";

		// Token: 0x04033BA2 RID: 211874
		[Token(Token = "0x4033BA2")]
		private const string TAB_BATTLE_END = "tab_battle_end";

		// Token: 0x04033BA3 RID: 211875
		[Token(Token = "0x4033BA3")]
		private const string TAB_BATTLE_TO_HELP = "tab_battle_to_help";

		// Token: 0x04033BA4 RID: 211876
		[Token(Token = "0x4033BA4")]
		private const string TAB_SELF_PLAYER_DEAD = "tab_self_player_dead";

		// Token: 0x04033BA5 RID: 211877
		[Token(Token = "0x4033BA5")]
		private const string TAB_EQUIP_REPLACE_DIALOG = "tab_eqip_replace_dialog";

		// Token: 0x04033BA6 RID: 211878
		[Token(Token = "0x4033BA6")]
		private const string TAB_BATTLE_WAITING = "tab_battle_waiting";

		// Token: 0x04033BA7 RID: 211879
		[Token(Token = "0x4033BA7")]
		private const string TAB_PRE_READY_TIP_HAND_OVERFLOW = "tab_pre_ready_tip_hand_overflow";

		// Token: 0x04033BA8 RID: 211880
		[Token(Token = "0x4033BA8")]
		private const string TAB_PRE_READY_TIP_GOLD = "tab_pre_ready_tip_gold";

		// Token: 0x04033BA9 RID: 211881
		[Token(Token = "0x4033BA9")]
		private const string TAB_HIDDEN_BOSS_PREPARE = "tab_hide_boss_prepare";

		// Token: 0x04033BAA RID: 211882
		[Token(Token = "0x4033BAA")]
		private const string TAB_SINGLE_BOSS_PREPARE = "tab_single_boss_prepare";

		// Token: 0x04033BAB RID: 211883
		[Token(Token = "0x4033BAB")]
		private const string TAB_MULTI_BOSS_PREPARE = "tab_multi_boss_prepare";

		// Token: 0x04033BAC RID: 211884
		[Token(Token = "0x4033BAC")]
		private const string TAB_GIVE_UP_DIALOG = "tab_give_up_dialog";

		// Token: 0x04033BAD RID: 211885
		[Token(Token = "0x4033BAD")]
		private const string TAB_SERVER_LOST_DIALOG = "tab_server_lost_dialog";

		// Token: 0x04033BAE RID: 211886
		[Token(Token = "0x4033BAE")]
		private const string TAB_SINGLE_RESUME_DIALOG = "tab_single_resume_dialog";

		// Token: 0x04033BAF RID: 211887
		[Token(Token = "0x4033BAF")]
		[NonSerialized]
		public const int ON_EFFECT_CHOOSE_CONFIRM = 1;

		// Token: 0x04033BB0 RID: 211888
		[Token(Token = "0x4033BB0")]
		[NonSerialized]
		public const int MSG_ON_PREP_READY_BTN_CLICK = 2;

		// Token: 0x04033BB1 RID: 211889
		[Token(Token = "0x4033BB1")]
		[NonSerialized]
		public const int ON_TOGGLE_BOND_PANEL_DISPLAY = 3;

		// Token: 0x04033BB2 RID: 211890
		[Token(Token = "0x4033BB2")]
		[NonSerialized]
		public const int ON_SET_SELECTED_BOND = 4;

		// Token: 0x04033BB3 RID: 211891
		[Token(Token = "0x4033BB3")]
		[NonSerialized]
		public const int ON_CLICK_PREV_BOND = 5;

		// Token: 0x04033BB4 RID: 211892
		[Token(Token = "0x4033BB4")]
		[NonSerialized]
		public const int ON_CLICK_NEXT_BOND = 6;

		// Token: 0x04033BB5 RID: 211893
		[Token(Token = "0x4033BB5")]
		[NonSerialized]
		public const int ON_TOGGLE_HUD_PLAYER_INFO = 7;

		// Token: 0x04033BB6 RID: 211894
		[Token(Token = "0x4033BB6")]
		[NonSerialized]
		public const int ON_TOGGLE_HUD_ENEMY_INFO = 8;

		// Token: 0x04033BB7 RID: 211895
		[Token(Token = "0x4033BB7")]
		[NonSerialized]
		public const int ON_EQUIP_REPLACE_DIALOG_CLICKED = 9;

		// Token: 0x04033BB8 RID: 211896
		[Token(Token = "0x4033BB8")]
		[NonSerialized]
		public const int ON_HUD_RESET = 10;

		// Token: 0x04033BB9 RID: 211897
		[Token(Token = "0x4033BB9")]
		[NonSerialized]
		public const int ON_OB_OTHER_PRE = 19;

		// Token: 0x04033BBA RID: 211898
		[Token(Token = "0x4033BBA")]
		[NonSerialized]
		public const int ON_OB_OTHER = 20;

		// Token: 0x04033BBB RID: 211899
		[Token(Token = "0x4033BBB")]
		[NonSerialized]
		public const int ON_CANCEL_OB = 21;

		// Token: 0x04033BBC RID: 211900
		[Token(Token = "0x4033BBC")]
		[NonSerialized]
		public const int ON_OB_LEFT_ARROW_CLICK = 22;

		// Token: 0x04033BBD RID: 211901
		[Token(Token = "0x4033BBD")]
		[NonSerialized]
		public const int ON_OB_RIGHT_ARROW_CLICK = 23;

		// Token: 0x04033BBE RID: 211902
		[Token(Token = "0x4033BBE")]
		[NonSerialized]
		public const int ON_OPEN_EMOJI = 24;

		// Token: 0x04033BBF RID: 211903
		[Token(Token = "0x4033BBF")]
		[NonSerialized]
		public const int ON_SEND_EMOJI = 25;

		// Token: 0x04033BC0 RID: 211904
		[Token(Token = "0x4033BC0")]
		[NonSerialized]
		public const int ON_SHOP_OPEN = 101;

		// Token: 0x04033BC1 RID: 211905
		[Token(Token = "0x4033BC1")]
		[NonSerialized]
		public const int ON_SHOP_REFRESH = 102;

		// Token: 0x04033BC2 RID: 211906
		[Token(Token = "0x4033BC2")]
		[NonSerialized]
		public const int ON_SHOP_FREEZE = 103;

		// Token: 0x04033BC3 RID: 211907
		[Token(Token = "0x4033BC3")]
		[NonSerialized]
		public const int ON_SHOP_UPGRADE = 104;

		// Token: 0x04033BC4 RID: 211908
		[Token(Token = "0x4033BC4")]
		[NonSerialized]
		public const int ON_SHOP_BUY = 105;

		// Token: 0x04033BC5 RID: 211909
		[Token(Token = "0x4033BC5")]
		[NonSerialized]
		public const int ON_SHOP_SEL = 106;

		// Token: 0x04033BC6 RID: 211910
		[Token(Token = "0x4033BC6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04033BC7 RID: 211911
		[Token(Token = "0x4033BC7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AutoChessBattleUIPanelBase[] _initPanels;

		// Token: 0x04033BC8 RID: 211912
		[Token(Token = "0x4033BC8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AutoChessBattleUIController.AutoChessBattleUIViewStruct[] _dynPanels;

		// Token: 0x04033BC9 RID: 211913
		[Token(Token = "0x4033BC9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AutoChessBattleBroadcastPanel _broadcastPanel;

		// Token: 0x04033BCA RID: 211914
		[Token(Token = "0x4033BCA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _broadcastContainer;

		// Token: 0x04033BCB RID: 211915
		[Token(Token = "0x4033BCB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x04033BCC RID: 211916
		[Token(Token = "0x4033BCC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UITabPager _tabPager;

		// Token: 0x04033BCD RID: 211917
		[Token(Token = "0x4033BCD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _reconnectWaitContainer;

		// Token: 0x04033BCE RID: 211918
		[Token(Token = "0x4033BCE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _reconnectWaitAlphaHandler;

		// Token: 0x04033BCF RID: 211919
		[Token(Token = "0x4033BCF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UITabPager _giveUpTabPager;

		// Token: 0x04033BD0 RID: 211920
		[Token(Token = "0x4033BD0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UITabPager _serverLostTabPager;

		// Token: 0x04033BD1 RID: 211921
		[Token(Token = "0x4033BD1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UITabPager _singleResumeTabPager;

		// Token: 0x04033BD2 RID: 211922
		[Token(Token = "0x4033BD2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _rectTransformBack;

		// Token: 0x04033BD3 RID: 211923
		[Token(Token = "0x4033BD3")]
		[FieldOffset(Offset = "0x88")]
		private string m_actId;

		// Token: 0x04033BD4 RID: 211924
		[Token(Token = "0x4033BD4")]
		[FieldOffset(Offset = "0x90")]
		private AutoChessBattleUIViewModelProperty m_modelProperty;

		// Token: 0x04033BD5 RID: 211925
		[Token(Token = "0x4033BD5")]
		[FieldOffset(Offset = "0x98")]
		private List<AutoChessBattleUIPanelBase> m_bindViews;

		// Token: 0x04033BD6 RID: 211926
		[Token(Token = "0x4033BD6")]
		[FieldOffset(Offset = "0xA0")]
		private AutoChessBattleBroadcastPanel m_broadcastPanel;

		// Token: 0x04033BD7 RID: 211927
		[Token(Token = "0x4033BD7")]
		[FieldOffset(Offset = "0xA8")]
		private List<AutoChessBattleUIController.IPanelWithTick> m_panelsWithTick;

		// Token: 0x04033BD8 RID: 211928
		[Token(Token = "0x4033BD8")]
		[FieldOffset(Offset = "0xB0")]
		private List<IAutoChessBattleUIDataHandler> m_uiDataHandlers;

		// Token: 0x04033BD9 RID: 211929
		[Token(Token = "0x4033BD9")]
		[FieldOffset(Offset = "0xB8")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x04033BDA RID: 211930
		[Token(Token = "0x4033BDA")]
		[FieldOffset(Offset = "0xC0")]
		private FadeSwitchTween m_reconnectTween;

		// Token: 0x04033BDB RID: 211931
		[Token(Token = "0x4033BDB")]
		[FieldOffset(Offset = "0xC8")]
		private UISimpleTabPagerHandler m_tabPagerHandler;

		// Token: 0x04033BDC RID: 211932
		[Token(Token = "0x4033BDC")]
		[FieldOffset(Offset = "0xD0")]
		private UISimpleTabPagerHandler m_giveUpTabPagerHandler;

		// Token: 0x04033BDD RID: 211933
		[Token(Token = "0x4033BDD")]
		[FieldOffset(Offset = "0xD8")]
		private UISimpleTabPagerHandler m_serverLostTabPagerHandler;

		// Token: 0x04033BDE RID: 211934
		[Token(Token = "0x4033BDE")]
		[FieldOffset(Offset = "0xE0")]
		private UISimpleTabPagerHandler m_singleResumeTabPagerHandler;

		// Token: 0x04033BDF RID: 211935
		[Token(Token = "0x4033BDF")]
		[FieldOffset(Offset = "0xE8")]
		private AutoChessBattleUIController.ServerLostReasonType m_cachedServerLostType;

		// Token: 0x04033BE0 RID: 211936
		[Token(Token = "0x4033BE0")]
		[FieldOffset(Offset = "0xEC")]
		private bool m_serverLostDlgHaveShown;

		// Token: 0x04033BE1 RID: 211937
		[Token(Token = "0x4033BE1")]
		[FieldOffset(Offset = "0xED")]
		private bool m_tutorialDragLock;

		// Token: 0x04033BE2 RID: 211938
		[Token(Token = "0x4033BE2")]
		[FieldOffset(Offset = "0xEE")]
		private bool m_tutorialBondExpandLock;

		// Token: 0x04033BE3 RID: 211939
		[Token(Token = "0x4033BE3")]
		[FieldOffset(Offset = "0xEF")]
		private bool m_singleResumeConfirmed;

		// Token: 0x04033BE4 RID: 211940
		[Token(Token = "0x4033BE4")]
		[FieldOffset(Offset = "0xF0")]
		private PlayerModeStateChecker m_playerStateChecker;

		// Token: 0x04033BE5 RID: 211941
		[Token(Token = "0x4033BE5")]
		[FieldOffset(Offset = "0xF8")]
		private AutoChessGameStatus.GameStateChecker m_gameStateChecker;

		// Token: 0x04033BE6 RID: 211942
		[Token(Token = "0x4033BE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04033BE7 RID: 211943
		[Token(Token = "0x4033BE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04033BE8 RID: 211944
		[Token(Token = "0x4033BE8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04033BE9 RID: 211945
		[Token(Token = "0x4033BE9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04033BEA RID: 211946
		[Token(Token = "0x4033BEA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04033BEB RID: 211947
		[Token(Token = "0x4033BEB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnObLeftArrowClick;

		// Token: 0x04033BEC RID: 211948
		[Token(Token = "0x4033BEC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnObRightArrowClick;

		// Token: 0x04033BED RID: 211949
		[Token(Token = "0x4033BED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ReqChangeBattleMapLayer;

		// Token: 0x04033BEE RID: 211950
		[Token(Token = "0x4033BEE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnCancelOb;

		// Token: 0x04033BEF RID: 211951
		[Token(Token = "0x4033BEF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnOpenEmoji;

		// Token: 0x04033BF0 RID: 211952
		[Token(Token = "0x4033BF0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnSendEmoji;

		// Token: 0x04033BF1 RID: 211953
		[Token(Token = "0x4033BF1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnObOtherPre;

		// Token: 0x04033BF2 RID: 211954
		[Token(Token = "0x4033BF2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnObOther;

		// Token: 0x04033BF3 RID: 211955
		[Token(Token = "0x4033BF3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnEffectChooseConfirm;

		// Token: 0x04033BF4 RID: 211956
		[Token(Token = "0x4033BF4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EventOnPrepReadyBtnClick;

		// Token: 0x04033BF5 RID: 211957
		[Token(Token = "0x4033BF5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnToggleBondPanelDisplay;

		// Token: 0x04033BF6 RID: 211958
		[Token(Token = "0x4033BF6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnSetSelectedBond;

		// Token: 0x04033BF7 RID: 211959
		[Token(Token = "0x4033BF7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnClickPrevBond;

		// Token: 0x04033BF8 RID: 211960
		[Token(Token = "0x4033BF8")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnClickNextBond;

		// Token: 0x04033BF9 RID: 211961
		[Token(Token = "0x4033BF9")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnToggleHUDPlayerInfo;

		// Token: 0x04033BFA RID: 211962
		[Token(Token = "0x4033BFA")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnToggleHUDEnemyInfo;

		// Token: 0x04033BFB RID: 211963
		[Token(Token = "0x4033BFB")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnEquipReplaceDialogClicked;

		// Token: 0x04033BFC RID: 211964
		[Token(Token = "0x4033BFC")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnHUDReset;

		// Token: 0x04033BFD RID: 211965
		[Token(Token = "0x4033BFD")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnShopSel;

		// Token: 0x04033BFE RID: 211966
		[Token(Token = "0x4033BFE")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnShopBuy;

		// Token: 0x04033BFF RID: 211967
		[Token(Token = "0x4033BFF")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnShopUpgrade;

		// Token: 0x04033C00 RID: 211968
		[Token(Token = "0x4033C00")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnShopFreeze;

		// Token: 0x04033C01 RID: 211969
		[Token(Token = "0x4033C01")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnShopRefresh;

		// Token: 0x04033C02 RID: 211970
		[Token(Token = "0x4033C02")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnShopOpen;

		// Token: 0x04033C03 RID: 211971
		[Token(Token = "0x4033C03")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ClearShopSel;

		// Token: 0x04033C04 RID: 211972
		[Token(Token = "0x4033C04")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__GeneTabPagerDialogConfigs;

		// Token: 0x04033C05 RID: 211973
		[Token(Token = "0x4033C05")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__GetSettleEndingTabInput;

		// Token: 0x04033C06 RID: 211974
		[Token(Token = "0x4033C06")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__GetPrepareStartTabInput;

		// Token: 0x04033C07 RID: 211975
		[Token(Token = "0x4033C07")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__GetBattleEndTabInput;

		// Token: 0x04033C08 RID: 211976
		[Token(Token = "0x4033C08")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__GetEquipReplaceDialogTabInput;

		// Token: 0x04033C09 RID: 211977
		[Token(Token = "0x4033C09")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__GetAnimBossPrepareDialogTabInput;

		// Token: 0x04033C0A RID: 211978
		[Token(Token = "0x4033C0A")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__GetPreReadyTipHandOverflowDialogTabInput;

		// Token: 0x04033C0B RID: 211979
		[Token(Token = "0x4033C0B")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__GetPreReadyTipGoldDialogTabInput;

		// Token: 0x04033C0C RID: 211980
		[Token(Token = "0x4033C0C")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__HandleTabSelfDead;

		// Token: 0x04033C0D RID: 211981
		[Token(Token = "0x4033C0D")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__HandleTabPrepReadyTipHandOverflow;

		// Token: 0x04033C0E RID: 211982
		[Token(Token = "0x4033C0E")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__HandleTabPrepReadyTipGold;

		// Token: 0x04033C0F RID: 211983
		[Token(Token = "0x4033C0F")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__GeneGiveUpTabPagerDialogConfigs;

		// Token: 0x04033C10 RID: 211984
		[Token(Token = "0x4033C10")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__GetGiveUpDialogTabInput;

		// Token: 0x04033C11 RID: 211985
		[Token(Token = "0x4033C11")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__HandleTabGiveUpDialog;

		// Token: 0x04033C12 RID: 211986
		[Token(Token = "0x4033C12")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__GeneServerLostTabPagerDialogConfigs;

		// Token: 0x04033C13 RID: 211987
		[Token(Token = "0x4033C13")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__GetServerLostDialogTabInput;

		// Token: 0x04033C14 RID: 211988
		[Token(Token = "0x4033C14")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__HandleTabServerLostDialog;

		// Token: 0x04033C15 RID: 211989
		[Token(Token = "0x4033C15")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__GeneSingleResumeTabPagerDialogConfigs;

		// Token: 0x04033C16 RID: 211990
		[Token(Token = "0x4033C16")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__GetSingleResumeDialogTabInput;

		// Token: 0x04033C17 RID: 211991
		[Token(Token = "0x4033C17")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__HandleTabSingleResumeDialog;

		// Token: 0x04033C18 RID: 211992
		[Token(Token = "0x4033C18")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x04033C19 RID: 211993
		[Token(Token = "0x4033C19")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_EventOnShowSingleResumeDialog;

		// Token: 0x04033C1A RID: 211994
		[Token(Token = "0x4033C1A")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__InitBattleEvent;

		// Token: 0x04033C1B RID: 211995
		[Token(Token = "0x4033C1B")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__RemoveBattleEvent;

		// Token: 0x04033C1C RID: 211996
		[Token(Token = "0x4033C1C")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__RegisterStatusTask;

		// Token: 0x04033C1D RID: 211997
		[Token(Token = "0x4033C1D")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__RegisterTabPagerTask;

		// Token: 0x04033C1E RID: 211998
		[Token(Token = "0x4033C1E")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__BindBattleUIViews;

		// Token: 0x04033C1F RID: 211999
		[Token(Token = "0x4033C1F")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__GetTabViewableCameras;

		// Token: 0x04033C20 RID: 212000
		[Token(Token = "0x4033C20")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__HandlePrepReadyTipGoldNoMore;

		// Token: 0x04033C21 RID: 212001
		[Token(Token = "0x4033C21")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__HandleDataChanged;

		// Token: 0x04033C22 RID: 212002
		[Token(Token = "0x4033C22")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__HandleRevChatMsg;

		// Token: 0x04033C23 RID: 212003
		[Token(Token = "0x4033C23")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__HandleRevBroadcast;

		// Token: 0x04033C24 RID: 212004
		[Token(Token = "0x4033C24")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__HandleServerLost;

		// Token: 0x04033C25 RID: 212005
		[Token(Token = "0x4033C25")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__HandleTutorialLockDrag;

		// Token: 0x04033C26 RID: 212006
		[Token(Token = "0x4033C26")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__HandleTutorialUnlockDrag;

		// Token: 0x04033C27 RID: 212007
		[Token(Token = "0x4033C27")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__HandleTutorialBondExpandLock;

		// Token: 0x04033C28 RID: 212008
		[Token(Token = "0x4033C28")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__HandleTutorialBondExpandUnlock;

		// Token: 0x04033C29 RID: 212009
		[Token(Token = "0x4033C29")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0__CheckIfTutorialLock;

		// Token: 0x04033C2A RID: 212010
		[Token(Token = "0x4033C2A")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__HandlePlayerStateChanged;

		// Token: 0x04033C2B RID: 212011
		[Token(Token = "0x4033C2B")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__HandleGameStateChanged;

		// Token: 0x04033C2C RID: 212012
		[Token(Token = "0x4033C2C")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0__HandleIfShowEquipReplaceDialog;

		// Token: 0x04033C2D RID: 212013
		[Token(Token = "0x4033C2D")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0__ShowToast;

		// Token: 0x04033C2E RID: 212014
		[Token(Token = "0x4033C2E")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006473 RID: 25715
		[Token(Token = "0x2006473")]
		private enum ServerLostReasonType
		{
			// Token: 0x04033C30 RID: 212016
			[Token(Token = "0x4033C30")]
			NORMAL,
			// Token: 0x04033C31 RID: 212017
			[Token(Token = "0x4033C31")]
			NEGATIVE_GAME
		}

		// Token: 0x02006474 RID: 25716
		[Token(Token = "0x2006474")]
		public interface IPanelWithTick
		{
			// Token: 0x06024FBF RID: 151487
			[Token(Token = "0x6024FBF")]
			void OnTick();
		}

		// Token: 0x02006475 RID: 25717
		[Token(Token = "0x2006475")]
		[Serializable]
		public struct AutoChessBattleUIViewStruct
		{
			// Token: 0x04033C32 RID: 212018
			[Token(Token = "0x4033C32")]
			[FieldOffset(Offset = "0x0")]
			public RectTransform rectTransform;

			// Token: 0x04033C33 RID: 212019
			[Token(Token = "0x4033C33")]
			[FieldOffset(Offset = "0x8")]
			public AutoChessBattleUIPanelBase panelPrefab;
		}

		// Token: 0x02006476 RID: 25718
		[Token(Token = "0x2006476")]
		private abstract class PendingTabPagerTaskBase : AutoChessTaskManager.IPendingTask, IHotfixable
		{
			// Token: 0x1700572A RID: 22314
			// (get) Token: 0x06024FC0 RID: 151488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700572A")]
			protected string tabId
			{
				[Token(Token = "0x6024FC0")]
				[Address(RVA = "0x1FDB430", Offset = "0x1FDA030", VA = "0x181FDB430")]
				get
				{
					return null;
				}
			}

			// Token: 0x06024FC1 RID: 151489 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FC1")]
			[Address(RVA = "0x1FDB3B0", Offset = "0x1FD9FB0", VA = "0x181FDB3B0")]
			public PendingTabPagerTaskBase(AutoChessBattleUIController closure)
			{
			}

			// Token: 0x1700572B RID: 22315
			// (get) Token: 0x06024FC2 RID: 151490 RVA: 0x000C5EE0 File Offset: 0x000C40E0
			[Token(Token = "0x1700572B")]
			public bool taskFinished
			{
				[Token(Token = "0x6024FC2")]
				[Address(RVA = "0x1FDB490", Offset = "0x1FDA090", VA = "0x181FDB490", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06024FC3 RID: 151491 RVA: 0x000C5EF8 File Offset: 0x000C40F8
			[Token(Token = "0x6024FC3")]
			[Address(RVA = "0x1FDB300", Offset = "0x1FD9F00", VA = "0x181FDB300")]
			private bool _IsCurrSelect()
			{
				return default(bool);
			}

			// Token: 0x1700572C RID: 22316
			// (get) Token: 0x06024FC4 RID: 151492
			[Token(Token = "0x1700572C")]
			public abstract float maxTaskTime { [Token(Token = "0x6024FC4")] get; }

			// Token: 0x06024FC5 RID: 151493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FC5")]
			[Address(RVA = "0x1FDB190", Offset = "0x1FD9D90", VA = "0x181FDB190", Slot = "5")]
			public void OnTaskFinish(bool isInterrupt)
			{
			}

			// Token: 0x06024FC6 RID: 151494 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FC6")]
			[Address(RVA = "0x1FDB230", Offset = "0x1FD9E30", VA = "0x181FDB230", Slot = "4")]
			public void OnTaskStart()
			{
			}

			// Token: 0x06024FC7 RID: 151495
			[Token(Token = "0x6024FC7")]
			protected abstract string CalcTabId();

			// Token: 0x04033C34 RID: 212020
			[Token(Token = "0x4033C34")]
			[FieldOffset(Offset = "0x10")]
			protected AutoChessBattleUIController m_closure;

			// Token: 0x04033C35 RID: 212021
			[Token(Token = "0x4033C35")]
			[FieldOffset(Offset = "0x18")]
			private string m_tabId;

			// Token: 0x04033C36 RID: 212022
			[Token(Token = "0x4033C36")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_tabId;

			// Token: 0x04033C37 RID: 212023
			[Token(Token = "0x4033C37")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033C38 RID: 212024
			[Token(Token = "0x4033C38")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_taskFinished;

			// Token: 0x04033C39 RID: 212025
			[Token(Token = "0x4033C39")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__IsCurrSelect;

			// Token: 0x04033C3A RID: 212026
			[Token(Token = "0x4033C3A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnTaskFinish;

			// Token: 0x04033C3B RID: 212027
			[Token(Token = "0x4033C3B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnTaskStart;
		}

		// Token: 0x02006477 RID: 25719
		[Token(Token = "0x2006477")]
		private class PendingTabPagerTask : AutoChessBattleUIController.PendingTabPagerTaskBase
		{
			// Token: 0x06024FC8 RID: 151496 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FC8")]
			[Address(RVA = "0x1FDB560", Offset = "0x1FDA160", VA = "0x181FDB560")]
			public PendingTabPagerTask(AutoChessBattleUIController.PendingTabPagerTask.Params param)
			{
			}

			// Token: 0x1700572D RID: 22317
			// (get) Token: 0x06024FC9 RID: 151497 RVA: 0x000C5F10 File Offset: 0x000C4110
			[Token(Token = "0x1700572D")]
			public override float maxTaskTime
			{
				[Token(Token = "0x6024FC9")]
				[Address(RVA = "0x1FDB680", Offset = "0x1FDA280", VA = "0x181FDB680", Slot = "8")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06024FCA RID: 151498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024FCA")]
			[Address(RVA = "0x1FDB500", Offset = "0x1FDA100", VA = "0x181FDB500", Slot = "9")]
			protected override string CalcTabId()
			{
				return null;
			}

			// Token: 0x04033C3C RID: 212028
			[Token(Token = "0x4033C3C")]
			[FieldOffset(Offset = "0x20")]
			private float m_maxDisplayTime;

			// Token: 0x04033C3D RID: 212029
			[Token(Token = "0x4033C3D")]
			[FieldOffset(Offset = "0x28")]
			private string m_tabId;

			// Token: 0x04033C3E RID: 212030
			[Token(Token = "0x4033C3E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033C3F RID: 212031
			[Token(Token = "0x4033C3F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_maxTaskTime;

			// Token: 0x04033C40 RID: 212032
			[Token(Token = "0x4033C40")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CalcTabId;

			// Token: 0x02006478 RID: 25720
			[Token(Token = "0x2006478")]
			public struct Params
			{
				// Token: 0x04033C41 RID: 212033
				[Token(Token = "0x4033C41")]
				[FieldOffset(Offset = "0x0")]
				public AutoChessBattleUIController closure;

				// Token: 0x04033C42 RID: 212034
				[Token(Token = "0x4033C42")]
				[FieldOffset(Offset = "0x8")]
				public float maxDisplayTime;

				// Token: 0x04033C43 RID: 212035
				[Token(Token = "0x4033C43")]
				[FieldOffset(Offset = "0x10")]
				public string tabId;
			}
		}

		// Token: 0x02006479 RID: 25721
		[Token(Token = "0x2006479")]
		private class PendingRoundStartPreTask : AutoChessBattleUIController.PendingTabPagerTaskBase
		{
			// Token: 0x06024FCB RID: 151499 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FCB")]
			[Address(RVA = "0x1FDAD70", Offset = "0x1FD9970", VA = "0x181FDAD70")]
			public PendingRoundStartPreTask(AutoChessBattleUIController closure)
			{
			}

			// Token: 0x1700572E RID: 22318
			// (get) Token: 0x06024FCC RID: 151500 RVA: 0x000C5F28 File Offset: 0x000C4128
			[Token(Token = "0x1700572E")]
			public override float maxTaskTime
			{
				[Token(Token = "0x6024FCC")]
				[Address(RVA = "0x1FDADE0", Offset = "0x1FD99E0", VA = "0x181FDADE0", Slot = "8")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06024FCD RID: 151501 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024FCD")]
			[Address(RVA = "0x1FDAC30", Offset = "0x1FD9830", VA = "0x181FDAC30", Slot = "9")]
			protected override string CalcTabId()
			{
				return null;
			}

			// Token: 0x04033C44 RID: 212036
			[Token(Token = "0x4033C44")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033C45 RID: 212037
			[Token(Token = "0x4033C45")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_maxTaskTime;

			// Token: 0x04033C46 RID: 212038
			[Token(Token = "0x4033C46")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CalcTabId;
		}

		// Token: 0x0200647A RID: 25722
		[Token(Token = "0x200647A")]
		private class PendingRoundResultBattleTask : AutoChessBattleUIController.PendingTabPagerTaskBase
		{
			// Token: 0x06024FCE RID: 151502 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FCE")]
			[Address(RVA = "0x1FDAB30", Offset = "0x1FD9730", VA = "0x181FDAB30")]
			public PendingRoundResultBattleTask(AutoChessBattleUIController closure)
			{
			}

			// Token: 0x1700572F RID: 22319
			// (get) Token: 0x06024FCF RID: 151503 RVA: 0x000C5F40 File Offset: 0x000C4140
			[Token(Token = "0x1700572F")]
			public override float maxTaskTime
			{
				[Token(Token = "0x6024FCF")]
				[Address(RVA = "0x1FDABA0", Offset = "0x1FD97A0", VA = "0x181FDABA0", Slot = "8")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06024FD0 RID: 151504 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024FD0")]
			[Address(RVA = "0x1FDAA20", Offset = "0x1FD9620", VA = "0x181FDAA20", Slot = "9")]
			protected override string CalcTabId()
			{
				return null;
			}

			// Token: 0x04033C47 RID: 212039
			[Token(Token = "0x4033C47")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033C48 RID: 212040
			[Token(Token = "0x4033C48")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_maxTaskTime;

			// Token: 0x04033C49 RID: 212041
			[Token(Token = "0x4033C49")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CalcTabId;
		}

		// Token: 0x0200647B RID: 25723
		[Token(Token = "0x200647B")]
		private class PendingBossPrepareWaitingTask : AutoChessBattleUIController.PendingTabPagerTaskBase
		{
			// Token: 0x06024FD1 RID: 151505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FD1")]
			[Address(RVA = "0x1FDA690", Offset = "0x1FD9290", VA = "0x181FDA690")]
			public PendingBossPrepareWaitingTask(AutoChessBattleUIController closure)
			{
			}

			// Token: 0x17005730 RID: 22320
			// (get) Token: 0x06024FD2 RID: 151506 RVA: 0x000C5F58 File Offset: 0x000C4158
			[Token(Token = "0x17005730")]
			public override float maxTaskTime
			{
				[Token(Token = "0x6024FD2")]
				[Address(RVA = "0x1FDA700", Offset = "0x1FD9300", VA = "0x181FDA700", Slot = "8")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06024FD3 RID: 151507 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024FD3")]
			[Address(RVA = "0x1FDA520", Offset = "0x1FD9120", VA = "0x181FDA520", Slot = "9")]
			protected override string CalcTabId()
			{
				return null;
			}

			// Token: 0x04033C4A RID: 212042
			[Token(Token = "0x4033C4A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033C4B RID: 212043
			[Token(Token = "0x4033C4B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_maxTaskTime;

			// Token: 0x04033C4C RID: 212044
			[Token(Token = "0x4033C4C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CalcTabId;
		}

		// Token: 0x0200647C RID: 25724
		[Token(Token = "0x200647C")]
		private class PendingResultBossBattleTask : AutoChessBattleUIController.PendingTabPagerTaskBase
		{
			// Token: 0x06024FD4 RID: 151508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FD4")]
			[Address(RVA = "0x1FDA920", Offset = "0x1FD9520", VA = "0x181FDA920")]
			public PendingResultBossBattleTask(AutoChessBattleUIController closure)
			{
			}

			// Token: 0x17005731 RID: 22321
			// (get) Token: 0x06024FD5 RID: 151509 RVA: 0x000C5F70 File Offset: 0x000C4170
			[Token(Token = "0x17005731")]
			public override float maxTaskTime
			{
				[Token(Token = "0x6024FD5")]
				[Address(RVA = "0x1FDA990", Offset = "0x1FD9590", VA = "0x181FDA990", Slot = "8")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06024FD6 RID: 151510 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024FD6")]
			[Address(RVA = "0x1FDA830", Offset = "0x1FD9430", VA = "0x181FDA830", Slot = "9")]
			protected override string CalcTabId()
			{
				return null;
			}

			// Token: 0x04033C4D RID: 212045
			[Token(Token = "0x4033C4D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033C4E RID: 212046
			[Token(Token = "0x4033C4E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_maxTaskTime;

			// Token: 0x04033C4F RID: 212047
			[Token(Token = "0x4033C4F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CalcTabId;
		}

		// Token: 0x0200647D RID: 25725
		[Token(Token = "0x200647D")]
		private class PendingSpPrepareEndWaitingTask : AutoChessTaskManager.IPendingTask, IHotfixable
		{
			// Token: 0x06024FD7 RID: 151511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FD7")]
			[Address(RVA = "0x1FDAF90", Offset = "0x1FD9B90", VA = "0x181FDAF90")]
			public PendingSpPrepareEndWaitingTask(AutoChessBattleUIController closure)
			{
			}

			// Token: 0x06024FD8 RID: 151512 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FD8")]
			[Address(RVA = "0x1FDAF30", Offset = "0x1FD9B30", VA = "0x181FDAF30", Slot = "4")]
			public void OnTaskStart()
			{
			}

			// Token: 0x06024FD9 RID: 151513 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FD9")]
			[Address(RVA = "0x1FDAED0", Offset = "0x1FD9AD0", VA = "0x181FDAED0", Slot = "5")]
			public void OnTaskFinish(bool isInterrupt)
			{
			}

			// Token: 0x17005732 RID: 22322
			// (get) Token: 0x06024FDA RID: 151514 RVA: 0x000C5F88 File Offset: 0x000C4188
			[Token(Token = "0x17005732")]
			public bool taskFinished
			{
				[Token(Token = "0x6024FDA")]
				[Address(RVA = "0x1FDB130", Offset = "0x1FD9D30", VA = "0x181FDB130", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005733 RID: 22323
			// (get) Token: 0x06024FDB RID: 151515 RVA: 0x000C5FA0 File Offset: 0x000C41A0
			[Token(Token = "0x17005733")]
			public float maxTaskTime
			{
				[Token(Token = "0x6024FDB")]
				[Address(RVA = "0x1FDB010", Offset = "0x1FD9C10", VA = "0x181FDB010", Slot = "7")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x04033C50 RID: 212048
			[Token(Token = "0x4033C50")]
			[FieldOffset(Offset = "0x10")]
			private AutoChessBattleUIController m_closure;

			// Token: 0x04033C51 RID: 212049
			[Token(Token = "0x4033C51")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033C52 RID: 212050
			[Token(Token = "0x4033C52")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnTaskStart;

			// Token: 0x04033C53 RID: 212051
			[Token(Token = "0x4033C53")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnTaskFinish;

			// Token: 0x04033C54 RID: 212052
			[Token(Token = "0x4033C54")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_taskFinished;

			// Token: 0x04033C55 RID: 212053
			[Token(Token = "0x4033C55")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_maxTaskTime;
		}

		// Token: 0x0200647E RID: 25726
		[Token(Token = "0x200647E")]
		private class PendingTaskShowAnimInLoading : AutoChessTaskManager.IPendingTask, IHotfixable
		{
			// Token: 0x06024FDC RID: 151516 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FDC")]
			[Address(RVA = "0x1FDB7C0", Offset = "0x1FDA3C0", VA = "0x181FDB7C0")]
			public PendingTaskShowAnimInLoading(AutoChessBattleUIController closure)
			{
			}

			// Token: 0x06024FDD RID: 151517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FDD")]
			[Address(RVA = "0x1FDB740", Offset = "0x1FDA340", VA = "0x181FDB740", Slot = "4")]
			public void OnTaskStart()
			{
			}

			// Token: 0x06024FDE RID: 151518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FDE")]
			[Address(RVA = "0x1FDB6E0", Offset = "0x1FDA2E0", VA = "0x181FDB6E0", Slot = "5")]
			public void OnTaskFinish(bool isInterrupt)
			{
			}

			// Token: 0x17005734 RID: 22324
			// (get) Token: 0x06024FDF RID: 151519 RVA: 0x000C5FB8 File Offset: 0x000C41B8
			[Token(Token = "0x17005734")]
			public bool taskFinished
			{
				[Token(Token = "0x6024FDF")]
				[Address(RVA = "0x1FDB8A0", Offset = "0x1FDA4A0", VA = "0x181FDB8A0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005735 RID: 22325
			// (get) Token: 0x06024FE0 RID: 151520 RVA: 0x000C5FD0 File Offset: 0x000C41D0
			[Token(Token = "0x17005735")]
			public float maxTaskTime
			{
				[Token(Token = "0x6024FE0")]
				[Address(RVA = "0x1FDB840", Offset = "0x1FDA440", VA = "0x181FDB840", Slot = "7")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x04033C56 RID: 212054
			[Token(Token = "0x4033C56")]
			public const float MAX_ANIM_DURATION = 0.5f;

			// Token: 0x04033C57 RID: 212055
			[Token(Token = "0x4033C57")]
			[FieldOffset(Offset = "0x10")]
			protected AutoChessBattleUIController m_closure;

			// Token: 0x04033C58 RID: 212056
			[Token(Token = "0x4033C58")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033C59 RID: 212057
			[Token(Token = "0x4033C59")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnTaskStart;

			// Token: 0x04033C5A RID: 212058
			[Token(Token = "0x4033C5A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnTaskFinish;

			// Token: 0x04033C5B RID: 212059
			[Token(Token = "0x4033C5B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_taskFinished;

			// Token: 0x04033C5C RID: 212060
			[Token(Token = "0x4033C5C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_maxTaskTime;
		}

		// Token: 0x0200647F RID: 25727
		[Token(Token = "0x200647F")]
		public class ResumeSingleModeBattleTask : AutoChessTaskManager.IPendingTask, IHotfixable
		{
			// Token: 0x06024FE1 RID: 151521 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FE1")]
			[Address(RVA = "0x1FDC1B0", Offset = "0x1FDADB0", VA = "0x181FDC1B0")]
			public ResumeSingleModeBattleTask(AutoChessBattleUIController closure)
			{
			}

			// Token: 0x06024FE2 RID: 151522 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FE2")]
			[Address(RVA = "0x1FDC0E0", Offset = "0x1FDACE0", VA = "0x181FDC0E0", Slot = "4")]
			public void OnTaskStart()
			{
			}

			// Token: 0x06024FE3 RID: 151523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024FE3")]
			[Address(RVA = "0x1FDC080", Offset = "0x1FDAC80", VA = "0x181FDC080", Slot = "5")]
			public void OnTaskFinish(bool isInterrupt)
			{
			}

			// Token: 0x17005736 RID: 22326
			// (get) Token: 0x06024FE4 RID: 151524 RVA: 0x000C5FE8 File Offset: 0x000C41E8
			[Token(Token = "0x17005736")]
			public bool taskFinished
			{
				[Token(Token = "0x6024FE4")]
				[Address(RVA = "0x1FDC290", Offset = "0x1FDAE90", VA = "0x181FDC290", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005737 RID: 22327
			// (get) Token: 0x06024FE5 RID: 151525 RVA: 0x000C6000 File Offset: 0x000C4200
			[Token(Token = "0x17005737")]
			public float maxTaskTime
			{
				[Token(Token = "0x6024FE5")]
				[Address(RVA = "0x1FDC230", Offset = "0x1FDAE30", VA = "0x181FDC230", Slot = "7")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x04033C5D RID: 212061
			[Token(Token = "0x4033C5D")]
			[FieldOffset(Offset = "0x10")]
			private AutoChessBattleUIController m_closure;

			// Token: 0x04033C5E RID: 212062
			[Token(Token = "0x4033C5E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033C5F RID: 212063
			[Token(Token = "0x4033C5F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnTaskStart;

			// Token: 0x04033C60 RID: 212064
			[Token(Token = "0x4033C60")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnTaskFinish;

			// Token: 0x04033C61 RID: 212065
			[Token(Token = "0x4033C61")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_taskFinished;

			// Token: 0x04033C62 RID: 212066
			[Token(Token = "0x4033C62")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_maxTaskTime;
		}
	}
}
