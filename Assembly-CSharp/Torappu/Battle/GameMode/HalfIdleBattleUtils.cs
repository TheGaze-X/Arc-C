using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.GameMode
{
	// Token: 0x02002801 RID: 10241
	[Token(Token = "0x2002801")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class HalfIdleBattleUtils
	{
		// Token: 0x0601107B RID: 69755 RVA: 0x00068C58 File Offset: 0x00066E58
		[Token(Token = "0x601107B")]
		[Address(RVA = "0x8FAAD0", Offset = "0x8F96D0", VA = "0x1808FAAD0")]
		public static bool TryGetConstData(string actId, out Act1VHalfIdleConstData constData)
		{
			return default(bool);
		}

		// Token: 0x0601107C RID: 69756 RVA: 0x00068C70 File Offset: 0x00066E70
		[Token(Token = "0x601107C")]
		[Address(RVA = "0x8FB0F0", Offset = "0x8F9CF0", VA = "0x1808FB0F0")]
		public static bool TryGetItemDataByItemId(string itemId, out Act1VHalfIdleItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x0601107D RID: 69757 RVA: 0x00068C88 File Offset: 0x00066E88
		[Token(Token = "0x601107D")]
		[Address(RVA = "0x8FB490", Offset = "0x8FA090", VA = "0x1808FB490")]
		public static bool TryGetTrapMeta(string actId, string trapId, out Act1VHalfIdleTrapMeta trapMeta)
		{
			return default(bool);
		}

		// Token: 0x0601107E RID: 69758 RVA: 0x00068CA0 File Offset: 0x00066EA0
		[Token(Token = "0x601107E")]
		[Address(RVA = "0x8FB1F0", Offset = "0x8F9DF0", VA = "0x1808FB1F0")]
		public static bool TryGetPlotShowHighlightCombineList(string actId, string plotId, out List<string> plotList)
		{
			return default(bool);
		}

		// Token: 0x0601107F RID: 69759 RVA: 0x00068CB8 File Offset: 0x00066EB8
		[Token(Token = "0x601107F")]
		[Address(RVA = "0x8FAB80", Offset = "0x8F9780", VA = "0x1808FAB80")]
		public static bool TryGetDropBundleOnEnemyDead(string actId, string enemyId, out Act1VHalfIdleEnemyDropBundle dropBundle)
		{
			return default(bool);
		}

		// Token: 0x06011080 RID: 69760 RVA: 0x00068CD0 File Offset: 0x00066ED0
		[Token(Token = "0x6011080")]
		[Address(RVA = "0x8FA9E0", Offset = "0x8F95E0", VA = "0x1808FA9E0")]
		public static bool TryGetBattleItemDropBundle(string actId, string poolKey, out List<Act1VBattleItemDropSlot> battleItemDropSlots)
		{
			return default(bool);
		}

		// Token: 0x06011081 RID: 69761 RVA: 0x00068CE8 File Offset: 0x00066EE8
		[Token(Token = "0x6011081")]
		[Address(RVA = "0x8FAE50", Offset = "0x8F9A50", VA = "0x1808FAE50")]
		public static bool TryGetEquipDataFromPool(string actId, string poolKey, out Act1VHalfIdleEquipData equipData)
		{
			return default(bool);
		}

		// Token: 0x06011082 RID: 69762 RVA: 0x00068D00 File Offset: 0x00066F00
		[Token(Token = "0x6011082")]
		[Address(RVA = "0x8FAC60", Offset = "0x8F9860", VA = "0x1808FAC60")]
		public static bool TryGetEquipDataById(string actId, string equipId, int level, string alias, out Act1VHalfIdleEquipData equipData)
		{
			return default(bool);
		}

		// Token: 0x06011083 RID: 69763 RVA: 0x00068D18 File Offset: 0x00066F18
		[Token(Token = "0x6011083")]
		[Address(RVA = "0x8FB570", Offset = "0x8FA170", VA = "0x1808FB570")]
		public static bool TryGetUpgradedEquipData(string actId, Act1VHalfIdleEquipData equipData, out Act1VHalfIdleEquipData upgradedData)
		{
			return default(bool);
		}

		// Token: 0x06011084 RID: 69764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011084")]
		[Address(RVA = "0x8FA470", Offset = "0x8F9070", VA = "0x1808FA470")]
		public static void GetTrapItemPools(string actId, Dictionary<string, List<HalfIdleWeightedBattleTrap>> trapItemPools)
		{
		}

		// Token: 0x06011085 RID: 69765 RVA: 0x00068D30 File Offset: 0x00066F30
		[Token(Token = "0x6011085")]
		[Address(RVA = "0x8FB2D0", Offset = "0x8F9ED0", VA = "0x1808FB2D0")]
		public static bool TryGetResourcesFromPool(string actId, string poolKey, out Dictionary<string, int> resourceDict)
		{
			return default(bool);
		}

		// Token: 0x06011086 RID: 69766 RVA: 0x00068D48 File Offset: 0x00066F48
		[Token(Token = "0x6011086")]
		[Address(RVA = "0x8F9B30", Offset = "0x8F8730", VA = "0x1808F9B30")]
		public static bool CheckIsLevelCapacityWhiteListId(string actId, string id)
		{
			return default(bool);
		}

		// Token: 0x06011087 RID: 69767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011087")]
		[Address(RVA = "0x8FA160", Offset = "0x8F8D60", VA = "0x1808FA160")]
		public static void GetLevelResourceDict(string actId, string stageId, out ListDict<string, int[]> resourceCountDict)
		{
		}

		// Token: 0x06011088 RID: 69768 RVA: 0x00068D60 File Offset: 0x00066F60
		[Token(Token = "0x6011088")]
		[Address(RVA = "0x8FA870", Offset = "0x8F9470", VA = "0x1808FA870")]
		public static bool TryGetBattleFailedHints(string actId, out List<string> battleFailedHints)
		{
			return default(bool);
		}

		// Token: 0x06011089 RID: 69769 RVA: 0x00068D78 File Offset: 0x00066F78
		[Token(Token = "0x6011089")]
		[Address(RVA = "0x8F9660", Offset = "0x8F8260", VA = "0x1808F9660")]
		public static int AchieveMaxLevel(string actId, RarityRank rarity, EvolvePhase evolvePhase)
		{
			return 0;
		}

		// Token: 0x0601108A RID: 69770 RVA: 0x00068D90 File Offset: 0x00066F90
		[Token(Token = "0x601108A")]
		[Address(RVA = "0x8F98D0", Offset = "0x8F84D0", VA = "0x1808F98D0")]
		public static int AchieveUplevelExp(string actId, EvolvePhase evolvePhase, int curLevel, string charId, CharacterData charData)
		{
			return 0;
		}

		// Token: 0x0601108B RID: 69771 RVA: 0x00068DA8 File Offset: 0x00066FA8
		[Token(Token = "0x601108B")]
		[Address(RVA = "0x8F9E70", Offset = "0x8F8A70", VA = "0x1808F9E70")]
		public static bool CheckPositionContainsLhport(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0601108C RID: 69772 RVA: 0x00068DC0 File Offset: 0x00066FC0
		[Token(Token = "0x601108C")]
		[Address(RVA = "0x8F9BF0", Offset = "0x8F87F0", VA = "0x1808F9BF0")]
		public static bool CheckLhshipPassable(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0601108D RID: 69773 RVA: 0x00068DD8 File Offset: 0x00066FD8
		[Token(Token = "0x601108D")]
		[Address(RVA = "0x8FA0E0", Offset = "0x8F8CE0", VA = "0x1808FA0E0")]
		public static bool CheckTargetTrap(BattleCharacterData data)
		{
			return default(bool);
		}

		// Token: 0x04013101 RID: 78081
		[Token(Token = "0x4013101")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetConstData;

		// Token: 0x04013102 RID: 78082
		[Token(Token = "0x4013102")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryGetItemDataByItemId;

		// Token: 0x04013103 RID: 78083
		[Token(Token = "0x4013103")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetTrapMeta;

		// Token: 0x04013104 RID: 78084
		[Token(Token = "0x4013104")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryGetPlotShowHighlightCombineList;

		// Token: 0x04013105 RID: 78085
		[Token(Token = "0x4013105")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryGetDropBundleOnEnemyDead;

		// Token: 0x04013106 RID: 78086
		[Token(Token = "0x4013106")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryGetBattleItemDropBundle;

		// Token: 0x04013107 RID: 78087
		[Token(Token = "0x4013107")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryGetEquipDataFromPool;

		// Token: 0x04013108 RID: 78088
		[Token(Token = "0x4013108")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryGetEquipDataById;

		// Token: 0x04013109 RID: 78089
		[Token(Token = "0x4013109")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryGetUpgradedEquipData;

		// Token: 0x0401310A RID: 78090
		[Token(Token = "0x401310A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetTrapItemPools;

		// Token: 0x0401310B RID: 78091
		[Token(Token = "0x401310B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TryGetResourcesFromPool;

		// Token: 0x0401310C RID: 78092
		[Token(Token = "0x401310C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckIsLevelCapacityWhiteListId;

		// Token: 0x0401310D RID: 78093
		[Token(Token = "0x401310D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetLevelResourceDict;

		// Token: 0x0401310E RID: 78094
		[Token(Token = "0x401310E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TryGetBattleFailedHints;

		// Token: 0x0401310F RID: 78095
		[Token(Token = "0x401310F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_AchieveMaxLevel;

		// Token: 0x04013110 RID: 78096
		[Token(Token = "0x4013110")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_AchieveUplevelExp;

		// Token: 0x04013111 RID: 78097
		[Token(Token = "0x4013111")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckPositionContainsLhport;

		// Token: 0x04013112 RID: 78098
		[Token(Token = "0x4013112")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CheckLhshipPassable;

		// Token: 0x04013113 RID: 78099
		[Token(Token = "0x4013113")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CheckTargetTrap;
	}
}
