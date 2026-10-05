using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070AA RID: 28842
	[Token(Token = "0x20070AA")]
	public class Act1BossRushActivityController : TemplateActivityController
	{
		// Token: 0x06029009 RID: 167945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029009")]
		[Address(RVA = "0x2463820", Offset = "0x2462420", VA = "0x182463820", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x0602900A RID: 167946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602900A")]
		[Address(RVA = "0x2465820", Offset = "0x2464420", VA = "0x182465820")]
		private void _TriggerTutorialIfNeed()
		{
		}

		// Token: 0x0602900B RID: 167947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602900B")]
		[Address(RVA = "0x2463530", Offset = "0x2462130", VA = "0x182463530", Slot = "34")]
		protected override void AfterEntryAnimPlay()
		{
		}

		// Token: 0x0602900C RID: 167948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602900C")]
		[Address(RVA = "0x24635A0", Offset = "0x24621A0", VA = "0x1824635A0")]
		public ActivityBossRushData GetData()
		{
			return null;
		}

		// Token: 0x0602900D RID: 167949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602900D")]
		[Address(RVA = "0x24636F0", Offset = "0x24622F0", VA = "0x1824636F0")]
		public PlayerActivity.PlayerBossRushActivity GetPlayerData()
		{
			return null;
		}

		// Token: 0x0602900E RID: 167950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602900E")]
		[Address(RVA = "0x2464D90", Offset = "0x2463990", VA = "0x182464D90")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x0602900F RID: 167951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602900F")]
		[Address(RVA = "0x2464EA0", Offset = "0x2463AA0", VA = "0x182464EA0")]
		private TemplateActivityMedalViewModel _GenMedalViewModel()
		{
			return null;
		}

		// Token: 0x06029010 RID: 167952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029010")]
		[Address(RVA = "0x2464AD0", Offset = "0x24636D0", VA = "0x182464AD0")]
		private Act1BossRushEntryRelicButtonViewModel _GenEntryRelicButtonViewModel()
		{
			return null;
		}

		// Token: 0x06029011 RID: 167953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029011")]
		[Address(RVA = "0x2464940", Offset = "0x2463540", VA = "0x182464940")]
		private Act1BossRushEntryMileStoneButtonViewModel _GenEntryMileStoneButtonViewModel()
		{
			return null;
		}

		// Token: 0x06029012 RID: 167954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029012")]
		[Address(RVA = "0x2464590", Offset = "0x2463190", VA = "0x182464590")]
		private TemplateActivityMissionGroupViewModel _GenActivityMissionGroupViewModel(ActivityBossRushData data)
		{
			return null;
		}

		// Token: 0x06029013 RID: 167955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029013")]
		[Address(RVA = "0x2463CA0", Offset = "0x24628A0", VA = "0x182463CA0")]
		public void SendConfirmAllMission()
		{
		}

		// Token: 0x06029014 RID: 167956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029014")]
		[Address(RVA = "0x24640D0", Offset = "0x2462CD0", VA = "0x1824640D0")]
		public void SendConfirmMission(string missionId)
		{
		}

		// Token: 0x06029015 RID: 167957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029015")]
		[Address(RVA = "0x2465150", Offset = "0x2463D50", VA = "0x182465150")]
		private void _ResponseOnClaimedMission(List<RewardItemModel> rewardItemModels)
		{
		}

		// Token: 0x06029016 RID: 167958 RVA: 0x000D4088 File Offset: 0x000D2288
		[Token(Token = "0x6029016")]
		[Address(RVA = "0x2465B00", Offset = "0x2464700", VA = "0x182465B00")]
		private bool _TryGetRelicNameById(string itemId, List<ActivityBossRushData.RelicData> relicDatas, out string relicName)
		{
			return default(bool);
		}

		// Token: 0x06029017 RID: 167959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029017")]
		[Address(RVA = "0x24650A0", Offset = "0x2463CA0", VA = "0x1824650A0")]
		private static IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x06029018 RID: 167960 RVA: 0x000D40A0 File Offset: 0x000D22A0
		[Token(Token = "0x6029018")]
		[Address(RVA = "0x2464FB0", Offset = "0x2463BB0", VA = "0x182464FB0")]
		private static bool _IsBattleEnd(string actId)
		{
			return default(bool);
		}

		// Token: 0x06029019 RID: 167961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029019")]
		[Address(RVA = "0x2465C40", Offset = "0x2464840", VA = "0x182465C40")]
		public Act1BossRushActivityController()
		{
		}

		// Token: 0x0602901E RID: 167966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602901E")]
		[Address(RVA = "0x24643F0", Offset = "0x2462FF0", VA = "0x1824643F0")]
		private void <>xLuaBaseProxy_AfterEntryAnimPlay()
		{
		}

		// Token: 0x0403A871 RID: 239729
		[Token(Token = "0x403A871")]
		private const string MILESTONE_VIEWMODEL = "act1bossrush_milestone";

		// Token: 0x0403A872 RID: 239730
		[Token(Token = "0x403A872")]
		private const string RELIC_VIEWMODEL = "act1bossrush_relic";

		// Token: 0x0403A873 RID: 239731
		[Token(Token = "0x403A873")]
		[NonSerialized]
		public const string IS_RELIC_TASK = "isRelicTask";

		// Token: 0x0403A874 RID: 239732
		[Token(Token = "0x403A874")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403A875 RID: 239733
		[Token(Token = "0x403A875")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TriggerTutorialIfNeed;

		// Token: 0x0403A876 RID: 239734
		[Token(Token = "0x403A876")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AfterEntryAnimPlay;

		// Token: 0x0403A877 RID: 239735
		[Token(Token = "0x403A877")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetData;

		// Token: 0x0403A878 RID: 239736
		[Token(Token = "0x403A878")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetPlayerData;

		// Token: 0x0403A879 RID: 239737
		[Token(Token = "0x403A879")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403A87A RID: 239738
		[Token(Token = "0x403A87A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenMedalViewModel;

		// Token: 0x0403A87B RID: 239739
		[Token(Token = "0x403A87B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenEntryRelicButtonViewModel;

		// Token: 0x0403A87C RID: 239740
		[Token(Token = "0x403A87C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenEntryMileStoneButtonViewModel;

		// Token: 0x0403A87D RID: 239741
		[Token(Token = "0x403A87D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenActivityMissionGroupViewModel;

		// Token: 0x0403A87E RID: 239742
		[Token(Token = "0x403A87E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SendConfirmAllMission;

		// Token: 0x0403A87F RID: 239743
		[Token(Token = "0x403A87F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SendConfirmMission;

		// Token: 0x0403A880 RID: 239744
		[Token(Token = "0x403A880")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ResponseOnClaimedMission;

		// Token: 0x0403A881 RID: 239745
		[Token(Token = "0x403A881")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TryGetRelicNameById;

		// Token: 0x0403A882 RID: 239746
		[Token(Token = "0x403A882")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403A883 RID: 239747
		[Token(Token = "0x403A883")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__IsBattleEnd;

		// Token: 0x0403A884 RID: 239748
		[Token(Token = "0x403A884")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020070AB RID: 28843
		[Token(Token = "0x20070AB")]
		private struct RelicInfoStruct
		{
			// Token: 0x0403A885 RID: 239749
			[Token(Token = "0x403A885")]
			[FieldOffset(Offset = "0x0")]
			public string relicId;

			// Token: 0x0403A886 RID: 239750
			[Token(Token = "0x403A886")]
			[FieldOffset(Offset = "0x8")]
			public string relicName;
		}
	}
}
