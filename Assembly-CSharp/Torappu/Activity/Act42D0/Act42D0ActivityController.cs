using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200732F RID: 29487
	[Token(Token = "0x200732F")]
	public class Act42D0ActivityController : TemplateActivityController
	{
		// Token: 0x06029B2A RID: 170794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B2A")]
		[Address(RVA = "0x2502D90", Offset = "0x2501990", VA = "0x182502D90", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x06029B2B RID: 170795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B2B")]
		[Address(RVA = "0x2503420", Offset = "0x2502020", VA = "0x182503420", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x06029B2C RID: 170796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B2C")]
		[Address(RVA = "0x2503840", Offset = "0x2502440", VA = "0x182503840")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x06029B2D RID: 170797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B2D")]
		[Address(RVA = "0x2503950", Offset = "0x2502550", VA = "0x182503950")]
		private TemplateActivityMedalViewModel _GenMedalViewModel()
		{
			return null;
		}

		// Token: 0x06029B2E RID: 170798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B2E")]
		[Address(RVA = "0x2503A60", Offset = "0x2502660", VA = "0x182503A60")]
		private TemplateActivityMilestoneGroupViewModel _GenMilestoneViewModel()
		{
			return null;
		}

		// Token: 0x06029B2F RID: 170799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B2F")]
		[Address(RVA = "0x2503BD0", Offset = "0x25027D0", VA = "0x182503BD0")]
		private Act42D0EntryNormalMapBtnViewModel _GenNormalMapBtnViewModel()
		{
			return null;
		}

		// Token: 0x06029B30 RID: 170800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029B30")]
		[Address(RVA = "0x25036F0", Offset = "0x25022F0", VA = "0x1825036F0")]
		private Act42D0EntryChallengeMapBtnViewModel _GenChallengeMapBtnViewModel()
		{
			return null;
		}

		// Token: 0x06029B31 RID: 170801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B31")]
		[Address(RVA = "0x2502C70", Offset = "0x2501870", VA = "0x182502C70")]
		public void EventOnOpenMilestone()
		{
		}

		// Token: 0x06029B32 RID: 170802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B32")]
		[Address(RVA = "0x2503D20", Offset = "0x2502920", VA = "0x182503D20")]
		public Act42D0ActivityController()
		{
		}

		// Token: 0x06029B33 RID: 170803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B33")]
		[Address(RVA = "0x246D2E0", Offset = "0x246BEE0", VA = "0x18246D2E0")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x0403BAF6 RID: 244470
		[Token(Token = "0x403BAF6")]
		private const string NORMAL_PARAM = "act42d0_normal_map";

		// Token: 0x0403BAF7 RID: 244471
		[Token(Token = "0x403BAF7")]
		private const string CHALLENGE_PARAM = "act42d0_challenge_map";

		// Token: 0x0403BAF8 RID: 244472
		[Token(Token = "0x403BAF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403BAF9 RID: 244473
		[Token(Token = "0x403BAF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403BAFA RID: 244474
		[Token(Token = "0x403BAFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403BAFB RID: 244475
		[Token(Token = "0x403BAFB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenMedalViewModel;

		// Token: 0x0403BAFC RID: 244476
		[Token(Token = "0x403BAFC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenMilestoneViewModel;

		// Token: 0x0403BAFD RID: 244477
		[Token(Token = "0x403BAFD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenNormalMapBtnViewModel;

		// Token: 0x0403BAFE RID: 244478
		[Token(Token = "0x403BAFE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenChallengeMapBtnViewModel;

		// Token: 0x0403BAFF RID: 244479
		[Token(Token = "0x403BAFF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnOpenMilestone;

		// Token: 0x0403BB00 RID: 244480
		[Token(Token = "0x403BB00")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007330 RID: 29488
		[Token(Token = "0x2007330")]
		private class Plugin : ITemplateActivityMilestonePlugin
		{
			// Token: 0x06029B34 RID: 170804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029B34")]
			[Address(RVA = "0x251BEE0", Offset = "0x251AAE0", VA = "0x18251BEE0", Slot = "4")]
			public void InitMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
			{
			}

			// Token: 0x06029B35 RID: 170805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029B35")]
			[Address(RVA = "0x251C1F0", Offset = "0x251ADF0", VA = "0x18251C1F0", Slot = "5")]
			public void UpdateMilestoneList(string actId, List<TemplateActivityMileStoneItemModel> milestoneList)
			{
			}

			// Token: 0x06029B36 RID: 170806 RVA: 0x000D63C8 File Offset: 0x000D45C8
			[Token(Token = "0x6029B36")]
			[Address(RVA = "0x2301B80", Offset = "0x2300780", VA = "0x182301B80", Slot = "6")]
			public int SortMilestoneItem(TemplateActivityMileStoneItemModel m1, TemplateActivityMileStoneItemModel m2)
			{
				return 0;
			}

			// Token: 0x06029B37 RID: 170807 RVA: 0x000D63E0 File Offset: 0x000D45E0
			[Token(Token = "0x6029B37")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			public bool IsItemShow(TemplateActivityMileStoneItemModel itemModel)
			{
				return default(bool);
			}

			// Token: 0x06029B38 RID: 170808 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029B38")]
			[Address(RVA = "0x251BE70", Offset = "0x251AA70", VA = "0x18251BE70", Slot = "8")]
			public string GetMilestoneId(string actId)
			{
				return null;
			}

			// Token: 0x06029B39 RID: 170809 RVA: 0x000D63F8 File Offset: 0x000D45F8
			[Token(Token = "0x6029B39")]
			[Address(RVA = "0x251C1D0", Offset = "0x251ADD0", VA = "0x18251C1D0", Slot = "9")]
			public int UpdateMilestoneCount(string actId)
			{
				return 0;
			}

			// Token: 0x06029B3A RID: 170810 RVA: 0x000D6410 File Offset: 0x000D4610
			[Token(Token = "0x6029B3A")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
			public bool NeedFocusToIdx()
			{
				return default(bool);
			}

			// Token: 0x06029B3B RID: 170811 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029B3B")]
			[Address(RVA = "0x251BD90", Offset = "0x251A990", VA = "0x18251BD90", Slot = "11")]
			public IMilestoneServiceConfig GenOneMilConfig(string actId, string milestoneId, Action<List<RewardItemModel>> onProceed)
			{
				return null;
			}

			// Token: 0x06029B3C RID: 170812 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029B3C")]
			[Address(RVA = "0x251BC30", Offset = "0x251A830", VA = "0x18251BC30", Slot = "12")]
			public IMilestoneServiceConfig GenAllMilConfig(string actId, List<TemplateActivityMileStoneItemModel> milestoneList, Action<List<RewardItemModel>> onProceed)
			{
				return null;
			}

			// Token: 0x06029B3D RID: 170813 RVA: 0x000D6428 File Offset: 0x000D4628
			[Token(Token = "0x6029B3D")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "13")]
			public bool IsMilestoneUnlock(string actId)
			{
				return default(bool);
			}

			// Token: 0x06029B3E RID: 170814 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029B3E")]
			[Address(RVA = "0x251BEA0", Offset = "0x251AAA0", VA = "0x18251BEA0", Slot = "14")]
			public string GetMilestoneLockedToastDesc(string actId)
			{
				return null;
			}

			// Token: 0x06029B3F RID: 170815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029B3F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Plugin()
			{
			}
		}
	}
}
