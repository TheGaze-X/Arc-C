using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Activity;
using Torappu.AVG;
using Torappu.UI.ActivityStage;
using Torappu.UI.CrisisV2;
using Torappu.UI.MissionArchive;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006852 RID: 26706
	[Token(Token = "0x2006852")]
	public class StagePage : StateEnginePage, IValueMsgReceiver, IDialogMgrHolder, IHotfixable
	{
		// Token: 0x17005A50 RID: 23120
		// (get) Token: 0x0602639C RID: 156572 RVA: 0x000CA6E0 File Offset: 0x000C88E0
		[Token(Token = "0x17005A50")]
		public override AVGPageKey avgPage
		{
			[Token(Token = "0x602639C")]
			[Address(RVA = "0x215AD30", Offset = "0x2159930", VA = "0x18215AD30", Slot = "20")]
			get
			{
				return AVGPageKey.NONE;
			}
		}

		// Token: 0x17005A51 RID: 23121
		// (get) Token: 0x0602639D RID: 156573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A51")]
		public StageStateBean stageStateBean
		{
			[Token(Token = "0x602639D")]
			[Address(RVA = "0x215AEB0", Offset = "0x2159AB0", VA = "0x18215AEB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005A52 RID: 23122
		// (get) Token: 0x0602639E RID: 156574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A52")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x602639E")]
			[Address(RVA = "0x215ADF0", Offset = "0x21599F0", VA = "0x18215ADF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005A53 RID: 23123
		// (get) Token: 0x0602639F RID: 156575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A53")]
		public StagePageGameMusicController musicController
		{
			[Token(Token = "0x602639F")]
			[Address(RVA = "0x215AE50", Offset = "0x2159A50", VA = "0x18215AE50")]
			get
			{
				return null;
			}
		}

		// Token: 0x060263A0 RID: 156576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263A0")]
		[Address(RVA = "0x2151B30", Offset = "0x2150730", VA = "0x182151B30", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x060263A1 RID: 156577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263A1")]
		[Address(RVA = "0x2152940", Offset = "0x2151540", VA = "0x182152940", Slot = "15")]
		protected override void OnRecycle()
		{
		}

		// Token: 0x060263A2 RID: 156578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263A2")]
		[Address(RVA = "0x21529C0", Offset = "0x21515C0", VA = "0x1821529C0", Slot = "9")]
		protected override void OnReuse(DataBundle savedInst)
		{
		}

		// Token: 0x060263A3 RID: 156579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263A3")]
		[Address(RVA = "0x2152770", Offset = "0x2151370", VA = "0x182152770", Slot = "19")]
		protected override IEnumerator OnPageReservedDuringReset(UIPageStackParam param)
		{
			return null;
		}

		// Token: 0x060263A4 RID: 156580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263A4")]
		[Address(RVA = "0x2152860", Offset = "0x2151460", VA = "0x182152860", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x060263A5 RID: 156581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263A5")]
		[Address(RVA = "0x2152A50", Offset = "0x2151650", VA = "0x182152A50", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x060263A6 RID: 156582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263A6")]
		[Address(RVA = "0x2156380", Offset = "0x2154F80", VA = "0x182156380")]
		private void _FetchCrisisV2DataIfNecessary()
		{
		}

		// Token: 0x060263A7 RID: 156583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263A7")]
		[Address(RVA = "0x2151320", Offset = "0x214FF20", VA = "0x182151320", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x060263A8 RID: 156584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263A8")]
		[Address(RVA = "0x2150520", Offset = "0x214F120", VA = "0x182150520", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x060263A9 RID: 156585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263A9")]
		[Address(RVA = "0x2150440", Offset = "0x214F040", VA = "0x182150440", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x060263AA RID: 156586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263AA")]
		[Address(RVA = "0x2150380", Offset = "0x214EF80", VA = "0x182150380", Slot = "23")]
		public override void DisplayWholePage(bool isShow)
		{
		}

		// Token: 0x060263AB RID: 156587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263AB")]
		[Address(RVA = "0x2152120", Offset = "0x2150D20", VA = "0x182152120", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060263AC RID: 156588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263AC")]
		[Address(RVA = "0x21512C0", Offset = "0x214FEC0", VA = "0x1821512C0", Slot = "30")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x060263AD RID: 156589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263AD")]
		[Address(RVA = "0x21521B0", Offset = "0x2150DB0", VA = "0x1821521B0", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060263AE RID: 156590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263AE")]
		[Address(RVA = "0x2155EE0", Offset = "0x2154AE0", VA = "0x182155EE0")]
		private void _EventOnMissionArchiveClicked(StagePage.MissionArchiveBtnEventParam param)
		{
		}

		// Token: 0x060263AF RID: 156591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263AF")]
		[Address(RVA = "0x2155E70", Offset = "0x2154A70", VA = "0x182155E70")]
		private void _EventOnFifthAnnivExploreClicked()
		{
		}

		// Token: 0x060263B0 RID: 156592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263B0")]
		[Address(RVA = "0x21561C0", Offset = "0x2154DC0", VA = "0x1821561C0")]
		private void _EventOnUpdateGlobalMask(bool active)
		{
		}

		// Token: 0x060263B1 RID: 156593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263B1")]
		[Address(RVA = "0x214FA50", Offset = "0x214E650", VA = "0x18214FA50")]
		public static DataBundle DataBundleToActivity(string activityId)
		{
			return null;
		}

		// Token: 0x060263B2 RID: 156594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263B2")]
		[Address(RVA = "0x214F940", Offset = "0x214E540", VA = "0x18214F940")]
		public static DataBundle DataBundleToActivity(string activityId, bool forceSkipEnterAnim)
		{
			return null;
		}

		// Token: 0x060263B3 RID: 156595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263B3")]
		[Address(RVA = "0x214FE30", Offset = "0x214EA30", VA = "0x18214FE30")]
		public static DataBundle DataBundleToStage(string zoneId, [Optional] string stageId)
		{
			return null;
		}

		// Token: 0x060263B4 RID: 156596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263B4")]
		[Address(RVA = "0x214FFB0", Offset = "0x214EBB0", VA = "0x18214FFB0")]
		public static void DataBundleToStage(DataBundle bundle, string zoneId, [Optional] string stageId)
		{
		}

		// Token: 0x060263B5 RID: 156597 RVA: 0x000CA6F8 File Offset: 0x000C88F8
		[Token(Token = "0x60263B5")]
		[Address(RVA = "0x21548E0", Offset = "0x21534E0", VA = "0x1821548E0")]
		public static bool TryGetStageDataFromSavedInst(DataBundle savedInst, out StageDataUtil.StageDataWrapper stageData)
		{
			return default(bool);
		}

		// Token: 0x060263B6 RID: 156598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263B6")]
		[Address(RVA = "0x2150170", Offset = "0x214ED70", VA = "0x182150170")]
		public static DataBundle DataBundleToZoneOnZoneSelect(string zoneId)
		{
			return null;
		}

		// Token: 0x060263B7 RID: 156599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263B7")]
		[Address(RVA = "0x21500B0", Offset = "0x214ECB0", VA = "0x1821500B0")]
		public static void DataBundleToZoneOnZoneSelect(DataBundle bundle, string zoneId)
		{
		}

		// Token: 0x060263B8 RID: 156600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263B8")]
		[Address(RVA = "0x21502A0", Offset = "0x214EEA0", VA = "0x1821502A0")]
		public static DataBundle DataBundleToZoneViewTab(ZoneViewType zoneViewType)
		{
			return null;
		}

		// Token: 0x060263B9 RID: 156601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263B9")]
		[Address(RVA = "0x214FD30", Offset = "0x214E930", VA = "0x18214FD30")]
		public static DataBundle DataBundleToMixStory(bool focusLastUnlockedMainline)
		{
			return null;
		}

		// Token: 0x060263BA RID: 156602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263BA")]
		[Address(RVA = "0x214FB30", Offset = "0x214E730", VA = "0x18214FB30")]
		public static DataBundle DataBundleToMixStoryBrief(string storySetId)
		{
			return null;
		}

		// Token: 0x060263BB RID: 156603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263BB")]
		[Address(RVA = "0x214FC30", Offset = "0x214E830", VA = "0x18214FC30")]
		public static DataBundle DataBundleToMixStoryRetro(string retroRelevantActId)
		{
			return null;
		}

		// Token: 0x060263BC RID: 156604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263BC")]
		[Address(RVA = "0x2153F90", Offset = "0x2152B90", VA = "0x182153F90")]
		public static void SetAlertInfos2Bundle(string lastStageId, bool isFirstPassStage, string curZoneId, IList<string> unlockStageIds, IAlertResponse response, DataBundle stageBundle)
		{
		}

		// Token: 0x060263BD RID: 156605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263BD")]
		[Address(RVA = "0x2158DE0", Offset = "0x21579E0", VA = "0x182158DE0")]
		private static void _SetCharTmplUnlock2Bundle(List<CharTmplUnlockPushMsg> msgList, DataBundle bundle)
		{
		}

		// Token: 0x060263BE RID: 156606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263BE")]
		[Address(RVA = "0x2159AC0", Offset = "0x21586C0", VA = "0x182159AC0")]
		private static void _SetSystemUnlock2Bundle(string lastPassStageId, DataBundle bundle)
		{
		}

		// Token: 0x060263BF RID: 156607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263BF")]
		[Address(RVA = "0x2159500", Offset = "0x2158100", VA = "0x182159500")]
		private static void _SetMixStoryOverallUnlock2Bunlde(string lastPassStageId, DataBundle bundle)
		{
		}

		// Token: 0x060263C0 RID: 156608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263C0")]
		[Address(RVA = "0x21595C0", Offset = "0x21581C0", VA = "0x1821595C0")]
		private static void _SetPermModeSystemUnlock2Bundle(string lastPassStageId, DataBundle bundle)
		{
		}

		// Token: 0x060263C1 RID: 156609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263C1")]
		[Address(RVA = "0x2158FE0", Offset = "0x2157BE0", VA = "0x182158FE0")]
		private static void _SetCrisisV2SystemUnlock2Bundle(string lastPassStageId, DataBundle bundle)
		{
		}

		// Token: 0x060263C2 RID: 156610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263C2")]
		[Address(RVA = "0x2159E60", Offset = "0x2158A60", VA = "0x182159E60")]
		private static void _SetVecBreakV2SystemUnlock2Bundle(string lastPassStageId, DataBundle bundle)
		{
		}

		// Token: 0x060263C3 RID: 156611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263C3")]
		[Address(RVA = "0x2159680", Offset = "0x2158280", VA = "0x182159680")]
		private static void _SetRecalRuneUnlock2Bundle(string lastPassStageId, DataBundle bundle)
		{
		}

		// Token: 0x060263C4 RID: 156612 RVA: 0x000CA710 File Offset: 0x000C8910
		[Token(Token = "0x60263C4")]
		[Address(RVA = "0x2154E50", Offset = "0x2153A50", VA = "0x182154E50")]
		private static bool _CheckSystemUnlock(string lastPassStageId, UILockTarget target)
		{
			return default(bool);
		}

		// Token: 0x060263C5 RID: 156613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263C5")]
		[Address(RVA = "0x2159110", Offset = "0x2157D10", VA = "0x182159110")]
		private static void _SetHardStageUnlock2Bundle(string lastStageId, IList<string> unlockStageIds, DataBundle bundle)
		{
		}

		// Token: 0x060263C6 RID: 156614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263C6")]
		[Address(RVA = "0x2159900", Offset = "0x2158500", VA = "0x182159900")]
		private static void _SetSixStarAdvanceUnlock2Bundle(string lastStageId, bool isFirstPassStage, DataBundle bundle)
		{
		}

		// Token: 0x060263C7 RID: 156615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263C7")]
		[Address(RVA = "0x2159F80", Offset = "0x2158B80", VA = "0x182159F80")]
		private static void _SetZoneUnlock2Bundle(string curZoneId, IList<string> unlockStageIds, DataBundle bundle)
		{
		}

		// Token: 0x060263C8 RID: 156616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263C8")]
		[Address(RVA = "0x2159310", Offset = "0x2157F10", VA = "0x182159310")]
		private static void _SetMainlineStageUnlock2Bundle(List<StageData> stages, DataBundle bundle)
		{
		}

		// Token: 0x060263C9 RID: 156617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263C9")]
		[Address(RVA = "0x2154C20", Offset = "0x2153820", VA = "0x182154C20")]
		private static void _AddAlertInfo2Bundle(DataBundle bundle, string alert)
		{
		}

		// Token: 0x060263CA RID: 156618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263CA")]
		[Address(RVA = "0x2154D50", Offset = "0x2153950", VA = "0x182154D50")]
		private static void _AddAlertInfo2Bundle(DataBundle bundle, List<string> alerts)
		{
		}

		// Token: 0x060263CB RID: 156619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263CB")]
		[Address(RVA = "0x2158AD0", Offset = "0x21576D0", VA = "0x182158AD0")]
		private static void _SetAlertInfo2Bundle(IAlertResponse response, DataBundle bundle)
		{
		}

		// Token: 0x060263CC RID: 156620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263CC")]
		[Address(RVA = "0x21543C0", Offset = "0x2152FC0", VA = "0x1821543C0")]
		public static void SetStoryRewardInfo2Bundle(StoryOnlyStartBattleResponse response, DataBundle bundle)
		{
		}

		// Token: 0x060263CD RID: 156621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263CD")]
		[Address(RVA = "0x2154180", Offset = "0x2152D80", VA = "0x182154180")]
		public static void SetStageActivityMeta2Bundle(string actId, string metaInfo, DataBundle outBundle)
		{
		}

		// Token: 0x060263CE RID: 156622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263CE")]
		[Address(RVA = "0x2154330", Offset = "0x2152F30", VA = "0x182154330")]
		public static void SetStageJustPlayed2Bundle(string stageId, DataBundle outBundle)
		{
		}

		// Token: 0x060263CF RID: 156623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263CF")]
		[Address(RVA = "0x21542A0", Offset = "0x2152EA0", VA = "0x1821542A0")]
		public static void SetStageJustPassed2Bundle(string stageId, DataBundle outBundle)
		{
		}

		// Token: 0x060263D0 RID: 156624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263D0")]
		[Address(RVA = "0x2153810", Offset = "0x2152410", VA = "0x182153810")]
		public static UIPageControllerParam SceneParamToStage(DataBundle bundleToStage)
		{
			return null;
		}

		// Token: 0x060263D1 RID: 156625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263D1")]
		[Address(RVA = "0x2153D40", Offset = "0x2152940", VA = "0x182153D40")]
		public static void SendUnlockStageFog(string stageId, Action<UnlockStageFogResponse> handler)
		{
		}

		// Token: 0x060263D2 RID: 156626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263D2")]
		[Address(RVA = "0x2153AF0", Offset = "0x21526F0", VA = "0x182153AF0")]
		public static void SendGetSpecialStageReward(string stageId, Action<SpecialStoryStageRewardResponse> handler)
		{
		}

		// Token: 0x060263D3 RID: 156627 RVA: 0x000CA728 File Offset: 0x000C8928
		[Token(Token = "0x60263D3")]
		[Address(RVA = "0x2154550", Offset = "0x2153150", VA = "0x182154550")]
		public bool SwitchToZone(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x060263D4 RID: 156628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263D4")]
		[Address(RVA = "0x2152E30", Offset = "0x2151A30", VA = "0x182152E30")]
		public void OpenRetroCoinDetail()
		{
		}

		// Token: 0x060263D5 RID: 156629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263D5")]
		[Address(RVA = "0x2153280", Offset = "0x2151E80", VA = "0x182153280")]
		public void OpenTrailDetail()
		{
		}

		// Token: 0x060263D6 RID: 156630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263D6")]
		[Address(RVA = "0x2152EE0", Offset = "0x2151AE0", VA = "0x182152EE0")]
		public void OpenSsTrail(string retroId)
		{
		}

		// Token: 0x060263D7 RID: 156631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263D7")]
		[Address(RVA = "0x2152BF0", Offset = "0x21517F0", VA = "0x182152BF0")]
		public void OpenCollectTrail(string actId)
		{
		}

		// Token: 0x060263D8 RID: 156632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263D8")]
		[Address(RVA = "0x2153140", Offset = "0x2151D40", VA = "0x182153140")]
		public void OpenStoryReview(string actId, bool isSs)
		{
		}

		// Token: 0x060263D9 RID: 156633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263D9")]
		[Address(RVA = "0x2152D20", Offset = "0x2151920", VA = "0x182152D20")]
		public void OpenMixStoryOverall()
		{
		}

		// Token: 0x060263DA RID: 156634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263DA")]
		[Address(RVA = "0x2154A00", Offset = "0x2153600", VA = "0x182154A00")]
		public void TryTriggerZoneHomeGuide()
		{
		}

		// Token: 0x060263DB RID: 156635 RVA: 0x000CA740 File Offset: 0x000C8940
		[Token(Token = "0x60263DB")]
		[Address(RVA = "0x214F760", Offset = "0x214E360", VA = "0x18214F760")]
		public ActivityStageController.ActivityMetaWrapper ConsumeActivityInitMeta(string actId)
		{
			return default(ActivityStageController.ActivityMetaWrapper);
		}

		// Token: 0x060263DC RID: 156636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263DC")]
		[Address(RVA = "0x2151A90", Offset = "0x2150690", VA = "0x182151A90")]
		public void NotifyActivityLoadReady(string activityId)
		{
		}

		// Token: 0x060263DD RID: 156637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263DD")]
		[Address(RVA = "0x21547C0", Offset = "0x21533C0", VA = "0x1821547C0")]
		public void TryBackToZoneSelectState()
		{
		}

		// Token: 0x17005A54 RID: 23124
		// (get) Token: 0x060263DE RID: 156638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A54")]
		public StageZoneSelectBlackLoadingManager blackLoadingOnZoneSelect
		{
			[Token(Token = "0x60263DE")]
			[Address(RVA = "0x215AD90", Offset = "0x2159990", VA = "0x18215AD90")]
			get
			{
				return null;
			}
		}

		// Token: 0x060263DF RID: 156639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263DF")]
		[Address(RVA = "0x21536B0", Offset = "0x21522B0", VA = "0x1821536B0")]
		public void ResetToStage(string stageId)
		{
		}

		// Token: 0x060263E0 RID: 156640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263E0")]
		[Address(RVA = "0x2153600", Offset = "0x2152200", VA = "0x182153600")]
		public IEnumerator ResetToDefault()
		{
			return null;
		}

		// Token: 0x060263E1 RID: 156641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263E1")]
		[Address(RVA = "0x2150F70", Offset = "0x214FB70", VA = "0x182150F70")]
		public void EventOnStageButtonClick(string stageId)
		{
		}

		// Token: 0x060263E2 RID: 156642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263E2")]
		[Address(RVA = "0x2150A60", Offset = "0x214F660", VA = "0x182150A60")]
		public void EventOnMapLoadError(string zoneId)
		{
		}

		// Token: 0x060263E3 RID: 156643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263E3")]
		[Address(RVA = "0x2150CA0", Offset = "0x214F8A0", VA = "0x182150CA0")]
		public void EventOnMapLoaded(string zoneId)
		{
		}

		// Token: 0x060263E4 RID: 156644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263E4")]
		[Address(RVA = "0x21505E0", Offset = "0x214F1E0", VA = "0x1821505E0")]
		public void EventOnFogClicked(string stageId)
		{
		}

		// Token: 0x060263E5 RID: 156645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263E5")]
		[Address(RVA = "0x21565F0", Offset = "0x21551F0", VA = "0x1821565F0")]
		private string _GetFogUnlockDesc(StageFogInfo fogInfo, StageData stageData)
		{
			return null;
		}

		// Token: 0x060263E6 RID: 156646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263E6")]
		[Address(RVA = "0x2150E50", Offset = "0x214FA50", VA = "0x182150E50")]
		public void EventOnSpecialStageRewardClicked(string stageId)
		{
		}

		// Token: 0x060263E7 RID: 156647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263E7")]
		[Address(RVA = "0x21511A0", Offset = "0x214FDA0", VA = "0x1821511A0")]
		public void EventOnZoneRecordClicked(string zoneId)
		{
		}

		// Token: 0x060263E8 RID: 156648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263E8")]
		[Address(RVA = "0x21566F0", Offset = "0x21552F0", VA = "0x1821566F0")]
		private CrisisV2ServerDataWrapper _GetValidCrisisData()
		{
			return null;
		}

		// Token: 0x060263E9 RID: 156649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263E9")]
		[Address(RVA = "0x2157920", Offset = "0x2156520", VA = "0x182157920")]
		private void _OnCrisisDataFetched()
		{
		}

		// Token: 0x060263EA RID: 156650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263EA")]
		[Address(RVA = "0x2158730", Offset = "0x2157330", VA = "0x182158730")]
		private void _RefreshPermModeModel()
		{
		}

		// Token: 0x060263EB RID: 156651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263EB")]
		[Address(RVA = "0x2157B00", Offset = "0x2156700", VA = "0x182157B00")]
		private void _OnSendUnlockStageFog(string stageId)
		{
		}

		// Token: 0x060263EC RID: 156652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263EC")]
		[Address(RVA = "0x2158140", Offset = "0x2156D40", VA = "0x182158140")]
		private void _OnZoneTabClicked(ZoneViewType zoneViewType)
		{
		}

		// Token: 0x060263ED RID: 156653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263ED")]
		[Address(RVA = "0x2157A30", Offset = "0x2156630", VA = "0x182157A30")]
		private void _OnSendGetSpecialStageReward(string stageId)
		{
		}

		// Token: 0x060263EE RID: 156654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263EE")]
		[Address(RVA = "0x2158690", Offset = "0x2157290", VA = "0x182158690")]
		private void _RefreshMutableStages()
		{
		}

		// Token: 0x060263EF RID: 156655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263EF")]
		[Address(RVA = "0x21587E0", Offset = "0x21573E0", VA = "0x1821587E0")]
		private void _RefreshSixStarStages()
		{
		}

		// Token: 0x060263F0 RID: 156656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263F0")]
		[Address(RVA = "0x21583B0", Offset = "0x2156FB0", VA = "0x1821583B0")]
		private void _OpenSixStarMileStoneDialog(string groupId)
		{
		}

		// Token: 0x060263F1 RID: 156657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263F1")]
		[Address(RVA = "0x2157EB0", Offset = "0x2156AB0", VA = "0x182157EB0")]
		private void _OnStoryStageClicked(string stageId, StageData stageData, SpecialStoryStageViewModel.DisplayInfo spstInfo)
		{
		}

		// Token: 0x060263F2 RID: 156658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263F2")]
		[Address(RVA = "0x2157BD0", Offset = "0x21567D0", VA = "0x182157BD0")]
		private void _OnSpecialStoryStageClicked(string stageId, StageData stageData, SpecialStoryStageViewModel.DisplayInfo spstInfo)
		{
		}

		// Token: 0x060263F3 RID: 156659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263F3")]
		[Address(RVA = "0x21576D0", Offset = "0x21562D0", VA = "0x1821576D0")]
		private void _OnBattleStageClicked(string stageId, StageData stageData)
		{
		}

		// Token: 0x060263F4 RID: 156660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263F4")]
		[Address(RVA = "0x215A220", Offset = "0x2158E20", VA = "0x18215A220")]
		private IEnumerator _ShowInitToastsAndAlerts()
		{
			return null;
		}

		// Token: 0x060263F5 RID: 156661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263F5")]
		[Address(RVA = "0x215A420", Offset = "0x2159020", VA = "0x18215A420")]
		private void _TriggerHiddenStageToast()
		{
		}

		// Token: 0x060263F6 RID: 156662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263F6")]
		[Address(RVA = "0x215A670", Offset = "0x2159270", VA = "0x18215A670")]
		private void _TriggerZoneHomeGuide()
		{
		}

		// Token: 0x060263F7 RID: 156663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263F7")]
		[Address(RVA = "0x21580C0", Offset = "0x2156CC0", VA = "0x1821580C0")]
		private void _OnZoneHomeGuideFinish(Story before)
		{
		}

		// Token: 0x060263F8 RID: 156664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263F8")]
		[Address(RVA = "0x215A9E0", Offset = "0x21595E0", VA = "0x18215A9E0")]
		private void _TryTriggerMixStoryIntro()
		{
		}

		// Token: 0x060263F9 RID: 156665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263F9")]
		[Address(RVA = "0x21567A0", Offset = "0x21553A0", VA = "0x1821567A0")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x060263FA RID: 156666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263FA")]
		[Address(RVA = "0x215A2D0", Offset = "0x2158ED0", VA = "0x18215A2D0")]
		private void _TopMenuProcessor(GameObject topMenuObj)
		{
		}

		// Token: 0x060263FB RID: 156667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263FB")]
		[Address(RVA = "0x2155F70", Offset = "0x2154B70", VA = "0x182155F70")]
		private void _EventOnStateBackBtnClicked()
		{
		}

		// Token: 0x060263FC RID: 156668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263FC")]
		[Address(RVA = "0x2158A20", Offset = "0x2157620", VA = "0x182158A20")]
		private IEnumerator _ResetToZoneSelectState()
		{
			return null;
		}

		// Token: 0x060263FD RID: 156669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263FD")]
		[Address(RVA = "0x2158880", Offset = "0x2157480", VA = "0x182158880")]
		private IEnumerator _ResetToStageEntry(StageViewModel stageEntry)
		{
			return null;
		}

		// Token: 0x060263FE RID: 156670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60263FE")]
		[Address(RVA = "0x2158950", Offset = "0x2157550", VA = "0x182158950")]
		private IEnumerator _ResetToStage(string stageId)
		{
			return null;
		}

		// Token: 0x060263FF RID: 156671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60263FF")]
		[Address(RVA = "0x2155370", Offset = "0x2153F70", VA = "0x182155370")]
		private void _ClearCacheBeforeReset()
		{
		}

		// Token: 0x06026400 RID: 156672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026400")]
		[Address(RVA = "0x215AB60", Offset = "0x2159760", VA = "0x18215AB60")]
		private IEnumerator _WrapWithBlackLoading(params IEnumerator[] innerSteps)
		{
			return null;
		}

		// Token: 0x06026401 RID: 156673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026401")]
		[Address(RVA = "0x21599F0", Offset = "0x21585F0", VA = "0x1821599F0")]
		private IEnumerator _SetStateViaParam(DataBundle param)
		{
			return null;
		}

		// Token: 0x06026402 RID: 156674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026402")]
		[Address(RVA = "0x2156D60", Offset = "0x2155960", VA = "0x182156D60")]
		private IEnumerator _JumpToZoneSelect(string zoneId)
		{
			return null;
		}

		// Token: 0x06026403 RID: 156675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026403")]
		[Address(RVA = "0x2156C40", Offset = "0x2155840", VA = "0x182156C40")]
		private IEnumerator _JumpToZoneSelectByViewType(ZoneViewType type, string retroRelevantActId, string storySetId, bool focusLastVisitedMainline)
		{
			return null;
		}

		// Token: 0x06026404 RID: 156676 RVA: 0x000CA758 File Offset: 0x000C8958
		[Token(Token = "0x6026404")]
		[Address(RVA = "0x21551F0", Offset = "0x2153DF0", VA = "0x1821551F0")]
		private bool _CheckZoneShouldCheckBriefByZoneId(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x06026405 RID: 156677 RVA: 0x000CA770 File Offset: 0x000C8970
		[Token(Token = "0x6026405")]
		[Address(RVA = "0x2154EF0", Offset = "0x2153AF0", VA = "0x182154EF0")]
		private bool _CheckZoneShouldCheckBriefByActivityId(string activityId)
		{
			return default(bool);
		}

		// Token: 0x06026406 RID: 156678 RVA: 0x000CA788 File Offset: 0x000C8988
		[Token(Token = "0x6026406")]
		[Address(RVA = "0x2155070", Offset = "0x2153C70", VA = "0x182155070")]
		private bool _CheckZoneShouldCheckBriefByStorySetId(string storySetId)
		{
			return default(bool);
		}

		// Token: 0x06026407 RID: 156679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026407")]
		[Address(RVA = "0x21568D0", Offset = "0x21554D0", VA = "0x1821568D0")]
		private IEnumerator _JumpToActivity(string activityId)
		{
			return null;
		}

		// Token: 0x06026408 RID: 156680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026408")]
		[Address(RVA = "0x2156E30", Offset = "0x2155A30", VA = "0x182156E30")]
		private IEnumerator _JumpToZone(string zoneId)
		{
			return null;
		}

		// Token: 0x06026409 RID: 156681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026409")]
		[Address(RVA = "0x2156B70", Offset = "0x2155770", VA = "0x182156B70")]
		private IEnumerator _JumpToStage(string stageId)
		{
			return null;
		}

		// Token: 0x0602640A RID: 156682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602640A")]
		[Address(RVA = "0x2156A50", Offset = "0x2155650", VA = "0x182156A50")]
		private IEnumerator _JumpToStageRemain(StageId stage, StageData stageData)
		{
			return null;
		}

		// Token: 0x0602640B RID: 156683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602640B")]
		[Address(RVA = "0x2155A20", Offset = "0x2154620", VA = "0x182155A20")]
		private List<StateCache> _DefaultStackListToZone(string zoneId)
		{
			return null;
		}

		// Token: 0x0602640C RID: 156684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602640C")]
		[Address(RVA = "0x2155450", Offset = "0x2154050", VA = "0x182155450")]
		private List<StateCache> _DefaultStackListToStage(StageId stageId, StageData stageData)
		{
			return null;
		}

		// Token: 0x0602640D RID: 156685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602640D")]
		[Address(RVA = "0x2156240", Offset = "0x2154E40", VA = "0x182156240")]
		private static List<CommonFinishBattleResponse.RewardModel> _ExtractInitRewards(DataBundle bundle)
		{
			return null;
		}

		// Token: 0x0602640E RID: 156686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602640E")]
		[Address(RVA = "0x2156440", Offset = "0x2155040", VA = "0x182156440")]
		private static StagePage.ActivityInitMeta _GenActInitDataWraper(DataBundle bundle)
		{
			return null;
		}

		// Token: 0x0602640F RID: 156687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602640F")]
		[Address(RVA = "0x2158570", Offset = "0x2157170", VA = "0x182158570")]
		private void _RedirectActInitMetaToStage(string zoneId, string stageId)
		{
		}

		// Token: 0x06026410 RID: 156688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026410")]
		[Address(RVA = "0x21569A0", Offset = "0x21555A0", VA = "0x1821569A0")]
		private void _JumpToCampaign()
		{
		}

		// Token: 0x06026411 RID: 156689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026411")]
		[Address(RVA = "0x2157180", Offset = "0x2155D80", VA = "0x182157180")]
		private void _OnBackToStagePage(UIPageTransContext context)
		{
		}

		// Token: 0x06026412 RID: 156690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026412")]
		[Address(RVA = "0x215AA90", Offset = "0x2159690", VA = "0x18215AA90")]
		private IEnumerator _WaitForActivityReadyCoroutine(string activityId)
		{
			return null;
		}

		// Token: 0x06026413 RID: 156691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026413")]
		[Address(RVA = "0x21553E0", Offset = "0x2153FE0", VA = "0x1821553E0")]
		private void _ConsumeExpiredTrackPoint()
		{
		}

		// Token: 0x06026414 RID: 156692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026414")]
		[Address(RVA = "0x215A8A0", Offset = "0x21594A0", VA = "0x18215A8A0")]
		private void _TryToTrackSixStarFirstPass(DataBundle dataBundle)
		{
		}

		// Token: 0x06026415 RID: 156693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026415")]
		[Address(RVA = "0x2151850", Offset = "0x2150450", VA = "0x182151850")]
		public Sprite LoadStartBattleCostIcon(string styleId)
		{
			return null;
		}

		// Token: 0x06026416 RID: 156694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026416")]
		[Address(RVA = "0x21513D0", Offset = "0x214FFD0", VA = "0x1821513D0")]
		public Sprite LoadStartBattleButtonImage(string styleId)
		{
			return null;
		}

		// Token: 0x06026417 RID: 156695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026417")]
		[Address(RVA = "0x2151610", Offset = "0x2150210", VA = "0x182151610")]
		public Sprite LoadStartBattleCostBkg(string styleId)
		{
			return null;
		}

		// Token: 0x06026418 RID: 156696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026418")]
		[Address(RVA = "0x2156F00", Offset = "0x2155B00", VA = "0x182156F00")]
		private Sprite _LoadSpriteFromStartBattleStyle(string styleId, Func<StageStartBattleButtonStyle.Style, Sprite> returnSpriteFromBuildIn, Func<ActivityStartBattleButtonStyle.Style, Sprite> returnSpriteFromActivity)
		{
			return null;
		}

		// Token: 0x06026419 RID: 156697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026419")]
		[Address(RVA = "0x2154B70", Offset = "0x2153770", VA = "0x182154B70")]
		private void Update()
		{
		}

		// Token: 0x0602641A RID: 156698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602641A")]
		[Address(RVA = "0x215AC30", Offset = "0x2159830", VA = "0x18215AC30")]
		public StagePage()
		{
		}

		// Token: 0x06026422 RID: 156706 RVA: 0x000CA7A0 File Offset: 0x000C89A0
		[Token(Token = "0x6026422")]
		[Address(RVA = "0x101CF00", Offset = "0x101BB00", VA = "0x18101CF00")]
		private AVGPageKey <>xLuaBaseProxy_get_avgPage()
		{
			return AVGPageKey.NONE;
		}

		// Token: 0x06026423 RID: 156707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026423")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06026424 RID: 156708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026424")]
		[Address(RVA = "0xF93B70", Offset = "0xF92770", VA = "0x180F93B70")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x06026425 RID: 156709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026425")]
		[Address(RVA = "0x1551CD0", Offset = "0x15508D0", VA = "0x181551CD0")]
		private void <>xLuaBaseProxy_OnReuse(DataBundle P0)
		{
		}

		// Token: 0x06026426 RID: 156710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026426")]
		[Address(RVA = "0x1649260", Offset = "0x1647E60", VA = "0x181649260")]
		private IEnumerator <>xLuaBaseProxy_OnPageReservedDuringReset(UIPageStackParam P0)
		{
			return null;
		}

		// Token: 0x06026427 RID: 156711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026427")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x06026428 RID: 156712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026428")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06026429 RID: 156713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026429")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x0602642A RID: 156714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602642A")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0602642B RID: 156715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602642B")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0602642C RID: 156716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602642C")]
		[Address(RVA = "0x185DEE0", Offset = "0x185CAE0", VA = "0x18185DEE0")]
		private void <>xLuaBaseProxy_DisplayWholePage(bool P0)
		{
		}

		// Token: 0x0602642D RID: 156717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602642D")]
		[Address(RVA = "0x12172F0", Offset = "0x1215EF0", VA = "0x1812172F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x04035E1D RID: 220701
		[Token(Token = "0x4035E1D")]
		private const float INIT_TOAST_DELAY = 0.5f;

		// Token: 0x04035E1E RID: 220702
		[Token(Token = "0x4035E1E")]
		private const float CONST_INIT_DURATION = 10000f;

		// Token: 0x04035E1F RID: 220703
		[Token(Token = "0x4035E1F")]
		[NonSerialized]
		public const int ZONE_RECORD_BTN_EVENT = 0;

		// Token: 0x04035E20 RID: 220704
		[Token(Token = "0x4035E20")]
		[NonSerialized]
		public const int MISSION_ARCHIVE_BTN_EVENT = 1;

		// Token: 0x04035E21 RID: 220705
		[Token(Token = "0x4035E21")]
		[NonSerialized]
		public const int FIFTH_ANNIV_EXPLORE_BTN_EVENT = 2;

		// Token: 0x04035E22 RID: 220706
		[Token(Token = "0x4035E22")]
		[NonSerialized]
		public const int ON_STATE_BACK_BTN_CLICKED = 3;

		// Token: 0x04035E23 RID: 220707
		[Token(Token = "0x4035E23")]
		[NonSerialized]
		public const int UPDATE_GLOBAL_MASK_EVENT = 4;

		// Token: 0x04035E24 RID: 220708
		[Token(Token = "0x4035E24")]
		[NonSerialized]
		public const int UPDATE_SIX_STAR_PREVIEW_INFO = 5;

		// Token: 0x04035E25 RID: 220709
		[Token(Token = "0x4035E25")]
		[NonSerialized]
		public const int OPEN_SIX_STAR_MILESTONE_DIALOG = 6;

		// Token: 0x04035E26 RID: 220710
		[Token(Token = "0x4035E26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private PrefabInstHolder[] _topMenuHolders;

		// Token: 0x04035E27 RID: 220711
		[Token(Token = "0x4035E27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private StageStateBean _stateBean;

		// Token: 0x04035E28 RID: 220712
		[Token(Token = "0x4035E28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Display Control")]
		private UICommonPageEffectHolder _zoneSelectEffect;

		// Token: 0x04035E29 RID: 220713
		[Token(Token = "0x4035E29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private StageZoneTabGroup _tabGroup;

		// Token: 0x04035E2A RID: 220714
		[Token(Token = "0x4035E2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private StageActivityDataBinder _activityDataBinder;

		// Token: 0x04035E2B RID: 220715
		[Token(Token = "0x4035E2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private SideStoryMapDecroDataBinder _sideStoryBinder;

		// Token: 0x04035E2C RID: 220716
		[Token(Token = "0x4035E2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private StageZoneStoryOnlyPanel _storyOnlyPanel;

		// Token: 0x04035E2D RID: 220717
		[Token(Token = "0x4035E2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private CanvasGroup _blackLoadingOnZoneSelect;

		// Token: 0x04035E2E RID: 220718
		[Token(Token = "0x4035E2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04035E2F RID: 220719
		[Token(Token = "0x4035E2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private GameObject _globalEventMask;

		// Token: 0x04035E30 RID: 220720
		[Token(Token = "0x4035E30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private StageZoneSpecialStoryOnlyPanel _specialStoryOnlyPanel;

		// Token: 0x04035E31 RID: 220721
		[Token(Token = "0x4035E31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private DataBundle m_dataBundle4InitStateEngine;

		// Token: 0x04035E32 RID: 220722
		[Token(Token = "0x4035E32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private List<string> m_initToasts;

		// Token: 0x04035E33 RID: 220723
		[Token(Token = "0x4035E33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private List<CommonFinishBattleResponse.RewardModel> m_initRewards;

		// Token: 0x04035E34 RID: 220724
		[Token(Token = "0x4035E34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private StagePage.ActivityInitMeta m_stageActInitMeta;

		// Token: 0x04035E35 RID: 220725
		[Token(Token = "0x4035E35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private YieldSemaphore<string> m_stageActSemaphore;

		// Token: 0x04035E36 RID: 220726
		[Token(Token = "0x4035E36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private UIPopupWindow.ReentrantFloatRef m_globalBlackMask;

		// Token: 0x04035E37 RID: 220727
		[Token(Token = "0x4035E37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private StageZoneSelectBlackLoadingManager m_blackLoadingOnZoneSelect;

		// Token: 0x04035E38 RID: 220728
		[Token(Token = "0x4035E38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private UICompDialogMgr m_dmgr;

		// Token: 0x04035E39 RID: 220729
		[Token(Token = "0x4035E39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private StagePageGameMusicController m_gameMusicController;

		// Token: 0x04035E3A RID: 220730
		[Token(Token = "0x4035E3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private bool m_requestingCrisisData;

		// Token: 0x04035E3B RID: 220731
		[Token(Token = "0x4035E3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private CrisisV2DataFromServer m_crisisData;

		// Token: 0x04035E3C RID: 220732
		[Token(Token = "0x4035E3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_avgPage;

		// Token: 0x04035E3D RID: 220733
		[Token(Token = "0x4035E3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_stageStateBean;

		// Token: 0x04035E3E RID: 220734
		[Token(Token = "0x4035E3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x04035E3F RID: 220735
		[Token(Token = "0x4035E3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_musicController;

		// Token: 0x04035E40 RID: 220736
		[Token(Token = "0x4035E40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04035E41 RID: 220737
		[Token(Token = "0x4035E41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04035E42 RID: 220738
		[Token(Token = "0x4035E42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnReuse;

		// Token: 0x04035E43 RID: 220739
		[Token(Token = "0x4035E43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPageReservedDuringReset;

		// Token: 0x04035E44 RID: 220740
		[Token(Token = "0x4035E44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x04035E45 RID: 220741
		[Token(Token = "0x4035E45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04035E46 RID: 220742
		[Token(Token = "0x4035E46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__FetchCrisisV2DataIfNecessary;

		// Token: 0x04035E47 RID: 220743
		[Token(Token = "0x4035E47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04035E48 RID: 220744
		[Token(Token = "0x4035E48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x04035E49 RID: 220745
		[Token(Token = "0x4035E49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x04035E4A RID: 220746
		[Token(Token = "0x4035E4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_DisplayWholePage;

		// Token: 0x04035E4B RID: 220747
		[Token(Token = "0x4035E4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04035E4C RID: 220748
		[Token(Token = "0x4035E4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x04035E4D RID: 220749
		[Token(Token = "0x4035E4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04035E4E RID: 220750
		[Token(Token = "0x4035E4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EventOnMissionArchiveClicked;

		// Token: 0x04035E4F RID: 220751
		[Token(Token = "0x4035E4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__EventOnFifthAnnivExploreClicked;

		// Token: 0x04035E50 RID: 220752
		[Token(Token = "0x4035E50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__EventOnUpdateGlobalMask;

		// Token: 0x04035E51 RID: 220753
		[Token(Token = "0x4035E51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_DataBundleToActivity;

		// Token: 0x04035E52 RID: 220754
		[Token(Token = "0x4035E52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix1_DataBundleToActivity;

		// Token: 0x04035E53 RID: 220755
		[Token(Token = "0x4035E53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_DataBundleToStage;

		// Token: 0x04035E54 RID: 220756
		[Token(Token = "0x4035E54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix1_DataBundleToStage;

		// Token: 0x04035E55 RID: 220757
		[Token(Token = "0x4035E55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_TryGetStageDataFromSavedInst;

		// Token: 0x04035E56 RID: 220758
		[Token(Token = "0x4035E56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_DataBundleToZoneOnZoneSelect;

		// Token: 0x04035E57 RID: 220759
		[Token(Token = "0x4035E57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix1_DataBundleToZoneOnZoneSelect;

		// Token: 0x04035E58 RID: 220760
		[Token(Token = "0x4035E58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_DataBundleToZoneViewTab;

		// Token: 0x04035E59 RID: 220761
		[Token(Token = "0x4035E59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_DataBundleToMixStory;

		// Token: 0x04035E5A RID: 220762
		[Token(Token = "0x4035E5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_DataBundleToMixStoryBrief;

		// Token: 0x04035E5B RID: 220763
		[Token(Token = "0x4035E5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_DataBundleToMixStoryRetro;

		// Token: 0x04035E5C RID: 220764
		[Token(Token = "0x4035E5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_SetAlertInfos2Bundle;

		// Token: 0x04035E5D RID: 220765
		[Token(Token = "0x4035E5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__SetCharTmplUnlock2Bundle;

		// Token: 0x04035E5E RID: 220766
		[Token(Token = "0x4035E5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__SetSystemUnlock2Bundle;

		// Token: 0x04035E5F RID: 220767
		[Token(Token = "0x4035E5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__SetMixStoryOverallUnlock2Bunlde;

		// Token: 0x04035E60 RID: 220768
		[Token(Token = "0x4035E60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__SetPermModeSystemUnlock2Bundle;

		// Token: 0x04035E61 RID: 220769
		[Token(Token = "0x4035E61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__SetCrisisV2SystemUnlock2Bundle;

		// Token: 0x04035E62 RID: 220770
		[Token(Token = "0x4035E62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__SetVecBreakV2SystemUnlock2Bundle;

		// Token: 0x04035E63 RID: 220771
		[Token(Token = "0x4035E63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__SetRecalRuneUnlock2Bundle;

		// Token: 0x04035E64 RID: 220772
		[Token(Token = "0x4035E64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__CheckSystemUnlock;

		// Token: 0x04035E65 RID: 220773
		[Token(Token = "0x4035E65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__SetHardStageUnlock2Bundle;

		// Token: 0x04035E66 RID: 220774
		[Token(Token = "0x4035E66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__SetSixStarAdvanceUnlock2Bundle;

		// Token: 0x04035E67 RID: 220775
		[Token(Token = "0x4035E67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__SetZoneUnlock2Bundle;

		// Token: 0x04035E68 RID: 220776
		[Token(Token = "0x4035E68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__SetMainlineStageUnlock2Bundle;

		// Token: 0x04035E69 RID: 220777
		[Token(Token = "0x4035E69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__AddAlertInfo2Bundle;

		// Token: 0x04035E6A RID: 220778
		[Token(Token = "0x4035E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix1__AddAlertInfo2Bundle;

		// Token: 0x04035E6B RID: 220779
		[Token(Token = "0x4035E6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__SetAlertInfo2Bundle;

		// Token: 0x04035E6C RID: 220780
		[Token(Token = "0x4035E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_SetStoryRewardInfo2Bundle;

		// Token: 0x04035E6D RID: 220781
		[Token(Token = "0x4035E6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_SetStageActivityMeta2Bundle;

		// Token: 0x04035E6E RID: 220782
		[Token(Token = "0x4035E6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_SetStageJustPlayed2Bundle;

		// Token: 0x04035E6F RID: 220783
		[Token(Token = "0x4035E6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_SetStageJustPassed2Bundle;

		// Token: 0x04035E70 RID: 220784
		[Token(Token = "0x4035E70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_SceneParamToStage;

		// Token: 0x04035E71 RID: 220785
		[Token(Token = "0x4035E71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_SendUnlockStageFog;

		// Token: 0x04035E72 RID: 220786
		[Token(Token = "0x4035E72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_SendGetSpecialStageReward;

		// Token: 0x04035E73 RID: 220787
		[Token(Token = "0x4035E73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_SwitchToZone;

		// Token: 0x04035E74 RID: 220788
		[Token(Token = "0x4035E74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_OpenRetroCoinDetail;

		// Token: 0x04035E75 RID: 220789
		[Token(Token = "0x4035E75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_OpenTrailDetail;

		// Token: 0x04035E76 RID: 220790
		[Token(Token = "0x4035E76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_OpenSsTrail;

		// Token: 0x04035E77 RID: 220791
		[Token(Token = "0x4035E77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_OpenCollectTrail;

		// Token: 0x04035E78 RID: 220792
		[Token(Token = "0x4035E78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_OpenStoryReview;

		// Token: 0x04035E79 RID: 220793
		[Token(Token = "0x4035E79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_OpenMixStoryOverall;

		// Token: 0x04035E7A RID: 220794
		[Token(Token = "0x4035E7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_TryTriggerZoneHomeGuide;

		// Token: 0x04035E7B RID: 220795
		[Token(Token = "0x4035E7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_ConsumeActivityInitMeta;

		// Token: 0x04035E7C RID: 220796
		[Token(Token = "0x4035E7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_NotifyActivityLoadReady;

		// Token: 0x04035E7D RID: 220797
		[Token(Token = "0x4035E7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_TryBackToZoneSelectState;

		// Token: 0x04035E7E RID: 220798
		[Token(Token = "0x4035E7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_get_blackLoadingOnZoneSelect;

		// Token: 0x04035E7F RID: 220799
		[Token(Token = "0x4035E7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_ResetToStage;

		// Token: 0x04035E80 RID: 220800
		[Token(Token = "0x4035E80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_ResetToDefault;

		// Token: 0x04035E81 RID: 220801
		[Token(Token = "0x4035E81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_EventOnStageButtonClick;

		// Token: 0x04035E82 RID: 220802
		[Token(Token = "0x4035E82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_EventOnMapLoadError;

		// Token: 0x04035E83 RID: 220803
		[Token(Token = "0x4035E83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_EventOnMapLoaded;

		// Token: 0x04035E84 RID: 220804
		[Token(Token = "0x4035E84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_EventOnFogClicked;

		// Token: 0x04035E85 RID: 220805
		[Token(Token = "0x4035E85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0__GetFogUnlockDesc;

		// Token: 0x04035E86 RID: 220806
		[Token(Token = "0x4035E86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_EventOnSpecialStageRewardClicked;

		// Token: 0x04035E87 RID: 220807
		[Token(Token = "0x4035E87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_EventOnZoneRecordClicked;

		// Token: 0x04035E88 RID: 220808
		[Token(Token = "0x4035E88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0__GetValidCrisisData;

		// Token: 0x04035E89 RID: 220809
		[Token(Token = "0x4035E89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0__OnCrisisDataFetched;

		// Token: 0x04035E8A RID: 220810
		[Token(Token = "0x4035E8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0__RefreshPermModeModel;

		// Token: 0x04035E8B RID: 220811
		[Token(Token = "0x4035E8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0__OnSendUnlockStageFog;

		// Token: 0x04035E8C RID: 220812
		[Token(Token = "0x4035E8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0__OnZoneTabClicked;

		// Token: 0x04035E8D RID: 220813
		[Token(Token = "0x4035E8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0__OnSendGetSpecialStageReward;

		// Token: 0x04035E8E RID: 220814
		[Token(Token = "0x4035E8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0__RefreshMutableStages;

		// Token: 0x04035E8F RID: 220815
		[Token(Token = "0x4035E8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0__RefreshSixStarStages;

		// Token: 0x04035E90 RID: 220816
		[Token(Token = "0x4035E90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0__OpenSixStarMileStoneDialog;

		// Token: 0x04035E91 RID: 220817
		[Token(Token = "0x4035E91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0__OnStoryStageClicked;

		// Token: 0x04035E92 RID: 220818
		[Token(Token = "0x4035E92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0__OnSpecialStoryStageClicked;

		// Token: 0x04035E93 RID: 220819
		[Token(Token = "0x4035E93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0__OnBattleStageClicked;

		// Token: 0x04035E94 RID: 220820
		[Token(Token = "0x4035E94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0__ShowInitToastsAndAlerts;

		// Token: 0x04035E95 RID: 220821
		[Token(Token = "0x4035E95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0__TriggerHiddenStageToast;

		// Token: 0x04035E96 RID: 220822
		[Token(Token = "0x4035E96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0__TriggerZoneHomeGuide;

		// Token: 0x04035E97 RID: 220823
		[Token(Token = "0x4035E97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0__OnZoneHomeGuideFinish;

		// Token: 0x04035E98 RID: 220824
		[Token(Token = "0x4035E98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0__TryTriggerMixStoryIntro;

		// Token: 0x04035E99 RID: 220825
		[Token(Token = "0x4035E99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x04035E9A RID: 220826
		[Token(Token = "0x4035E9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0__TopMenuProcessor;

		// Token: 0x04035E9B RID: 220827
		[Token(Token = "0x4035E9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0__EventOnStateBackBtnClicked;

		// Token: 0x04035E9C RID: 220828
		[Token(Token = "0x4035E9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0__ResetToZoneSelectState;

		// Token: 0x04035E9D RID: 220829
		[Token(Token = "0x4035E9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0__ResetToStageEntry;

		// Token: 0x04035E9E RID: 220830
		[Token(Token = "0x4035E9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0__ResetToStage;

		// Token: 0x04035E9F RID: 220831
		[Token(Token = "0x4035E9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0__ClearCacheBeforeReset;

		// Token: 0x04035EA0 RID: 220832
		[Token(Token = "0x4035EA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0__WrapWithBlackLoading;

		// Token: 0x04035EA1 RID: 220833
		[Token(Token = "0x4035EA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0__SetStateViaParam;

		// Token: 0x04035EA2 RID: 220834
		[Token(Token = "0x4035EA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0__JumpToZoneSelect;

		// Token: 0x04035EA3 RID: 220835
		[Token(Token = "0x4035EA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0__JumpToZoneSelectByViewType;

		// Token: 0x04035EA4 RID: 220836
		[Token(Token = "0x4035EA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0__CheckZoneShouldCheckBriefByZoneId;

		// Token: 0x04035EA5 RID: 220837
		[Token(Token = "0x4035EA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0__CheckZoneShouldCheckBriefByActivityId;

		// Token: 0x04035EA6 RID: 220838
		[Token(Token = "0x4035EA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0__CheckZoneShouldCheckBriefByStorySetId;

		// Token: 0x04035EA7 RID: 220839
		[Token(Token = "0x4035EA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0__JumpToActivity;

		// Token: 0x04035EA8 RID: 220840
		[Token(Token = "0x4035EA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0__JumpToZone;

		// Token: 0x04035EA9 RID: 220841
		[Token(Token = "0x4035EA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0__JumpToStage;

		// Token: 0x04035EAA RID: 220842
		[Token(Token = "0x4035EAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0__JumpToStageRemain;

		// Token: 0x04035EAB RID: 220843
		[Token(Token = "0x4035EAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0__DefaultStackListToZone;

		// Token: 0x04035EAC RID: 220844
		[Token(Token = "0x4035EAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0__DefaultStackListToStage;

		// Token: 0x04035EAD RID: 220845
		[Token(Token = "0x4035EAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0__ExtractInitRewards;

		// Token: 0x04035EAE RID: 220846
		[Token(Token = "0x4035EAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0__GenActInitDataWraper;

		// Token: 0x04035EAF RID: 220847
		[Token(Token = "0x4035EAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0__RedirectActInitMetaToStage;

		// Token: 0x04035EB0 RID: 220848
		[Token(Token = "0x4035EB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0__JumpToCampaign;

		// Token: 0x04035EB1 RID: 220849
		[Token(Token = "0x4035EB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0__OnBackToStagePage;

		// Token: 0x04035EB2 RID: 220850
		[Token(Token = "0x4035EB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0__WaitForActivityReadyCoroutine;

		// Token: 0x04035EB3 RID: 220851
		[Token(Token = "0x4035EB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0__ConsumeExpiredTrackPoint;

		// Token: 0x04035EB4 RID: 220852
		[Token(Token = "0x4035EB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0__TryToTrackSixStarFirstPass;

		// Token: 0x04035EB5 RID: 220853
		[Token(Token = "0x4035EB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_LoadStartBattleCostIcon;

		// Token: 0x04035EB6 RID: 220854
		[Token(Token = "0x4035EB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0_LoadStartBattleButtonImage;

		// Token: 0x04035EB7 RID: 220855
		[Token(Token = "0x4035EB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_LoadStartBattleCostBkg;

		// Token: 0x04035EB8 RID: 220856
		[Token(Token = "0x4035EB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0__LoadSpriteFromStartBattleStyle;

		// Token: 0x04035EB9 RID: 220857
		[Token(Token = "0x4035EB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04035EBA RID: 220858
		[Token(Token = "0x4035EBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006853 RID: 26707
		[Token(Token = "0x2006853")]
		public class MissionArchiveBtnEventParam
		{
			// Token: 0x0602642E RID: 156718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602642E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MissionArchiveBtnEventParam()
			{
			}

			// Token: 0x04035EBB RID: 220859
			[Token(Token = "0x4035EBB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x04035EBC RID: 220860
			[Token(Token = "0x4035EBC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MissionArchiveDataServiceProxy proxy;
		}

		// Token: 0x02006854 RID: 26708
		[Token(Token = "0x2006854")]
		private class ActivityInitMeta
		{
			// Token: 0x0602642F RID: 156719 RVA: 0x000CA7B8 File Offset: 0x000C89B8
			[Token(Token = "0x602642F")]
			[Address(RVA = "0x2147720", Offset = "0x2146320", VA = "0x182147720")]
			public bool ConsumeAct(string actId)
			{
				return default(bool);
			}

			// Token: 0x06026430 RID: 156720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026430")]
			[Address(RVA = "0x21477B0", Offset = "0x21463B0", VA = "0x1821477B0")]
			public ActivityInitMeta()
			{
			}

			// Token: 0x04035EBD RID: 220861
			[Token(Token = "0x4035EBD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string targetZoneId;

			// Token: 0x04035EBE RID: 220862
			[Token(Token = "0x4035EBE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string targetStageId;

			// Token: 0x04035EBF RID: 220863
			[Token(Token = "0x4035EBF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool forceSkipEnterAnim;

			// Token: 0x04035EC0 RID: 220864
			[Token(Token = "0x4035EC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DataBundle actInitMeta;

			// Token: 0x04035EC1 RID: 220865
			[Token(Token = "0x4035EC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ListSet<string> m_consumedActIds;
		}
	}
}
