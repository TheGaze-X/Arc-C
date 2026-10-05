using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005918 RID: 22808
	[Token(Token = "0x2005918")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CrisisV2Util
	{
		// Token: 0x060213C7 RID: 136135 RVA: 0x000B9058 File Offset: 0x000B7258
		[Token(Token = "0x60213C7")]
		[Address(RVA = "0x1B9A4F0", Offset = "0x1B990F0", VA = "0x181B9A4F0")]
		public static bool IsDimensionValid(int dimension)
		{
			return default(bool);
		}

		// Token: 0x060213C8 RID: 136136 RVA: 0x000B9070 File Offset: 0x000B7270
		[Token(Token = "0x60213C8")]
		[Address(RVA = "0x1B98930", Offset = "0x1B97530", VA = "0x181B98930")]
		public static float GetBagJumpPos(CrisisV2BagPosData posData)
		{
			return 0f;
		}

		// Token: 0x060213C9 RID: 136137 RVA: 0x000B9088 File Offset: 0x000B7288
		[Token(Token = "0x60213C9")]
		[Address(RVA = "0x1B99040", Offset = "0x1B97C40", VA = "0x181B99040")]
		public static float GetNodeJumpPos(CrisisV2NodePosData posData)
		{
			return 0f;
		}

		// Token: 0x060213CA RID: 136138 RVA: 0x000B90A0 File Offset: 0x000B72A0
		[Token(Token = "0x60213CA")]
		[Address(RVA = "0x1B9A560", Offset = "0x1B99160", VA = "0x181B9A560")]
		public static bool IsInSeason()
		{
			return default(bool);
		}

		// Token: 0x060213CB RID: 136139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213CB")]
		[Address(RVA = "0x1B989B0", Offset = "0x1B975B0", VA = "0x181B989B0")]
		public static CrisisV2SeasonAtlasResHolder GetCrisisV2SeasonAtlasResHolder(string seasonId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060213CC RID: 136140 RVA: 0x000B90B8 File Offset: 0x000B72B8
		[Token(Token = "0x60213CC")]
		[Address(RVA = "0x1B987B0", Offset = "0x1B973B0", VA = "0x181B987B0")]
		public static bool CheckCrisisV2Avail(string seasonId, out string textToast)
		{
			return default(bool);
		}

		// Token: 0x060213CD RID: 136141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213CD")]
		[Address(RVA = "0x1B98BE0", Offset = "0x1B977E0", VA = "0x181B98BE0")]
		public static CrisisV2LongTermResHolder GetCrisisV2SeasonLongTermResHolder(string seasonId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060213CE RID: 136142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213CE")]
		[Address(RVA = "0x1B995E0", Offset = "0x1B981E0", VA = "0x181B995E0")]
		public static string GetRuneDescription(RuneTable.PackedRuneData packedRuneData)
		{
			return null;
		}

		// Token: 0x060213CF RID: 136143 RVA: 0x000B90D0 File Offset: 0x000B72D0
		[Token(Token = "0x60213CF")]
		[Address(RVA = "0x1B994A0", Offset = "0x1B980A0", VA = "0x181B994A0")]
		public static CrisisV2AppraiseType GetRankByScore(int scoreTotal, ListDict<int, CrisisV2AppraiseWrap> scoreToAppraiseDataMap)
		{
			return CrisisV2AppraiseType.RANK_D;
		}

		// Token: 0x060213D0 RID: 136144 RVA: 0x000B90E8 File Offset: 0x000B72E8
		[Token(Token = "0x60213D0")]
		[Address(RVA = "0x1B99300", Offset = "0x1B97F00", VA = "0x181B99300")]
		public static int GetPermanentMapTotalScore(string seasonId)
		{
			return 0;
		}

		// Token: 0x060213D1 RID: 136145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213D1")]
		[Address(RVA = "0x1B990B0", Offset = "0x1B97CB0", VA = "0x181B990B0")]
		public static List<int> GetPermanentMapTotalScoreList(string seasonId)
		{
			return null;
		}

		// Token: 0x060213D2 RID: 136146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213D2")]
		[Address(RVA = "0x1B98E10", Offset = "0x1B97A10", VA = "0x181B98E10")]
		public static List<int> GetMapMaxScoreList(string mapId)
		{
			return null;
		}

		// Token: 0x060213D3 RID: 136147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213D3")]
		[Address(RVA = "0x1B99CC0", Offset = "0x1B988C0", VA = "0x181B99CC0")]
		public static void IfMapHaveMissionReward(string mapId, out bool hasReward, out bool allGet)
		{
		}

		// Token: 0x060213D4 RID: 136148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213D4")]
		[Address(RVA = "0x1B9A980", Offset = "0x1B99580", VA = "0x181B9A980")]
		public static Sprite LoadRankIconFromSpriteHub(CrisisV2AppraiseType rankType, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060213D5 RID: 136149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213D5")]
		[Address(RVA = "0x1B98690", Offset = "0x1B97290", VA = "0x181B98690")]
		public static Sprite BattleFinishOnly_LoadRankIconFromSpriteHub(CrisisV2AppraiseType rankType)
		{
			return null;
		}

		// Token: 0x060213D6 RID: 136150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213D6")]
		[Address(RVA = "0x1B98740", Offset = "0x1B97340", VA = "0x181B98740")]
		public static Sprite BattleFinishOnly_LoadRuneIconFromSpriteHub(string runeIconId)
		{
			return null;
		}

		// Token: 0x060213D7 RID: 136151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213D7")]
		[Address(RVA = "0x1B98540", Offset = "0x1B97140", VA = "0x181B98540")]
		public static CrisisV2LongTermResHolder BattleFinishOnly_GetCrisisV2SeasonLongTermResHolder(string seasonId)
		{
			return null;
		}

		// Token: 0x060213D8 RID: 136152 RVA: 0x000B9100 File Offset: 0x000B7300
		[Token(Token = "0x60213D8")]
		[Address(RVA = "0x1B9A600", Offset = "0x1B99200", VA = "0x181B9A600")]
		public static SpriteRenderData LoadBagDimension(UIAtlasObject atlas, int dimension, bool isDaily)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060213D9 RID: 136153 RVA: 0x000B9118 File Offset: 0x000B7318
		[Token(Token = "0x60213D9")]
		[Address(RVA = "0x1B9A730", Offset = "0x1B99330", VA = "0x181B9A730")]
		public static SpriteRenderData LoadCommonDimensionIcon(UIAtlasObject atlas, int dimension, bool isDaily)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x060213DA RID: 136154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213DA")]
		[Address(RVA = "0x1B9A900", Offset = "0x1B99500", VA = "0x181B9A900")]
		public static Sprite LoadCrisisV2StageLogo(string stageLogoId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060213DB RID: 136155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213DB")]
		[Address(RVA = "0x1B9AA50", Offset = "0x1B99650", VA = "0x181B9AA50")]
		public static Sprite LoadRuneIconFromSpriteHub(string runeIconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060213DC RID: 136156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213DC")]
		[Address(RVA = "0x1B9A880", Offset = "0x1B99480", VA = "0x181B9A880")]
		public static Sprite LoadCrisisV2AreaBg(string bgId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060213DD RID: 136157 RVA: 0x000B9130 File Offset: 0x000B7330
		[Token(Token = "0x60213DD")]
		[Address(RVA = "0x1B99AB0", Offset = "0x1B986B0", VA = "0x181B99AB0")]
		public static CrisisV2EntryViewModel.TempState GetTempState(string seasonId, string mapId, long currentDate)
		{
			return CrisisV2EntryViewModel.TempState.NOTOPEN;
		}

		// Token: 0x060213DE RID: 136158 RVA: 0x000B9148 File Offset: 0x000B7348
		[Token(Token = "0x60213DE")]
		[Address(RVA = "0x1B998F0", Offset = "0x1B984F0", VA = "0x181B998F0")]
		public static CrisisV2ZoneEntryTempState GetStageTempState(string seasonId, string mapId, long currentDate)
		{
			return CrisisV2ZoneEntryTempState.INREWARD;
		}

		// Token: 0x060213DF RID: 136159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213DF")]
		[Address(RVA = "0x1B9AAD0", Offset = "0x1B996D0", VA = "0x181B9AAD0")]
		private static Sprite _LoadFromAutoPackSpriteHub(string hubPath, string spriteId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0402D432 RID: 185394
		[Token(Token = "0x402D432")]
		private const CrisisV2AppraiseType DEFAULT_APPRAISE_TYPE = CrisisV2AppraiseType.RANK_D;

		// Token: 0x0402D433 RID: 185395
		[Token(Token = "0x402D433")]
		private const float NODE_JUMP_POS_OFFSET = 50f;

		// Token: 0x0402D434 RID: 185396
		[Token(Token = "0x402D434")]
		private const string BAG_DIMENSION_ICON_FORMAT_STR = "icon_bag_dimension_{0}";

		// Token: 0x0402D435 RID: 185397
		[Token(Token = "0x402D435")]
		private const string BAG_DIMENSION_ICON_DAILY = "icon_bag_dimension_daily";

		// Token: 0x0402D436 RID: 185398
		[Token(Token = "0x402D436")]
		private const string DEFAULT_DIMENSION_ICON = "icon_common_dimension_default";

		// Token: 0x0402D437 RID: 185399
		[Token(Token = "0x402D437")]
		private const string DAILY_DIMENSION_ICON = "icon_common_dimension_daily";

		// Token: 0x0402D438 RID: 185400
		[Token(Token = "0x402D438")]
		private const string COMMON_DIMENSION_FORMAT_STR = "icon_common_dimension_{0}";

		// Token: 0x0402D439 RID: 185401
		[Token(Token = "0x402D439")]
		public const int UNRECORDED_TOTAL_SCORE = -1;

		// Token: 0x0402D43A RID: 185402
		[Token(Token = "0x402D43A")]
		public const int DIMENSION_COUNT = 6;

		// Token: 0x0402D43B RID: 185403
		[Token(Token = "0x402D43B")]
		public const string RANK_ICON_NAME_PREFIX = "appraise_{0}";

		// Token: 0x0402D43C RID: 185404
		[Token(Token = "0x402D43C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsDimensionValid;

		// Token: 0x0402D43D RID: 185405
		[Token(Token = "0x402D43D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBagJumpPos;

		// Token: 0x0402D43E RID: 185406
		[Token(Token = "0x402D43E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetNodeJumpPos;

		// Token: 0x0402D43F RID: 185407
		[Token(Token = "0x402D43F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsInSeason;

		// Token: 0x0402D440 RID: 185408
		[Token(Token = "0x402D440")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCrisisV2SeasonAtlasResHolder;

		// Token: 0x0402D441 RID: 185409
		[Token(Token = "0x402D441")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckCrisisV2Avail;

		// Token: 0x0402D442 RID: 185410
		[Token(Token = "0x402D442")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCrisisV2SeasonLongTermResHolder;

		// Token: 0x0402D443 RID: 185411
		[Token(Token = "0x402D443")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetRuneDescription;

		// Token: 0x0402D444 RID: 185412
		[Token(Token = "0x402D444")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetRankByScore;

		// Token: 0x0402D445 RID: 185413
		[Token(Token = "0x402D445")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetPermanentMapTotalScore;

		// Token: 0x0402D446 RID: 185414
		[Token(Token = "0x402D446")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetPermanentMapTotalScoreList;

		// Token: 0x0402D447 RID: 185415
		[Token(Token = "0x402D447")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetMapMaxScoreList;

		// Token: 0x0402D448 RID: 185416
		[Token(Token = "0x402D448")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_IfMapHaveMissionReward;

		// Token: 0x0402D449 RID: 185417
		[Token(Token = "0x402D449")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadRankIconFromSpriteHub;

		// Token: 0x0402D44A RID: 185418
		[Token(Token = "0x402D44A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_BattleFinishOnly_LoadRankIconFromSpriteHub;

		// Token: 0x0402D44B RID: 185419
		[Token(Token = "0x402D44B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_BattleFinishOnly_LoadRuneIconFromSpriteHub;

		// Token: 0x0402D44C RID: 185420
		[Token(Token = "0x402D44C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_BattleFinishOnly_GetCrisisV2SeasonLongTermResHolder;

		// Token: 0x0402D44D RID: 185421
		[Token(Token = "0x402D44D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadBagDimension;

		// Token: 0x0402D44E RID: 185422
		[Token(Token = "0x402D44E")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadCommonDimensionIcon;

		// Token: 0x0402D44F RID: 185423
		[Token(Token = "0x402D44F")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LoadCrisisV2StageLogo;

		// Token: 0x0402D450 RID: 185424
		[Token(Token = "0x402D450")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadRuneIconFromSpriteHub;

		// Token: 0x0402D451 RID: 185425
		[Token(Token = "0x402D451")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadCrisisV2AreaBg;

		// Token: 0x0402D452 RID: 185426
		[Token(Token = "0x402D452")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetTempState;

		// Token: 0x0402D453 RID: 185427
		[Token(Token = "0x402D453")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetStageTempState;

		// Token: 0x0402D454 RID: 185428
		[Token(Token = "0x402D454")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__LoadFromAutoPackSpriteHub;
	}
}
