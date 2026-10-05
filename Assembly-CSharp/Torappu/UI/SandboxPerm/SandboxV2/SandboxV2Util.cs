using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.Sandbox;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004378 RID: 17272
	[Token(Token = "0x2004378")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2Util
	{
		// Token: 0x0601A7EB RID: 108523 RVA: 0x000A2000 File Offset: 0x000A0200
		[Token(Token = "0x601A7EB")]
		[Address(RVA = "0x1398510", Offset = "0x1397110", VA = "0x181398510")]
		public static bool CheckIfRacingOpen(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601A7EC RID: 108524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7EC")]
		[Address(RVA = "0x139C7C0", Offset = "0x139B3C0", VA = "0x18139C7C0")]
		public static string GetRacerName(SandboxV2RacingData racingData, string prefixId, string suffixId)
		{
			return null;
		}

		// Token: 0x0601A7ED RID: 108525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7ED")]
		[Address(RVA = "0x139D0C0", Offset = "0x139BCC0", VA = "0x18139D0C0")]
		public static string GetTimeStrFromMs(int ms)
		{
			return null;
		}

		// Token: 0x0601A7EE RID: 108526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7EE")]
		[Address(RVA = "0x139C6D0", Offset = "0x139B2D0", VA = "0x18139C6D0")]
		public static string GetRacerName(string prefix, string suffix)
		{
			return null;
		}

		// Token: 0x0601A7EF RID: 108527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7EF")]
		[Address(RVA = "0x139C600", Offset = "0x139B200", VA = "0x18139C600")]
		public static string GetRacerBagName(string topicId)
		{
			return null;
		}

		// Token: 0x0601A7F0 RID: 108528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7F0")]
		[Address(RVA = "0x139EC30", Offset = "0x139D830", VA = "0x18139EC30")]
		public static Sprite LoadRacerMedalIcon(ILoadAsset loader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601A7F1 RID: 108529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7F1")]
		[Address(RVA = "0x139ECF0", Offset = "0x139D8F0", VA = "0x18139ECF0")]
		public static Sprite LoadRacerMedalSmallIcon(ILoadAsset loader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601A7F2 RID: 108530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7F2")]
		[Address(RVA = "0x139FF10", Offset = "0x139EB10", VA = "0x18139FF10")]
		public static Sprite LoadracerMedalSmallIconBattleFinishOnly(string topicId, string medalId)
		{
			return null;
		}

		// Token: 0x0601A7F3 RID: 108531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7F3")]
		[Address(RVA = "0x139EDB0", Offset = "0x139D9B0", VA = "0x18139EDB0")]
		public static Sprite LoadRacerTalentIcon(ILoadAsset loader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601A7F4 RID: 108532 RVA: 0x000A2018 File Offset: 0x000A0218
		[Token(Token = "0x601A7F4")]
		[Address(RVA = "0x1398C80", Offset = "0x1397880", VA = "0x181398C80")]
		public static bool EnsurePlayerSandboxV2(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601A7F5 RID: 108533 RVA: 0x000A2030 File Offset: 0x000A0230
		[Token(Token = "0x601A7F5")]
		[Address(RVA = "0x139D8B0", Offset = "0x139C4B0", VA = "0x18139D8B0")]
		public static bool IsTutorial(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601A7F6 RID: 108534 RVA: 0x000A2048 File Offset: 0x000A0248
		[Token(Token = "0x601A7F6")]
		[Address(RVA = "0x139AE60", Offset = "0x1399A60", VA = "0x18139AE60")]
		public static long GetCurrentGameTimeStamp(string topicId)
		{
			return 0L;
		}

		// Token: 0x0601A7F7 RID: 108535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7F7")]
		public static void GetNodeStageEntityHpRatio<TPlayerEntity>(List<TPlayerEntity> entities, out bool isAllDead, out float hpRatio) where TPlayerEntity : PlayerSandboxV2.Dungeon.EntityStatus
		{
		}

		// Token: 0x0601A7F8 RID: 108536 RVA: 0x000A2060 File Offset: 0x000A0260
		[Token(Token = "0x601A7F8")]
		[Address(RVA = "0x139AB90", Offset = "0x1399790", VA = "0x18139AB90")]
		public static SandboxV2CharStatus GetCharStatus(string topicId, int charInstId)
		{
			return SandboxV2CharStatus.NONE;
		}

		// Token: 0x0601A7F9 RID: 108537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7F9")]
		[Address(RVA = "0x139A5F0", Offset = "0x13991F0", VA = "0x18139A5F0")]
		public static string GetCharFilterDesc(SandboxV2CharFilter charFilter)
		{
			return null;
		}

		// Token: 0x0601A7FA RID: 108538 RVA: 0x000A2078 File Offset: 0x000A0278
		[Token(Token = "0x601A7FA")]
		[Address(RVA = "0x139D5B0", Offset = "0x139C1B0", VA = "0x18139D5B0")]
		public static bool IsCharFilterMatch(SandboxV2CharFilter charFilter, SandboxV2CharStatus charStatus)
		{
			return default(bool);
		}

		// Token: 0x0601A7FB RID: 108539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7FB")]
		[Address(RVA = "0x139AA50", Offset = "0x1399650", VA = "0x18139AA50")]
		public static string GetCharStatusDesc(SandboxV2CharStatus charStatus)
		{
			return null;
		}

		// Token: 0x0601A7FC RID: 108540 RVA: 0x000A2090 File Offset: 0x000A0290
		[Token(Token = "0x601A7FC")]
		[Address(RVA = "0x139BB90", Offset = "0x139A790", VA = "0x18139BB90")]
		public static int GetMaxFoodDuration(string topicId)
		{
			return 0;
		}

		// Token: 0x0601A7FD RID: 108541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7FD")]
		[Address(RVA = "0x139C500", Offset = "0x139B100", VA = "0x18139C500")]
		public static PlayerSandboxV2 GetPlayerSandboxV2TopicData(string topicId)
		{
			return null;
		}

		// Token: 0x0601A7FE RID: 108542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7FE")]
		[Address(RVA = "0x139CD50", Offset = "0x139B950", VA = "0x18139CD50")]
		public static SandboxV2Data GetSandboxV2DetailData(string topicId)
		{
			return null;
		}

		// Token: 0x0601A7FF RID: 108543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A7FF")]
		[Address(RVA = "0x139CC70", Offset = "0x139B870", VA = "0x18139CC70")]
		public static string GetSandboxV2ConstStringRes(string topicId, string key)
		{
			return null;
		}

		// Token: 0x0601A800 RID: 108544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A800")]
		[Address(RVA = "0x139E870", Offset = "0x139D470", VA = "0x18139E870")]
		public static Sprite LoadItemTrapTag(ILoadAsset assetLoader, string tagId)
		{
			return null;
		}

		// Token: 0x0601A801 RID: 108545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A801")]
		[Address(RVA = "0x139DC50", Offset = "0x139C850", VA = "0x18139DC50")]
		public static Sprite LoadDiffModeIcon(ILoadAsset assetLoader, int mode, string topicId)
		{
			return null;
		}

		// Token: 0x0601A802 RID: 108546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A802")]
		[Address(RVA = "0x139F4C0", Offset = "0x139E0C0", VA = "0x18139F4C0")]
		public static SandboxV2AbstractBackgroundView LoadSandboxV2DungeonMapBkg(ILoadAsset assetLoader, string topicId, string mapBkgId)
		{
			return null;
		}

		// Token: 0x0601A803 RID: 108547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A803")]
		[Address(RVA = "0x139F670", Offset = "0x139E270", VA = "0x18139F670")]
		public static SandboxV2DungeonViewConfig LoadSandboxV2DungeonViewConfig(ILoadAsset assetLoader, string topicId)
		{
			return null;
		}

		// Token: 0x0601A804 RID: 108548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A804")]
		[Address(RVA = "0x139E9E0", Offset = "0x139D5E0", VA = "0x18139E9E0")]
		public static Sprite LoadMiscIcon(ILoadAsset assetLoader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601A805 RID: 108549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A805")]
		[Address(RVA = "0x139EAB0", Offset = "0x139D6B0", VA = "0x18139EAB0")]
		public static Sprite LoadNodeTypeIcon(ILoadAsset assetLoader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601A806 RID: 108550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A806")]
		[Address(RVA = "0x139FE40", Offset = "0x139EA40", VA = "0x18139FE40")]
		public static Sprite LoadWeatherIcon(ILoadAsset assetLoader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601A807 RID: 108551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A807")]
		[Address(RVA = "0x139FD40", Offset = "0x139E940", VA = "0x18139FD40")]
		public static Sprite LoadWeatherClassIcon(ILoadAsset assetLoader, string topicId, SandboxV2WeatherType weatherType)
		{
			return null;
		}

		// Token: 0x0601A808 RID: 108552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A808")]
		[Address(RVA = "0x139E910", Offset = "0x139D510", VA = "0x18139E910")]
		public static Sprite LoadMatIcon(ILoadAsset assetLoader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601A809 RID: 108553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A809")]
		[Address(RVA = "0x139DA20", Offset = "0x139C620", VA = "0x18139DA20")]
		public static Sprite LoadBasementFuncIcon(ILoadAsset assetLoader, string iconId)
		{
			return null;
		}

		// Token: 0x0601A80A RID: 108554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A80A")]
		[Address(RVA = "0x139F9A0", Offset = "0x139E5A0", VA = "0x18139F9A0")]
		public static Sprite LoadStageMapPreviewSprite(ILoadAsset assetLoader, string topicId, string stageId)
		{
			return null;
		}

		// Token: 0x0601A80B RID: 108555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A80B")]
		[Address(RVA = "0x139DE30", Offset = "0x139CA30", VA = "0x18139DE30")]
		public static Sprite LoadFloatIcon(ILoadAsset assetLoader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601A80C RID: 108556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A80C")]
		[Address(RVA = "0x139E7D0", Offset = "0x139D3D0", VA = "0x18139E7D0")]
		public static Sprite LoadItemIcon(ILoadAsset loader, string itemId)
		{
			return null;
		}

		// Token: 0x0601A80D RID: 108557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A80D")]
		[Address(RVA = "0x139E730", Offset = "0x139D330", VA = "0x18139E730")]
		public static Sprite LoadItemIconBattleFinishOnly(string itemId)
		{
			return null;
		}

		// Token: 0x0601A80E RID: 108558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A80E")]
		[Address(RVA = "0x139FC00", Offset = "0x139E800", VA = "0x18139FC00")]
		public static Sprite LoadStaminaIcon(ILoadAsset loader, string topicId)
		{
			return null;
		}

		// Token: 0x0601A80F RID: 108559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A80F")]
		[Address(RVA = "0x139DD60", Offset = "0x139C960", VA = "0x18139DD60")]
		public static Sprite LoadEventIcon(ILoadAsset loader, string topicId, string eventIconId)
		{
			return null;
		}

		// Token: 0x0601A810 RID: 108560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A810")]
		[Address(RVA = "0x139EB80", Offset = "0x139D780", VA = "0x18139EB80")]
		public static Sprite LoadProfessionIcon(ILoadAsset loader, ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x0601A811 RID: 108561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A811")]
		[Address(RVA = "0x139EE70", Offset = "0x139DA70", VA = "0x18139EE70")]
		public static Sprite LoadRarityIcon(ILoadAsset loader, int rarity)
		{
			return null;
		}

		// Token: 0x0601A812 RID: 108562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A812")]
		[Address(RVA = "0x139F3F0", Offset = "0x139DFF0", VA = "0x18139F3F0")]
		public static Sprite LoadSandboxV2DevelopmentNodeIcon(ILoadAsset assetLoader, string topicId, string iconId)
		{
			return null;
		}

		// Token: 0x0601A813 RID: 108563 RVA: 0x000A20A8 File Offset: 0x000A02A8
		[Token(Token = "0x601A813")]
		[Address(RVA = "0x139B360", Offset = "0x1399F60", VA = "0x18139B360")]
		public static int GetDrinkBottleCount(string topicId)
		{
			return 0;
		}

		// Token: 0x0601A814 RID: 108564 RVA: 0x000A20C0 File Offset: 0x000A02C0
		[Token(Token = "0x601A814")]
		[Address(RVA = "0x139B290", Offset = "0x1399E90", VA = "0x18139B290")]
		public static int GetDrinkBottleCount(SandboxV2Data gameData, PlayerSandboxV2 playerData)
		{
			return 0;
		}

		// Token: 0x0601A815 RID: 108565 RVA: 0x000A20D8 File Offset: 0x000A02D8
		[Token(Token = "0x601A815")]
		[Address(RVA = "0x1398060", Offset = "0x1396C60", VA = "0x181398060")]
		public static bool CanToolBuild(string topicId, string toolId)
		{
			return default(bool);
		}

		// Token: 0x0601A816 RID: 108566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A816")]
		[Address(RVA = "0x139F140", Offset = "0x139DD40", VA = "0x18139F140")]
		public static SandboxPermItemData LoadSandboxPermItem(string itemId)
		{
			return null;
		}

		// Token: 0x0601A817 RID: 108567 RVA: 0x000A20F0 File Offset: 0x000A02F0
		[Token(Token = "0x601A817")]
		[Address(RVA = "0x139E080", Offset = "0x139CC80", VA = "0x18139E080")]
		public static int LoadItemCount(string topicId, string itemId)
		{
			return 0;
		}

		// Token: 0x0601A818 RID: 108568 RVA: 0x000A2108 File Offset: 0x000A0308
		[Token(Token = "0x601A818")]
		[Address(RVA = "0x13A44B0", Offset = "0x13A30B0", VA = "0x1813A44B0")]
		private static int _LoadCoinCount(PlayerSandboxV2 playerData, string itemId)
		{
			return 0;
		}

		// Token: 0x0601A819 RID: 108569 RVA: 0x000A2120 File Offset: 0x000A0320
		[Token(Token = "0x601A819")]
		[Address(RVA = "0x13A4750", Offset = "0x13A3350", VA = "0x1813A4750")]
		private static int _LoadFoodCount(PlayerSandboxV2 playerData, string itemId)
		{
			return 0;
		}

		// Token: 0x0601A81A RID: 108570 RVA: 0x000A2138 File Offset: 0x000A0338
		[Token(Token = "0x601A81A")]
		[Address(RVA = "0x13A4590", Offset = "0x13A3190", VA = "0x1813A4590")]
		private static int _LoadCraftCount(PlayerSandboxV2 playerData, string itemId)
		{
			return 0;
		}

		// Token: 0x0601A81B RID: 108571 RVA: 0x000A2150 File Offset: 0x000A0350
		[Token(Token = "0x601A81B")]
		[Address(RVA = "0x13A4920", Offset = "0x13A3520", VA = "0x1813A4920")]
		private static int _LoadMaterialCount(PlayerSandboxV2 playerData, string itemId)
		{
			return 0;
		}

		// Token: 0x0601A81C RID: 108572 RVA: 0x000A2168 File Offset: 0x000A0368
		[Token(Token = "0x601A81C")]
		[Address(RVA = "0x13A43F0", Offset = "0x13A2FF0", VA = "0x1813A43F0")]
		private static int _LoadBuildingCount(PlayerSandboxV2 playerData, string itemId)
		{
			return 0;
		}

		// Token: 0x0601A81D RID: 108573 RVA: 0x000A2180 File Offset: 0x000A0380
		[Token(Token = "0x601A81D")]
		[Address(RVA = "0x13A4A00", Offset = "0x13A3600", VA = "0x1813A4A00")]
		private static int _LoadTacticalCount(PlayerSandboxV2 playerData, string itemId)
		{
			return 0;
		}

		// Token: 0x0601A81E RID: 108574 RVA: 0x000A2198 File Offset: 0x000A0398
		[Token(Token = "0x601A81E")]
		[Address(RVA = "0x13A4680", Offset = "0x13A3280", VA = "0x1813A4680")]
		private static int _LoadDictItemCount(Dictionary<string, int> itemDict, string itemId)
		{
			return 0;
		}

		// Token: 0x0601A81F RID: 108575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A81F")]
		[Address(RVA = "0x139F7F0", Offset = "0x139E3F0", VA = "0x18139F7F0")]
		public static SandboxV2GainItemView LoadSandboxV2GainItemViewPrefab(ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601A820 RID: 108576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A820")]
		[Address(RVA = "0x13A1790", Offset = "0x13A0390", VA = "0x1813A1790")]
		public static void ScanFoodSubMats(SandboxV2Data gameData, List<string> subMats, out SandboxV2FoodVariantType variantType)
		{
		}

		// Token: 0x0601A821 RID: 108577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A821")]
		[Address(RVA = "0x13A1430", Offset = "0x13A0030", VA = "0x1813A1430")]
		public static void ScanFoodSubMats(SandboxV2Data gameData, SandboxV2FoodData foodData, List<string> subMats, out SandboxV2FoodVariantType variantType, out int duration)
		{
		}

		// Token: 0x0601A822 RID: 108578 RVA: 0x000A21B0 File Offset: 0x000A03B0
		[Token(Token = "0x601A822")]
		[Address(RVA = "0x13A12A0", Offset = "0x139FEA0", VA = "0x1813A12A0")]
		public static SandboxV2FoodVariantType ProcessFoodVariantType(Dictionary<SandboxV2FoodVariantType, int> subMatVariants)
		{
			return SandboxV2FoodVariantType.NONE;
		}

		// Token: 0x0601A823 RID: 108579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A823")]
		[Address(RVA = "0x139B820", Offset = "0x139A420", VA = "0x18139B820")]
		public static SandboxV2FoodVariantData GetFoodVariantData(SandboxV2FoodData foodData, SandboxV2FoodVariantType variantType)
		{
			return null;
		}

		// Token: 0x0601A824 RID: 108580 RVA: 0x000A21C8 File Offset: 0x000A03C8
		[Token(Token = "0x601A824")]
		[Address(RVA = "0x139B930", Offset = "0x139A530", VA = "0x18139B930")]
		public static SandboxV2FoodVariantShowType GetFoodVariantShowType(SandboxV2FoodVariantType variantType)
		{
			return SandboxV2FoodVariantShowType.NONE;
		}

		// Token: 0x0601A825 RID: 108581 RVA: 0x000A21E0 File Offset: 0x000A03E0
		[Token(Token = "0x601A825")]
		[Address(RVA = "0x13A26E0", Offset = "0x13A12E0", VA = "0x1813A26E0")]
		public static bool TryLoadFoodInstVariantInfo(string topicId, string foodInstId, out SandboxV2FoodVariantInfo info)
		{
			return default(bool);
		}

		// Token: 0x0601A826 RID: 108582 RVA: 0x000A21F8 File Offset: 0x000A03F8
		[Token(Token = "0x601A826")]
		[Address(RVA = "0x13A2A50", Offset = "0x13A1650", VA = "0x1813A2A50")]
		public static bool TryLoadFoodInstVariantInfo(string topicId, int charInstId, out SandboxV2FoodVariantInfo info)
		{
			return default(bool);
		}

		// Token: 0x0601A827 RID: 108583 RVA: 0x000A2210 File Offset: 0x000A0410
		[Token(Token = "0x601A827")]
		[Address(RVA = "0x139CE50", Offset = "0x139BA50", VA = "0x18139CE50")]
		public static float GetSeasonAngleByDay(int day, SandboxV2GameConst gameConst)
		{
			return 0f;
		}

		// Token: 0x0601A828 RID: 108584 RVA: 0x000A2228 File Offset: 0x000A0428
		[Token(Token = "0x601A828")]
		[Address(RVA = "0x13A2500", Offset = "0x13A1100", VA = "0x1813A2500")]
		public static bool TryLoadFoodInstVariantInfo(SandboxV2Data gameData, SandboxPermItemData itemData, PlayerSandboxV2.Cook.Food food, out SandboxV2FoodVariantInfo info)
		{
			return default(bool);
		}

		// Token: 0x0601A829 RID: 108585 RVA: 0x000A2240 File Offset: 0x000A0440
		[Token(Token = "0x601A829")]
		[Address(RVA = "0x13A25F0", Offset = "0x13A11F0", VA = "0x1813A25F0")]
		public static bool TryLoadFoodInstVariantInfo(SandboxV2Data gameData, SandboxPermItemData itemData, PlayerSandboxV2.Troop.CharFood food, out SandboxV2FoodVariantInfo info)
		{
			return default(bool);
		}

		// Token: 0x0601A82A RID: 108586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A82A")]
		[Address(RVA = "0x1398F50", Offset = "0x1397B50", VA = "0x181398F50")]
		public static void FindPriorRecipe(PlayerSandboxV2 playerData, List<SandboxV2FoodRecipeData> recipes, out SandboxV2FoodRecipeData priorRecipe, out int priorRecipeIndex, out bool canCook)
		{
		}

		// Token: 0x0601A82B RID: 108587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A82B")]
		[Address(RVA = "0x139DF00", Offset = "0x139CB00", VA = "0x18139DF00")]
		public static Sprite LoadFoodAttributeIcon(ILoadAsset assetLoader, SandboxV2FoodAttribute attribute, bool isSub)
		{
			return null;
		}

		// Token: 0x0601A82C RID: 108588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A82C")]
		[Address(RVA = "0x13A0240", Offset = "0x139EE40", VA = "0x1813A0240")]
		public static void OpenBuildScene(string topicId, string nodeId)
		{
		}

		// Token: 0x0601A82D RID: 108589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A82D")]
		[Address(RVA = "0x139BE30", Offset = "0x139AA30", VA = "0x18139BE30")]
		public static PlayerSandboxV2.Dungeon.NodeStage GetNodeStageOrNull(PlayerSandboxV2 playerSandboxV2, string nodeId)
		{
			return null;
		}

		// Token: 0x0601A82E RID: 108590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A82E")]
		[Address(RVA = "0x139BC90", Offset = "0x139A890", VA = "0x18139BC90")]
		public static PlayerSandboxV2.Dungeon.Node GetNodeOrNull(PlayerSandboxV2 playerSandboxV2, string nodeId)
		{
			return null;
		}

		// Token: 0x0601A82F RID: 108591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A82F")]
		[Address(RVA = "0x1399530", Offset = "0x1398130", VA = "0x181399530")]
		public static SandboxInput GenerateBuildInput(string topicId, string nodeId, SandboxV2Data sandboxV2Data)
		{
			return null;
		}

		// Token: 0x0601A830 RID: 108592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A830")]
		[Address(RVA = "0x13A0E40", Offset = "0x139FA40", VA = "0x1813A0E40")]
		public static void ParseCatchAnimals(SandboxInput input, PlayerSandboxV2.Dungeon.NodeStage nodeStage)
		{
		}

		// Token: 0x0601A831 RID: 108593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A831")]
		[Address(RVA = "0x13A0900", Offset = "0x139F500", VA = "0x1813A0900")]
		public static void ParseBaseBuildingLimitIfBase(SandboxInput input, PlayerSandboxV2 playerSandboxV2, PlayerSandboxV2.Dungeon.NodeStage playerNodeStage, SandboxV2Data gameData)
		{
		}

		// Token: 0x0601A832 RID: 108594 RVA: 0x000A2258 File Offset: 0x000A0458
		[Token(Token = "0x601A832")]
		[Address(RVA = "0x1397EB0", Offset = "0x1396AB0", VA = "0x181397EB0")]
		public static bool CanReserveRift(PlayerSandboxV2 playerData, string riftId)
		{
			return default(bool);
		}

		// Token: 0x0601A833 RID: 108595 RVA: 0x000A2270 File Offset: 0x000A0470
		[Token(Token = "0x601A833")]
		[Address(RVA = "0x139D810", Offset = "0x139C410", VA = "0x18139D810")]
		public static bool IsRiftReservation(PlayerSandboxV2 playerData)
		{
			return default(bool);
		}

		// Token: 0x0601A834 RID: 108596 RVA: 0x000A2288 File Offset: 0x000A0488
		[Token(Token = "0x601A834")]
		[Address(RVA = "0x1398DF0", Offset = "0x13979F0", VA = "0x181398DF0")]
		public static bool EnsureRiftReservation(string topicId, out PlayerSandboxV2.RiftInfo riftInfo)
		{
			return default(bool);
		}

		// Token: 0x0601A835 RID: 108597 RVA: 0x000A22A0 File Offset: 0x000A04A0
		[Token(Token = "0x601A835")]
		[Address(RVA = "0x139D740", Offset = "0x139C340", VA = "0x18139D740")]
		public static bool IsRandomRift(SandboxV2Data gameData, string riftId)
		{
			return default(bool);
		}

		// Token: 0x0601A836 RID: 108598 RVA: 0x000A22B8 File Offset: 0x000A04B8
		[Token(Token = "0x601A836")]
		[Address(RVA = "0x139D670", Offset = "0x139C270", VA = "0x18139D670")]
		public static bool IsPreyRift(SandboxV2Data gameData, string riftId)
		{
			return default(bool);
		}

		// Token: 0x0601A837 RID: 108599 RVA: 0x000A22D0 File Offset: 0x000A04D0
		[Token(Token = "0x601A837")]
		[Address(RVA = "0x13A2DC0", Offset = "0x13A19C0", VA = "0x1813A2DC0")]
		public static bool UseDifficultyInRift(SandboxV2Data gameData, string riftId)
		{
			return default(bool);
		}

		// Token: 0x0601A838 RID: 108600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A838")]
		[Address(RVA = "0x139EF60", Offset = "0x139DB60", VA = "0x18139EF60")]
		public static Sprite LoadRiftParamIcon(string paramIconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601A839 RID: 108601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A839")]
		[Address(RVA = "0x139F0A0", Offset = "0x139DCA0", VA = "0x18139F0A0")]
		public static Sprite LoadRiftTeamIcon(string iconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601A83A RID: 108602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A83A")]
		[Address(RVA = "0x139F000", Offset = "0x139DC00", VA = "0x18139F000")]
		public static Sprite LoadRiftTeamBg(string bgId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601A83B RID: 108603 RVA: 0x000A22E8 File Offset: 0x000A04E8
		[Token(Token = "0x601A83B")]
		[Address(RVA = "0x139B0C0", Offset = "0x1399CC0", VA = "0x18139B0C0")]
		public static int GetDaysBeforeAssessment(string topicId)
		{
			return 0;
		}

		// Token: 0x0601A83C RID: 108604 RVA: 0x000A2300 File Offset: 0x000A0500
		[Token(Token = "0x601A83C")]
		[Address(RVA = "0x139AFD0", Offset = "0x1399BD0", VA = "0x18139AFD0")]
		public static int GetDaysBeforeAssessment(PlayerSandboxV2 playerData, SandboxV2Data gameData)
		{
			return 0;
		}

		// Token: 0x0601A83D RID: 108605 RVA: 0x000A2318 File Offset: 0x000A0518
		[Token(Token = "0x601A83D")]
		[Address(RVA = "0x1398640", Offset = "0x1397240", VA = "0x181398640")]
		public static bool CheckIsSettleDay(PlayerSandboxV2 playerData, PlayerSandboxV2.Dungeon playerDungeon, int datBeforeAssessment)
		{
			return default(bool);
		}

		// Token: 0x0601A83E RID: 108606 RVA: 0x000A2330 File Offset: 0x000A0530
		[Token(Token = "0x601A83E")]
		[Address(RVA = "0x1398870", Offset = "0x1397470", VA = "0x181398870")]
		public static bool CheckSandboxV2PlayerMatEnough(Dictionary<string, int> requiredMats, PlayerSandboxV2 playerTopicData)
		{
			return default(bool);
		}

		// Token: 0x0601A83F RID: 108607 RVA: 0x000A2348 File Offset: 0x000A0548
		[Token(Token = "0x601A83F")]
		[Address(RVA = "0x13A4B80", Offset = "0x13A3780", VA = "0x1813A4B80")]
		private static bool _TryLoadFoodInstVariantInfo(SandboxV2Data gameData, SandboxPermItemData itemData, string foodId, List<string> sub, out SandboxV2FoodVariantInfo info)
		{
			return default(bool);
		}

		// Token: 0x0601A840 RID: 108608 RVA: 0x000A2360 File Offset: 0x000A0560
		[Token(Token = "0x601A840")]
		[Address(RVA = "0x13A4AC0", Offset = "0x13A36C0", VA = "0x1813A4AC0")]
		private static int _SubMatComparison(SandboxV2FoodMatData x, SandboxV2FoodMatData y)
		{
			return 0;
		}

		// Token: 0x0601A841 RID: 108609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A841")]
		public static void ShrinkSlots<T>(List<T> slotList)
		{
		}

		// Token: 0x0601A842 RID: 108610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A842")]
		[Address(RVA = "0x13A1C40", Offset = "0x13A0840", VA = "0x1813A1C40")]
		public static void StartBattle(SandboxV2BattleStartParam input)
		{
		}

		// Token: 0x0601A843 RID: 108611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A843")]
		[Address(RVA = "0x13A1E90", Offset = "0x13A0A90", VA = "0x1813A1E90")]
		public static void StartMonthBattle(SandboxV2BattleStartParam input)
		{
		}

		// Token: 0x0601A844 RID: 108612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A844")]
		[Address(RVA = "0x13A20E0", Offset = "0x13A0CE0", VA = "0x1813A20E0")]
		public static void StartRacingBattle(SandboxV2BattleStartParam input)
		{
		}

		// Token: 0x0601A845 RID: 108613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A845")]
		[Address(RVA = "0x13A2EB0", Offset = "0x13A1AB0", VA = "0x1813A2EB0")]
		private static void _CommonStartBattle(SandboxV2BattleStartParam input, IStartBattleServiceConfig startBattleServiceConfig, IFinishBattleServiceConfig finishBattleServiceConfig)
		{
		}

		// Token: 0x0601A846 RID: 108614 RVA: 0x000A2378 File Offset: 0x000A0578
		[Token(Token = "0x601A846")]
		[Address(RVA = "0x13A4310", Offset = "0x13A2F10", VA = "0x1813A4310")]
		private static BattleStageMeta _GenStageMeta(SandboxV2BattleStartParam input)
		{
			return default(BattleStageMeta);
		}

		// Token: 0x0601A847 RID: 108615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A847")]
		[Address(RVA = "0x13A3CA0", Offset = "0x13A28A0", VA = "0x1813A3CA0")]
		private static BattleStartController.IPlugin _GenBattleStartPlugin(SandboxV2BattleStartParam input)
		{
			return null;
		}

		// Token: 0x0601A848 RID: 108616 RVA: 0x000A2390 File Offset: 0x000A0590
		[Token(Token = "0x601A848")]
		[Address(RVA = "0x13A4070", Offset = "0x13A2C70", VA = "0x1813A4070")]
		private static GameModeMeta _GenGameModeMeta(SandboxV2BattleStartParam input)
		{
			return default(GameModeMeta);
		}

		// Token: 0x0601A849 RID: 108617 RVA: 0x000A23A8 File Offset: 0x000A05A8
		[Token(Token = "0x601A849")]
		[Address(RVA = "0x139A8C0", Offset = "0x13994C0", VA = "0x18139A8C0")]
		public static Color GetCharRarityColor(string topicId, RarityRank rarity)
		{
			return default(Color);
		}

		// Token: 0x0601A84A RID: 108618 RVA: 0x000A23C0 File Offset: 0x000A05C0
		[Token(Token = "0x601A84A")]
		[Address(RVA = "0x139A700", Offset = "0x1399300", VA = "0x18139A700")]
		public static int GetCharLogisticsBeanCount(SandboxV2Data gameData, RarityRank rarity, EvolvePhase evolvePhase, int level)
		{
			return 0;
		}

		// Token: 0x0601A84B RID: 108619 RVA: 0x000A23D8 File Offset: 0x000A05D8
		[Token(Token = "0x601A84B")]
		[Address(RVA = "0x1397C10", Offset = "0x1396810", VA = "0x181397C10")]
		public static int CalcLogisticsPerPeriodDrinkCnt(string topicId, int charCount)
		{
			return 0;
		}

		// Token: 0x0601A84C RID: 108620 RVA: 0x000A23F0 File Offset: 0x000A05F0
		[Token(Token = "0x601A84C")]
		[Address(RVA = "0x1397DE0", Offset = "0x13969E0", VA = "0x181397DE0")]
		public static int CalcLogisticsPerPeriodDrinkCnt(SandboxV2Data sandboxV2GameData, int charCount)
		{
			return 0;
		}

		// Token: 0x0601A84D RID: 108621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A84D")]
		[Address(RVA = "0x139F240", Offset = "0x139DE40", VA = "0x18139F240")]
		public static SandboxV2ConfirmDialogView LoadSandboxV2ConfirmDialogViewPrefab(ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601A84E RID: 108622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A84E")]
		[Address(RVA = "0x13A1A90", Offset = "0x13A0690", VA = "0x1813A1A90")]
		public static void ShowSandboxTextToast(ILoadAsset loader, SandboxV2Const.SandboxV2ToastType type, string text, bool useDedupliate = true)
		{
		}

		// Token: 0x0601A84F RID: 108623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A84F")]
		[Address(RVA = "0x139B5C0", Offset = "0x139A1C0", VA = "0x18139B5C0")]
		public static string GetEnemyRushTipDesc(int day, SandboxV2EnemyRushType type, int state)
		{
			return null;
		}

		// Token: 0x0601A850 RID: 108624 RVA: 0x000A2408 File Offset: 0x000A0608
		[Token(Token = "0x601A850")]
		[Address(RVA = "0x13981E0", Offset = "0x1396DE0", VA = "0x1813981E0")]
		public static bool CheckEnemyRushEmergency(SandboxV2DungeonEnemyRushViewModel enemyRushViewModel)
		{
			return default(bool);
		}

		// Token: 0x0601A851 RID: 108625 RVA: 0x000A2420 File Offset: 0x000A0620
		[Token(Token = "0x601A851")]
		[Address(RVA = "0x13A23D0", Offset = "0x13A0FD0", VA = "0x1813A23D0")]
		public static bool TryGetTrapDeployedCnt(PlayerSandboxV2 playerData, SandboxV2Data dataTable, string buildingItemId, out int deployCnt)
		{
			return default(bool);
		}

		// Token: 0x0601A852 RID: 108626 RVA: 0x000A2438 File Offset: 0x000A0638
		[Token(Token = "0x601A852")]
		[Address(RVA = "0x139D260", Offset = "0x139BE60", VA = "0x18139D260")]
		public static int GetTrapDeployedCnt(SandboxV2Data gameData, PlayerSandboxV2 playerData, string trapId)
		{
			return 0;
		}

		// Token: 0x0601A853 RID: 108627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A853")]
		[Address(RVA = "0x139C3E0", Offset = "0x139AFE0", VA = "0x18139C3E0")]
		public static SandboxV2DungeonEventViewModel GetPlayerEvent(SandboxV2DungeonNodeViewModel nodeViewModel, int instId)
		{
			return null;
		}

		// Token: 0x0601A854 RID: 108628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A854")]
		[Address(RVA = "0x139B9C0", Offset = "0x139A5C0", VA = "0x18139B9C0")]
		public static SandboxV2LogisticsData GetLogisticsDataByProfession(SandboxV2Data gameData, ProfessionCategory professionCategory)
		{
			return null;
		}

		// Token: 0x0601A855 RID: 108629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A855")]
		[Address(RVA = "0x139DAC0", Offset = "0x139C6C0", VA = "0x18139DAC0")]
		public static string LoadConfirmDialogIconId(string topicId, SandboxV2ConfirmIconType iconType)
		{
			return null;
		}

		// Token: 0x0601A856 RID: 108630 RVA: 0x000A2450 File Offset: 0x000A0650
		[Token(Token = "0x601A856")]
		[Address(RVA = "0x13982A0", Offset = "0x1396EA0", VA = "0x1813982A0")]
		public static bool CheckIfPortableEmpty(string topicId, string nodeId)
		{
			return default(bool);
		}

		// Token: 0x0601A857 RID: 108631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A857")]
		[Address(RVA = "0x139BFD0", Offset = "0x139ABD0", VA = "0x18139BFD0")]
		public static UIPageControllerParam GetPageCtrlParam(DataBundle dataBundle)
		{
			return null;
		}

		// Token: 0x0601A858 RID: 108632 RVA: 0x000A2468 File Offset: 0x000A0668
		[Token(Token = "0x601A858")]
		[Address(RVA = "0x13A0080", Offset = "0x139EC80", VA = "0x1813A0080")]
		public static bool NeedHomeShopUpdateTrackPoint(string topicId, string trackId)
		{
			return default(bool);
		}

		// Token: 0x0601A859 RID: 108633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A859")]
		[Address(RVA = "0x1398AC0", Offset = "0x13976C0", VA = "0x181398AC0")]
		public static void ConsumeHomeShopUpdateTrackPoint(string topicId, string trackId)
		{
		}

		// Token: 0x0601A85A RID: 108634 RVA: 0x000A2480 File Offset: 0x000A0680
		[Token(Token = "0x601A85A")]
		[Address(RVA = "0x13A0160", Offset = "0x139ED60", VA = "0x1813A0160")]
		public static bool NeedMonthTrackPoint(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0601A85B RID: 108635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A85B")]
		[Address(RVA = "0x1398BA0", Offset = "0x13977A0", VA = "0x181398BA0")]
		public static void ConsumeMonthTrackPoint(string topicId)
		{
		}

		// Token: 0x0601A85C RID: 108636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A85C")]
		[Address(RVA = "0x139C990", Offset = "0x139B590", VA = "0x18139C990")]
		public static SandboxV2BattleRushEnemyGroupConfig GetRushEnemyGroupConfig(string topicId, SandboxV2EnemyRushType type, string groupId)
		{
			return null;
		}

		// Token: 0x0601A85D RID: 108637 RVA: 0x000A2498 File Offset: 0x000A0698
		[Token(Token = "0x601A85D")]
		[Address(RVA = "0x1398740", Offset = "0x1397340", VA = "0x181398740")]
		public static bool CheckNoLogInEnemyStats(string enemyId)
		{
			return default(bool);
		}

		// Token: 0x04021B96 RID: 138134
		[Token(Token = "0x4021B96")]
		[FieldOffset(Offset = "0x0")]
		private static readonly StringBuilder STRING_BUILDER;

		// Token: 0x04021B97 RID: 138135
		[Token(Token = "0x4021B97")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, int> MAT_DICT;

		// Token: 0x04021B98 RID: 138136
		[Token(Token = "0x4021B98")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<SandboxV2FoodVariantType, int> SUB_VARIANT_TEMP_DICT;

		// Token: 0x04021B99 RID: 138137
		[Token(Token = "0x4021B99")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfRacingOpen;

		// Token: 0x04021B9A RID: 138138
		[Token(Token = "0x4021B9A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetRacerName;

		// Token: 0x04021B9B RID: 138139
		[Token(Token = "0x4021B9B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetTimeStrFromMs;

		// Token: 0x04021B9C RID: 138140
		[Token(Token = "0x4021B9C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_GetRacerName;

		// Token: 0x04021B9D RID: 138141
		[Token(Token = "0x4021B9D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetRacerBagName;

		// Token: 0x04021B9E RID: 138142
		[Token(Token = "0x4021B9E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadRacerMedalIcon;

		// Token: 0x04021B9F RID: 138143
		[Token(Token = "0x4021B9F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadRacerMedalSmallIcon;

		// Token: 0x04021BA0 RID: 138144
		[Token(Token = "0x4021BA0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadracerMedalSmallIconBattleFinishOnly;

		// Token: 0x04021BA1 RID: 138145
		[Token(Token = "0x4021BA1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadRacerTalentIcon;

		// Token: 0x04021BA2 RID: 138146
		[Token(Token = "0x4021BA2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EnsurePlayerSandboxV2;

		// Token: 0x04021BA3 RID: 138147
		[Token(Token = "0x4021BA3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_IsTutorial;

		// Token: 0x04021BA4 RID: 138148
		[Token(Token = "0x4021BA4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetCurrentGameTimeStamp;

		// Token: 0x04021BA5 RID: 138149
		[Token(Token = "0x4021BA5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetNodeStageEntityHpRatio;

		// Token: 0x04021BA6 RID: 138150
		[Token(Token = "0x4021BA6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetCharStatus;

		// Token: 0x04021BA7 RID: 138151
		[Token(Token = "0x4021BA7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetCharFilterDesc;

		// Token: 0x04021BA8 RID: 138152
		[Token(Token = "0x4021BA8")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_IsCharFilterMatch;

		// Token: 0x04021BA9 RID: 138153
		[Token(Token = "0x4021BA9")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetCharStatusDesc;

		// Token: 0x04021BAA RID: 138154
		[Token(Token = "0x4021BAA")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetMaxFoodDuration;

		// Token: 0x04021BAB RID: 138155
		[Token(Token = "0x4021BAB")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetPlayerSandboxV2TopicData;

		// Token: 0x04021BAC RID: 138156
		[Token(Token = "0x4021BAC")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetSandboxV2DetailData;

		// Token: 0x04021BAD RID: 138157
		[Token(Token = "0x4021BAD")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetSandboxV2ConstStringRes;

		// Token: 0x04021BAE RID: 138158
		[Token(Token = "0x4021BAE")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_LoadItemTrapTag;

		// Token: 0x04021BAF RID: 138159
		[Token(Token = "0x4021BAF")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_LoadDiffModeIcon;

		// Token: 0x04021BB0 RID: 138160
		[Token(Token = "0x4021BB0")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_LoadSandboxV2DungeonMapBkg;

		// Token: 0x04021BB1 RID: 138161
		[Token(Token = "0x4021BB1")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_LoadSandboxV2DungeonViewConfig;

		// Token: 0x04021BB2 RID: 138162
		[Token(Token = "0x4021BB2")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_LoadMiscIcon;

		// Token: 0x04021BB3 RID: 138163
		[Token(Token = "0x4021BB3")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_LoadNodeTypeIcon;

		// Token: 0x04021BB4 RID: 138164
		[Token(Token = "0x4021BB4")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_LoadWeatherIcon;

		// Token: 0x04021BB5 RID: 138165
		[Token(Token = "0x4021BB5")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_LoadWeatherClassIcon;

		// Token: 0x04021BB6 RID: 138166
		[Token(Token = "0x4021BB6")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_LoadMatIcon;

		// Token: 0x04021BB7 RID: 138167
		[Token(Token = "0x4021BB7")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_LoadBasementFuncIcon;

		// Token: 0x04021BB8 RID: 138168
		[Token(Token = "0x4021BB8")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_LoadStageMapPreviewSprite;

		// Token: 0x04021BB9 RID: 138169
		[Token(Token = "0x4021BB9")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_LoadFloatIcon;

		// Token: 0x04021BBA RID: 138170
		[Token(Token = "0x4021BBA")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_LoadItemIcon;

		// Token: 0x04021BBB RID: 138171
		[Token(Token = "0x4021BBB")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_LoadItemIconBattleFinishOnly;

		// Token: 0x04021BBC RID: 138172
		[Token(Token = "0x4021BBC")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_LoadStaminaIcon;

		// Token: 0x04021BBD RID: 138173
		[Token(Token = "0x4021BBD")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_LoadEventIcon;

		// Token: 0x04021BBE RID: 138174
		[Token(Token = "0x4021BBE")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_LoadProfessionIcon;

		// Token: 0x04021BBF RID: 138175
		[Token(Token = "0x4021BBF")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_LoadRarityIcon;

		// Token: 0x04021BC0 RID: 138176
		[Token(Token = "0x4021BC0")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_LoadSandboxV2DevelopmentNodeIcon;

		// Token: 0x04021BC1 RID: 138177
		[Token(Token = "0x4021BC1")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_GetDrinkBottleCount;

		// Token: 0x04021BC2 RID: 138178
		[Token(Token = "0x4021BC2")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix1_GetDrinkBottleCount;

		// Token: 0x04021BC3 RID: 138179
		[Token(Token = "0x4021BC3")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_CanToolBuild;

		// Token: 0x04021BC4 RID: 138180
		[Token(Token = "0x4021BC4")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_LoadSandboxPermItem;

		// Token: 0x04021BC5 RID: 138181
		[Token(Token = "0x4021BC5")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_LoadItemCount;

		// Token: 0x04021BC6 RID: 138182
		[Token(Token = "0x4021BC6")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__LoadCoinCount;

		// Token: 0x04021BC7 RID: 138183
		[Token(Token = "0x4021BC7")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__LoadFoodCount;

		// Token: 0x04021BC8 RID: 138184
		[Token(Token = "0x4021BC8")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__LoadCraftCount;

		// Token: 0x04021BC9 RID: 138185
		[Token(Token = "0x4021BC9")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__LoadMaterialCount;

		// Token: 0x04021BCA RID: 138186
		[Token(Token = "0x4021BCA")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__LoadBuildingCount;

		// Token: 0x04021BCB RID: 138187
		[Token(Token = "0x4021BCB")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__LoadTacticalCount;

		// Token: 0x04021BCC RID: 138188
		[Token(Token = "0x4021BCC")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__LoadDictItemCount;

		// Token: 0x04021BCD RID: 138189
		[Token(Token = "0x4021BCD")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_LoadSandboxV2GainItemViewPrefab;

		// Token: 0x04021BCE RID: 138190
		[Token(Token = "0x4021BCE")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_ScanFoodSubMats;

		// Token: 0x04021BCF RID: 138191
		[Token(Token = "0x4021BCF")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix1_ScanFoodSubMats;

		// Token: 0x04021BD0 RID: 138192
		[Token(Token = "0x4021BD0")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_ProcessFoodVariantType;

		// Token: 0x04021BD1 RID: 138193
		[Token(Token = "0x4021BD1")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_GetFoodVariantData;

		// Token: 0x04021BD2 RID: 138194
		[Token(Token = "0x4021BD2")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_GetFoodVariantShowType;

		// Token: 0x04021BD3 RID: 138195
		[Token(Token = "0x4021BD3")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_TryLoadFoodInstVariantInfo;

		// Token: 0x04021BD4 RID: 138196
		[Token(Token = "0x4021BD4")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix1_TryLoadFoodInstVariantInfo;

		// Token: 0x04021BD5 RID: 138197
		[Token(Token = "0x4021BD5")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_GetSeasonAngleByDay;

		// Token: 0x04021BD6 RID: 138198
		[Token(Token = "0x4021BD6")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix2_TryLoadFoodInstVariantInfo;

		// Token: 0x04021BD7 RID: 138199
		[Token(Token = "0x4021BD7")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix3_TryLoadFoodInstVariantInfo;

		// Token: 0x04021BD8 RID: 138200
		[Token(Token = "0x4021BD8")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_FindPriorRecipe;

		// Token: 0x04021BD9 RID: 138201
		[Token(Token = "0x4021BD9")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_LoadFoodAttributeIcon;

		// Token: 0x04021BDA RID: 138202
		[Token(Token = "0x4021BDA")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_OpenBuildScene;

		// Token: 0x04021BDB RID: 138203
		[Token(Token = "0x4021BDB")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_GetNodeStageOrNull;

		// Token: 0x04021BDC RID: 138204
		[Token(Token = "0x4021BDC")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_GetNodeOrNull;

		// Token: 0x04021BDD RID: 138205
		[Token(Token = "0x4021BDD")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_GenerateBuildInput;

		// Token: 0x04021BDE RID: 138206
		[Token(Token = "0x4021BDE")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_ParseCatchAnimals;

		// Token: 0x04021BDF RID: 138207
		[Token(Token = "0x4021BDF")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_ParseBaseBuildingLimitIfBase;

		// Token: 0x04021BE0 RID: 138208
		[Token(Token = "0x4021BE0")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_CanReserveRift;

		// Token: 0x04021BE1 RID: 138209
		[Token(Token = "0x4021BE1")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_IsRiftReservation;

		// Token: 0x04021BE2 RID: 138210
		[Token(Token = "0x4021BE2")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_EnsureRiftReservation;

		// Token: 0x04021BE3 RID: 138211
		[Token(Token = "0x4021BE3")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_IsRandomRift;

		// Token: 0x04021BE4 RID: 138212
		[Token(Token = "0x4021BE4")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_IsPreyRift;

		// Token: 0x04021BE5 RID: 138213
		[Token(Token = "0x4021BE5")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_UseDifficultyInRift;

		// Token: 0x04021BE6 RID: 138214
		[Token(Token = "0x4021BE6")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_LoadRiftParamIcon;

		// Token: 0x04021BE7 RID: 138215
		[Token(Token = "0x4021BE7")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_LoadRiftTeamIcon;

		// Token: 0x04021BE8 RID: 138216
		[Token(Token = "0x4021BE8")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_LoadRiftTeamBg;

		// Token: 0x04021BE9 RID: 138217
		[Token(Token = "0x4021BE9")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_GetDaysBeforeAssessment;

		// Token: 0x04021BEA RID: 138218
		[Token(Token = "0x4021BEA")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix1_GetDaysBeforeAssessment;

		// Token: 0x04021BEB RID: 138219
		[Token(Token = "0x4021BEB")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_CheckIsSettleDay;

		// Token: 0x04021BEC RID: 138220
		[Token(Token = "0x4021BEC")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_CheckSandboxV2PlayerMatEnough;

		// Token: 0x04021BED RID: 138221
		[Token(Token = "0x4021BED")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0__TryLoadFoodInstVariantInfo;

		// Token: 0x04021BEE RID: 138222
		[Token(Token = "0x4021BEE")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0__SubMatComparison;

		// Token: 0x04021BEF RID: 138223
		[Token(Token = "0x4021BEF")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_ShrinkSlots;

		// Token: 0x04021BF0 RID: 138224
		[Token(Token = "0x4021BF0")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_StartBattle;

		// Token: 0x04021BF1 RID: 138225
		[Token(Token = "0x4021BF1")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_StartMonthBattle;

		// Token: 0x04021BF2 RID: 138226
		[Token(Token = "0x4021BF2")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_StartRacingBattle;

		// Token: 0x04021BF3 RID: 138227
		[Token(Token = "0x4021BF3")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0__CommonStartBattle;

		// Token: 0x04021BF4 RID: 138228
		[Token(Token = "0x4021BF4")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0__GenStageMeta;

		// Token: 0x04021BF5 RID: 138229
		[Token(Token = "0x4021BF5")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0__GenBattleStartPlugin;

		// Token: 0x04021BF6 RID: 138230
		[Token(Token = "0x4021BF6")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0__GenGameModeMeta;

		// Token: 0x04021BF7 RID: 138231
		[Token(Token = "0x4021BF7")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_GetCharRarityColor;

		// Token: 0x04021BF8 RID: 138232
		[Token(Token = "0x4021BF8")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_GetCharLogisticsBeanCount;

		// Token: 0x04021BF9 RID: 138233
		[Token(Token = "0x4021BF9")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_CalcLogisticsPerPeriodDrinkCnt;

		// Token: 0x04021BFA RID: 138234
		[Token(Token = "0x4021BFA")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix1_CalcLogisticsPerPeriodDrinkCnt;

		// Token: 0x04021BFB RID: 138235
		[Token(Token = "0x4021BFB")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_LoadSandboxV2ConfirmDialogViewPrefab;

		// Token: 0x04021BFC RID: 138236
		[Token(Token = "0x4021BFC")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_ShowSandboxTextToast;

		// Token: 0x04021BFD RID: 138237
		[Token(Token = "0x4021BFD")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_GetEnemyRushTipDesc;

		// Token: 0x04021BFE RID: 138238
		[Token(Token = "0x4021BFE")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_CheckEnemyRushEmergency;

		// Token: 0x04021BFF RID: 138239
		[Token(Token = "0x4021BFF")]
		[FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_TryGetTrapDeployedCnt;

		// Token: 0x04021C00 RID: 138240
		[Token(Token = "0x4021C00")]
		[FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_GetTrapDeployedCnt;

		// Token: 0x04021C01 RID: 138241
		[Token(Token = "0x4021C01")]
		[FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_GetPlayerEvent;

		// Token: 0x04021C02 RID: 138242
		[Token(Token = "0x4021C02")]
		[FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_GetLogisticsDataByProfession;

		// Token: 0x04021C03 RID: 138243
		[Token(Token = "0x4021C03")]
		[FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_LoadConfirmDialogIconId;

		// Token: 0x04021C04 RID: 138244
		[Token(Token = "0x4021C04")]
		[FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_CheckIfPortableEmpty;

		// Token: 0x04021C05 RID: 138245
		[Token(Token = "0x4021C05")]
		[FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_GetPageCtrlParam;

		// Token: 0x04021C06 RID: 138246
		[Token(Token = "0x4021C06")]
		[FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_NeedHomeShopUpdateTrackPoint;

		// Token: 0x04021C07 RID: 138247
		[Token(Token = "0x4021C07")]
		[FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_ConsumeHomeShopUpdateTrackPoint;

		// Token: 0x04021C08 RID: 138248
		[Token(Token = "0x4021C08")]
		[FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_NeedMonthTrackPoint;

		// Token: 0x04021C09 RID: 138249
		[Token(Token = "0x4021C09")]
		[FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_ConsumeMonthTrackPoint;

		// Token: 0x04021C0A RID: 138250
		[Token(Token = "0x4021C0A")]
		[FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_GetRushEnemyGroupConfig;

		// Token: 0x04021C0B RID: 138251
		[Token(Token = "0x4021C0B")]
		[FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_CheckNoLogInEnemyStats;
	}
}
