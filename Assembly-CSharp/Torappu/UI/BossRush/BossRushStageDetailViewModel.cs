using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061C3 RID: 25027
	[Token(Token = "0x20061C3")]
	public class BossRushStageDetailViewModel : IHotfixable
	{
		// Token: 0x17005538 RID: 21816
		// (get) Token: 0x060241E0 RID: 147936 RVA: 0x000C3258 File Offset: 0x000C1458
		[Token(Token = "0x17005538")]
		public ActivityBossRushData.BossRushStageType selectedMode
		{
			[Token(Token = "0x60241E0")]
			[Address(RVA = "0x1EE20D0", Offset = "0x1EE0CD0", VA = "0x181EE20D0")]
			get
			{
				return ActivityBossRushData.BossRushStageType.NONE;
			}
		}

		// Token: 0x17005539 RID: 21817
		// (get) Token: 0x060241E1 RID: 147937 RVA: 0x000C3270 File Offset: 0x000C1470
		[Token(Token = "0x17005539")]
		public int waveCount
		{
			[Token(Token = "0x60241E1")]
			[Address(RVA = "0x1EE2130", Offset = "0x1EE0D30", VA = "0x181EE2130")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060241E2 RID: 147938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241E2")]
		[Address(RVA = "0x1EE18B0", Offset = "0x1EE04B0", VA = "0x181EE18B0")]
		public void Reset(string selectStageId, string selectTeam)
		{
		}

		// Token: 0x060241E3 RID: 147939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241E3")]
		[Address(RVA = "0x1EE1A90", Offset = "0x1EE0690", VA = "0x181EE1A90")]
		public void SetSelectedModeAndRefreshModel(ActivityBossRushData.BossRushStageType value, string selectTeam)
		{
		}

		// Token: 0x060241E4 RID: 147940 RVA: 0x000C3288 File Offset: 0x000C1488
		[Token(Token = "0x60241E4")]
		[Address(RVA = "0x1EE0F30", Offset = "0x1EDFB30", VA = "0x181EE0F30")]
		public bool CheckIfCanHideMapPreview()
		{
			return default(bool);
		}

		// Token: 0x060241E5 RID: 147941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241E5")]
		[Address(RVA = "0x1EE15A0", Offset = "0x1EE01A0", VA = "0x181EE15A0")]
		public void LoadTeamData(Dictionary<string, ActivityBossRushData.BossRushTeamData> teamData)
		{
		}

		// Token: 0x060241E6 RID: 147942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241E6")]
		[Address(RVA = "0x1EE1D00", Offset = "0x1EE0900", VA = "0x181EE1D00")]
		private void _RefreshTeam(BossRushStageModel stageModel)
		{
		}

		// Token: 0x060241E7 RID: 147943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241E7")]
		[Address(RVA = "0x1EE1050", Offset = "0x1EDFC50", VA = "0x181EE1050")]
		public void LoadStageData(Dictionary<ActivityBossRushData.BossRushStageType, string> stageIdMap, Dictionary<string, ActivityBossRushData.BossRushStageAdditionData> additionDataMap)
		{
		}

		// Token: 0x060241E8 RID: 147944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241E8")]
		[Address(RVA = "0x1EE1ED0", Offset = "0x1EE0AD0", VA = "0x181EE1ED0")]
		public BossRushStageDetailViewModel()
		{
		}

		// Token: 0x0403234B RID: 205643
		[Token(Token = "0x403234B")]
		[FieldOffset(Offset = "0x10")]
		public string stageGroupId;

		// Token: 0x0403234C RID: 205644
		[Token(Token = "0x403234C")]
		[FieldOffset(Offset = "0x18")]
		public string actId;

		// Token: 0x0403234D RID: 205645
		[Token(Token = "0x403234D")]
		[FieldOffset(Offset = "0x20")]
		public bool canSpModeShow;

		// Token: 0x0403234E RID: 205646
		[Token(Token = "0x403234E")]
		[FieldOffset(Offset = "0x21")]
		public bool isSpModeBtnShow;

		// Token: 0x0403234F RID: 205647
		[Token(Token = "0x403234F")]
		[FieldOffset(Offset = "0x24")]
		public int mapFocusItemIndex;

		// Token: 0x04032350 RID: 205648
		[Token(Token = "0x4032350")]
		[FieldOffset(Offset = "0x28")]
		public string selectTeamId;

		// Token: 0x04032351 RID: 205649
		[Token(Token = "0x4032351")]
		[FieldOffset(Offset = "0x30")]
		public List<BossRushTeamModel> teamList;

		// Token: 0x04032352 RID: 205650
		[Token(Token = "0x4032352")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<ActivityBossRushData.BossRushStageType, BossRushStageModel> stageModelMap;

		// Token: 0x04032353 RID: 205651
		[Token(Token = "0x4032353")]
		[FieldOffset(Offset = "0x40")]
		public List<List<string>> waveBossInfo;

		// Token: 0x04032354 RID: 205652
		[Token(Token = "0x4032354")]
		[FieldOffset(Offset = "0x48")]
		public bool isMapPreviewShow;

		// Token: 0x04032355 RID: 205653
		[Token(Token = "0x4032355")]
		[FieldOffset(Offset = "0x4C")]
		private ActivityBossRushData.BossRushStageType m_selectedMode;

		// Token: 0x04032356 RID: 205654
		[Token(Token = "0x4032356")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, BossRushTeamModel> m_teamDataMap;

		// Token: 0x04032357 RID: 205655
		[Token(Token = "0x4032357")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, BossRushStageModel> m_stageIdMap;

		// Token: 0x04032358 RID: 205656
		[Token(Token = "0x4032358")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedMode;

		// Token: 0x04032359 RID: 205657
		[Token(Token = "0x4032359")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_waveCount;

		// Token: 0x0403235A RID: 205658
		[Token(Token = "0x403235A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0403235B RID: 205659
		[Token(Token = "0x403235B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetSelectedModeAndRefreshModel;

		// Token: 0x0403235C RID: 205660
		[Token(Token = "0x403235C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfCanHideMapPreview;

		// Token: 0x0403235D RID: 205661
		[Token(Token = "0x403235D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadTeamData;

		// Token: 0x0403235E RID: 205662
		[Token(Token = "0x403235E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshTeam;

		// Token: 0x0403235F RID: 205663
		[Token(Token = "0x403235F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadStageData;

		// Token: 0x04032360 RID: 205664
		[Token(Token = "0x4032360")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
