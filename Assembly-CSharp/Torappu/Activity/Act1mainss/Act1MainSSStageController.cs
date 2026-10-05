using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.MissionArchive;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x02007842 RID: 30786
	[Token(Token = "0x2007842")]
	public class Act1MainSSStageController : TemplateActivityController, IMissionArchiveEntry
	{
		// Token: 0x1700650F RID: 25871
		// (get) Token: 0x0602B2D6 RID: 176854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700650F")]
		public UICompDialogMgr dlgMgr
		{
			[Token(Token = "0x602B2D6")]
			[Address(RVA = "0x26F2160", Offset = "0x26F0D60", VA = "0x1826F2160")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B2D7 RID: 176855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2D7")]
		[Address(RVA = "0x26F0580", Offset = "0x26EF180", VA = "0x1826F0580", Slot = "32")]
		public override void InitModelDict(string actId)
		{
		}

		// Token: 0x0602B2D8 RID: 176856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2D8")]
		[Address(RVA = "0x26F0C80", Offset = "0x26EF880", VA = "0x1826F0C80", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x0602B2D9 RID: 176857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2D9")]
		[Address(RVA = "0x26F0260", Offset = "0x26EEE60", VA = "0x1826F0260")]
		public void ClaimApReward()
		{
		}

		// Token: 0x0602B2DA RID: 176858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2DA")]
		[Address(RVA = "0x26F1F60", Offset = "0x26F0B60", VA = "0x1826F1F60")]
		private void _OnApRewardProceed(Act1MainSSGetInfRewardResponse response)
		{
		}

		// Token: 0x0602B2DB RID: 176859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2DB")]
		[Address(RVA = "0x26F0ED0", Offset = "0x26EFAD0", VA = "0x1826F0ED0")]
		public void OnZoneClick(string zoneId)
		{
		}

		// Token: 0x0602B2DC RID: 176860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2DC")]
		[Address(RVA = "0x26F0BD0", Offset = "0x26EF7D0", VA = "0x1826F0BD0")]
		public void OnActDetailClick()
		{
		}

		// Token: 0x0602B2DD RID: 176861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2DD")]
		[Address(RVA = "0x26F11B0", Offset = "0x26EFDB0", VA = "0x1826F11B0", Slot = "38")]
		public void OpenMissionArchive(string topicId)
		{
		}

		// Token: 0x0602B2DE RID: 176862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B2DE")]
		[Address(RVA = "0x26F1D10", Offset = "0x26F0910", VA = "0x1826F1D10")]
		private ActivityYear5GeneralData _GetGameData()
		{
			return null;
		}

		// Token: 0x0602B2DF RID: 176863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B2DF")]
		[Address(RVA = "0x26F1E30", Offset = "0x26F0A30", VA = "0x1826F1E30")]
		private PlayerActivity.PlayerYear5GeneralActivity _GetPlayerData()
		{
			return null;
		}

		// Token: 0x0602B2E0 RID: 176864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B2E0")]
		[Address(RVA = "0x26F1690", Offset = "0x26F0290", VA = "0x1826F1690")]
		private TemplateActivityLifeCycleViewModel _GenLifeCycle()
		{
			return null;
		}

		// Token: 0x0602B2E1 RID: 176865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B2E1")]
		[Address(RVA = "0x26F1A00", Offset = "0x26F0600", VA = "0x1826F1A00")]
		private Act1MainSSZoneGroupViewModel _GenZoneViewModel(TemplateActivityLifeCycleViewModel lfViewModel)
		{
			return null;
		}

		// Token: 0x0602B2E2 RID: 176866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B2E2")]
		[Address(RVA = "0x26F1580", Offset = "0x26F0180", VA = "0x1826F1580")]
		private TemplateActivityFavorViewModel _GenFavorStateViewModel()
		{
			return null;
		}

		// Token: 0x0602B2E3 RID: 176867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B2E3")]
		[Address(RVA = "0x26F17A0", Offset = "0x26F03A0", VA = "0x1826F17A0")]
		private TemplateActivityMissionArchiveViewModel _GenMissionArchiveViewModel()
		{
			return null;
		}

		// Token: 0x0602B2E4 RID: 176868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B2E4")]
		[Address(RVA = "0x26F12A0", Offset = "0x26EFEA0", VA = "0x1826F12A0")]
		private Act1MainSSApCostRewardViewModel _GenApCostRewardViewModel()
		{
			return null;
		}

		// Token: 0x0602B2E5 RID: 176869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B2E5")]
		[Address(RVA = "0x26F1380", Offset = "0x26EFF80", VA = "0x1826F1380")]
		private TemplateActivityCoinViewModel _GenCoinStateViewModel()
		{
			return null;
		}

		// Token: 0x0602B2E6 RID: 176870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B2E6")]
		[Address(RVA = "0x26F14A0", Offset = "0x26F00A0", VA = "0x1826F14A0")]
		private Act1MainSSHomeExploreViewModel _GenExploreViewModel(TemplateActivityLifeCycleViewModel lfViewModel)
		{
			return null;
		}

		// Token: 0x0602B2E7 RID: 176871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2E7")]
		[Address(RVA = "0x26F2100", Offset = "0x26F0D00", VA = "0x1826F2100")]
		public Act1MainSSStageController()
		{
		}

		// Token: 0x0602B2E9 RID: 176873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2E9")]
		[Address(RVA = "0x246D2E0", Offset = "0x246BEE0", VA = "0x18246D2E0")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x0403E6A7 RID: 255655
		[Token(Token = "0x403E6A7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private MissionArchiveDataServiceProxy _missionArchiveProxy;

		// Token: 0x0403E6A8 RID: 255656
		[Token(Token = "0x403E6A8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _entryContainer;

		// Token: 0x0403E6A9 RID: 255657
		[Token(Token = "0x403E6A9")]
		[FieldOffset(Offset = "0x90")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x0403E6AA RID: 255658
		[Token(Token = "0x403E6AA")]
		[NonSerialized]
		public const string AP_COST_REWARD = "ap_cost_reward";

		// Token: 0x0403E6AB RID: 255659
		[Token(Token = "0x403E6AB")]
		[NonSerialized]
		public const string EXPLORE = "explore_info";

		// Token: 0x0403E6AC RID: 255660
		[Token(Token = "0x403E6AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dlgMgr;

		// Token: 0x0403E6AD RID: 255661
		[Token(Token = "0x403E6AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitModelDict;

		// Token: 0x0403E6AE RID: 255662
		[Token(Token = "0x403E6AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403E6AF RID: 255663
		[Token(Token = "0x403E6AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ClaimApReward;

		// Token: 0x0403E6B0 RID: 255664
		[Token(Token = "0x403E6B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnApRewardProceed;

		// Token: 0x0403E6B1 RID: 255665
		[Token(Token = "0x403E6B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnZoneClick;

		// Token: 0x0403E6B2 RID: 255666
		[Token(Token = "0x403E6B2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnActDetailClick;

		// Token: 0x0403E6B3 RID: 255667
		[Token(Token = "0x403E6B3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OpenMissionArchive;

		// Token: 0x0403E6B4 RID: 255668
		[Token(Token = "0x403E6B4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetGameData;

		// Token: 0x0403E6B5 RID: 255669
		[Token(Token = "0x403E6B5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetPlayerData;

		// Token: 0x0403E6B6 RID: 255670
		[Token(Token = "0x403E6B6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenLifeCycle;

		// Token: 0x0403E6B7 RID: 255671
		[Token(Token = "0x403E6B7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GenZoneViewModel;

		// Token: 0x0403E6B8 RID: 255672
		[Token(Token = "0x403E6B8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenFavorStateViewModel;

		// Token: 0x0403E6B9 RID: 255673
		[Token(Token = "0x403E6B9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GenMissionArchiveViewModel;

		// Token: 0x0403E6BA RID: 255674
		[Token(Token = "0x403E6BA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GenApCostRewardViewModel;

		// Token: 0x0403E6BB RID: 255675
		[Token(Token = "0x403E6BB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenCoinStateViewModel;

		// Token: 0x0403E6BC RID: 255676
		[Token(Token = "0x403E6BC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GenExploreViewModel;

		// Token: 0x0403E6BD RID: 255677
		[Token(Token = "0x403E6BD")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
