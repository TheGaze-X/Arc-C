using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Resource;
using Torappu.UI.Atlas;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005451 RID: 21585
	[Token(Token = "0x2005451")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeUtil
	{
		// Token: 0x0601FC41 RID: 130113 RVA: 0x000B3100 File Offset: 0x000B1300
		[Token(Token = "0x601FC41")]
		[Address(RVA = "0x1977390", Offset = "0x1975F90", VA = "0x181977390")]
		public static bool ReturnFuncOpenFlag()
		{
			return default(bool);
		}

		// Token: 0x0601FC42 RID: 130114 RVA: 0x000B3118 File Offset: 0x000B1318
		[Token(Token = "0x601FC42")]
		[Address(RVA = "0x1977310", Offset = "0x1975F10", VA = "0x181977310")]
		public static bool ReturnAvgAchieveFuncOpenFlag()
		{
			return default(bool);
		}

		// Token: 0x0601FC43 RID: 130115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC43")]
		[Address(RVA = "0x1973BC0", Offset = "0x19727C0", VA = "0x181973BC0")]
		public static RoguelikeCommonTopMenu CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClicked, bool showReturnBtn = true, [Optional] Action onInfoClicked)
		{
			return null;
		}

		// Token: 0x0601FC44 RID: 130116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC44")]
		[Address(RVA = "0x1975D30", Offset = "0x1974930", VA = "0x181975D30")]
		public static Sprite LoadProfessionPic(ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x0601FC45 RID: 130117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC45")]
		[Address(RVA = "0x1975D90", Offset = "0x1974990", VA = "0x181975D90")]
		public static Sprite LoadRarityBar(RarityRank rarity)
		{
			return null;
		}

		// Token: 0x0601FC46 RID: 130118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC46")]
		[Address(RVA = "0x1975B80", Offset = "0x1974780", VA = "0x181975B80")]
		public static Sprite LoadLevelBackgroundSprite(string topicId, string backgroundId)
		{
			return null;
		}

		// Token: 0x0601FC47 RID: 130119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC47")]
		[Address(RVA = "0x1975630", Offset = "0x1974230", VA = "0x181975630")]
		public static Sprite LoadInitialRelicIcon(ILoadAsset page, string topicId, string itemId)
		{
			return null;
		}

		// Token: 0x0601FC48 RID: 130120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC48")]
		[Address(RVA = "0x19750E0", Offset = "0x1973CE0", VA = "0x1819750E0")]
		public static Sprite LoadBuffIcon(string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601FC49 RID: 130121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC49")]
		[Address(RVA = "0x1975040", Offset = "0x1973C40", VA = "0x181975040")]
		public static Sprite LoadBuffIcon(ILoadAsset assetLoader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601FC4A RID: 130122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC4A")]
		[Address(RVA = "0x1975C00", Offset = "0x1974800", VA = "0x181975C00")]
		public static Sprite LoadMonthRecordEndingPortrait(UIPage page, string topicId, string portraitId)
		{
			return null;
		}

		// Token: 0x0601FC4B RID: 130123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC4B")]
		[Address(RVA = "0x1975160", Offset = "0x1973D60", VA = "0x181975160")]
		public static Sprite LoadChoiceIcon(UIPage page, string iconId)
		{
			return null;
		}

		// Token: 0x0601FC4C RID: 130124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC4C")]
		[Address(RVA = "0x19755B0", Offset = "0x19741B0", VA = "0x1819755B0")]
		public static Sprite LoadInitChoiceIcon(string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601FC4D RID: 130125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC4D")]
		[Address(RVA = "0x1975230", Offset = "0x1973E30", VA = "0x181975230")]
		public static string LoadEndingIconId(RoguelikeGameEndingData endData, int grade)
		{
			return null;
		}

		// Token: 0x0601FC4E RID: 130126 RVA: 0x000B3130 File Offset: 0x000B1330
		[Token(Token = "0x601FC4E")]
		[Address(RVA = "0x1975370", Offset = "0x1973F70", VA = "0x181975370")]
		public static SpriteRenderData LoadEndingIcon(string topicId, RoguelikeGameEndingData endData, int grade, ILoadAsset iLoadAsset)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601FC4F RID: 130127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC4F")]
		[Address(RVA = "0x1975870", Offset = "0x1974470", VA = "0x181975870")]
		public static Sprite LoadItemIcon(string iconId)
		{
			return null;
		}

		// Token: 0x0601FC50 RID: 130128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC50")]
		[Address(RVA = "0x1975920", Offset = "0x1974520", VA = "0x181975920")]
		public static Sprite LoadItemIcon(UIPage page, string iconId)
		{
			return null;
		}

		// Token: 0x0601FC51 RID: 130129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC51")]
		[Address(RVA = "0x1975790", Offset = "0x1974390", VA = "0x181975790")]
		public static Sprite LoadItemIcon(ILoadAsset loadAsset, string iconId)
		{
			return null;
		}

		// Token: 0x0601FC52 RID: 130130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC52")]
		[Address(RVA = "0x1975A30", Offset = "0x1974630", VA = "0x181975A30")]
		public static Sprite LoadItemTinyIcon(UIPage page, string itemTinyIconId)
		{
			return null;
		}

		// Token: 0x0601FC53 RID: 130131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC53")]
		[Address(RVA = "0x1975B00", Offset = "0x1974700", VA = "0x181975B00")]
		public static Sprite LoadItemTinyIcon(ILoadAsset loadAsset, string iconId)
		{
			return null;
		}

		// Token: 0x0601FC54 RID: 130132 RVA: 0x000B3148 File Offset: 0x000B1348
		[Token(Token = "0x601FC54")]
		[Address(RVA = "0x1974870", Offset = "0x1973470", VA = "0x181974870")]
		public static Color GetItemTinyIconColor(string topicId, string itemId)
		{
			return default(Color);
		}

		// Token: 0x0601FC55 RID: 130133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC55")]
		[Address(RVA = "0x1974A10", Offset = "0x1973610", VA = "0x181974A10")]
		public static Sprite GetLineConnectSprite(RoguelikeNodeViewData viewData, RoguelikeDungeonLine line)
		{
			return null;
		}

		// Token: 0x0601FC56 RID: 130134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC56")]
		[Address(RVA = "0x1976CD0", Offset = "0x19758D0", VA = "0x181976CD0")]
		public static Sprite LoadUnderTex(string topicId, RoguelikeTopicItemModel itemData)
		{
			return null;
		}

		// Token: 0x0601FC57 RID: 130135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC57")]
		[Address(RVA = "0x1976A10", Offset = "0x1975610", VA = "0x181976A10")]
		public static Sprite LoadUnderTex(string topicId, RoguelikeRewardShowType type)
		{
			return null;
		}

		// Token: 0x0601FC58 RID: 130136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC58")]
		[Address(RVA = "0x1974780", Offset = "0x1973380", VA = "0x181974780")]
		public static string GetItemNameDefaultEmpty(string topicId, string itemId)
		{
			return null;
		}

		// Token: 0x0601FC59 RID: 130137 RVA: 0x000B3160 File Offset: 0x000B1360
		[Token(Token = "0x601FC59")]
		[Address(RVA = "0x19743F0", Offset = "0x1972FF0", VA = "0x1819743F0")]
		public static int GetConsumableItemCount(string itemId)
		{
			return 0;
		}

		// Token: 0x0601FC5A RID: 130138 RVA: 0x000B3178 File Offset: 0x000B1378
		[Token(Token = "0x601FC5A")]
		[Address(RVA = "0x1974210", Offset = "0x1972E10", VA = "0x181974210")]
		public static int GetChestNeedKeyCount(string topicId)
		{
			return 0;
		}

		// Token: 0x0601FC5B RID: 130139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC5B")]
		[Address(RVA = "0x1974300", Offset = "0x1972F00", VA = "0x181974300")]
		public static string GetChestUnlockKeyId(string topicId)
		{
			return null;
		}

		// Token: 0x0601FC5C RID: 130140 RVA: 0x000B3190 File Offset: 0x000B1390
		[Token(Token = "0x601FC5C")]
		[Address(RVA = "0x1973750", Offset = "0x1972350", VA = "0x181973750")]
		public static bool CheckIfGameSettle(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601FC5D RID: 130141 RVA: 0x000B31A8 File Offset: 0x000B13A8
		[Token(Token = "0x601FC5D")]
		[Address(RVA = "0x1973870", Offset = "0x1972470", VA = "0x181973870")]
		public static bool CheckRollNodeAvailable(string topicId, string zoneId, RoguelikeEventType nodeType)
		{
			return default(bool);
		}

		// Token: 0x0601FC5E RID: 130142 RVA: 0x000B31C0 File Offset: 0x000B13C0
		[Token(Token = "0x601FC5E")]
		[Address(RVA = "0x1974CB0", Offset = "0x19738B0", VA = "0x181974CB0")]
		public static RoguelikeRewardShowType GetUnderTexType(RoguelikeTopicItemModel itemData)
		{
			return RoguelikeRewardShowType.NONE;
		}

		// Token: 0x0601FC5F RID: 130143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC5F")]
		[Address(RVA = "0x1975E40", Offset = "0x1974A40", VA = "0x181975E40")]
		public static Sprite LoadRecruitGrpIcon(string iconId)
		{
			return null;
		}

		// Token: 0x0601FC60 RID: 130144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC60")]
		[Address(RVA = "0x19767C0", Offset = "0x19753C0", VA = "0x1819767C0")]
		public static RoguelikeSingleTopicResHolder LoadTopicResHolder(string topicId, [Optional] BaseAssetLoader.IAssets assets)
		{
			return null;
		}

		// Token: 0x0601FC61 RID: 130145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC61")]
		[Address(RVA = "0x19783F0", Offset = "0x1976FF0", VA = "0x1819783F0")]
		private static Sprite _LoadAutoPackSprite(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0601FC62 RID: 130146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC62")]
		[Address(RVA = "0x19785E0", Offset = "0x19771E0", VA = "0x1819785E0")]
		private static Sprite _LoadAutoPackSprite(UIPage page, string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0601FC63 RID: 130147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC63")]
		[Address(RVA = "0x1978800", Offset = "0x1977400", VA = "0x181978800")]
		private static Sprite _LoadAutoPackSprite(ILoadAsset loader, string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0601FC64 RID: 130148 RVA: 0x000B31D8 File Offset: 0x000B13D8
		[Token(Token = "0x601FC64")]
		[Address(RVA = "0x1978060", Offset = "0x1976C60", VA = "0x181978060")]
		private static SpriteRenderData _LoadAtlasSprite(string spriteName, string atlasPath, ILoadAsset iLoadAsset)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601FC65 RID: 130149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC65")]
		[Address(RVA = "0x1975EB0", Offset = "0x1974AB0", VA = "0x181975EB0")]
		public static List<IRoguelikeCharCardViewPluginContext> LoadRoguelikeCharCardViewPlugins(UIPage page, string topicId, Transform parent)
		{
			return null;
		}

		// Token: 0x0601FC66 RID: 130150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC66")]
		[Address(RVA = "0x1976290", Offset = "0x1974E90", VA = "0x181976290")]
		public static List<RoguelikeCharCardViewModel> LoadRoguelikeSquad()
		{
			return null;
		}

		// Token: 0x0601FC67 RID: 130151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC67")]
		[Address(RVA = "0x19775C0", Offset = "0x19761C0", VA = "0x1819775C0")]
		public static void SaveRoguelikeSquad(List<RoguelikeCharCardViewModel> squad)
		{
		}

		// Token: 0x0601FC68 RID: 130152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC68")]
		[Address(RVA = "0x1973A10", Offset = "0x1972610", VA = "0x181973A10")]
		public static void CleanRoguelikeSquad()
		{
		}

		// Token: 0x0601FC69 RID: 130153 RVA: 0x000B31F0 File Offset: 0x000B13F0
		[Token(Token = "0x601FC69")]
		[Address(RVA = "0x1977950", Offset = "0x1976550", VA = "0x181977950")]
		public static bool TryGetItemUnlockProgress(RoguelikeTopicItemModel item, string topicId, out int curr, out int target)
		{
			return default(bool);
		}

		// Token: 0x0601FC6A RID: 130154 RVA: 0x000B3208 File Offset: 0x000B1408
		[Token(Token = "0x601FC6A")]
		[Address(RVA = "0x1977E60", Offset = "0x1976A60", VA = "0x181977E60")]
		public static bool TryGetRecruitSetUnlockPrg(string id, string topicId, out int curr, out int target)
		{
			return default(bool);
		}

		// Token: 0x0601FC6B RID: 130155 RVA: 0x000B3220 File Offset: 0x000B1420
		[Token(Token = "0x601FC6B")]
		[Address(RVA = "0x1974E10", Offset = "0x1973A10", VA = "0x181974E10")]
		public static bool IsRoguelikeMutuallyExclusiveChar(int charInstIdA, int charInstIdB, bool ignoreSame = false)
		{
			return default(bool);
		}

		// Token: 0x0601FC6C RID: 130156 RVA: 0x000B3238 File Offset: 0x000B1438
		[Token(Token = "0x601FC6C")]
		[Address(RVA = "0x1974AD0", Offset = "0x19736D0", VA = "0x181974AD0")]
		public static Color GetRarityColor(RarityRank rarity)
		{
			return default(Color);
		}

		// Token: 0x0601FC6D RID: 130157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC6D")]
		[Address(RVA = "0x19770A0", Offset = "0x1975CA0", VA = "0x1819770A0")]
		public static void OpenRoguelikeShopJudgeDialog(RoguelikeCommonJudgeDialog.Options options)
		{
		}

		// Token: 0x0601FC6E RID: 130158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC6E")]
		[Address(RVA = "0x1976FB0", Offset = "0x1975BB0", VA = "0x181976FB0")]
		public static void OpenRoguelikeCommonJudgeDialog(string topicId, RoguelikeCommonJudgeDialog.Options options)
		{
		}

		// Token: 0x0601FC6F RID: 130159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC6F")]
		[Address(RVA = "0x1976EC0", Offset = "0x1975AC0", VA = "0x181976EC0")]
		public static void OpenRoguelikeCommonCheckJudgeDialog(string topicId, RoguelikeCommonCheckJudgeDialog.Options options)
		{
		}

		// Token: 0x0601FC70 RID: 130160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC70")]
		[Address(RVA = "0x1977240", Offset = "0x1975E40", VA = "0x181977240")]
		public static Sprite RL02LoadMutationRarityBar(string topicId, RarityRank rarity)
		{
			return null;
		}

		// Token: 0x0601FC71 RID: 130161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC71")]
		[Address(RVA = "0x1977170", Offset = "0x1975D70", VA = "0x181977170")]
		public static Sprite RL02LoadEvolutionRarityBar(string topicId, RarityRank rarity)
		{
			return null;
		}

		// Token: 0x0601FC72 RID: 130162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC72")]
		[Address(RVA = "0x1974100", Offset = "0x1972D00", VA = "0x181974100")]
		public static RoguelikeGameInitData FindInitData(RoguelikeTopicDetail detail, RoguelikeTopicMode mode, string predefinedId, int grade)
		{
			return null;
		}

		// Token: 0x0601FC73 RID: 130163 RVA: 0x000B3250 File Offset: 0x000B1450
		[Token(Token = "0x601FC73")]
		[Address(RVA = "0x1977C90", Offset = "0x1976890", VA = "0x181977C90")]
		public static bool TryGetModeUnlockInfo(RoguelikeTopicMode mode, int grade, PlayerRoguelikeV2.OuterData outerData, out PlayerRoguelikeV2.OuterData.Collection.DifficultyUnlockInfo statusInfo)
		{
			return default(bool);
		}

		// Token: 0x0601FC74 RID: 130164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FC74")]
		[Address(RVA = "0x1973AE0", Offset = "0x19726E0", VA = "0x181973AE0")]
		public static string ConvertNumToUnknownMark(bool needConvert, string numStr)
		{
			return null;
		}

		// Token: 0x0601FC75 RID: 130165 RVA: 0x000B3268 File Offset: 0x000B1468
		[Token(Token = "0x601FC75")]
		[Address(RVA = "0x1973680", Offset = "0x1972280", VA = "0x181973680")]
		public static bool CheckIfExistRewardHpDecoPluginToLoad(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601FC76 RID: 130166 RVA: 0x000B3280 File Offset: 0x000B1480
		[Token(Token = "0x601FC76")]
		[Address(RVA = "0x19735B0", Offset = "0x19721B0", VA = "0x1819735B0")]
		public static bool CheckIfExistRewardExtraInfoPluginToLoad(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0402ACD0 RID: 175312
		[Token(Token = "0x402ACD0")]
		public const string WARNING_RED = "f43641";

		// Token: 0x0402ACD1 RID: 175313
		[Token(Token = "0x402ACD1")]
		public const string STATUS_BAR_LEVEL_BLUE = "FFC000";

		// Token: 0x0402ACD2 RID: 175314
		[Token(Token = "0x402ACD2")]
		public const string DEFAULT_KV = "rogue_kv_default";

		// Token: 0x0402ACD3 RID: 175315
		[Token(Token = "0x402ACD3")]
		private const string QUESTION_MARK_BASE = "?????????";

		// Token: 0x0402ACD4 RID: 175316
		[Token(Token = "0x402ACD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ReturnFuncOpenFlag;

		// Token: 0x0402ACD5 RID: 175317
		[Token(Token = "0x402ACD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ReturnAvgAchieveFuncOpenFlag;

		// Token: 0x0402ACD6 RID: 175318
		[Token(Token = "0x402ACD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x0402ACD7 RID: 175319
		[Token(Token = "0x402ACD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadProfessionPic;

		// Token: 0x0402ACD8 RID: 175320
		[Token(Token = "0x402ACD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadRarityBar;

		// Token: 0x0402ACD9 RID: 175321
		[Token(Token = "0x402ACD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadLevelBackgroundSprite;

		// Token: 0x0402ACDA RID: 175322
		[Token(Token = "0x402ACDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadInitialRelicIcon;

		// Token: 0x0402ACDB RID: 175323
		[Token(Token = "0x402ACDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadBuffIcon;

		// Token: 0x0402ACDC RID: 175324
		[Token(Token = "0x402ACDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_LoadBuffIcon;

		// Token: 0x0402ACDD RID: 175325
		[Token(Token = "0x402ACDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadMonthRecordEndingPortrait;

		// Token: 0x0402ACDE RID: 175326
		[Token(Token = "0x402ACDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadChoiceIcon;

		// Token: 0x0402ACDF RID: 175327
		[Token(Token = "0x402ACDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadInitChoiceIcon;

		// Token: 0x0402ACE0 RID: 175328
		[Token(Token = "0x402ACE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadEndingIconId;

		// Token: 0x0402ACE1 RID: 175329
		[Token(Token = "0x402ACE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadEndingIcon;

		// Token: 0x0402ACE2 RID: 175330
		[Token(Token = "0x402ACE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadItemIcon;

		// Token: 0x0402ACE3 RID: 175331
		[Token(Token = "0x402ACE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix1_LoadItemIcon;

		// Token: 0x0402ACE4 RID: 175332
		[Token(Token = "0x402ACE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix2_LoadItemIcon;

		// Token: 0x0402ACE5 RID: 175333
		[Token(Token = "0x402ACE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadItemTinyIcon;

		// Token: 0x0402ACE6 RID: 175334
		[Token(Token = "0x402ACE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix1_LoadItemTinyIcon;

		// Token: 0x0402ACE7 RID: 175335
		[Token(Token = "0x402ACE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetItemTinyIconColor;

		// Token: 0x0402ACE8 RID: 175336
		[Token(Token = "0x402ACE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetLineConnectSprite;

		// Token: 0x0402ACE9 RID: 175337
		[Token(Token = "0x402ACE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadUnderTex;

		// Token: 0x0402ACEA RID: 175338
		[Token(Token = "0x402ACEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix1_LoadUnderTex;

		// Token: 0x0402ACEB RID: 175339
		[Token(Token = "0x402ACEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetItemNameDefaultEmpty;

		// Token: 0x0402ACEC RID: 175340
		[Token(Token = "0x402ACEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetConsumableItemCount;

		// Token: 0x0402ACED RID: 175341
		[Token(Token = "0x402ACED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetChestNeedKeyCount;

		// Token: 0x0402ACEE RID: 175342
		[Token(Token = "0x402ACEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetChestUnlockKeyId;

		// Token: 0x0402ACEF RID: 175343
		[Token(Token = "0x402ACEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CheckIfGameSettle;

		// Token: 0x0402ACF0 RID: 175344
		[Token(Token = "0x402ACF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_CheckRollNodeAvailable;

		// Token: 0x0402ACF1 RID: 175345
		[Token(Token = "0x402ACF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetUnderTexType;

		// Token: 0x0402ACF2 RID: 175346
		[Token(Token = "0x402ACF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_LoadRecruitGrpIcon;

		// Token: 0x0402ACF3 RID: 175347
		[Token(Token = "0x402ACF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_LoadTopicResHolder;

		// Token: 0x0402ACF4 RID: 175348
		[Token(Token = "0x402ACF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__LoadAutoPackSprite;

		// Token: 0x0402ACF5 RID: 175349
		[Token(Token = "0x402ACF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix1__LoadAutoPackSprite;

		// Token: 0x0402ACF6 RID: 175350
		[Token(Token = "0x402ACF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix2__LoadAutoPackSprite;

		// Token: 0x0402ACF7 RID: 175351
		[Token(Token = "0x402ACF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__LoadAtlasSprite;

		// Token: 0x0402ACF8 RID: 175352
		[Token(Token = "0x402ACF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_LoadRoguelikeCharCardViewPlugins;

		// Token: 0x0402ACF9 RID: 175353
		[Token(Token = "0x402ACF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_LoadRoguelikeSquad;

		// Token: 0x0402ACFA RID: 175354
		[Token(Token = "0x402ACFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_SaveRoguelikeSquad;

		// Token: 0x0402ACFB RID: 175355
		[Token(Token = "0x402ACFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_CleanRoguelikeSquad;

		// Token: 0x0402ACFC RID: 175356
		[Token(Token = "0x402ACFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_TryGetItemUnlockProgress;

		// Token: 0x0402ACFD RID: 175357
		[Token(Token = "0x402ACFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_TryGetRecruitSetUnlockPrg;

		// Token: 0x0402ACFE RID: 175358
		[Token(Token = "0x402ACFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_IsRoguelikeMutuallyExclusiveChar;

		// Token: 0x0402ACFF RID: 175359
		[Token(Token = "0x402ACFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_GetRarityColor;

		// Token: 0x0402AD00 RID: 175360
		[Token(Token = "0x402AD00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_OpenRoguelikeShopJudgeDialog;

		// Token: 0x0402AD01 RID: 175361
		[Token(Token = "0x402AD01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_OpenRoguelikeCommonJudgeDialog;

		// Token: 0x0402AD02 RID: 175362
		[Token(Token = "0x402AD02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_OpenRoguelikeCommonCheckJudgeDialog;

		// Token: 0x0402AD03 RID: 175363
		[Token(Token = "0x402AD03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_RL02LoadMutationRarityBar;

		// Token: 0x0402AD04 RID: 175364
		[Token(Token = "0x402AD04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_RL02LoadEvolutionRarityBar;

		// Token: 0x0402AD05 RID: 175365
		[Token(Token = "0x402AD05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_FindInitData;

		// Token: 0x0402AD06 RID: 175366
		[Token(Token = "0x402AD06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_TryGetModeUnlockInfo;

		// Token: 0x0402AD07 RID: 175367
		[Token(Token = "0x402AD07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_ConvertNumToUnknownMark;

		// Token: 0x0402AD08 RID: 175368
		[Token(Token = "0x402AD08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_CheckIfExistRewardHpDecoPluginToLoad;

		// Token: 0x0402AD09 RID: 175369
		[Token(Token = "0x402AD09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_CheckIfExistRewardExtraInfoPluginToLoad;
	}
}
