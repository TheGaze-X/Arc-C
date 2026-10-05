using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Medal;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200594E RID: 22862
	[Token(Token = "0x200594E")]
	public class CrisisV2AchievementSeasonViewModel : IHotfixable, IComparable
	{
		// Token: 0x06021521 RID: 136481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021521")]
		[Address(RVA = "0x1BA1350", Offset = "0x1B9FF50", VA = "0x181BA1350")]
		private CrisisV2AchievementSeasonViewModel()
		{
		}

		// Token: 0x06021522 RID: 136482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021522")]
		[Address(RVA = "0x1B9FD60", Offset = "0x1B9E960", VA = "0x181B9FD60")]
		public static CrisisV2AchievementSeasonViewModel GetViewModelForCurrSeason(string seasonId, ListDict<int, CrisisV2AppraiseWrap> scoreLevelToAppraiseDataMap, CrisisV2SeasonInfo data, PlayerCrisisV2Season playerData, PlayerStatus playerStatus, CrisisV2MapStageData mapStageData, CrisisV2MapDetailData mapDetailData, CrisisV2SnapShotBase snapshot)
		{
			return null;
		}

		// Token: 0x06021523 RID: 136483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021523")]
		[Address(RVA = "0x1BA00D0", Offset = "0x1B9ECD0", VA = "0x181BA00D0")]
		public static CrisisV2AchievementSeasonViewModel GetViewModelForPassedSeason(string seasonId, CrisisV2SeasonInfo data, ListDict<int, CrisisV2AppraiseWrap> scoreLevelToAppraiseDataMap, CrisisV2AchievementData achievement, PlayerCrisisV2Season playerData, PlayerStatus playerStatus, CrisisV2SnapShotBase snapshot)
		{
			return null;
		}

		// Token: 0x06021524 RID: 136484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021524")]
		[Address(RVA = "0x1BA0890", Offset = "0x1B9F490", VA = "0x181BA0890")]
		private void _LoadCommonData(string seasonId, CrisisV2SeasonInfo data, ListDict<int, CrisisV2AppraiseWrap> scoreLevelToAppraiseDataMap, PlayerCrisisV2Season playerData, PlayerStatus playerStatus, CrisisV2SnapShotBase snapshot)
		{
		}

		// Token: 0x06021525 RID: 136485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021525")]
		[Address(RVA = "0x1BA0C70", Offset = "0x1B9F870", VA = "0x181BA0C70")]
		private void _LoadDimensionItemData(IList<CrisisV2DimensionItemData> dimensionItemList)
		{
		}

		// Token: 0x06021526 RID: 136486 RVA: 0x000B9508 File Offset: 0x000B7708
		[Token(Token = "0x6021526")]
		[Address(RVA = "0x1B9FC50", Offset = "0x1B9E850", VA = "0x181B9FC50", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06021527 RID: 136487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021527")]
		[Address(RVA = "0x1BA0EF0", Offset = "0x1B9FAF0", VA = "0x181BA0EF0")]
		private static void _LoadRuneDataFromServer(ref List<ICrisisV2RuneData> dataList, IDictionary<string, PlayerCrisisV2Season.RuneState> runePlayerData, CrisisV2MapDetailData mapDetailData)
		{
		}

		// Token: 0x06021528 RID: 136488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021528")]
		[Address(RVA = "0x1BA05E0", Offset = "0x1B9F1E0", VA = "0x181BA05E0")]
		public static void LoadRuneDataFromServer(ref List<ICrisisV2RuneData> dataList, IList<string> runeIdList, CrisisV2MapDetailData mapDetailData)
		{
		}

		// Token: 0x06021529 RID: 136489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021529")]
		[Address(RVA = "0x1BA0330", Offset = "0x1B9EF30", VA = "0x181BA0330")]
		public static void LoadCommentDataFromServer(ref List<ICrisisV2CommentData> dataList, IList<string> commentPlayerData, IDictionary<string, CrisisV2CommentData> commentDataMap)
		{
		}

		// Token: 0x0602152A RID: 136490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602152A")]
		public static void LoadRuneData<T>(ref List<CrisisV2AchievementRuneViewModel> runeModelList, IList<T> runeData) where T : ICrisisV2RuneData
		{
		}

		// Token: 0x0602152B RID: 136491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602152B")]
		public static void LoadCommentData<T>(ref List<CrisisV2AchievementCommentViewModel> commentModelList, IList<T> commentData) where T : ICrisisV2CommentData
		{
		}

		// Token: 0x0402D6EF RID: 186095
		[Token(Token = "0x402D6EF")]
		[FieldOffset(Offset = "0x10")]
		public string seasonId;

		// Token: 0x0402D6F0 RID: 186096
		[Token(Token = "0x402D6F0")]
		[FieldOffset(Offset = "0x18")]
		public string mapName;

		// Token: 0x0402D6F1 RID: 186097
		[Token(Token = "0x402D6F1")]
		[FieldOffset(Offset = "0x20")]
		public string mapCode;

		// Token: 0x0402D6F2 RID: 186098
		[Token(Token = "0x402D6F2")]
		[FieldOffset(Offset = "0x28")]
		public MedalGroupViewModel medalGroupModel;

		// Token: 0x0402D6F3 RID: 186099
		[Token(Token = "0x402D6F3")]
		[FieldOffset(Offset = "0x30")]
		public CrisisV2AppraiseType appraiseType;

		// Token: 0x0402D6F4 RID: 186100
		[Token(Token = "0x402D6F4")]
		[FieldOffset(Offset = "0x34")]
		public int totalScore;

		// Token: 0x0402D6F5 RID: 186101
		[Token(Token = "0x402D6F5")]
		[FieldOffset(Offset = "0x38")]
		public bool hasRecord;

		// Token: 0x0402D6F6 RID: 186102
		[Token(Token = "0x402D6F6")]
		[FieldOffset(Offset = "0x39")]
		public bool hasHistory;

		// Token: 0x0402D6F7 RID: 186103
		[Token(Token = "0x402D6F7")]
		[FieldOffset(Offset = "0x40")]
		public CrisisV2SnapShotBase snapshotData;

		// Token: 0x0402D6F8 RID: 186104
		[Token(Token = "0x402D6F8")]
		[FieldOffset(Offset = "0x48")]
		public int runeCount;

		// Token: 0x0402D6F9 RID: 186105
		[Token(Token = "0x402D6F9")]
		[FieldOffset(Offset = "0x50")]
		public List<CrisisV2AchievementRuneViewModel> runeModelList;

		// Token: 0x0402D6FA RID: 186106
		[Token(Token = "0x402D6FA")]
		[FieldOffset(Offset = "0x58")]
		public List<CrisisV2AchievementCommentViewModel> commentModelList;

		// Token: 0x0402D6FB RID: 186107
		[Token(Token = "0x402D6FB")]
		[FieldOffset(Offset = "0x60")]
		public List<int> dimensionSingleScore;

		// Token: 0x0402D6FC RID: 186108
		[Token(Token = "0x402D6FC")]
		[FieldOffset(Offset = "0x68")]
		public List<int> dimensionTotalScore;

		// Token: 0x0402D6FD RID: 186109
		[Token(Token = "0x402D6FD")]
		[FieldOffset(Offset = "0x70")]
		public List<string> dimensionDesc;

		// Token: 0x0402D6FE RID: 186110
		[Token(Token = "0x402D6FE")]
		[FieldOffset(Offset = "0x78")]
		public List<int> dimensionMaxScore;

		// Token: 0x0402D6FF RID: 186111
		[Token(Token = "0x402D6FF")]
		[FieldOffset(Offset = "0x80")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x0402D700 RID: 186112
		[Token(Token = "0x402D700")]
		[FieldOffset(Offset = "0x98")]
		public string playerNickName;

		// Token: 0x0402D701 RID: 186113
		[Token(Token = "0x402D701")]
		[FieldOffset(Offset = "0xA0")]
		public string playerNickNumber;

		// Token: 0x0402D702 RID: 186114
		[Token(Token = "0x402D702")]
		[FieldOffset(Offset = "0xA8")]
		private long m_startTs;

		// Token: 0x0402D703 RID: 186115
		[Token(Token = "0x402D703")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402D704 RID: 186116
		[Token(Token = "0x402D704")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetViewModelForCurrSeason;

		// Token: 0x0402D705 RID: 186117
		[Token(Token = "0x402D705")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetViewModelForPassedSeason;

		// Token: 0x0402D706 RID: 186118
		[Token(Token = "0x402D706")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadCommonData;

		// Token: 0x0402D707 RID: 186119
		[Token(Token = "0x402D707")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadDimensionItemData;

		// Token: 0x0402D708 RID: 186120
		[Token(Token = "0x402D708")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402D709 RID: 186121
		[Token(Token = "0x402D709")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadRuneDataFromServer;

		// Token: 0x0402D70A RID: 186122
		[Token(Token = "0x402D70A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadRuneDataFromServer;

		// Token: 0x0402D70B RID: 186123
		[Token(Token = "0x402D70B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadCommentDataFromServer;

		// Token: 0x0402D70C RID: 186124
		[Token(Token = "0x402D70C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadRuneData;

		// Token: 0x0402D70D RID: 186125
		[Token(Token = "0x402D70D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadCommentData;
	}
}
