using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.TemplateMission;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076AF RID: 30383
	[Token(Token = "0x20076AF")]
	public class Act1VHalfIdleActivityController : TemplateActivityController
	{
		// Token: 0x0602ABA8 RID: 175016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABA8")]
		[Address(RVA = "0x267F6C0", Offset = "0x267E2C0", VA = "0x18267F6C0", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x0602ABA9 RID: 175017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABA9")]
		[Address(RVA = "0x2680240", Offset = "0x267EE40", VA = "0x182680240")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x0602ABAA RID: 175018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABAA")]
		[Address(RVA = "0x267FDE0", Offset = "0x267E9E0", VA = "0x18267FDE0")]
		private TemplateActivityCoinViewModel _GenCoinViewModel()
		{
			return null;
		}

		// Token: 0x0602ABAB RID: 175019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABAB")]
		[Address(RVA = "0x2680460", Offset = "0x267F060", VA = "0x182680460")]
		private TemplateActivityMilestoneGroupViewModel _GenMilestoneViewModel()
		{
			return null;
		}

		// Token: 0x0602ABAC RID: 175020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABAC")]
		[Address(RVA = "0x2680350", Offset = "0x267EF50", VA = "0x182680350")]
		private TemplateActivityMedalViewModel _GenMedalViewModel()
		{
			return null;
		}

		// Token: 0x0602ABAD RID: 175021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABAD")]
		[Address(RVA = "0x267FF00", Offset = "0x267EB00", VA = "0x18267FF00")]
		private Act1VHalfIdleEntryButtonViewModel _GenEntryButtonViewModel()
		{
			return null;
		}

		// Token: 0x0602ABAE RID: 175022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABAE")]
		[Address(RVA = "0x26805D0", Offset = "0x267F1D0", VA = "0x1826805D0")]
		private TemplateActivityMissionViewModel _GenMissionViewModel()
		{
			return null;
		}

		// Token: 0x0602ABAF RID: 175023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABAF")]
		[Address(RVA = "0x2680C50", Offset = "0x267F850", VA = "0x182680C50")]
		private void _ShowTutorialLockedToastIfNeed()
		{
		}

		// Token: 0x0602ABB0 RID: 175024 RVA: 0x000D9B48 File Offset: 0x000D7D48
		[Token(Token = "0x602ABB0")]
		[Address(RVA = "0x2680B70", Offset = "0x267F770", VA = "0x182680B70")]
		private bool _IsActEnd()
		{
			return default(bool);
		}

		// Token: 0x0602ABB1 RID: 175025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABB1")]
		[Address(RVA = "0x2680860", Offset = "0x267F460", VA = "0x182680860")]
		private Act1VHalfIdleData _GetData()
		{
			return null;
		}

		// Token: 0x0602ABB2 RID: 175026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABB2")]
		[Address(RVA = "0x26809E0", Offset = "0x267F5E0", VA = "0x1826809E0")]
		private PlayerActivity.PlayerAct1VHalfIdleActivity _GetPlayerData()
		{
			return null;
		}

		// Token: 0x0602ABB3 RID: 175027 RVA: 0x000D9B60 File Offset: 0x000D7D60
		[Token(Token = "0x602ABB3")]
		[Address(RVA = "0x2680690", Offset = "0x267F290", VA = "0x182680690")]
		private int _GetCoinCount()
		{
			return 0;
		}

		// Token: 0x0602ABB4 RID: 175028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABB4")]
		[Address(RVA = "0x267F5F0", Offset = "0x267E1F0", VA = "0x18267F5F0", Slot = "36")]
		public override string GetTutorialCustomOperationKey()
		{
			return null;
		}

		// Token: 0x0602ABB5 RID: 175029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABB5")]
		[Address(RVA = "0x267FD70", Offset = "0x267E970", VA = "0x18267FD70", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x0602ABB6 RID: 175030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABB6")]
		[Address(RVA = "0x267FCC0", Offset = "0x267E8C0", VA = "0x18267FCC0", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x0602ABB7 RID: 175031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABB7")]
		[Address(RVA = "0x267E9E0", Offset = "0x267D5E0", VA = "0x18267E9E0", Slot = "34")]
		protected override void AfterEntryAnimPlay()
		{
		}

		// Token: 0x0602ABB8 RID: 175032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABB8")]
		[Address(RVA = "0x2680ED0", Offset = "0x267FAD0", VA = "0x182680ED0")]
		private void _UpdateViewModel()
		{
		}

		// Token: 0x0602ABB9 RID: 175033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABB9")]
		[Address(RVA = "0x2680E20", Offset = "0x267FA20", VA = "0x182680E20")]
		private void _TryConsumeGuidebook()
		{
		}

		// Token: 0x0602ABBA RID: 175034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABBA")]
		[Address(RVA = "0x267F040", Offset = "0x267DC40", VA = "0x18267F040")]
		public void EventOnOpenHarvestPage()
		{
		}

		// Token: 0x0602ABBB RID: 175035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABBB")]
		[Address(RVA = "0x267EF60", Offset = "0x267DB60", VA = "0x18267EF60")]
		public void EventOnMission()
		{
		}

		// Token: 0x0602ABBC RID: 175036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABBC")]
		[Address(RVA = "0x267EA50", Offset = "0x267D650", VA = "0x18267EA50")]
		public void EventOnMap()
		{
		}

		// Token: 0x0602ABBD RID: 175037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABBD")]
		[Address(RVA = "0x267ED20", Offset = "0x267D920", VA = "0x18267ED20")]
		public void EventOnMilestone()
		{
		}

		// Token: 0x0602ABBE RID: 175038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABBE")]
		[Address(RVA = "0x267F250", Offset = "0x267DE50", VA = "0x18267F250")]
		public void EventOnOpenTechTreePage()
		{
		}

		// Token: 0x0602ABBF RID: 175039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABBF")]
		[Address(RVA = "0x267F420", Offset = "0x267E020", VA = "0x18267F420")]
		public void EventOpenDepotPage()
		{
		}

		// Token: 0x0602ABC0 RID: 175040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABC0")]
		[Address(RVA = "0x2681130", Offset = "0x267FD30", VA = "0x182681130")]
		public Act1VHalfIdleActivityController()
		{
		}

		// Token: 0x0602ABC1 RID: 175041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ABC1")]
		[Address(RVA = "0x246D2C0", Offset = "0x246BEC0", VA = "0x18246D2C0")]
		private string <>xLuaBaseProxy_GetTutorialCustomOperationKey()
		{
			return null;
		}

		// Token: 0x0602ABC2 RID: 175042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABC2")]
		[Address(RVA = "0x246D320", Offset = "0x246BF20", VA = "0x18246D320")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x0602ABC3 RID: 175043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABC3")]
		[Address(RVA = "0x246D2E0", Offset = "0x246BEE0", VA = "0x18246D2E0")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x0602ABC4 RID: 175044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABC4")]
		[Address(RVA = "0x24643F0", Offset = "0x2462FF0", VA = "0x1824643F0")]
		private void <>xLuaBaseProxy_AfterEntryAnimPlay()
		{
		}

		// Token: 0x0403D91B RID: 252187
		[Token(Token = "0x403D91B")]
		private const string ENTRY_BUTTON_PARAM = "entry_button";

		// Token: 0x0403D91C RID: 252188
		[Token(Token = "0x403D91C")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "entry";

		// Token: 0x0403D91D RID: 252189
		[Token(Token = "0x403D91D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403D91E RID: 252190
		[Token(Token = "0x403D91E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403D91F RID: 252191
		[Token(Token = "0x403D91F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenCoinViewModel;

		// Token: 0x0403D920 RID: 252192
		[Token(Token = "0x403D920")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenMilestoneViewModel;

		// Token: 0x0403D921 RID: 252193
		[Token(Token = "0x403D921")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenMedalViewModel;

		// Token: 0x0403D922 RID: 252194
		[Token(Token = "0x403D922")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenEntryButtonViewModel;

		// Token: 0x0403D923 RID: 252195
		[Token(Token = "0x403D923")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenMissionViewModel;

		// Token: 0x0403D924 RID: 252196
		[Token(Token = "0x403D924")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShowTutorialLockedToastIfNeed;

		// Token: 0x0403D925 RID: 252197
		[Token(Token = "0x403D925")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__IsActEnd;

		// Token: 0x0403D926 RID: 252198
		[Token(Token = "0x403D926")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetData;

		// Token: 0x0403D927 RID: 252199
		[Token(Token = "0x403D927")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetPlayerData;

		// Token: 0x0403D928 RID: 252200
		[Token(Token = "0x403D928")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetCoinCount;

		// Token: 0x0403D929 RID: 252201
		[Token(Token = "0x403D929")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetTutorialCustomOperationKey;

		// Token: 0x0403D92A RID: 252202
		[Token(Token = "0x403D92A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403D92B RID: 252203
		[Token(Token = "0x403D92B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403D92C RID: 252204
		[Token(Token = "0x403D92C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_AfterEntryAnimPlay;

		// Token: 0x0403D92D RID: 252205
		[Token(Token = "0x403D92D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateViewModel;

		// Token: 0x0403D92E RID: 252206
		[Token(Token = "0x403D92E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TryConsumeGuidebook;

		// Token: 0x0403D92F RID: 252207
		[Token(Token = "0x403D92F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnOpenHarvestPage;

		// Token: 0x0403D930 RID: 252208
		[Token(Token = "0x403D930")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnMission;

		// Token: 0x0403D931 RID: 252209
		[Token(Token = "0x403D931")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnMap;

		// Token: 0x0403D932 RID: 252210
		[Token(Token = "0x403D932")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EventOnMilestone;

		// Token: 0x0403D933 RID: 252211
		[Token(Token = "0x403D933")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnOpenTechTreePage;

		// Token: 0x0403D934 RID: 252212
		[Token(Token = "0x403D934")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_EventOpenDepotPage;

		// Token: 0x0403D935 RID: 252213
		[Token(Token = "0x403D935")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020076B0 RID: 30384
		[Token(Token = "0x20076B0")]
		private class Plugin : ITemplateActivityMilestonePlugin
		{
			// Token: 0x0602ABC5 RID: 175045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602ABC5")]
			[Address(RVA = "0x2694B50", Offset = "0x2693750", VA = "0x182694B50", Slot = "4")]
			public void InitMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
			{
			}

			// Token: 0x0602ABC6 RID: 175046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602ABC6")]
			[Address(RVA = "0x2694F20", Offset = "0x2693B20", VA = "0x182694F20", Slot = "5")]
			public void UpdateMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
			{
			}

			// Token: 0x0602ABC7 RID: 175047 RVA: 0x000D9B78 File Offset: 0x000D7D78
			[Token(Token = "0x602ABC7")]
			[Address(RVA = "0x2301B80", Offset = "0x2300780", VA = "0x182301B80", Slot = "6")]
			public int SortMilestoneItem(TemplateActivityMileStoneItemModel m1, TemplateActivityMileStoneItemModel m2)
			{
				return 0;
			}

			// Token: 0x0602ABC8 RID: 175048 RVA: 0x000D9B90 File Offset: 0x000D7D90
			[Token(Token = "0x602ABC8")]
			[Address(RVA = "0x2376240", Offset = "0x2374E40", VA = "0x182376240", Slot = "7")]
			public bool IsItemShow(TemplateActivityMileStoneItemModel itemModel)
			{
				return default(bool);
			}

			// Token: 0x0602ABC9 RID: 175049 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602ABC9")]
			[Address(RVA = "0x2694AD0", Offset = "0x26936D0", VA = "0x182694AD0", Slot = "8")]
			public string GetMilestoneId(string actId)
			{
				return null;
			}

			// Token: 0x0602ABCA RID: 175050 RVA: 0x000D9BA8 File Offset: 0x000D7DA8
			[Token(Token = "0x602ABCA")]
			[Address(RVA = "0x2694EF0", Offset = "0x2693AF0", VA = "0x182694EF0", Slot = "9")]
			public int UpdateMilestoneCount(string actId)
			{
				return 0;
			}

			// Token: 0x0602ABCB RID: 175051 RVA: 0x000D9BC0 File Offset: 0x000D7DC0
			[Token(Token = "0x602ABCB")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
			public bool NeedFocusToIdx()
			{
				return default(bool);
			}

			// Token: 0x0602ABCC RID: 175052 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602ABCC")]
			[Address(RVA = "0x2694A40", Offset = "0x2693640", VA = "0x182694A40", Slot = "11")]
			public IMilestoneServiceConfig GenOneMilConfig(string actId, string milestoneId, Action<List<RewardItemModel>> onProceed)
			{
				return null;
			}

			// Token: 0x0602ABCD RID: 175053 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602ABCD")]
			[Address(RVA = "0x26949D0", Offset = "0x26935D0", VA = "0x1826949D0", Slot = "12")]
			public IMilestoneServiceConfig GenAllMilConfig(string actId, List<TemplateActivityMileStoneItemModel> milestoneList, Action<List<RewardItemModel>> onProceed)
			{
				return null;
			}

			// Token: 0x0602ABCE RID: 175054 RVA: 0x000D9BD8 File Offset: 0x000D7DD8
			[Token(Token = "0x602ABCE")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "13")]
			public bool IsMilestoneUnlock(string actId)
			{
				return default(bool);
			}

			// Token: 0x0602ABCF RID: 175055 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602ABCF")]
			[Address(RVA = "0x2694B10", Offset = "0x2693710", VA = "0x182694B10", Slot = "14")]
			public string GetMilestoneLockedToastDesc(string actId)
			{
				return null;
			}

			// Token: 0x0602ABD0 RID: 175056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602ABD0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Plugin()
			{
			}

			// Token: 0x0403D936 RID: 252214
			[Token(Token = "0x403D936")]
			[FieldOffset(Offset = "0x10")]
			private bool m_hasLockedItem;
		}
	}
}
