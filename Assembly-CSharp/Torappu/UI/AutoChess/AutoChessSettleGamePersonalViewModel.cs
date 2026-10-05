using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006301 RID: 25345
	[Token(Token = "0x2006301")]
	public class AutoChessSettleGamePersonalViewModel : IHotfixable
	{
		// Token: 0x170055F6 RID: 22006
		// (get) Token: 0x06024874 RID: 149620 RVA: 0x000C47D0 File Offset: 0x000C29D0
		[Token(Token = "0x170055F6")]
		public bool hasDailyReward
		{
			[Token(Token = "0x6024874")]
			[Address(RVA = "0x1F58650", Offset = "0x1F57250", VA = "0x181F58650")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06024875 RID: 149621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024875")]
		[Address(RVA = "0x1F561D0", Offset = "0x1F54DD0", VA = "0x181F561D0")]
		public void LoadData(ActAutoChessData actData, PlayerActivity.PlayerActAutoChessActivity playerActData, AutoChessSeasonSettleGameInfo settleGameInfo, ActAutoChessModeType modeType)
		{
		}

		// Token: 0x06024876 RID: 149622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024876")]
		[Address(RVA = "0x1F58240", Offset = "0x1F56E40", VA = "0x181F58240")]
		private void _LoadVoice(AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleTeamInfo selfTeamInfo)
		{
		}

		// Token: 0x06024877 RID: 149623 RVA: 0x000C47E8 File Offset: 0x000C29E8
		[Token(Token = "0x6024877")]
		[Address(RVA = "0x1F56C50", Offset = "0x1F55850", VA = "0x181F56C50")]
		private CharWordShowType _GetProperCharWordShowType(AutoChessSettleGamePlayerStatus playerStatus)
		{
			return CharWordShowType.HOME_SHOW;
		}

		// Token: 0x06024878 RID: 149624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024878")]
		[Address(RVA = "0x1F57FC0", Offset = "0x1F56BC0", VA = "0x181F57FC0")]
		private void _LoadNormalRewardInfo(ActAutoChessData.ActAutoChessConstData constData, AutoChessSeasonSettleGameInfo.AutoChessRecordInfos recordInfos)
		{
		}

		// Token: 0x06024879 RID: 149625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024879")]
		[Address(RVA = "0x1F57CC0", Offset = "0x1F568C0", VA = "0x181F57CC0")]
		private void _LoadDailyRewardInfo(ActAutoChessData.ActAutoChessConstData constData, PlayerActivity.PlayerCommonDailyMission playerDailyMission, AutoChessSeasonSettleGameInfo.AutoChessRecordInfos recordInfos)
		{
		}

		// Token: 0x0602487A RID: 149626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602487A")]
		[Address(RVA = "0x1F57DB0", Offset = "0x1F569B0", VA = "0x181F57DB0")]
		private void _LoadMilestoneInfo(ActAutoChessData actData, PlayerActivity.MilestoneInfo milestoneInfo, AutoChessSeasonSettleGameInfo.AutoChessRecordInfos recordInfos)
		{
		}

		// Token: 0x0602487B RID: 149627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602487B")]
		[Address(RVA = "0x1F57600", Offset = "0x1F56200", VA = "0x181F57600")]
		private void _LoadCharsInfo(ActAutoChessData actData, Dictionary<string, ActAutoChessData.ActAutoChessCharChessData> charChessDataDict, Dictionary<string, PlayerActivity.PlayerActAutoChessActivity.AutoChessSquadSlot> playerChessPool, List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleSquadInfo> onStageChess)
		{
		}

		// Token: 0x0602487C RID: 149628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602487C")]
		[Address(RVA = "0x1F56F90", Offset = "0x1F55B90", VA = "0x181F56F90")]
		private void _LoadBondInfo(ActAutoChessData actData, List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleBondInfo> bondInfos, string modeId)
		{
		}

		// Token: 0x0602487D RID: 149629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602487D")]
		[Address(RVA = "0x1F57E80", Offset = "0x1F56A80", VA = "0x181F57E80")]
		private void _LoadNormalOrGoldenDataIfNeed(Dictionary<string, ActAutoChessData.ActAutoChessCharChessData> charDatabase, ActAutoChessData.ActAutoChessCharShopChessData shopData, ActAutoChessData.ActAutoChessCharChessData formerLookup, out ActAutoChessData.ActAutoChessCharChessData normal, out ActAutoChessData.ActAutoChessCharChessData golden)
		{
		}

		// Token: 0x0602487E RID: 149630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602487E")]
		[Address(RVA = "0x1F56DE0", Offset = "0x1F559E0", VA = "0x181F56DE0")]
		private void _LoadBandInfo(string bandId, ListDict<string, ActAutoChessData.ActAutoChessBandData> bandDataListDict, PlayerActivity.PlayerActAutoChessActivity playerActData)
		{
		}

		// Token: 0x0602487F RID: 149631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602487F")]
		[Address(RVA = "0x1F57440", Offset = "0x1F56040", VA = "0x181F57440")]
		private void _LoadBriefInfo(List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleTeamInfo> teamInfos, string uid, bool isViolation)
		{
		}

		// Token: 0x06024880 RID: 149632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024880")]
		[Address(RVA = "0x1F56CE0", Offset = "0x1F558E0", VA = "0x181F56CE0")]
		private AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleTeamInfo _GetSelfBattleBriefInfo(List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleTeamInfo> teamInfos, string uid)
		{
			return null;
		}

		// Token: 0x06024881 RID: 149633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024881")]
		[Address(RVA = "0x1F57300", Offset = "0x1F55F00", VA = "0x181F57300")]
		private void _LoadBossInfo(List<AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleBossInfo> bossRecords)
		{
		}

		// Token: 0x06024882 RID: 149634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024882")]
		[Address(RVA = "0x1F56B50", Offset = "0x1F55750", VA = "0x181F56B50")]
		private string _GetBossIconId(string bossId)
		{
			return null;
		}

		// Token: 0x06024883 RID: 149635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024883")]
		[Address(RVA = "0x1F58080", Offset = "0x1F56C80", VA = "0x181F58080")]
		private void _LoadPlayerInfo(AutoChessSeasonSettleGameInfo.AutoChessRecordInfos recordInfos, int playerHasTrophyNum)
		{
		}

		// Token: 0x06024884 RID: 149636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024884")]
		[Address(RVA = "0x1F58480", Offset = "0x1F57080", VA = "0x181F58480")]
		public AutoChessSettleGamePersonalViewModel()
		{
		}

		// Token: 0x04032F19 RID: 208665
		[Token(Token = "0x4032F19")]
		[FieldOffset(Offset = "0x10")]
		public string bandIconId;

		// Token: 0x04032F1A RID: 208666
		[Token(Token = "0x4032F1A")]
		[FieldOffset(Offset = "0x18")]
		public bool isBandVictor;

		// Token: 0x04032F1B RID: 208667
		[Token(Token = "0x4032F1B")]
		[FieldOffset(Offset = "0x20")]
		public string bossIconId;

		// Token: 0x04032F1C RID: 208668
		[Token(Token = "0x4032F1C")]
		[FieldOffset(Offset = "0x28")]
		public string spBossIconId;

		// Token: 0x04032F1D RID: 208669
		[Token(Token = "0x4032F1D")]
		[FieldOffset(Offset = "0x30")]
		public AutoChessSettleGamePlayerStatus battleStatus;

		// Token: 0x04032F1E RID: 208670
		[Token(Token = "0x4032F1E")]
		[FieldOffset(Offset = "0x34")]
		public AutoChessSettleGameInterruptType interruptType;

		// Token: 0x04032F1F RID: 208671
		[Token(Token = "0x4032F1F")]
		[FieldOffset(Offset = "0x38")]
		public int maxPassRound;

		// Token: 0x04032F20 RID: 208672
		[Token(Token = "0x4032F20")]
		[FieldOffset(Offset = "0x40")]
		public string nickName;

		// Token: 0x04032F21 RID: 208673
		[Token(Token = "0x4032F21")]
		[FieldOffset(Offset = "0x48")]
		public string nickNameId;

		// Token: 0x04032F22 RID: 208674
		[Token(Token = "0x4032F22")]
		[FieldOffset(Offset = "0x50")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x04032F23 RID: 208675
		[Token(Token = "0x4032F23")]
		[FieldOffset(Offset = "0x68")]
		public int totalTrophyNum;

		// Token: 0x04032F24 RID: 208676
		[Token(Token = "0x4032F24")]
		[FieldOffset(Offset = "0x6C")]
		public int curTimeGetTrophyNum;

		// Token: 0x04032F25 RID: 208677
		[Token(Token = "0x4032F25")]
		[FieldOffset(Offset = "0x70")]
		public string trophyIconId;

		// Token: 0x04032F26 RID: 208678
		[Token(Token = "0x4032F26")]
		[FieldOffset(Offset = "0x78")]
		public long startTs;

		// Token: 0x04032F27 RID: 208679
		[Token(Token = "0x4032F27")]
		[FieldOffset(Offset = "0x80")]
		public long settleTs;

		// Token: 0x04032F28 RID: 208680
		[Token(Token = "0x4032F28")]
		[FieldOffset(Offset = "0x88")]
		public List<AutoChessSettleGamePersonalCharItemViewModel> charItems;

		// Token: 0x04032F29 RID: 208681
		[Token(Token = "0x4032F29")]
		[FieldOffset(Offset = "0x90")]
		public List<AutoChessSettleGamePersonalBondItemViewModel> bondItems;

		// Token: 0x04032F2A RID: 208682
		[Token(Token = "0x4032F2A")]
		[FieldOffset(Offset = "0x98")]
		public string normalRewardItemId;

		// Token: 0x04032F2B RID: 208683
		[Token(Token = "0x4032F2B")]
		[FieldOffset(Offset = "0xA0")]
		public int normalRewardCount;

		// Token: 0x04032F2C RID: 208684
		[Token(Token = "0x4032F2C")]
		[FieldOffset(Offset = "0xA8")]
		public ActBattleFinishCommonDailyRewardViewModel dailyRewardViewModel;

		// Token: 0x04032F2D RID: 208685
		[Token(Token = "0x4032F2D")]
		[FieldOffset(Offset = "0xB0")]
		public ActBattleFinishCommonMilestoneViewModel milestoneViewModel;

		// Token: 0x04032F2E RID: 208686
		[Token(Token = "0x4032F2E")]
		[FieldOffset(Offset = "0xB8")]
		public CharWordData charWord;

		// Token: 0x04032F2F RID: 208687
		[Token(Token = "0x4032F2F")]
		[FieldOffset(Offset = "0xC0")]
		public bool showNextBtn;

		// Token: 0x04032F30 RID: 208688
		[Token(Token = "0x4032F30")]
		[FieldOffset(Offset = "0xC1")]
		public bool showBackToHomeBtn;

		// Token: 0x04032F31 RID: 208689
		[Token(Token = "0x4032F31")]
		[FieldOffset(Offset = "0xC4")]
		public float autoJumpToTeamViewWaitTime;

		// Token: 0x04032F32 RID: 208690
		[Token(Token = "0x4032F32")]
		[FieldOffset(Offset = "0xC8")]
		private AutoChessSeasonSettleGameInfo.AutoChessSeasonSettleTeamInfo m_selfTeamInfo;

		// Token: 0x04032F33 RID: 208691
		[Token(Token = "0x4032F33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasDailyReward;

		// Token: 0x04032F34 RID: 208692
		[Token(Token = "0x4032F34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04032F35 RID: 208693
		[Token(Token = "0x4032F35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadVoice;

		// Token: 0x04032F36 RID: 208694
		[Token(Token = "0x4032F36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetProperCharWordShowType;

		// Token: 0x04032F37 RID: 208695
		[Token(Token = "0x4032F37")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadNormalRewardInfo;

		// Token: 0x04032F38 RID: 208696
		[Token(Token = "0x4032F38")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadDailyRewardInfo;

		// Token: 0x04032F39 RID: 208697
		[Token(Token = "0x4032F39")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadMilestoneInfo;

		// Token: 0x04032F3A RID: 208698
		[Token(Token = "0x4032F3A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadCharsInfo;

		// Token: 0x04032F3B RID: 208699
		[Token(Token = "0x4032F3B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadBondInfo;

		// Token: 0x04032F3C RID: 208700
		[Token(Token = "0x4032F3C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadNormalOrGoldenDataIfNeed;

		// Token: 0x04032F3D RID: 208701
		[Token(Token = "0x4032F3D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadBandInfo;

		// Token: 0x04032F3E RID: 208702
		[Token(Token = "0x4032F3E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadBriefInfo;

		// Token: 0x04032F3F RID: 208703
		[Token(Token = "0x4032F3F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetSelfBattleBriefInfo;

		// Token: 0x04032F40 RID: 208704
		[Token(Token = "0x4032F40")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadBossInfo;

		// Token: 0x04032F41 RID: 208705
		[Token(Token = "0x4032F41")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetBossIconId;

		// Token: 0x04032F42 RID: 208706
		[Token(Token = "0x4032F42")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__LoadPlayerInfo;

		// Token: 0x04032F43 RID: 208707
		[Token(Token = "0x4032F43")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
