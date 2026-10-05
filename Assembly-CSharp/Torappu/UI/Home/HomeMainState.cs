using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B20 RID: 19232
	[Token(Token = "0x2004B20")]
	public class HomeMainState : State, IValueMsgReceiver
	{
		// Token: 0x0601CEE1 RID: 118497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CEE1")]
		[Address(RVA = "0x165EDF0", Offset = "0x165D9F0", VA = "0x18165EDF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CEE2 RID: 118498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEE2")]
		[Address(RVA = "0x165F0A0", Offset = "0x165DCA0", VA = "0x18165F0A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CEE3 RID: 118499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEE3")]
		[Address(RVA = "0x165F6A0", Offset = "0x165E2A0", VA = "0x18165F6A0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601CEE4 RID: 118500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEE4")]
		[Address(RVA = "0x1661E40", Offset = "0x1660A40", VA = "0x181661E40")]
		private void _ResumeHomeImpl()
		{
		}

		// Token: 0x0601CEE5 RID: 118501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEE5")]
		[Address(RVA = "0x165F5B0", Offset = "0x165E1B0", VA = "0x18165F5B0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601CEE6 RID: 118502 RVA: 0x000A9D40 File Offset: 0x000A7F40
		[Token(Token = "0x601CEE6")]
		[Address(RVA = "0x165FEF0", Offset = "0x165EAF0", VA = "0x18165FEF0", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0601CEE7 RID: 118503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CEE7")]
		[Address(RVA = "0x165F7A0", Offset = "0x165E3A0", VA = "0x18165F7A0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601CEE8 RID: 118504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEE8")]
		[Address(RVA = "0x165F370", Offset = "0x165DF70", VA = "0x18165F370", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601CEE9 RID: 118505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEE9")]
		[Address(RVA = "0x165F010", Offset = "0x165DC10", VA = "0x18165F010")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601CEEA RID: 118506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEEA")]
		[Address(RVA = "0x165F3E0", Offset = "0x165DFE0", VA = "0x18165F3E0", Slot = "23")]
		public void OnMessage(int index, ValueBundle value)
		{
		}

		// Token: 0x0601CEEB RID: 118507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEEB")]
		[Address(RVA = "0x165ED60", Offset = "0x165D960", VA = "0x18165ED60")]
		public void EventOnStageClick()
		{
		}

		// Token: 0x0601CEEC RID: 118508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEEC")]
		[Address(RVA = "0x165E020", Offset = "0x165CC20", VA = "0x18165E020")]
		public void EventOnCheckInClick()
		{
		}

		// Token: 0x0601CEED RID: 118509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEED")]
		[Address(RVA = "0x165EB40", Offset = "0x165D740", VA = "0x18165EB40")]
		public void EventOnShopClick()
		{
		}

		// Token: 0x0601CEEE RID: 118510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEEE")]
		[Address(RVA = "0x165E220", Offset = "0x165CE20", VA = "0x18165E220")]
		public void EventOnFriendClick()
		{
		}

		// Token: 0x0601CEEF RID: 118511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEEF")]
		[Address(RVA = "0x165E710", Offset = "0x165D310", VA = "0x18165E710")]
		public void EventOnMissionClick()
		{
		}

		// Token: 0x0601CEF0 RID: 118512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEF0")]
		[Address(RVA = "0x165EBF0", Offset = "0x165D7F0", VA = "0x18165EBF0")]
		public void EventOnSquadClick()
		{
		}

		// Token: 0x0601CEF1 RID: 118513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEF1")]
		[Address(RVA = "0x165E2D0", Offset = "0x165CED0", VA = "0x18165E2D0")]
		public void EventOnHandbookClick()
		{
		}

		// Token: 0x0601CEF2 RID: 118514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEF2")]
		[Address(RVA = "0x165DEB0", Offset = "0x165CAB0", VA = "0x18165DEB0")]
		public void EventOnCharacterRepoClick()
		{
		}

		// Token: 0x0601CEF3 RID: 118515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEF3")]
		[Address(RVA = "0x165DA00", Offset = "0x165C600", VA = "0x18165DA00")]
		public void EventOnAdvancedRecruitClick()
		{
		}

		// Token: 0x0601CEF4 RID: 118516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEF4")]
		[Address(RVA = "0x165E7C0", Offset = "0x165D3C0", VA = "0x18165E7C0")]
		public void EventOnNormalRecruitClick()
		{
		}

		// Token: 0x0601CEF5 RID: 118517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEF5")]
		[Address(RVA = "0x165E0A0", Offset = "0x165CCA0", VA = "0x18165E0A0")]
		public void EventOnClickActivity(string activityId)
		{
		}

		// Token: 0x0601CEF6 RID: 118518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEF6")]
		[Address(RVA = "0x165E5F0", Offset = "0x165D1F0", VA = "0x18165E5F0")]
		public void EventOnItemRepoClick()
		{
		}

		// Token: 0x0601CEF7 RID: 118519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEF7")]
		[Address(RVA = "0x165E680", Offset = "0x165D280", VA = "0x18165E680")]
		public void EventOnMailClick()
		{
		}

		// Token: 0x0601CEF8 RID: 118520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEF8")]
		[Address(RVA = "0x165E470", Offset = "0x165D070", VA = "0x18165E470")]
		public void EventOnHomeIllustClick()
		{
		}

		// Token: 0x0601CEF9 RID: 118521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEF9")]
		[Address(RVA = "0x165E530", Offset = "0x165D130", VA = "0x18165E530")]
		public void EventOnHomeIllustPreviewClick()
		{
		}

		// Token: 0x0601CEFA RID: 118522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEFA")]
		[Address(RVA = "0x165DB70", Offset = "0x165C770", VA = "0x18165DB70")]
		public void EventOnAnouncementClick()
		{
		}

		// Token: 0x0601CEFB RID: 118523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEFB")]
		[Address(RVA = "0x165EAB0", Offset = "0x165D6B0", VA = "0x18165EAB0")]
		public void EventOnSettingClick()
		{
		}

		// Token: 0x0601CEFC RID: 118524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEFC")]
		[Address(RVA = "0x165E930", Offset = "0x165D530", VA = "0x18165E930")]
		public void EventOnOpenSeverClick()
		{
		}

		// Token: 0x0601CEFD RID: 118525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEFD")]
		[Address(RVA = "0x165EA30", Offset = "0x165D630", VA = "0x18165EA30")]
		public void EventOnReturnningClick()
		{
		}

		// Token: 0x0601CEFE RID: 118526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEFE")]
		[Address(RVA = "0x165DD90", Offset = "0x165C990", VA = "0x18165DD90")]
		public void EventOnBuyApClick()
		{
		}

		// Token: 0x0601CEFF RID: 118527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEFF")]
		[Address(RVA = "0x165E130", Offset = "0x165CD30", VA = "0x18165E130")]
		public void EventOnExchangeDiamondClick()
		{
		}

		// Token: 0x0601CF00 RID: 118528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF00")]
		[Address(RVA = "0x165DE10", Offset = "0x165CA10", VA = "0x18165DE10")]
		public void EventOnBuyApFinish()
		{
		}

		// Token: 0x0601CF01 RID: 118529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF01")]
		[Address(RVA = "0x165E1B0", Offset = "0x165CDB0", VA = "0x18165E1B0")]
		public void EventOnExchangeFinish()
		{
		}

		// Token: 0x0601CF02 RID: 118530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF02")]
		[Address(RVA = "0x165E9B0", Offset = "0x165D5B0", VA = "0x18165E9B0")]
		public void EventOnRefreshResource(IStateBean stateBean)
		{
		}

		// Token: 0x0601CF03 RID: 118531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF03")]
		[Address(RVA = "0x165DBF0", Offset = "0x165C7F0", VA = "0x18165DBF0")]
		public void EventOnBuildingClick()
		{
		}

		// Token: 0x0601CF04 RID: 118532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF04")]
		[Address(RVA = "0x165D910", Offset = "0x165C510", VA = "0x18165D910")]
		public void EventOnAddDiamondClicked()
		{
		}

		// Token: 0x0601CF05 RID: 118533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF05")]
		[Address(RVA = "0x1661090", Offset = "0x165FC90", VA = "0x181661090")]
		private void _LoadHomeBackgroundAndTheme()
		{
		}

		// Token: 0x0601CF06 RID: 118534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF06")]
		[Address(RVA = "0x1661380", Offset = "0x165FF80", VA = "0x181661380")]
		private void _NotifyActivateDisplay()
		{
		}

		// Token: 0x0601CF07 RID: 118535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF07")]
		[Address(RVA = "0x165FF60", Offset = "0x165EB60", VA = "0x18165FF60")]
		private void _BindTrackPoints()
		{
		}

		// Token: 0x0601CF08 RID: 118536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF08")]
		[Address(RVA = "0x1663230", Offset = "0x1661E30", VA = "0x181663230")]
		private void _UpdateFuncLockStatus()
		{
		}

		// Token: 0x0601CF09 RID: 118537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF09")]
		[Address(RVA = "0x1660AC0", Offset = "0x165F6C0", VA = "0x181660AC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CF0A RID: 118538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF0A")]
		[Address(RVA = "0x1660B40", Offset = "0x165F740", VA = "0x181660B40")]
		private void _InitialRender()
		{
		}

		// Token: 0x0601CF0B RID: 118539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF0B")]
		[Address(RVA = "0x1661420", Offset = "0x1660020", VA = "0x181661420")]
		private void _OnJumpToActivity(string activityId)
		{
		}

		// Token: 0x0601CF0C RID: 118540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF0C")]
		[Address(RVA = "0x16614F0", Offset = "0x16600F0", VA = "0x1816614F0")]
		private void _OnJumpToCrisisV2(string seasonId)
		{
		}

		// Token: 0x0601CF0D RID: 118541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF0D")]
		[Address(RVA = "0x1661710", Offset = "0x1660310", VA = "0x181661710")]
		private void _OnJumpToRoguelike(string topicId)
		{
		}

		// Token: 0x0601CF0E RID: 118542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF0E")]
		[Address(RVA = "0x16615F0", Offset = "0x16601F0", VA = "0x1816615F0")]
		private void _OnJumpToMainline(string zoneId)
		{
		}

		// Token: 0x0601CF0F RID: 118543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF0F")]
		[Address(RVA = "0x1661810", Offset = "0x1660410", VA = "0x181661810")]
		private void _OnJumpToSandboxPerm(string topicId)
		{
		}

		// Token: 0x0601CF10 RID: 118544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF10")]
		[Address(RVA = "0x1660FF0", Offset = "0x165FBF0", VA = "0x181660FF0")]
		private void _JumpToSandboxEntryView(string topicId)
		{
		}

		// Token: 0x0601CF11 RID: 118545 RVA: 0x000A9D58 File Offset: 0x000A7F58
		[Token(Token = "0x601CF11")]
		[Address(RVA = "0x1662060", Offset = "0x1660C60", VA = "0x181662060")]
		private bool _ShouldTriggerAvg()
		{
			return default(bool);
		}

		// Token: 0x0601CF12 RID: 118546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF12")]
		[Address(RVA = "0x1662A20", Offset = "0x1661620", VA = "0x181662A20")]
		private void _TriggerUniEquipAvg()
		{
		}

		// Token: 0x0601CF13 RID: 118547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF13")]
		[Address(RVA = "0x1662AF0", Offset = "0x16616F0", VA = "0x181662AF0")]
		private void _UniqEquipGuideEndCallback(Story story)
		{
		}

		// Token: 0x0601CF14 RID: 118548 RVA: 0x000A9D70 File Offset: 0x000A7F70
		[Token(Token = "0x601CF14")]
		[Address(RVA = "0x16605A0", Offset = "0x165F1A0", VA = "0x1816605A0")]
		private bool _HandleAutoPopupEvent(AutoPopupItem popup)
		{
			return default(bool);
		}

		// Token: 0x0601CF15 RID: 118549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF15")]
		[Address(RVA = "0x165EE50", Offset = "0x165DA50", VA = "0x18165EE50")]
		public void NotifyPageRoutedFromNonPluginPage(bool playedDynEntranceWhenRouted)
		{
		}

		// Token: 0x0601CF16 RID: 118550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF16")]
		[Address(RVA = "0x1662940", Offset = "0x1661540", VA = "0x181662940")]
		private void _SyncPlayerStatus()
		{
		}

		// Token: 0x0601CF17 RID: 118551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF17")]
		[Address(RVA = "0x1660420", Offset = "0x165F020", VA = "0x181660420")]
		private void _ErrorWhenCrossDayFailed()
		{
		}

		// Token: 0x0601CF18 RID: 118552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF18")]
		[Address(RVA = "0x1661C30", Offset = "0x1660830", VA = "0x181661C30")]
		private void _ProcessPlayerStatus()
		{
		}

		// Token: 0x0601CF19 RID: 118553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF19")]
		[Address(RVA = "0x1662BC0", Offset = "0x16617C0", VA = "0x181662BC0")]
		private void _UpdateAutoPopups()
		{
		}

		// Token: 0x0601CF1A RID: 118554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF1A")]
		[Address(RVA = "0x1661AC0", Offset = "0x16606C0", VA = "0x181661AC0")]
		private void _PlayerDataRelatedRender()
		{
		}

		// Token: 0x0601CF1B RID: 118555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF1B")]
		[Address(RVA = "0x1663350", Offset = "0x1661F50", VA = "0x181663350")]
		private void _UpdateLockTargetButtonStatus(Button button, bool isUnlocked)
		{
		}

		// Token: 0x0601CF1C RID: 118556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF1C")]
		[Address(RVA = "0x1662140", Offset = "0x1660D40", VA = "0x181662140")]
		private void _ShowAnnouncement()
		{
		}

		// Token: 0x0601CF1D RID: 118557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF1D")]
		[Address(RVA = "0x16622E0", Offset = "0x1660EE0", VA = "0x1816622E0")]
		private void _ShowCheckin()
		{
		}

		// Token: 0x0601CF1E RID: 118558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF1E")]
		[Address(RVA = "0x1662270", Offset = "0x1660E70", VA = "0x181662270")]
		private void _ShowBirthdaySetting()
		{
		}

		// Token: 0x0601CF1F RID: 118559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF1F")]
		[Address(RVA = "0x1662650", Offset = "0x1661250", VA = "0x181662650")]
		private void _ShowOpenServer()
		{
		}

		// Token: 0x0601CF20 RID: 118560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF20")]
		[Address(RVA = "0x16626C0", Offset = "0x16612C0", VA = "0x1816626C0")]
		private void _ShowReturnPage(bool isClicked = false)
		{
		}

		// Token: 0x0601CF21 RID: 118561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF21")]
		[Address(RVA = "0x1662440", Offset = "0x1661040", VA = "0x181662440")]
		private void _ShowHomeActivity(string activityId)
		{
		}

		// Token: 0x0601CF22 RID: 118562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF22")]
		[Address(RVA = "0x16623A0", Offset = "0x1660FA0", VA = "0x1816623A0")]
		private void _ShowHomeActivityAvg(string storyId)
		{
		}

		// Token: 0x0601CF23 RID: 118563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF23")]
		[Address(RVA = "0x1662570", Offset = "0x1661170", VA = "0x181662570")]
		private void _ShowHomeBackgroundPreview()
		{
		}

		// Token: 0x0601CF24 RID: 118564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF24")]
		[Address(RVA = "0x16627B0", Offset = "0x16613B0", VA = "0x1816627B0")]
		private void _ShowUnFinishedOrders()
		{
		}

		// Token: 0x0601CF25 RID: 118565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF25")]
		[Address(RVA = "0x16625E0", Offset = "0x16611E0", VA = "0x1816625E0")]
		private void _ShowHomeCharRotation()
		{
		}

		// Token: 0x0601CF26 RID: 118566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF26")]
		private void _AddPopupState<PopState>() where PopState : State
		{
		}

		// Token: 0x0601CF27 RID: 118567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF27")]
		[Address(RVA = "0x1661210", Offset = "0x165FE10", VA = "0x181661210")]
		private void _LoadIllustView(HomeIllustView.DisplayHandler displayHandler)
		{
		}

		// Token: 0x0601CF28 RID: 118568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF28")]
		[Address(RVA = "0x1660330", Offset = "0x165EF30", VA = "0x181660330")]
		private void _DisposeIllustConfig()
		{
		}

		// Token: 0x0601CF29 RID: 118569 RVA: 0x000A9D88 File Offset: 0x000A7F88
		[Token(Token = "0x601CF29")]
		[Address(RVA = "0x1660280", Offset = "0x165EE80", VA = "0x181660280")]
		private bool _CheckIfHomePageActive()
		{
			return default(bool);
		}

		// Token: 0x0601CF2A RID: 118570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF2A")]
		[Address(RVA = "0x1661940", Offset = "0x1660540", VA = "0x181661940")]
		private void _OnRoutedFromIllustRelatedStates(IStateBean stateBean)
		{
		}

		// Token: 0x0601CF2B RID: 118571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF2B")]
		[Address(RVA = "0x1663510", Offset = "0x1662110", VA = "0x181663510")]
		public HomeMainState()
		{
		}

		// Token: 0x0601CF2F RID: 118575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF2F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CF30 RID: 118576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF30")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601CF31 RID: 118577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF31")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0601CF32 RID: 118578 RVA: 0x000A9DA0 File Offset: 0x000A7FA0
		[Token(Token = "0x601CF32")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0601CF33 RID: 118579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CF33")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601CF34 RID: 118580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF34")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04025F42 RID: 155458
		[Token(Token = "0x4025F42")]
		private const int SYNC_STATUS_INTERVAL_COUNT = 5;

		// Token: 0x04025F43 RID: 155459
		[Token(Token = "0x4025F43")]
		private const int SYNC_STATUS_INTERVAL_MINUTES = 5;

		// Token: 0x04025F44 RID: 155460
		[Token(Token = "0x4025F44")]
		[NonSerialized]
		public const int ON_ROUTE_TO_ZONE = 1;

		// Token: 0x04025F45 RID: 155461
		[Token(Token = "0x4025F45")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HomeMainStateBean _stateBean;

		// Token: 0x04025F46 RID: 155462
		[Token(Token = "0x4025F46")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _versionLabel;

		// Token: 0x04025F47 RID: 155463
		[Token(Token = "0x4025F47")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _nickname;

		// Token: 0x04025F48 RID: 155464
		[Token(Token = "0x4025F48")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private HomeMainTextWidgetHolder _mainlineProgress;

		// Token: 0x04025F49 RID: 155465
		[Token(Token = "0x4025F49")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HomeAPFloatView _apFloat;

		// Token: 0x04025F4A RID: 155466
		[Token(Token = "0x4025F4A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private HomeDiamondChangeView _diamondChangeView;

		// Token: 0x04025F4B RID: 155467
		[Token(Token = "0x4025F4B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimation _homeLoadAnim;

		// Token: 0x04025F4C RID: 155468
		[Token(Token = "0x4025F4C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private PanelActivityViewController _activityController;

		// Token: 0x04025F4D RID: 155469
		[Token(Token = "0x4025F4D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private HomeMainInventoryCountDownView _inventoryCountDownView;

		// Token: 0x04025F4E RID: 155470
		[Token(Token = "0x4025F4E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private HomeMainShopCountDownView _shopCountDownView;

		// Token: 0x04025F4F RID: 155471
		[Token(Token = "0x4025F4F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private HomeActivityOnBattleView _actOnBattleView;

		// Token: 0x04025F50 RID: 155472
		[Token(Token = "0x4025F50")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private HomeMainGachaNoticeView _gachaNoticeView;

		// Token: 0x04025F51 RID: 155473
		[Token(Token = "0x4025F51")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Track Points")]
		private UIHomeThemeTrackPoint _mailTrackPoint;

		// Token: 0x04025F52 RID: 155474
		[Token(Token = "0x4025F52")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Track Points")]
		private UIHomeThemeTrackPoint _checkInTrackPoint;

		// Token: 0x04025F53 RID: 155475
		[Token(Token = "0x4025F53")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Track Points")]
		private UIHomeThemeTrackPoint _recruitTrackPoint;

		// Token: 0x04025F54 RID: 155476
		[Token(Token = "0x4025F54")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Track Points")]
		private UIHomeThemeTrackPoint _characterRepoTrackPoint;

		// Token: 0x04025F55 RID: 155477
		[Token(Token = "0x4025F55")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Track Points")]
		private UIHomeThemeTrackPoint _infoPolyTrackPoint;

		// Token: 0x04025F56 RID: 155478
		[Token(Token = "0x4025F56")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Track Points")]
		private HomeBuildingTrackPoint _buildingTrackPoint;

		// Token: 0x04025F57 RID: 155479
		[Token(Token = "0x4025F57")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Track Points")]
		private UIHomeThemeTrackPoint _missionTrackPoint;

		// Token: 0x04025F58 RID: 155480
		[Token(Token = "0x4025F58")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Track Points")]
		private UIHomeThemeTrackPoint _friendTrackPoint;

		// Token: 0x04025F59 RID: 155481
		[Token(Token = "0x4025F59")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Track Points")]
		private UIHomeThemeTrackPoint _OpenServerTrackPoint;

		// Token: 0x04025F5A RID: 155482
		[Token(Token = "0x4025F5A")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Track Points")]
		private UIHomeThemeTrackPoint _returnTrackPoint;

		// Token: 0x04025F5B RID: 155483
		[Token(Token = "0x4025F5B")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Track Points")]
		private UIHomeThemeTrackPoint _announceTrackPoint;

		// Token: 0x04025F5C RID: 155484
		[Token(Token = "0x4025F5C")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Track Points")]
		private UIHomeThemeTrackPoint _apItemTrackPoint;

		// Token: 0x04025F5D RID: 155485
		[Token(Token = "0x4025F5D")]
		[FieldOffset(Offset = "0x110")]
		[Group("Track Points")]
		[FormerlySerializedAs("_SocialShopTrackPoint")]
		[SerializeField]
		private UIHomeThemeTrackPoint _shopTrackPoint;

		// Token: 0x04025F5E RID: 155486
		[Token(Token = "0x4025F5E")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Track Points")]
		private UIHomeThemeTrackPoint _illustTrackPoint;

		// Token: 0x04025F5F RID: 155487
		[Token(Token = "0x4025F5F")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Track Points")]
		private UIHomeThemeTrackPoint _settingTrackPoint;

		// Token: 0x04025F60 RID: 155488
		[Token(Token = "0x4025F60")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("Func Lock")]
		private Button _buildingEntry;

		// Token: 0x04025F61 RID: 155489
		[Token(Token = "0x4025F61")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Func Lock")]
		private Button _shopEntry;

		// Token: 0x04025F62 RID: 155490
		[Token(Token = "0x4025F62")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Func Lock")]
		private Button _handbookEntry;

		// Token: 0x04025F63 RID: 155491
		[Token(Token = "0x4025F63")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Func Lock")]
		private GameObject _openServerEntry;

		// Token: 0x04025F64 RID: 155492
		[Token(Token = "0x4025F64")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("Func Lock")]
		private GameObject _returnningEntry;

		// Token: 0x04025F65 RID: 155493
		[Token(Token = "0x4025F65")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("Func Lock")]
		private TwoStateToggle _returnningEntryToggle;

		// Token: 0x04025F66 RID: 155494
		[Token(Token = "0x4025F66")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Group("Func Lock")]
		private Button _friendEntry;

		// Token: 0x04025F67 RID: 155495
		[Token(Token = "0x4025F67")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Group("Func Lock")]
		private Button _missionEntry;

		// Token: 0x04025F68 RID: 155496
		[Token(Token = "0x4025F68")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Group("Func Lock")]
		private Color _normalFuncBtnColor;

		// Token: 0x04025F69 RID: 155497
		[Token(Token = "0x4025F69")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("Func Lock")]
		private Color _pressedFuncBtnColor;

		// Token: 0x04025F6A RID: 155498
		[Token(Token = "0x4025F6A")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Group("Func Lock")]
		private Color _lockedFuncBtnColor;

		// Token: 0x04025F6B RID: 155499
		[Token(Token = "0x4025F6B")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private ActivityTopBarHolder _activityTopBarHolder;

		// Token: 0x04025F6C RID: 155500
		[Token(Token = "0x4025F6C")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private float _dialogueMaxHeight;

		// Token: 0x04025F6D RID: 155501
		[Token(Token = "0x4025F6D")]
		[FieldOffset(Offset = "0x1A4")]
		[SerializeField]
		private float _dialoguePaddingHeight;

		// Token: 0x04025F6E RID: 155502
		[Token(Token = "0x4025F6E")]
		[FieldOffset(Offset = "0x1A8")]
		private UIPopupWindow.UIBlocker m_blocker;

		// Token: 0x04025F6F RID: 155503
		[Token(Token = "0x4025F6F")]
		[FieldOffset(Offset = "0x1B0")]
		private int m_instId;

		// Token: 0x04025F70 RID: 155504
		[Token(Token = "0x4025F70")]
		[FieldOffset(Offset = "0x1B4")]
		private bool m_isInited;

		// Token: 0x04025F71 RID: 155505
		[Token(Token = "0x4025F71")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025F72 RID: 155506
		[Token(Token = "0x4025F72")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025F73 RID: 155507
		[Token(Token = "0x4025F73")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04025F74 RID: 155508
		[Token(Token = "0x4025F74")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ResumeHomeImpl;

		// Token: 0x04025F75 RID: 155509
		[Token(Token = "0x4025F75")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04025F76 RID: 155510
		[Token(Token = "0x4025F76")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x04025F77 RID: 155511
		[Token(Token = "0x4025F77")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x04025F78 RID: 155512
		[Token(Token = "0x4025F78")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04025F79 RID: 155513
		[Token(Token = "0x4025F79")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04025F7A RID: 155514
		[Token(Token = "0x4025F7A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04025F7B RID: 155515
		[Token(Token = "0x4025F7B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnStageClick;

		// Token: 0x04025F7C RID: 155516
		[Token(Token = "0x4025F7C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnCheckInClick;

		// Token: 0x04025F7D RID: 155517
		[Token(Token = "0x4025F7D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnShopClick;

		// Token: 0x04025F7E RID: 155518
		[Token(Token = "0x4025F7E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnFriendClick;

		// Token: 0x04025F7F RID: 155519
		[Token(Token = "0x4025F7F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnMissionClick;

		// Token: 0x04025F80 RID: 155520
		[Token(Token = "0x4025F80")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnSquadClick;

		// Token: 0x04025F81 RID: 155521
		[Token(Token = "0x4025F81")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnHandbookClick;

		// Token: 0x04025F82 RID: 155522
		[Token(Token = "0x4025F82")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnCharacterRepoClick;

		// Token: 0x04025F83 RID: 155523
		[Token(Token = "0x4025F83")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnAdvancedRecruitClick;

		// Token: 0x04025F84 RID: 155524
		[Token(Token = "0x4025F84")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnNormalRecruitClick;

		// Token: 0x04025F85 RID: 155525
		[Token(Token = "0x4025F85")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnClickActivity;

		// Token: 0x04025F86 RID: 155526
		[Token(Token = "0x4025F86")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EventOnItemRepoClick;

		// Token: 0x04025F87 RID: 155527
		[Token(Token = "0x4025F87")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnMailClick;

		// Token: 0x04025F88 RID: 155528
		[Token(Token = "0x4025F88")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_EventOnHomeIllustClick;

		// Token: 0x04025F89 RID: 155529
		[Token(Token = "0x4025F89")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_EventOnHomeIllustPreviewClick;

		// Token: 0x04025F8A RID: 155530
		[Token(Token = "0x4025F8A")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_EventOnAnouncementClick;

		// Token: 0x04025F8B RID: 155531
		[Token(Token = "0x4025F8B")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_EventOnSettingClick;

		// Token: 0x04025F8C RID: 155532
		[Token(Token = "0x4025F8C")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_EventOnOpenSeverClick;

		// Token: 0x04025F8D RID: 155533
		[Token(Token = "0x4025F8D")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_EventOnReturnningClick;

		// Token: 0x04025F8E RID: 155534
		[Token(Token = "0x4025F8E")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_EventOnBuyApClick;

		// Token: 0x04025F8F RID: 155535
		[Token(Token = "0x4025F8F")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_EventOnExchangeDiamondClick;

		// Token: 0x04025F90 RID: 155536
		[Token(Token = "0x4025F90")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_EventOnBuyApFinish;

		// Token: 0x04025F91 RID: 155537
		[Token(Token = "0x4025F91")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_EventOnExchangeFinish;

		// Token: 0x04025F92 RID: 155538
		[Token(Token = "0x4025F92")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_EventOnRefreshResource;

		// Token: 0x04025F93 RID: 155539
		[Token(Token = "0x4025F93")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_EventOnBuildingClick;

		// Token: 0x04025F94 RID: 155540
		[Token(Token = "0x4025F94")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_EventOnAddDiamondClicked;

		// Token: 0x04025F95 RID: 155541
		[Token(Token = "0x4025F95")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__LoadHomeBackgroundAndTheme;

		// Token: 0x04025F96 RID: 155542
		[Token(Token = "0x4025F96")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__NotifyActivateDisplay;

		// Token: 0x04025F97 RID: 155543
		[Token(Token = "0x4025F97")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__BindTrackPoints;

		// Token: 0x04025F98 RID: 155544
		[Token(Token = "0x4025F98")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__UpdateFuncLockStatus;

		// Token: 0x04025F99 RID: 155545
		[Token(Token = "0x4025F99")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025F9A RID: 155546
		[Token(Token = "0x4025F9A")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__InitialRender;

		// Token: 0x04025F9B RID: 155547
		[Token(Token = "0x4025F9B")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__OnJumpToActivity;

		// Token: 0x04025F9C RID: 155548
		[Token(Token = "0x4025F9C")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__OnJumpToCrisisV2;

		// Token: 0x04025F9D RID: 155549
		[Token(Token = "0x4025F9D")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__OnJumpToRoguelike;

		// Token: 0x04025F9E RID: 155550
		[Token(Token = "0x4025F9E")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__OnJumpToMainline;

		// Token: 0x04025F9F RID: 155551
		[Token(Token = "0x4025F9F")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__OnJumpToSandboxPerm;

		// Token: 0x04025FA0 RID: 155552
		[Token(Token = "0x4025FA0")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__JumpToSandboxEntryView;

		// Token: 0x04025FA1 RID: 155553
		[Token(Token = "0x4025FA1")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__ShouldTriggerAvg;

		// Token: 0x04025FA2 RID: 155554
		[Token(Token = "0x4025FA2")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__TriggerUniEquipAvg;

		// Token: 0x04025FA3 RID: 155555
		[Token(Token = "0x4025FA3")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__UniqEquipGuideEndCallback;

		// Token: 0x04025FA4 RID: 155556
		[Token(Token = "0x4025FA4")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__HandleAutoPopupEvent;

		// Token: 0x04025FA5 RID: 155557
		[Token(Token = "0x4025FA5")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_NotifyPageRoutedFromNonPluginPage;

		// Token: 0x04025FA6 RID: 155558
		[Token(Token = "0x4025FA6")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__SyncPlayerStatus;

		// Token: 0x04025FA7 RID: 155559
		[Token(Token = "0x4025FA7")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__ErrorWhenCrossDayFailed;

		// Token: 0x04025FA8 RID: 155560
		[Token(Token = "0x4025FA8")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__ProcessPlayerStatus;

		// Token: 0x04025FA9 RID: 155561
		[Token(Token = "0x4025FA9")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__UpdateAutoPopups;

		// Token: 0x04025FAA RID: 155562
		[Token(Token = "0x4025FAA")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__PlayerDataRelatedRender;

		// Token: 0x04025FAB RID: 155563
		[Token(Token = "0x4025FAB")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__UpdateLockTargetButtonStatus;

		// Token: 0x04025FAC RID: 155564
		[Token(Token = "0x4025FAC")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__ShowAnnouncement;

		// Token: 0x04025FAD RID: 155565
		[Token(Token = "0x4025FAD")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__ShowCheckin;

		// Token: 0x04025FAE RID: 155566
		[Token(Token = "0x4025FAE")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__ShowBirthdaySetting;

		// Token: 0x04025FAF RID: 155567
		[Token(Token = "0x4025FAF")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__ShowOpenServer;

		// Token: 0x04025FB0 RID: 155568
		[Token(Token = "0x4025FB0")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__ShowReturnPage;

		// Token: 0x04025FB1 RID: 155569
		[Token(Token = "0x4025FB1")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__ShowHomeActivity;

		// Token: 0x04025FB2 RID: 155570
		[Token(Token = "0x4025FB2")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__ShowHomeActivityAvg;

		// Token: 0x04025FB3 RID: 155571
		[Token(Token = "0x4025FB3")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__ShowHomeBackgroundPreview;

		// Token: 0x04025FB4 RID: 155572
		[Token(Token = "0x4025FB4")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0__ShowUnFinishedOrders;

		// Token: 0x04025FB5 RID: 155573
		[Token(Token = "0x4025FB5")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__ShowHomeCharRotation;

		// Token: 0x04025FB6 RID: 155574
		[Token(Token = "0x4025FB6")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__AddPopupState;

		// Token: 0x04025FB7 RID: 155575
		[Token(Token = "0x4025FB7")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0__LoadIllustView;

		// Token: 0x04025FB8 RID: 155576
		[Token(Token = "0x4025FB8")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0__DisposeIllustConfig;

		// Token: 0x04025FB9 RID: 155577
		[Token(Token = "0x4025FB9")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0__CheckIfHomePageActive;

		// Token: 0x04025FBA RID: 155578
		[Token(Token = "0x4025FBA")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0__OnRoutedFromIllustRelatedStates;

		// Token: 0x04025FBB RID: 155579
		[Token(Token = "0x4025FBB")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
