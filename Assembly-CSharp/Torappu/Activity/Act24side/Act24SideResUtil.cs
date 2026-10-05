using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Gacha;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007540 RID: 30016
	[Token(Token = "0x2007540")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act24SideResUtil
	{
		// Token: 0x0602A48B RID: 173195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A48B")]
		[Address(RVA = "0x25F16F0", Offset = "0x25F02F0", VA = "0x1825F16F0")]
		public static Act24SideData GetAct24SideData(string actId)
		{
			return null;
		}

		// Token: 0x0602A48C RID: 173196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A48C")]
		[Address(RVA = "0x25F1D10", Offset = "0x25F0910", VA = "0x1825F1D10")]
		public static Sprite LoadMeldingIcon(string iconId, string actId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A48D RID: 173197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A48D")]
		[Address(RVA = "0x25F1C60", Offset = "0x25F0860", VA = "0x1825F1C60")]
		public static Sprite LoadMeldingIconSmall(string iconId, string actId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A48E RID: 173198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A48E")]
		[Address(RVA = "0x25F1BC0", Offset = "0x25F07C0", VA = "0x1825F1BC0")]
		public static Sprite LoadMeldingIconBg(string iconId, string actId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A48F RID: 173199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A48F")]
		[Address(RVA = "0x25F29D0", Offset = "0x25F15D0", VA = "0x1825F29D0")]
		private static Sprite _LoadMeldingSprite(string spriteId, string actId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A490 RID: 173200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A490")]
		[Address(RVA = "0x25F0C50", Offset = "0x25EF850", VA = "0x1825F0C50")]
		public static Sprite BattleFinishOnly_LoadMeldingIcon(string iconId, string actId)
		{
			return null;
		}

		// Token: 0x0602A491 RID: 173201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A491")]
		[Address(RVA = "0x25F0BC0", Offset = "0x25EF7C0", VA = "0x1825F0BC0")]
		public static Sprite BattleFinishOnly_LoadMeldingIconSmall(string iconId, string actId)
		{
			return null;
		}

		// Token: 0x0602A492 RID: 173202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A492")]
		[Address(RVA = "0x25F0B40", Offset = "0x25EF740", VA = "0x1825F0B40")]
		public static Sprite BattleFinishOnly_LoadMeldingIconBg(string iconId, string actId)
		{
			return null;
		}

		// Token: 0x0602A493 RID: 173203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A493")]
		[Address(RVA = "0x25F2430", Offset = "0x25F1030", VA = "0x1825F2430")]
		private static Sprite _BattleFinishOnly_LoadMeldingSprite(string spriteId, string actId)
		{
			return null;
		}

		// Token: 0x0602A494 RID: 173204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A494")]
		[Address(RVA = "0x25F17C0", Offset = "0x25F03C0", VA = "0x1825F17C0")]
		public static string GetLastSelectQuest(string actId)
		{
			return null;
		}

		// Token: 0x0602A495 RID: 173205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A495")]
		[Address(RVA = "0x25F21D0", Offset = "0x25F0DD0", VA = "0x1825F21D0")]
		public static void SaveLastSelectQuest(string actId, string questId)
		{
		}

		// Token: 0x0602A496 RID: 173206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A496")]
		[Address(RVA = "0x25F18D0", Offset = "0x25F04D0", VA = "0x1825F18D0")]
		public static string GetTrackType(string actId)
		{
			return null;
		}

		// Token: 0x0602A497 RID: 173207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A497")]
		[Address(RVA = "0x25F1860", Offset = "0x25F0460", VA = "0x1825F1860")]
		public static string GetStageNewFlagId(string stageId)
		{
			return null;
		}

		// Token: 0x0602A498 RID: 173208 RVA: 0x000D7EE0 File Offset: 0x000D60E0
		[Token(Token = "0x602A498")]
		[Address(RVA = "0x25F0E90", Offset = "0x25EFA90", VA = "0x1825F0E90")]
		public static bool CheckQuestStageNewFlag(string actId, string stageId)
		{
			return default(bool);
		}

		// Token: 0x0602A499 RID: 173209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A499")]
		[Address(RVA = "0x25F1050", Offset = "0x25EFC50", VA = "0x1825F1050")]
		public static void ConsumeQuestStageNewFlag(string actId, string stageId)
		{
		}

		// Token: 0x0602A49A RID: 173210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A49A")]
		[Address(RVA = "0x25F1130", Offset = "0x25EFD30", VA = "0x1825F1130")]
		public static void GenerateMeldingRewardPreviewList(List<Act24sideMeldingSmallItemViewModel> meldingList, string actId, string stageId, PlayerStageState stageState)
		{
		}

		// Token: 0x0602A49B RID: 173211 RVA: 0x000D7EF8 File Offset: 0x000D60F8
		[Token(Token = "0x602A49B")]
		[Address(RVA = "0x25F19C0", Offset = "0x25F05C0", VA = "0x1825F19C0")]
		public static bool IsRewardVisible(PlayerStageState stageState, bool isOnce, bool isComplete)
		{
			return default(bool);
		}

		// Token: 0x0602A49C RID: 173212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A49C")]
		[Address(RVA = "0x25F1A70", Offset = "0x25F0670", VA = "0x1825F1A70")]
		public static Sprite LoadMealIcon(string mealId, string actId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A49D RID: 173213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A49D")]
		[Address(RVA = "0x25F1B10", Offset = "0x25F0710", VA = "0x1825F1B10")]
		public static Sprite LoadMealNameImage(string mealId, string actId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A49E RID: 173214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A49E")]
		[Address(RVA = "0x25F2880", Offset = "0x25F1480", VA = "0x1825F2880")]
		private static Sprite _LoadMealSprite(string spriteId, string actId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A49F RID: 173215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A49F")]
		[Address(RVA = "0x25F2060", Offset = "0x25F0C60", VA = "0x1825F2060")]
		public static Sprite LoadToolIcon(string iconId, string actId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A4A0 RID: 173216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A4A0")]
		[Address(RVA = "0x25F1F00", Offset = "0x25F0B00", VA = "0x1825F1F00")]
		public static Sprite LoadToolIconBg(string iconId, string actId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A4A1 RID: 173217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A4A1")]
		[Address(RVA = "0x25F1FB0", Offset = "0x25F0BB0", VA = "0x1825F1FB0")]
		public static Sprite LoadToolIconDec(string iconId, string actId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A4A2 RID: 173218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A4A2")]
		[Address(RVA = "0x25F2B20", Offset = "0x25F1720", VA = "0x1825F2B20")]
		private static Sprite _LoadToolSprite(string spriteId, string actId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A4A3 RID: 173219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A4A3")]
		[Address(RVA = "0x25F1DB0", Offset = "0x25F09B0", VA = "0x1825F1DB0")]
		public static Sprite LoadMissionSprite(string spriteId, string actId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A4A4 RID: 173220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4A4")]
		[Address(RVA = "0x25F2100", Offset = "0x25F0D00", VA = "0x1825F2100")]
		public static void LogBattleTrapNewUnlock(string actId, string relicId)
		{
		}

		// Token: 0x0602A4A5 RID: 173221 RVA: 0x000D7F10 File Offset: 0x000D6110
		[Token(Token = "0x602A4A5")]
		[Address(RVA = "0x25F0DA0", Offset = "0x25EF9A0", VA = "0x1825F0DA0")]
		public static bool CheckHasBattleTrapNewUnlockTrack(string actId, List<string> battleTrapIdList)
		{
			return default(bool);
		}

		// Token: 0x0602A4A6 RID: 173222 RVA: 0x000D7F28 File Offset: 0x000D6128
		[Token(Token = "0x602A4A6")]
		[Address(RVA = "0x25F0CD0", Offset = "0x25EF8D0", VA = "0x1825F0CD0")]
		public static bool CheckBattleTrapNewUnlockTrack(string actId, string battleTrapId)
		{
			return default(bool);
		}

		// Token: 0x0602A4A7 RID: 173223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4A7")]
		[Address(RVA = "0x25F0F80", Offset = "0x25EFB80", VA = "0x1825F0F80")]
		public static void ConsumeBattleTrapNewUnlockTrack(string actId, string battleTrapId)
		{
		}

		// Token: 0x0602A4A8 RID: 173224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A4A8")]
		[Address(RVA = "0x25F2590", Offset = "0x25F1190", VA = "0x1825F2590")]
		private static string _GenBattleTrapTrackKey(string actId, string battleTrapId)
		{
			return null;
		}

		// Token: 0x0602A4A9 RID: 173225 RVA: 0x000D7F40 File Offset: 0x000D6140
		[Token(Token = "0x602A4A9")]
		[Address(RVA = "0x25F1940", Offset = "0x25F0540", VA = "0x1825F1940")]
		public static bool IsEntryNoteUnwatched(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602A4AA RID: 173226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4AA")]
		[Address(RVA = "0x25F2260", Offset = "0x25F0E60", VA = "0x1825F2260")]
		public static void SetEntryNoteWatched(string actId)
		{
		}

		// Token: 0x0602A4AB RID: 173227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A4AB")]
		[Address(RVA = "0x25F22E0", Offset = "0x25F0EE0", VA = "0x1825F22E0")]
		public static IEnumerator ShowGainedItemsWithPossibleGachasAhead(List<RewardItemModel> itemGets, GameObject disableTarget, GachaController.PlayMode gachaPlayMode, bool isSkippable, Action onBeforeItemShow, string actId, bool shouldMergeItems = true)
		{
			return null;
		}

		// Token: 0x0602A4AC RID: 173228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4AC")]
		[Address(RVA = "0x25F3060", Offset = "0x25F1C60", VA = "0x1825F3060")]
		private static void _ShowGainedItems(List<UIItemViewModel> itemViewModels, string actId)
		{
		}

		// Token: 0x0602A4AD RID: 173229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A4AD")]
		[Address(RVA = "0x25F2F70", Offset = "0x25F1B70", VA = "0x1825F2F70")]
		private static IEnumerator _ShowGainedItemsRelatedChar(GachaResult charGet, GameObject disableTarget, GachaController.PlayMode gachaPlayMode)
		{
			return null;
		}

		// Token: 0x0602A4AE RID: 173230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4AE")]
		[Address(RVA = "0x25F2650", Offset = "0x25F1250", VA = "0x1825F2650")]
		private static void _InsertOrMergeCharRelatedItems(List<UIItemViewModel> itemViewModels, bool isNew, UIItemViewModel itemModel, ItemBundle[] charItemGet, bool shouldMergeItems)
		{
		}

		// Token: 0x0602A4AF RID: 173231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4AF")]
		[Address(RVA = "0x25F2770", Offset = "0x25F1370", VA = "0x1825F2770")]
		private static void _InsertOrMergeItems(List<UIItemViewModel> itemViewModels, UIItemViewModel itemModel, bool shouldMergeItems)
		{
		}

		// Token: 0x0602A4B0 RID: 173232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4B0")]
		[Address(RVA = "0x25F2C70", Offset = "0x25F1870", VA = "0x1825F2C70")]
		private static void _ShowGainedItemsRelatedCharActivityPotential(GachaResult charGet)
		{
		}

		// Token: 0x0602A4B1 RID: 173233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A4B1")]
		[Address(RVA = "0x25F2EA0", Offset = "0x25F1AA0", VA = "0x1825F2EA0")]
		private static IEnumerator _ShowGainedItemsRelatedCharSkin(UIItemViewModel itemModel, GameObject disableTarget)
		{
			return null;
		}

		// Token: 0x0403CCCB RID: 249035
		[Token(Token = "0x403CCCB")]
		private const string MELDING_ICON_SMALL_POSTFIX = "{0}_small";

		// Token: 0x0403CCCC RID: 249036
		[Token(Token = "0x403CCCC")]
		private const string MEAL_NAME_IMAGE_PREFIX = "title_{0}";

		// Token: 0x0403CCCD RID: 249037
		[Token(Token = "0x403CCCD")]
		private const string ACT_LOCAL_CACHE_LAST_SELECT_QUEST = "{0}_last_select_quest";

		// Token: 0x0403CCCE RID: 249038
		[Token(Token = "0x403CCCE")]
		private const string BATTLE_TRAP_TRACK_KEY = "{0}_{1}";

		// Token: 0x0403CCCF RID: 249039
		[Token(Token = "0x403CCCF")]
		private const string TOOL_ICON_BG_POSTFIX = "{0}_bg";

		// Token: 0x0403CCD0 RID: 249040
		[Token(Token = "0x403CCD0")]
		private const string TOOL_ICON_DEC_POSTFIX = "{0}_dec";

		// Token: 0x0403CCD1 RID: 249041
		[Token(Token = "0x403CCD1")]
		private const string NOTE_TRACK = "{0}_note";

		// Token: 0x0403CCD2 RID: 249042
		[Token(Token = "0x403CCD2")]
		private const string QUEST_STAGE_UNLOCK_ID = "act24side_quest_stage_unlock_{0}";

		// Token: 0x0403CCD3 RID: 249043
		[Token(Token = "0x403CCD3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAct24SideData;

		// Token: 0x0403CCD4 RID: 249044
		[Token(Token = "0x403CCD4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadMeldingIcon;

		// Token: 0x0403CCD5 RID: 249045
		[Token(Token = "0x403CCD5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadMeldingIconSmall;

		// Token: 0x0403CCD6 RID: 249046
		[Token(Token = "0x403CCD6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadMeldingIconBg;

		// Token: 0x0403CCD7 RID: 249047
		[Token(Token = "0x403CCD7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadMeldingSprite;

		// Token: 0x0403CCD8 RID: 249048
		[Token(Token = "0x403CCD8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_BattleFinishOnly_LoadMeldingIcon;

		// Token: 0x0403CCD9 RID: 249049
		[Token(Token = "0x403CCD9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_BattleFinishOnly_LoadMeldingIconSmall;

		// Token: 0x0403CCDA RID: 249050
		[Token(Token = "0x403CCDA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_BattleFinishOnly_LoadMeldingIconBg;

		// Token: 0x0403CCDB RID: 249051
		[Token(Token = "0x403CCDB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__BattleFinishOnly_LoadMeldingSprite;

		// Token: 0x0403CCDC RID: 249052
		[Token(Token = "0x403CCDC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetLastSelectQuest;

		// Token: 0x0403CCDD RID: 249053
		[Token(Token = "0x403CCDD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SaveLastSelectQuest;

		// Token: 0x0403CCDE RID: 249054
		[Token(Token = "0x403CCDE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetTrackType;

		// Token: 0x0403CCDF RID: 249055
		[Token(Token = "0x403CCDF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetStageNewFlagId;

		// Token: 0x0403CCE0 RID: 249056
		[Token(Token = "0x403CCE0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckQuestStageNewFlag;

		// Token: 0x0403CCE1 RID: 249057
		[Token(Token = "0x403CCE1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ConsumeQuestStageNewFlag;

		// Token: 0x0403CCE2 RID: 249058
		[Token(Token = "0x403CCE2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GenerateMeldingRewardPreviewList;

		// Token: 0x0403CCE3 RID: 249059
		[Token(Token = "0x403CCE3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_IsRewardVisible;

		// Token: 0x0403CCE4 RID: 249060
		[Token(Token = "0x403CCE4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadMealIcon;

		// Token: 0x0403CCE5 RID: 249061
		[Token(Token = "0x403CCE5")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadMealNameImage;

		// Token: 0x0403CCE6 RID: 249062
		[Token(Token = "0x403CCE6")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__LoadMealSprite;

		// Token: 0x0403CCE7 RID: 249063
		[Token(Token = "0x403CCE7")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadToolIcon;

		// Token: 0x0403CCE8 RID: 249064
		[Token(Token = "0x403CCE8")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadToolIconBg;

		// Token: 0x0403CCE9 RID: 249065
		[Token(Token = "0x403CCE9")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadToolIconDec;

		// Token: 0x0403CCEA RID: 249066
		[Token(Token = "0x403CCEA")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__LoadToolSprite;

		// Token: 0x0403CCEB RID: 249067
		[Token(Token = "0x403CCEB")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_LoadMissionSprite;

		// Token: 0x0403CCEC RID: 249068
		[Token(Token = "0x403CCEC")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_LogBattleTrapNewUnlock;

		// Token: 0x0403CCED RID: 249069
		[Token(Token = "0x403CCED")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_CheckHasBattleTrapNewUnlockTrack;

		// Token: 0x0403CCEE RID: 249070
		[Token(Token = "0x403CCEE")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CheckBattleTrapNewUnlockTrack;

		// Token: 0x0403CCEF RID: 249071
		[Token(Token = "0x403CCEF")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_ConsumeBattleTrapNewUnlockTrack;

		// Token: 0x0403CCF0 RID: 249072
		[Token(Token = "0x403CCF0")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__GenBattleTrapTrackKey;

		// Token: 0x0403CCF1 RID: 249073
		[Token(Token = "0x403CCF1")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_IsEntryNoteUnwatched;

		// Token: 0x0403CCF2 RID: 249074
		[Token(Token = "0x403CCF2")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_SetEntryNoteWatched;

		// Token: 0x0403CCF3 RID: 249075
		[Token(Token = "0x403CCF3")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_ShowGainedItemsWithPossibleGachasAhead;

		// Token: 0x0403CCF4 RID: 249076
		[Token(Token = "0x403CCF4")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__ShowGainedItems;

		// Token: 0x0403CCF5 RID: 249077
		[Token(Token = "0x403CCF5")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__ShowGainedItemsRelatedChar;

		// Token: 0x0403CCF6 RID: 249078
		[Token(Token = "0x403CCF6")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__InsertOrMergeCharRelatedItems;

		// Token: 0x0403CCF7 RID: 249079
		[Token(Token = "0x403CCF7")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__InsertOrMergeItems;

		// Token: 0x0403CCF8 RID: 249080
		[Token(Token = "0x403CCF8")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__ShowGainedItemsRelatedCharActivityPotential;

		// Token: 0x0403CCF9 RID: 249081
		[Token(Token = "0x403CCF9")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__ShowGainedItemsRelatedCharSkin;
	}
}
