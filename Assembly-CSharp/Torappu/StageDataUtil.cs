using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.Battle;
using Torappu.UI;
using Torappu.UI.EnemyHandBook;
using Torappu.UI.Stage;
using Torappu.UI.Stage.MixStory;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02001442 RID: 5186
	[Token(Token = "0x2001442")]
	[LuaCallCSharp(GenFlag.No)]
	[Hotfix(HotfixFlag.Stateless)]
	public static class StageDataUtil
	{
		// Token: 0x060077EF RID: 30703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077EF")]
		[Address(RVA = "0x2545CF0", Offset = "0x25448F0", VA = "0x182545CF0")]
		public static Sprite LoadStagePreviewMap(string stageId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060077F0 RID: 30704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077F0")]
		[Address(RVA = "0x2545AD0", Offset = "0x25446D0", VA = "0x182545AD0")]
		public static Sprite LoadSpecialSizeStagePreviewMap(string stageId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060077F1 RID: 30705 RVA: 0x00035D30 File Offset: 0x00033F30
		[Token(Token = "0x60077F1")]
		[Address(RVA = "0x2543630", Offset = "0x2542230", VA = "0x182543630")]
		public static Vector2 GetProperSizeForSpecialStagePreview(Vector2 spriteRectSize, Vector2 bound)
		{
			return default(Vector2);
		}

		// Token: 0x060077F2 RID: 30706 RVA: 0x00035D48 File Offset: 0x00033F48
		[Token(Token = "0x60077F2")]
		[Address(RVA = "0x2544860", Offset = "0x2543460", VA = "0x182544860")]
		public static ZoneViewType GetZoneViewTypeByZoneType(ZoneType zoneType)
		{
			return ZoneViewType.NONE;
		}

		// Token: 0x060077F3 RID: 30707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077F3")]
		[Address(RVA = "0x2544930", Offset = "0x2543530", VA = "0x182544930")]
		public static string GetZoneViewTypeTrackId(ZoneViewType viewType)
		{
			return null;
		}

		// Token: 0x060077F4 RID: 30708 RVA: 0x00035D60 File Offset: 0x00033F60
		[Token(Token = "0x60077F4")]
		[Address(RVA = "0x254AB00", Offset = "0x2549700", VA = "0x18254AB00")]
		private static int _GetSortIndex(ZoneData zoneData, ZoneViewType type)
		{
			return 0;
		}

		// Token: 0x060077F5 RID: 30709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077F5")]
		[Address(RVA = "0x25450C0", Offset = "0x2543CC0", VA = "0x1825450C0")]
		public static IEnumerator<ActivityThemeData> LoadAvailThemeData(ActivityThemeType type)
		{
			return null;
		}

		// Token: 0x060077F6 RID: 30710 RVA: 0x00035D78 File Offset: 0x00033F78
		[Token(Token = "0x60077F6")]
		[Address(RVA = "0x2541440", Offset = "0x2540040", VA = "0x182541440")]
		public static bool CheckIfZoneValid(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x060077F7 RID: 30711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077F7")]
		[Address(RVA = "0x2545EE0", Offset = "0x2544AE0", VA = "0x182545EE0")]
		public static ListDict<string, StageViewModel> LoadStageViewModelDict(IEnumerator<KeyValuePair<string, StageData>> stageDataIter, out bool haveUnlock, out string availTimelyDrop)
		{
			return null;
		}

		// Token: 0x060077F8 RID: 30712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077F8")]
		[Address(RVA = "0x25462C0", Offset = "0x2544EC0", VA = "0x1825462C0")]
		public static StageViewModel LoadStageViewModel(StageData stageData, StageViewModel.LocalCache localCache, StageViewModel.TimelyDropOptions timelyDropInfo)
		{
			return null;
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x00035D90 File Offset: 0x00033F90
		[Token(Token = "0x60077F9")]
		[Address(RVA = "0x2540370", Offset = "0x253EF70", VA = "0x182540370")]
		public static bool CheckIfPlayerStageAvail(string stageId)
		{
			return default(bool);
		}

		// Token: 0x060077FA RID: 30714 RVA: 0x00035DA8 File Offset: 0x00033FA8
		[Token(Token = "0x60077FA")]
		[Address(RVA = "0x2546E10", Offset = "0x2545A10", VA = "0x182546E10")]
		public static bool TryGetAvailStage(string stageId, out PlayerStage playerStageInfo)
		{
			return default(bool);
		}

		// Token: 0x060077FB RID: 30715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077FB")]
		[Address(RVA = "0x254A300", Offset = "0x2548F00", VA = "0x18254A300")]
		private static string _GetAntiSpoilerId(string zoneId)
		{
			return null;
		}

		// Token: 0x060077FC RID: 30716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077FC")]
		[Address(RVA = "0x254D4D0", Offset = "0x254C0D0", VA = "0x18254D4D0")]
		private static void _SetAntiSpoilerChecked(string zoneId)
		{
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x00035DC0 File Offset: 0x00033FC0
		[Token(Token = "0x60077FD")]
		[Address(RVA = "0x2549460", Offset = "0x2548060", VA = "0x182549460")]
		private static bool _CheckIfNeedToAntiSpoiler(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x00035DD8 File Offset: 0x00033FD8
		[Token(Token = "0x60077FE")]
		[Address(RVA = "0x2548CA0", Offset = "0x25478A0", VA = "0x182548CA0")]
		public static bool WrapJumpToStageWithAntiSpoiler(string stageId, Action<string> toStage)
		{
			return default(bool);
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x00035DF0 File Offset: 0x00033FF0
		[Token(Token = "0x60077FF")]
		[Address(RVA = "0x2548DF0", Offset = "0x25479F0", VA = "0x182548DF0")]
		public static bool WrapJumpToZoneWithAntiSpoiler(string zoneId, Action<string> toZone)
		{
			return default(bool);
		}

		// Token: 0x06007800 RID: 30720 RVA: 0x00035E08 File Offset: 0x00034008
		[Token(Token = "0x6007800")]
		[Address(RVA = "0x254D580", Offset = "0x254C180", VA = "0x18254D580")]
		private static bool _ShowAntiSpoilerDialog(string zoneId, Action onPositive)
		{
			return default(bool);
		}

		// Token: 0x06007801 RID: 30721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007801")]
		[Address(RVA = "0x2546590", Offset = "0x2545190", VA = "0x182546590")]
		public static ListDict<ZoneViewType, ZoneGroupViewModel> LoadZonesView(ref Dictionary<string, ZoneViewModel> zoneModels)
		{
			return null;
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007802")]
		[Address(RVA = "0x254B2E0", Offset = "0x2549EE0", VA = "0x18254B2E0")]
		private static ListDict<ZoneViewType, ZoneGroupViewModel> _LoadZonesViewImpl(ref Dictionary<string, ZoneViewModel> zoneModels)
		{
			return null;
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007803")]
		[Address(RVA = "0x254AF30", Offset = "0x2549B30", VA = "0x18254AF30")]
		private static void _LoadSixStarStageLinkedInfo(Dictionary<string, ZoneViewModel> zoneModels)
		{
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x00035E20 File Offset: 0x00034020
		[Token(Token = "0x6007804")]
		[Address(RVA = "0x2547120", Offset = "0x2545D20", VA = "0x182547120")]
		public static bool TryGetOverrideDropAvailCount(string overrideBuffId, out int remainCount)
		{
			return default(bool);
		}

		// Token: 0x06007805 RID: 30725 RVA: 0x00035E38 File Offset: 0x00034038
		[Token(Token = "0x6007805")]
		[Address(RVA = "0x2541A50", Offset = "0x2540650", VA = "0x182541A50")]
		public static bool CheckOverrideDropAvail(OverrideDropInfo dropInfo)
		{
			return default(bool);
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x00035E50 File Offset: 0x00034050
		[Token(Token = "0x6007806")]
		[Address(RVA = "0x2543F90", Offset = "0x2542B90", VA = "0x182543F90")]
		public static int GetStageApCost(StageViewModel stageViewModel, int multipleBattleTimes = 1)
		{
			return 0;
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007807")]
		[Address(RVA = "0x25423D0", Offset = "0x2540FD0", VA = "0x1825423D0")]
		public static StageDiffGroupTable FindStageDiffGroup(string stageId)
		{
			return null;
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007808")]
		[Address(RVA = "0x25428F0", Offset = "0x25414F0", VA = "0x1825428F0")]
		public static StageData GetChapterEndStageData(string chapterId, List<ChapterViewModel> chapterInfoList)
		{
			return null;
		}

		// Token: 0x06007809 RID: 30729 RVA: 0x00035E68 File Offset: 0x00034068
		[Token(Token = "0x6007809")]
		[Address(RVA = "0x2547340", Offset = "0x2545F40", VA = "0x182547340")]
		public static bool TryGetOverrideDropInfo(string zoneId, string stageId, out OverrideDropInfo overrideDropInfo, out StageData.StageDropInfo dropInfo)
		{
			return default(bool);
		}

		// Token: 0x0600780A RID: 30730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600780A")]
		[Address(RVA = "0x253FD50", Offset = "0x253E950", VA = "0x18253FD50")]
		public static void CalcTotalStar(List<string> stageList, out int totalStar, out int maxStar)
		{
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x00035E80 File Offset: 0x00034080
		[Token(Token = "0x600780B")]
		[Address(RVA = "0x25424A0", Offset = "0x25410A0", VA = "0x1825424A0")]
		public static StageViewModel.TimelyDropOptions FindValidTimelyDrop()
		{
			return default(StageViewModel.TimelyDropOptions);
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x00035E98 File Offset: 0x00034098
		[Token(Token = "0x600780C")]
		[Address(RVA = "0x2544D60", Offset = "0x2543960", VA = "0x182544D60")]
		public static bool IsWeeklyOnActive()
		{
			return default(bool);
		}

		// Token: 0x0600780D RID: 30733 RVA: 0x00035EB0 File Offset: 0x000340B0
		[Token(Token = "0x600780D")]
		[Address(RVA = "0x2548610", Offset = "0x2547210", VA = "0x182548610")]
		public static WeekStruct<ZoneOpenDetailState> WeeklyZoneOpenInfo(string zoneId)
		{
			return default(WeekStruct<ZoneOpenDetailState>);
		}

		// Token: 0x0600780E RID: 30734 RVA: 0x00035EC8 File Offset: 0x000340C8
		[Token(Token = "0x600780E")]
		[Address(RVA = "0x2548160", Offset = "0x2546D60", VA = "0x182548160")]
		private static WeekStruct<ZoneOpenDetailState> WeeklyZoneOpenInfoFullOpenPostProcess(DateTime currentTime, WeekStruct<ZoneOpenDetailState> weekStruct)
		{
			return default(WeekStruct<ZoneOpenDetailState>);
		}

		// Token: 0x0600780F RID: 30735 RVA: 0x00035EE0 File Offset: 0x000340E0
		[Token(Token = "0x600780F")]
		[Address(RVA = "0x254A7A0", Offset = "0x25493A0", VA = "0x18254A7A0")]
		private static int _GetOpenServerFullOpenRemainDays()
		{
			return 0;
		}

		// Token: 0x06007810 RID: 30736 RVA: 0x00035EF8 File Offset: 0x000340F8
		[Token(Token = "0x6007810")]
		[Address(RVA = "0x254A3E0", Offset = "0x2548FE0", VA = "0x18254A3E0")]
		private static int _GetBackFlowFullOpenRemainDays()
		{
			return 0;
		}

		// Token: 0x06007811 RID: 30737 RVA: 0x00035F10 File Offset: 0x00034110
		[Token(Token = "0x6007811")]
		[Address(RVA = "0x254DCF0", Offset = "0x254C8F0", VA = "0x18254DCF0")]
		private static WeekStruct<ZoneOpenDetailState> _WeeklyZoneOpenInfoPostProcessWithRemainDay(int remainDays, DateTime currentTime, WeekStruct<ZoneOpenDetailState> weekStruct)
		{
			return default(WeekStruct<ZoneOpenDetailState>);
		}

		// Token: 0x06007812 RID: 30738 RVA: 0x00035F28 File Offset: 0x00034128
		[Token(Token = "0x6007812")]
		[Address(RVA = "0x2544F40", Offset = "0x2543B40", VA = "0x182544F40")]
		public static bool IsWeeklyZoneOpen(WeekStruct<ZoneOpenDetailState> openInfo, DateTime time)
		{
			return default(bool);
		}

		// Token: 0x06007813 RID: 30739 RVA: 0x00035F40 File Offset: 0x00034140
		[Token(Token = "0x6007813")]
		[Address(RVA = "0x2541150", Offset = "0x253FD50", VA = "0x182541150")]
		public static bool CheckIfWeeklyStage(string stageId, out StageData stageData)
		{
			return default(bool);
		}

		// Token: 0x06007814 RID: 30740 RVA: 0x00035F58 File Offset: 0x00034158
		[Token(Token = "0x6007814")]
		[Address(RVA = "0x25406A0", Offset = "0x253F2A0", VA = "0x1825406A0")]
		public static bool CheckIfStageAvailable(string stageId, out string errorAlert)
		{
			return default(bool);
		}

		// Token: 0x06007815 RID: 30741 RVA: 0x00035F70 File Offset: 0x00034170
		[Token(Token = "0x6007815")]
		[Address(RVA = "0x2547750", Offset = "0x2546350", VA = "0x182547750")]
		public static bool TryGetRetroLinkedAvailAct(string retroId, long curTs, out ActivityTable.BasicData basicDataOutput)
		{
			return default(bool);
		}

		// Token: 0x06007816 RID: 30742 RVA: 0x00035F88 File Offset: 0x00034188
		[Token(Token = "0x6007816")]
		[Address(RVA = "0x2541AD0", Offset = "0x25406D0", VA = "0x182541AD0")]
		public static bool CheckRetroLinkedActStageValid(string retroId, long curTs)
		{
			return default(bool);
		}

		// Token: 0x06007817 RID: 30743 RVA: 0x00035FA0 File Offset: 0x000341A0
		[Token(Token = "0x6007817")]
		[Address(RVA = "0x25497A0", Offset = "0x25483A0", VA = "0x1825497A0")]
		private static bool _CheckIfWeeklyAvailable(string zoneId, out string errorAlert)
		{
			return default(bool);
		}

		// Token: 0x06007818 RID: 30744 RVA: 0x00035FB8 File Offset: 0x000341B8
		[Token(Token = "0x6007818")]
		[Address(RVA = "0x25465F0", Offset = "0x25451F0", VA = "0x1825465F0")]
		public static bool QueryPlayerHardLevel()
		{
			return default(bool);
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007819")]
		[Address(RVA = "0x2542E50", Offset = "0x2541A50", VA = "0x182542E50")]
		public static StageData GetMainStageProgress()
		{
			return null;
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x00035FD0 File Offset: 0x000341D0
		[Token(Token = "0x600781A")]
		[Address(RVA = "0x2542210", Offset = "0x2540E10", VA = "0x182542210")]
		public static StageId ConvertStageId(string stageId)
		{
			return default(StageId);
		}

		// Token: 0x0600781B RID: 30747 RVA: 0x00035FE8 File Offset: 0x000341E8
		[Token(Token = "0x600781B")]
		[Address(RVA = "0x2542180", Offset = "0x2540D80", VA = "0x182542180")]
		public static bool CheckStageUnlockRequireMainlineNotification(StageData stageData)
		{
			return default(bool);
		}

		// Token: 0x0600781C RID: 30748 RVA: 0x00036000 File Offset: 0x00034200
		[Token(Token = "0x600781C")]
		[Address(RVA = "0x2544480", Offset = "0x2543080", VA = "0x182544480")]
		public static int GetStageRank(string stageId)
		{
			return 0;
		}

		// Token: 0x0600781D RID: 30749 RVA: 0x00036018 File Offset: 0x00034218
		[Token(Token = "0x600781D")]
		[Address(RVA = "0x254A6D0", Offset = "0x25492D0", VA = "0x18254A6D0")]
		private static bool _GetHardStageRank(string hardStageId, out int rank)
		{
			return default(bool);
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x00036030 File Offset: 0x00034230
		[Token(Token = "0x600781E")]
		[Address(RVA = "0x254A980", Offset = "0x2549580", VA = "0x18254A980")]
		private static bool _GetSixStarStageRank(string sixStarStageId, out int rank)
		{
			return default(bool);
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x00036048 File Offset: 0x00034248
		[Token(Token = "0x600781F")]
		[Address(RVA = "0x2543B50", Offset = "0x2542750", VA = "0x182543B50")]
		public static int GetSixStarStageRank(string stageId, LevelData.Difficulty stageDifficulty)
		{
			return 0;
		}

		// Token: 0x06007820 RID: 30752 RVA: 0x00036060 File Offset: 0x00034260
		[Token(Token = "0x6007820")]
		[Address(RVA = "0x2543AC0", Offset = "0x25426C0", VA = "0x182543AC0")]
		public static SpecialStageType GetSelectStageDefaultStatus(string zoneId)
		{
			return SpecialStageType.NORMAL;
		}

		// Token: 0x06007821 RID: 30753 RVA: 0x00036078 File Offset: 0x00034278
		[Token(Token = "0x6007821")]
		public static bool CheckStageMapType<StageMapType>(ZoneType type, string zoneId)
		{
			return default(bool);
		}

		// Token: 0x06007822 RID: 30754 RVA: 0x00036090 File Offset: 0x00034290
		[Token(Token = "0x6007822")]
		[Address(RVA = "0x2542030", Offset = "0x2540C30", VA = "0x182542030")]
		public static bool CheckStageMapType(Type stageMapType, ZoneType type)
		{
			return default(bool);
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x000360A8 File Offset: 0x000342A8
		[Token(Token = "0x6007823")]
		[Address(RVA = "0x2541F00", Offset = "0x2540B00", VA = "0x182541F00")]
		public static bool CheckStageCustomZoneContainer(ZoneType type, string zoneId)
		{
			return default(bool);
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007824")]
		[Address(RVA = "0x25440A0", Offset = "0x2542CA0", VA = "0x1825440A0")]
		public static string GetStageCustomZoneContainerPath(ZoneType type, string zoneId)
		{
			return null;
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x000360C0 File Offset: 0x000342C0
		[Token(Token = "0x6007825")]
		[Address(RVA = "0x2544CF0", Offset = "0x25438F0", VA = "0x182544CF0")]
		public static bool IsWeeklyFuncUnlocked(WeeklyType weeklyType)
		{
			return default(bool);
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x000360D8 File Offset: 0x000342D8
		[Token(Token = "0x6007826")]
		[Address(RVA = "0x2544C00", Offset = "0x2543800", VA = "0x182544C00")]
		public static bool IsCampaignFuncUnlocked()
		{
			return default(bool);
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x000360F0 File Offset: 0x000342F0
		[Token(Token = "0x6007827")]
		[Address(RVA = "0x2544C60", Offset = "0x2543860", VA = "0x182544C60")]
		public static bool IsCampaignStageOpen(string campaignStageId)
		{
			return default(bool);
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x00036108 File Offset: 0x00034308
		[Token(Token = "0x6007828")]
		[Address(RVA = "0x25449A0", Offset = "0x25435A0", VA = "0x1825449A0")]
		public static bool HasOpenCampaigns(IList<string> campaignStageIds)
		{
			return default(bool);
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x00036120 File Offset: 0x00034320
		[Token(Token = "0x6007829")]
		[Address(RVA = "0x2546DA0", Offset = "0x25459A0", VA = "0x182546DA0")]
		public static bool TryGetActiveCampaignGroup(out CampaignGroupData groupData)
		{
			return default(bool);
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x00036138 File Offset: 0x00034338
		[Token(Token = "0x600782A")]
		[Address(RVA = "0x2546F60", Offset = "0x2545B60", VA = "0x182546F60")]
		public static bool TryGetCampaignStage(string stageId, bool checkActive, bool logErrorIfNotFound, out CampaignData campData)
		{
			return default(bool);
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600782B")]
		[Address(RVA = "0x254A150", Offset = "0x2548D50", VA = "0x18254A150")]
		private static CampaignGroupData _GetActiveCampaignGroup()
		{
			return null;
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600782C")]
		[Address(RVA = "0x2544650", Offset = "0x2543250", VA = "0x182544650")]
		public static string GetWeeklyTypeName()
		{
			return null;
		}

		// Token: 0x0600782D RID: 30765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600782D")]
		[Address(RVA = "0x2542AE0", Offset = "0x25416E0", VA = "0x182542AE0")]
		public static string GetDiffName(StageDiffGroup diff, bool isShort)
		{
			return null;
		}

		// Token: 0x0600782E RID: 30766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600782E")]
		[Address(RVA = "0x2542C70", Offset = "0x2541870", VA = "0x182542C70")]
		public static string GetDropJumpName(StageData stageData, bool isShort)
		{
			return null;
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x00036150 File Offset: 0x00034350
		[Token(Token = "0x600782F")]
		[Address(RVA = "0x254A840", Offset = "0x2549440", VA = "0x18254A840")]
		private static bool _GetSixStarDropJumpName(StageData stageData, out string jumpName)
		{
			return default(bool);
		}

		// Token: 0x06007830 RID: 30768 RVA: 0x00036168 File Offset: 0x00034368
		[Token(Token = "0x6007830")]
		[Address(RVA = "0x254A490", Offset = "0x2549090", VA = "0x18254A490")]
		private static bool _GetDiffDropJumpName(StageData stageData, bool isShort, out string jumpName)
		{
			return default(bool);
		}

		// Token: 0x06007831 RID: 30769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007831")]
		private static T _CheckAndLoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06007832 RID: 30770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007832")]
		[Address(RVA = "0x25446D0", Offset = "0x25432D0", VA = "0x1825446D0")]
		public static string GetZoneMapAssetPath(string zoneId)
		{
			return null;
		}

		// Token: 0x06007833 RID: 30771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007833")]
		[Address(RVA = "0x2548F30", Offset = "0x2547B30", VA = "0x182548F30")]
		public static void WriteLastPlayedStageToLocalCache(string zoneId, string stageId, StageDiffGroup diffGroup = StageDiffGroup.NONE)
		{
		}

		// Token: 0x06007834 RID: 30772 RVA: 0x00036180 File Offset: 0x00034380
		[Token(Token = "0x6007834")]
		[Address(RVA = "0x25443E0", Offset = "0x2542FE0", VA = "0x1825443E0")]
		public static PlayerStageState GetStagePlayerState(string stageId)
		{
			return PlayerStageState.UNLOCKED;
		}

		// Token: 0x06007835 RID: 30773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007835")]
		[Address(RVA = "0x2542FF0", Offset = "0x2541BF0", VA = "0x182542FF0")]
		public static StageData GetMainlinePreposedStageData(string zoneId)
		{
			return null;
		}

		// Token: 0x06007836 RID: 30774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007836")]
		[Address(RVA = "0x2542EF0", Offset = "0x2541AF0", VA = "0x182542EF0")]
		public static StageData GetMainlineAndRetroPreposedStageData(string zoneId)
		{
			return null;
		}

		// Token: 0x06007837 RID: 30775 RVA: 0x00036198 File Offset: 0x00034398
		[Token(Token = "0x6007837")]
		[Address(RVA = "0x2541680", Offset = "0x2540280", VA = "0x182541680")]
		public static bool CheckMainlineRecapIdExist(string zoneId, out string recapId)
		{
			return default(bool);
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007838")]
		[Address(RVA = "0x2543310", Offset = "0x2541F10", VA = "0x182543310")]
		public static MainlineZoneData GetMainlineZoneData(string zoneId)
		{
			return null;
		}

		// Token: 0x06007839 RID: 30777 RVA: 0x000361B0 File Offset: 0x000343B0
		[Token(Token = "0x6007839")]
		[Address(RVA = "0x25417C0", Offset = "0x25403C0", VA = "0x1825417C0")]
		public static bool CheckMainlineRecapSpoilerPassed(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x0600783A RID: 30778 RVA: 0x000361C8 File Offset: 0x000343C8
		[Token(Token = "0x600783A")]
		[Address(RVA = "0x2541900", Offset = "0x2540500", VA = "0x182541900")]
		public static bool CheckMainlineRecapSpolierNeedToShow(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x0600783B RID: 30779 RVA: 0x000361E0 File Offset: 0x000343E0
		[Token(Token = "0x600783B")]
		[Address(RVA = "0x2541570", Offset = "0x2540170", VA = "0x182541570")]
		public static bool CheckIsCampaign(string stageId)
		{
			return default(bool);
		}

		// Token: 0x0600783C RID: 30780 RVA: 0x000361F8 File Offset: 0x000343F8
		[Token(Token = "0x600783C")]
		[Address(RVA = "0x2541600", Offset = "0x2540200", VA = "0x182541600")]
		public static bool CheckIsPerformance(string stageId)
		{
			return default(bool);
		}

		// Token: 0x0600783D RID: 30781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600783D")]
		[Address(RVA = "0x2544320", Offset = "0x2542F20", VA = "0x182544320")]
		public static StageData GetStageOrNull(string stageId)
		{
			return null;
		}

		// Token: 0x0600783E RID: 30782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600783E")]
		[Address(RVA = "0x2544180", Offset = "0x2542D80", VA = "0x182544180")]
		public static StageData GetStageIgnoreTime(string stageId)
		{
			return null;
		}

		// Token: 0x0600783F RID: 30783 RVA: 0x00036210 File Offset: 0x00034410
		[Token(Token = "0x600783F")]
		[Address(RVA = "0x2547930", Offset = "0x2546530", VA = "0x182547930")]
		public static bool TryGetStageIgnoreTime(string stageId, out StageData stageData)
		{
			return default(bool);
		}

		// Token: 0x06007840 RID: 30784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007840")]
		[Address(RVA = "0x2544280", Offset = "0x2542E80", VA = "0x182544280")]
		public static StageData GetStageOrNull(string stageId, long curTs)
		{
			return null;
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x00036228 File Offset: 0x00034428
		[Token(Token = "0x6007841")]
		[Address(RVA = "0x2547AE0", Offset = "0x25466E0", VA = "0x182547AE0")]
		public static bool TryGetStage(string stageId, long curTs, out StageData stageData)
		{
			return default(bool);
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x00036240 File Offset: 0x00034440
		[Token(Token = "0x6007842")]
		[Address(RVA = "0x2547A40", Offset = "0x2546640", VA = "0x182547A40")]
		public static bool TryGetStageWrapper(string stageId, long curTs, out StageDataUtil.StageDataWrapper dataWrapper)
		{
			return default(bool);
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x00036258 File Offset: 0x00034458
		[Token(Token = "0x6007843")]
		[Address(RVA = "0x254DA20", Offset = "0x254C620", VA = "0x18254DA20")]
		public static bool _TryGetStageImpl(string stageId, long curTs, out StageDataUtil.StageDataWrapper dataWrapper)
		{
			return default(bool);
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007844")]
		[Address(RVA = "0x2547FC0", Offset = "0x2546BC0", VA = "0x182547FC0")]
		public static IEnumerator<KeyValuePair<string, StageData>> ValidStageEnumerator(long curTs)
		{
			return null;
		}

		// Token: 0x06007845 RID: 30789 RVA: 0x00036270 File Offset: 0x00034470
		[Token(Token = "0x6007845")]
		[Address(RVA = "0x2541C50", Offset = "0x2540850", VA = "0x182541C50")]
		public static bool CheckRetroRewardAvailFlag(RetroTrailData trailData, int currentCount = -1)
		{
			return default(bool);
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007846")]
		[Address(RVA = "0x25437E0", Offset = "0x25423E0", VA = "0x1825437E0")]
		public static void GetRetroTrailStatus(RetroTrailData trailData, int currentCount, out bool hasAvailReward, out bool complete)
		{
		}

		// Token: 0x06007847 RID: 30791 RVA: 0x00036288 File Offset: 0x00034488
		[Token(Token = "0x6007847")]
		[Address(RVA = "0x2541B80", Offset = "0x2540780", VA = "0x182541B80")]
		public static bool CheckRetroNewFlag(SideStoryViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x000362A0 File Offset: 0x000344A0
		[Token(Token = "0x6007848")]
		[Address(RVA = "0x2540DF0", Offset = "0x253F9F0", VA = "0x182540DF0")]
		public static bool CheckIfStageUnlocked(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x000362B8 File Offset: 0x000344B8
		[Token(Token = "0x6007849")]
		[Address(RVA = "0x2540C30", Offset = "0x253F830", VA = "0x182540C30")]
		public static bool CheckIfStageFogPrevStageUnlocked(StageFogInfo fogInfo)
		{
			return default(bool);
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x000362D0 File Offset: 0x000344D0
		[Token(Token = "0x600784A")]
		[Address(RVA = "0x2549DE0", Offset = "0x25489E0", VA = "0x182549DE0")]
		private static bool _CheckStageFogPrevStageUnlockImpl(StageFogInfo fogInfo)
		{
			return default(bool);
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x000362E8 File Offset: 0x000344E8
		[Token(Token = "0x600784B")]
		[Address(RVA = "0x2540B70", Offset = "0x253F770", VA = "0x182540B70")]
		public static bool CheckIfStageFogPrevStagePassed(StageFogInfo fogInfo)
		{
			return default(bool);
		}

		// Token: 0x0600784C RID: 30796 RVA: 0x00036300 File Offset: 0x00034500
		[Token(Token = "0x600784C")]
		[Address(RVA = "0x2549D50", Offset = "0x2548950", VA = "0x182549D50")]
		private static bool _CheckStageFogPrevStagePassedImpl(StageFogInfo fogInfo)
		{
			return default(bool);
		}

		// Token: 0x0600784D RID: 30797 RVA: 0x00036318 File Offset: 0x00034518
		[Token(Token = "0x600784D")]
		[Address(RVA = "0x2540B00", Offset = "0x253F700", VA = "0x182540B00")]
		public static bool CheckIfStageFogPrevFogUnlocked(StageFogInfo fogInfo)
		{
			return default(bool);
		}

		// Token: 0x0600784E RID: 30798 RVA: 0x00036330 File Offset: 0x00034530
		[Token(Token = "0x600784E")]
		[Address(RVA = "0x2549C70", Offset = "0x2548870", VA = "0x182549C70")]
		private static bool _CheckStageFogPrevFogUnlockedImpl(StageFogInfo fogInfo)
		{
			return default(bool);
		}

		// Token: 0x0600784F RID: 30799 RVA: 0x00036348 File Offset: 0x00034548
		[Token(Token = "0x600784F")]
		[Address(RVA = "0x2540A20", Offset = "0x253F620", VA = "0x182540A20")]
		public static bool CheckIfStageFogPrevAllUnlocked(StageFogInfo fogInfo)
		{
			return default(bool);
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007850")]
		[Address(RVA = "0x2543BF0", Offset = "0x25427F0", VA = "0x182543BF0")]
		public static string GetSquadHomePluginAssetPath(string stageId, bool isRetro)
		{
			return null;
		}

		// Token: 0x06007851 RID: 30801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007851")]
		[Address(RVA = "0x254AC70", Offset = "0x2549870", VA = "0x18254AC70")]
		private static string _GetSquadHomePluginAssetPathForActivity(StageData stageData)
		{
			return null;
		}

		// Token: 0x06007852 RID: 30802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007852")]
		[Address(RVA = "0x254AD90", Offset = "0x2549990", VA = "0x18254AD90")]
		private static string _GetSquadHomePluginAssetPathForRetro(StageData stageData)
		{
			return null;
		}

		// Token: 0x06007853 RID: 30803 RVA: 0x00036360 File Offset: 0x00034560
		[Token(Token = "0x6007853")]
		[Address(RVA = "0x2549630", Offset = "0x2548230", VA = "0x182549630")]
		private static bool _CheckIfRetroHasSquadPlugin(string retroId)
		{
			return default(bool);
		}

		// Token: 0x06007854 RID: 30804 RVA: 0x00036378 File Offset: 0x00034578
		[Token(Token = "0x6007854")]
		[Address(RVA = "0x2546900", Offset = "0x2545500", VA = "0x182546900")]
		public static bool StageCanUseCharm(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06007855 RID: 30805 RVA: 0x00036390 File Offset: 0x00034590
		[Token(Token = "0x6007855")]
		[Address(RVA = "0x2546980", Offset = "0x2545580", VA = "0x182546980")]
		public static bool StageCanUseFirework(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06007856 RID: 30806 RVA: 0x000363A8 File Offset: 0x000345A8
		[Token(Token = "0x6007856")]
		[Address(RVA = "0x2546A00", Offset = "0x2545600", VA = "0x182546A00")]
		public static bool StageCanUseTech(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06007857 RID: 30807 RVA: 0x000363C0 File Offset: 0x000345C0
		[Token(Token = "0x6007857")]
		[Address(RVA = "0x2546A80", Offset = "0x2545680", VA = "0x182546A80")]
		public static bool StageCanUseTrapTool(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06007858 RID: 30808 RVA: 0x000363D8 File Offset: 0x000345D8
		[Token(Token = "0x6007858")]
		[Address(RVA = "0x2540CF0", Offset = "0x253F8F0", VA = "0x182540CF0")]
		public static bool CheckIfStageGameModeNeedOverride(string stageId, out GameModeMeta.GameModeType gameMode)
		{
			return default(bool);
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x000363F0 File Offset: 0x000345F0
		[Token(Token = "0x6007859")]
		[Address(RVA = "0x2546880", Offset = "0x2545480", VA = "0x182546880")]
		public static bool StageCanUseBattlePerformance(string stageId)
		{
			return default(bool);
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x00036408 File Offset: 0x00034608
		[Token(Token = "0x600785A")]
		[Address(RVA = "0x2540490", Offset = "0x253F090", VA = "0x182540490")]
		public static bool CheckIfRetroHasTrail(string retroId, long curTs)
		{
			return default(bool);
		}

		// Token: 0x0600785B RID: 30811 RVA: 0x00036420 File Offset: 0x00034620
		[Token(Token = "0x600785B")]
		[Address(RVA = "0x25405D0", Offset = "0x253F1D0", VA = "0x1825405D0")]
		public static bool CheckIfRetroHasTrail(RetroActData retroActData, long curTs)
		{
			return default(bool);
		}

		// Token: 0x0600785C RID: 30812 RVA: 0x00036438 File Offset: 0x00034638
		[Token(Token = "0x600785C")]
		[Address(RVA = "0x2549700", Offset = "0x2548300", VA = "0x182549700")]
		private static bool _CheckIfRetroHasTrailImpl(RetroActData retroActData, long curTs)
		{
			return default(bool);
		}

		// Token: 0x0600785D RID: 30813 RVA: 0x00036450 File Offset: 0x00034650
		[Token(Token = "0x600785D")]
		[Address(RVA = "0x25412C0", Offset = "0x253FEC0", VA = "0x1825412C0")]
		public static bool CheckIfZoneHasApProtect(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x0600785E RID: 30814 RVA: 0x00036468 File Offset: 0x00034668
		[Token(Token = "0x600785E")]
		[Address(RVA = "0x2547BC0", Offset = "0x25467C0", VA = "0x182547BC0")]
		public static bool TryTriggerRecapAvg(string zoneId, [Optional] string stageId)
		{
			return default(bool);
		}

		// Token: 0x0600785F RID: 30815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600785F")]
		[Address(RVA = "0x2549A90", Offset = "0x2548690", VA = "0x182549A90")]
		private static void _CheckSpoiler(string zoneId, string recapId, string stageId)
		{
		}

		// Token: 0x06007860 RID: 30816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007860")]
		[Address(RVA = "0x254D790", Offset = "0x254C390", VA = "0x18254D790")]
		private static void _TriggerRecapAvgWithSpoiler(string zoneId, string recapId, string stageId)
		{
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007861")]
		[Address(RVA = "0x254D260", Offset = "0x254BE60", VA = "0x18254D260")]
		private static void _PlayRecapAvg(string zoneId, string recapId, string stageId)
		{
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007862")]
		[Address(RVA = "0x2549F10", Offset = "0x2548B10", VA = "0x182549F10")]
		private static void _FinishRecapAVG(string zoneId, string recapId, string stageId)
		{
		}

		// Token: 0x06007863 RID: 30819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007863")]
		[Address(RVA = "0x2549E70", Offset = "0x2548A70", VA = "0x182549E70")]
		private static void _FinishAVGAndCommit(string storyId, Action<Story.StoryOutPut> proceedCallBack)
		{
		}

		// Token: 0x06007864 RID: 30820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007864")]
		[Address(RVA = "0x2546B00", Offset = "0x2545700", VA = "0x182546B00")]
		public static void StartAVGAndBackToZoneMap(StoryData targetStory, string zoneId, [Optional] string stageId)
		{
		}

		// Token: 0x06007865 RID: 30821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007865")]
		[Address(RVA = "0x2546C50", Offset = "0x2545850", VA = "0x182546C50")]
		public static void StartAVGAndBackToZoneSelect(StoryData targetStory, string zoneId)
		{
		}

		// Token: 0x06007866 RID: 30822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007866")]
		[Address(RVA = "0x25433F0", Offset = "0x2541FF0", VA = "0x1825433F0")]
		public static PlayerHiddenStage GetPlayerHiddenStageData(string stageId)
		{
			return null;
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x00036480 File Offset: 0x00034680
		[Token(Token = "0x6007867")]
		[Address(RVA = "0x253FFD0", Offset = "0x253EBD0", VA = "0x18253FFD0")]
		public static bool CheckHiddenStageEntryShow(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x00036498 File Offset: 0x00034698
		[Token(Token = "0x6007868")]
		[Address(RVA = "0x2540080", Offset = "0x253EC80", VA = "0x182540080")]
		public static bool CheckHiddenStageTrackPoint(string stageId)
		{
			return default(bool);
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007869")]
		[Address(RVA = "0x2545670", Offset = "0x2544270", VA = "0x182545670")]
		public static List<EnemyHandBookEverViewModel> LoadEnemyHandbook(string stageId, bool unlockAll = false)
		{
			return null;
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600786A")]
		[Address(RVA = "0x2545160", Offset = "0x2543D60", VA = "0x182545160")]
		public static List<EnemyHandBookEverViewModel> LoadEnemyHandbookAllOpenByLevelId(string levelId, bool allOpen = true)
		{
			return null;
		}

		// Token: 0x0600786B RID: 30827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600786B")]
		[Address(RVA = "0x25453A0", Offset = "0x2543FA0", VA = "0x1825453A0")]
		public static List<EnemyHandBookEverViewModel> LoadEnemyHandbookByEnemyId(List<string> enemyList, bool isAlwaysOpen)
		{
			return null;
		}

		// Token: 0x0600786C RID: 30828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600786C")]
		[Address(RVA = "0x2542810", Offset = "0x2541410", VA = "0x182542810")]
		public static string GetActivityCustomZoneMapHolderAssetPath(ZoneType zoneType, string zoneId)
		{
			return null;
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600786D")]
		[Address(RVA = "0x2543550", Offset = "0x2542150", VA = "0x182543550")]
		public static IPreviewConfigViewModelPlugin GetPreviewConfigViewModelPlugin(StageViewModel stageModel, IStageSelectHandler selectStageHandler)
		{
			return null;
		}

		// Token: 0x040075A1 RID: 30113
		[Token(Token = "0x40075A1")]
		private const string DROP_JUMP_NAME_FORMAT = "{0} {1}";

		// Token: 0x040075A2 RID: 30114
		[Token(Token = "0x40075A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadStagePreviewMap;

		// Token: 0x040075A3 RID: 30115
		[Token(Token = "0x40075A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadSpecialSizeStagePreviewMap;

		// Token: 0x040075A4 RID: 30116
		[Token(Token = "0x40075A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetProperSizeForSpecialStagePreview;

		// Token: 0x040075A5 RID: 30117
		[Token(Token = "0x40075A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetZoneViewTypeByZoneType;

		// Token: 0x040075A6 RID: 30118
		[Token(Token = "0x40075A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetZoneViewTypeTrackId;

		// Token: 0x040075A7 RID: 30119
		[Token(Token = "0x40075A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetSortIndex;

		// Token: 0x040075A8 RID: 30120
		[Token(Token = "0x40075A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadAvailThemeData;

		// Token: 0x040075A9 RID: 30121
		[Token(Token = "0x40075A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfZoneValid;

		// Token: 0x040075AA RID: 30122
		[Token(Token = "0x40075AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadStageViewModelDict;

		// Token: 0x040075AB RID: 30123
		[Token(Token = "0x40075AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadStageViewModel;

		// Token: 0x040075AC RID: 30124
		[Token(Token = "0x40075AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfPlayerStageAvail;

		// Token: 0x040075AD RID: 30125
		[Token(Token = "0x40075AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TryGetAvailStage;

		// Token: 0x040075AE RID: 30126
		[Token(Token = "0x40075AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetAntiSpoilerId;

		// Token: 0x040075AF RID: 30127
		[Token(Token = "0x40075AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SetAntiSpoilerChecked;

		// Token: 0x040075B0 RID: 30128
		[Token(Token = "0x40075B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckIfNeedToAntiSpoiler;

		// Token: 0x040075B1 RID: 30129
		[Token(Token = "0x40075B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_WrapJumpToStageWithAntiSpoiler;

		// Token: 0x040075B2 RID: 30130
		[Token(Token = "0x40075B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_WrapJumpToZoneWithAntiSpoiler;

		// Token: 0x040075B3 RID: 30131
		[Token(Token = "0x40075B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ShowAntiSpoilerDialog;

		// Token: 0x040075B4 RID: 30132
		[Token(Token = "0x40075B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadZonesView;

		// Token: 0x040075B5 RID: 30133
		[Token(Token = "0x40075B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__LoadZonesViewImpl;

		// Token: 0x040075B6 RID: 30134
		[Token(Token = "0x40075B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__LoadSixStarStageLinkedInfo;

		// Token: 0x040075B7 RID: 30135
		[Token(Token = "0x40075B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_TryGetOverrideDropAvailCount;

		// Token: 0x040075B8 RID: 30136
		[Token(Token = "0x40075B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CheckOverrideDropAvail;

		// Token: 0x040075B9 RID: 30137
		[Token(Token = "0x40075B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetStageApCost;

		// Token: 0x040075BA RID: 30138
		[Token(Token = "0x40075BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_FindStageDiffGroup;

		// Token: 0x040075BB RID: 30139
		[Token(Token = "0x40075BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetChapterEndStageData;

		// Token: 0x040075BC RID: 30140
		[Token(Token = "0x40075BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_TryGetOverrideDropInfo;

		// Token: 0x040075BD RID: 30141
		[Token(Token = "0x40075BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CalcTotalStar;

		// Token: 0x040075BE RID: 30142
		[Token(Token = "0x40075BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_FindValidTimelyDrop;

		// Token: 0x040075BF RID: 30143
		[Token(Token = "0x40075BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_IsWeeklyOnActive;

		// Token: 0x040075C0 RID: 30144
		[Token(Token = "0x40075C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_WeeklyZoneOpenInfo;

		// Token: 0x040075C1 RID: 30145
		[Token(Token = "0x40075C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_WeeklyZoneOpenInfoFullOpenPostProcess;

		// Token: 0x040075C2 RID: 30146
		[Token(Token = "0x40075C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__GetOpenServerFullOpenRemainDays;

		// Token: 0x040075C3 RID: 30147
		[Token(Token = "0x40075C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__GetBackFlowFullOpenRemainDays;

		// Token: 0x040075C4 RID: 30148
		[Token(Token = "0x40075C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__WeeklyZoneOpenInfoPostProcessWithRemainDay;

		// Token: 0x040075C5 RID: 30149
		[Token(Token = "0x40075C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_IsWeeklyZoneOpen;

		// Token: 0x040075C6 RID: 30150
		[Token(Token = "0x40075C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CheckIfWeeklyStage;

		// Token: 0x040075C7 RID: 30151
		[Token(Token = "0x40075C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_CheckIfStageAvailable;

		// Token: 0x040075C8 RID: 30152
		[Token(Token = "0x40075C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_TryGetRetroLinkedAvailAct;

		// Token: 0x040075C9 RID: 30153
		[Token(Token = "0x40075C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_CheckRetroLinkedActStageValid;

		// Token: 0x040075CA RID: 30154
		[Token(Token = "0x40075CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__CheckIfWeeklyAvailable;

		// Token: 0x040075CB RID: 30155
		[Token(Token = "0x40075CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_QueryPlayerHardLevel;

		// Token: 0x040075CC RID: 30156
		[Token(Token = "0x40075CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_GetMainStageProgress;

		// Token: 0x040075CD RID: 30157
		[Token(Token = "0x40075CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_ConvertStageId;

		// Token: 0x040075CE RID: 30158
		[Token(Token = "0x40075CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_CheckStageUnlockRequireMainlineNotification;

		// Token: 0x040075CF RID: 30159
		[Token(Token = "0x40075CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_GetStageRank;

		// Token: 0x040075D0 RID: 30160
		[Token(Token = "0x40075D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__GetHardStageRank;

		// Token: 0x040075D1 RID: 30161
		[Token(Token = "0x40075D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__GetSixStarStageRank;

		// Token: 0x040075D2 RID: 30162
		[Token(Token = "0x40075D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_GetSixStarStageRank;

		// Token: 0x040075D3 RID: 30163
		[Token(Token = "0x40075D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_GetSelectStageDefaultStatus;

		// Token: 0x040075D4 RID: 30164
		[Token(Token = "0x40075D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_CheckStageMapType;

		// Token: 0x040075D5 RID: 30165
		[Token(Token = "0x40075D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix1_CheckStageMapType;

		// Token: 0x040075D6 RID: 30166
		[Token(Token = "0x40075D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_CheckStageCustomZoneContainer;

		// Token: 0x040075D7 RID: 30167
		[Token(Token = "0x40075D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_GetStageCustomZoneContainerPath;

		// Token: 0x040075D8 RID: 30168
		[Token(Token = "0x40075D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_IsWeeklyFuncUnlocked;

		// Token: 0x040075D9 RID: 30169
		[Token(Token = "0x40075D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_IsCampaignFuncUnlocked;

		// Token: 0x040075DA RID: 30170
		[Token(Token = "0x40075DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_IsCampaignStageOpen;

		// Token: 0x040075DB RID: 30171
		[Token(Token = "0x40075DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_HasOpenCampaigns;

		// Token: 0x040075DC RID: 30172
		[Token(Token = "0x40075DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_TryGetActiveCampaignGroup;

		// Token: 0x040075DD RID: 30173
		[Token(Token = "0x40075DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_TryGetCampaignStage;

		// Token: 0x040075DE RID: 30174
		[Token(Token = "0x40075DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__GetActiveCampaignGroup;

		// Token: 0x040075DF RID: 30175
		[Token(Token = "0x40075DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_GetWeeklyTypeName;

		// Token: 0x040075E0 RID: 30176
		[Token(Token = "0x40075E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_GetDiffName;

		// Token: 0x040075E1 RID: 30177
		[Token(Token = "0x40075E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_GetDropJumpName;

		// Token: 0x040075E2 RID: 30178
		[Token(Token = "0x40075E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__GetSixStarDropJumpName;

		// Token: 0x040075E3 RID: 30179
		[Token(Token = "0x40075E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__GetDiffDropJumpName;

		// Token: 0x040075E4 RID: 30180
		[Token(Token = "0x40075E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__CheckAndLoadAsset;

		// Token: 0x040075E5 RID: 30181
		[Token(Token = "0x40075E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_GetZoneMapAssetPath;

		// Token: 0x040075E6 RID: 30182
		[Token(Token = "0x40075E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_WriteLastPlayedStageToLocalCache;

		// Token: 0x040075E7 RID: 30183
		[Token(Token = "0x40075E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_GetStagePlayerState;

		// Token: 0x040075E8 RID: 30184
		[Token(Token = "0x40075E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_GetMainlinePreposedStageData;

		// Token: 0x040075E9 RID: 30185
		[Token(Token = "0x40075E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_GetMainlineAndRetroPreposedStageData;

		// Token: 0x040075EA RID: 30186
		[Token(Token = "0x40075EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_CheckMainlineRecapIdExist;

		// Token: 0x040075EB RID: 30187
		[Token(Token = "0x40075EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_GetMainlineZoneData;

		// Token: 0x040075EC RID: 30188
		[Token(Token = "0x40075EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_CheckMainlineRecapSpoilerPassed;

		// Token: 0x040075ED RID: 30189
		[Token(Token = "0x40075ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_CheckMainlineRecapSpolierNeedToShow;

		// Token: 0x040075EE RID: 30190
		[Token(Token = "0x40075EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_CheckIsCampaign;

		// Token: 0x040075EF RID: 30191
		[Token(Token = "0x40075EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_CheckIsPerformance;

		// Token: 0x040075F0 RID: 30192
		[Token(Token = "0x40075F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_GetStageOrNull;

		// Token: 0x040075F1 RID: 30193
		[Token(Token = "0x40075F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_GetStageIgnoreTime;

		// Token: 0x040075F2 RID: 30194
		[Token(Token = "0x40075F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_TryGetStageIgnoreTime;

		// Token: 0x040075F3 RID: 30195
		[Token(Token = "0x40075F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix1_GetStageOrNull;

		// Token: 0x040075F4 RID: 30196
		[Token(Token = "0x40075F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_TryGetStage;

		// Token: 0x040075F5 RID: 30197
		[Token(Token = "0x40075F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_TryGetStageWrapper;

		// Token: 0x040075F6 RID: 30198
		[Token(Token = "0x40075F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0__TryGetStageImpl;

		// Token: 0x040075F7 RID: 30199
		[Token(Token = "0x40075F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_ValidStageEnumerator;

		// Token: 0x040075F8 RID: 30200
		[Token(Token = "0x40075F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_CheckRetroRewardAvailFlag;

		// Token: 0x040075F9 RID: 30201
		[Token(Token = "0x40075F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_GetRetroTrailStatus;

		// Token: 0x040075FA RID: 30202
		[Token(Token = "0x40075FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_CheckRetroNewFlag;

		// Token: 0x040075FB RID: 30203
		[Token(Token = "0x40075FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_CheckIfStageUnlocked;

		// Token: 0x040075FC RID: 30204
		[Token(Token = "0x40075FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_CheckIfStageFogPrevStageUnlocked;

		// Token: 0x040075FD RID: 30205
		[Token(Token = "0x40075FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0__CheckStageFogPrevStageUnlockImpl;

		// Token: 0x040075FE RID: 30206
		[Token(Token = "0x40075FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_CheckIfStageFogPrevStagePassed;

		// Token: 0x040075FF RID: 30207
		[Token(Token = "0x40075FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0__CheckStageFogPrevStagePassedImpl;

		// Token: 0x04007600 RID: 30208
		[Token(Token = "0x4007600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_CheckIfStageFogPrevFogUnlocked;

		// Token: 0x04007601 RID: 30209
		[Token(Token = "0x4007601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0__CheckStageFogPrevFogUnlockedImpl;

		// Token: 0x04007602 RID: 30210
		[Token(Token = "0x4007602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_CheckIfStageFogPrevAllUnlocked;

		// Token: 0x04007603 RID: 30211
		[Token(Token = "0x4007603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_GetSquadHomePluginAssetPath;

		// Token: 0x04007604 RID: 30212
		[Token(Token = "0x4007604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0__GetSquadHomePluginAssetPathForActivity;

		// Token: 0x04007605 RID: 30213
		[Token(Token = "0x4007605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0__GetSquadHomePluginAssetPathForRetro;

		// Token: 0x04007606 RID: 30214
		[Token(Token = "0x4007606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0__CheckIfRetroHasSquadPlugin;

		// Token: 0x04007607 RID: 30215
		[Token(Token = "0x4007607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_StageCanUseCharm;

		// Token: 0x04007608 RID: 30216
		[Token(Token = "0x4007608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_StageCanUseFirework;

		// Token: 0x04007609 RID: 30217
		[Token(Token = "0x4007609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_StageCanUseTech;

		// Token: 0x0400760A RID: 30218
		[Token(Token = "0x400760A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_StageCanUseTrapTool;

		// Token: 0x0400760B RID: 30219
		[Token(Token = "0x400760B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_CheckIfStageGameModeNeedOverride;

		// Token: 0x0400760C RID: 30220
		[Token(Token = "0x400760C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_StageCanUseBattlePerformance;

		// Token: 0x0400760D RID: 30221
		[Token(Token = "0x400760D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_CheckIfRetroHasTrail;

		// Token: 0x0400760E RID: 30222
		[Token(Token = "0x400760E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix1_CheckIfRetroHasTrail;

		// Token: 0x0400760F RID: 30223
		[Token(Token = "0x400760F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0__CheckIfRetroHasTrailImpl;

		// Token: 0x04007610 RID: 30224
		[Token(Token = "0x4007610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_CheckIfZoneHasApProtect;

		// Token: 0x04007611 RID: 30225
		[Token(Token = "0x4007611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_TryTriggerRecapAvg;

		// Token: 0x04007612 RID: 30226
		[Token(Token = "0x4007612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0__CheckSpoiler;

		// Token: 0x04007613 RID: 30227
		[Token(Token = "0x4007613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0__TriggerRecapAvgWithSpoiler;

		// Token: 0x04007614 RID: 30228
		[Token(Token = "0x4007614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0__PlayRecapAvg;

		// Token: 0x04007615 RID: 30229
		[Token(Token = "0x4007615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0__FinishRecapAVG;

		// Token: 0x04007616 RID: 30230
		[Token(Token = "0x4007616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0__FinishAVGAndCommit;

		// Token: 0x04007617 RID: 30231
		[Token(Token = "0x4007617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_StartAVGAndBackToZoneMap;

		// Token: 0x04007618 RID: 30232
		[Token(Token = "0x4007618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0_StartAVGAndBackToZoneSelect;

		// Token: 0x04007619 RID: 30233
		[Token(Token = "0x4007619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_GetPlayerHiddenStageData;

		// Token: 0x0400761A RID: 30234
		[Token(Token = "0x400761A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_CheckHiddenStageEntryShow;

		// Token: 0x0400761B RID: 30235
		[Token(Token = "0x400761B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_CheckHiddenStageTrackPoint;

		// Token: 0x0400761C RID: 30236
		[Token(Token = "0x400761C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0_LoadEnemyHandbook;

		// Token: 0x0400761D RID: 30237
		[Token(Token = "0x400761D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_LoadEnemyHandbookAllOpenByLevelId;

		// Token: 0x0400761E RID: 30238
		[Token(Token = "0x400761E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0_LoadEnemyHandbookByEnemyId;

		// Token: 0x0400761F RID: 30239
		[Token(Token = "0x400761F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_GetActivityCustomZoneMapHolderAssetPath;

		// Token: 0x04007620 RID: 30240
		[Token(Token = "0x4007620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0_GetPreviewConfigViewModelPlugin;

		// Token: 0x02001443 RID: 5187
		[Token(Token = "0x2001443")]
		public enum StageDataSource
		{
			// Token: 0x04007622 RID: 30242
			[Token(Token = "0x4007622")]
			NONE,
			// Token: 0x04007623 RID: 30243
			[Token(Token = "0x4007623")]
			STAGE_DB,
			// Token: 0x04007624 RID: 30244
			[Token(Token = "0x4007624")]
			RETRO_DB
		}

		// Token: 0x02001444 RID: 5188
		[Token(Token = "0x2001444")]
		public struct StageDataWrapper
		{
			// Token: 0x0600786E RID: 30830 RVA: 0x000364B0 File Offset: 0x000346B0
			[Token(Token = "0x600786E")]
			[Address(RVA = "0x1E424B0", Offset = "0x1E410B0", VA = "0x181E424B0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0600786F RID: 30831 RVA: 0x000364C8 File Offset: 0x000346C8
			[Token(Token = "0x600786F")]
			[Address(RVA = "0x254DFD0", Offset = "0x254CBD0", VA = "0x18254DFD0")]
			public bool IsFromRetro()
			{
				return default(bool);
			}

			// Token: 0x06007870 RID: 30832 RVA: 0x000364E0 File Offset: 0x000346E0
			[Token(Token = "0x6007870")]
			[Address(RVA = "0x254DF70", Offset = "0x254CB70", VA = "0x18254DF70")]
			public bool IsFromActRetro()
			{
				return default(bool);
			}

			// Token: 0x04007625 RID: 30245
			[Token(Token = "0x4007625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly StageDataUtil.StageDataWrapper EMPTY;

			// Token: 0x04007626 RID: 30246
			[Token(Token = "0x4007626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public StageData data;

			// Token: 0x04007627 RID: 30247
			[Token(Token = "0x4007627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public StageDataUtil.StageDataSource source;
		}
	}
}
