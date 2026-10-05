using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.SandboxPerm.SandboxV2;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A66 RID: 10854
	[Token(Token = "0x2002A66")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxBattleUtil
	{
		// Token: 0x060120D7 RID: 73943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120D7")]
		[Address(RVA = "0xA2AF90", Offset = "0xA29B90", VA = "0x180A2AF90")]
		public static GameObject LoadUIPlugin()
		{
			return null;
		}

		// Token: 0x060120D8 RID: 73944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120D8")]
		[Address(RVA = "0xA2AED0", Offset = "0xA29AD0", VA = "0x180A2AED0")]
		public static GameObject LoadHUDUIPlugin(string prefabName)
		{
			return null;
		}

		// Token: 0x060120D9 RID: 73945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120D9")]
		[Address(RVA = "0xA29760", Offset = "0xA28360", VA = "0x180A29760")]
		public static SandboxPermItemData GetItem(string itemId)
		{
			return null;
		}

		// Token: 0x060120DA RID: 73946 RVA: 0x0006E718 File Offset: 0x0006C918
		[Token(Token = "0x60120DA")]
		[Address(RVA = "0xA2B170", Offset = "0xA29D70", VA = "0x180A2B170")]
		public static ResPackType ResPackTypeViaItem(SandboxPermItemData item, Dictionary<string, string> data)
		{
			return ResPackType.WOOD;
		}

		// Token: 0x060120DB RID: 73947 RVA: 0x0006E730 File Offset: 0x0006C930
		[Token(Token = "0x60120DB")]
		[Address(RVA = "0xA2B000", Offset = "0xA29C00", VA = "0x180A2B000")]
		public static ResPackType ResPackTypeViaItemId(string itemId, Dictionary<string, string> data)
		{
			return ResPackType.WOOD;
		}

		// Token: 0x060120DC RID: 73948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120DC")]
		[Address(RVA = "0xA2AC40", Offset = "0xA29840", VA = "0x180A2AC40")]
		public static string ItemIdViaPackType(ResPackType type, Dictionary<string, string> data)
		{
			return null;
		}

		// Token: 0x060120DD RID: 73949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120DD")]
		[Address(RVA = "0xA2ACF0", Offset = "0xA298F0", VA = "0x180A2ACF0")]
		public static string ItemIdViaSubTypeName(string typeName, Dictionary<string, string> data)
		{
			return null;
		}

		// Token: 0x060120DE RID: 73950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120DE")]
		[Address(RVA = "0xA2A390", Offset = "0xA28F90", VA = "0x180A2A390")]
		public static SandboxV2ItemTrapData GetTrapData(string itemId, SandboxV2Data dataTable)
		{
			return null;
		}

		// Token: 0x060120DF RID: 73951 RVA: 0x0006E748 File Offset: 0x0006C948
		[Token(Token = "0x60120DF")]
		[Address(RVA = "0xA2B3F0", Offset = "0xA29FF0", VA = "0x180A2B3F0")]
		public static bool TryGetRacerItemIdByEnemyId(string enemyId, SandboxV2Data dataTable, out string itemId)
		{
			return default(bool);
		}

		// Token: 0x060120E0 RID: 73952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120E0")]
		[Address(RVA = "0xA29640", Offset = "0xA28240", VA = "0x180A29640")]
		public static AdvancedCharacterInst GetInstByBuildingId(string buildingId, SandboxV2Data dataTable)
		{
			return null;
		}

		// Token: 0x060120E1 RID: 73953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120E1")]
		[Address(RVA = "0xA2A690", Offset = "0xA29290", VA = "0x180A2A690")]
		public static string GetTrapItemId(Character trap, SandboxV2Data dataTable)
		{
			return null;
		}

		// Token: 0x060120E2 RID: 73954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120E2")]
		[Address(RVA = "0xA2A450", Offset = "0xA29050", VA = "0x180A2A450")]
		public static string GetTrapItemIdByData(BattleCharacterData data, SandboxV2Data dataTable)
		{
			return null;
		}

		// Token: 0x060120E3 RID: 73955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120E3")]
		[Address(RVA = "0xA2A050", Offset = "0xA28C50", VA = "0x180A2A050")]
		public static SandboxV2BattleRushEnemyGroupConfig GetRushEnemyGroupConfig(SandboxV2Data dataTable, SandboxV2EnemyRushType type, string groupId)
		{
			return null;
		}

		// Token: 0x060120E4 RID: 73956 RVA: 0x0006E760 File Offset: 0x0006C960
		[Token(Token = "0x60120E4")]
		[Address(RVA = "0xA2A2A0", Offset = "0xA28EA0", VA = "0x180A2A2A0")]
		public static int GetRushEnemyLevel(SandboxV2Data dataTable, string enemyId)
		{
			return 0;
		}

		// Token: 0x060120E5 RID: 73957 RVA: 0x0006E778 File Offset: 0x0006C978
		[Token(Token = "0x60120E5")]
		[Address(RVA = "0xA2ABD0", Offset = "0xA297D0", VA = "0x180A2ABD0")]
		public static bool IsTimingNode(SandboxV2NodeType type)
		{
			return default(bool);
		}

		// Token: 0x060120E6 RID: 73958 RVA: 0x0006E790 File Offset: 0x0006C990
		[Token(Token = "0x60120E6")]
		[Address(RVA = "0xA2B210", Offset = "0xA29E10", VA = "0x180A2B210")]
		public static bool TryGetLocatableArea(LevelData levelData, ref List<GridPosition> tilePos)
		{
			return default(bool);
		}

		// Token: 0x060120E7 RID: 73959 RVA: 0x0006E7A8 File Offset: 0x0006C9A8
		[Token(Token = "0x60120E7")]
		[Address(RVA = "0xA282A0", Offset = "0xA26EA0", VA = "0x180A282A0")]
		public static bool CheckIsBuildingTrap(string trapId)
		{
			return default(bool);
		}

		// Token: 0x060120E8 RID: 73960 RVA: 0x0006E7C0 File Offset: 0x0006C9C0
		[Token(Token = "0x60120E8")]
		[Address(RVA = "0xA28540", Offset = "0xA27140", VA = "0x180A28540")]
		public static bool CheckIsNPCTrap(string trapId)
		{
			return default(bool);
		}

		// Token: 0x060120E9 RID: 73961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120E9")]
		[Address(RVA = "0xA29400", Offset = "0xA28000", VA = "0x180A29400")]
		public static void GetHiddenAreas(LevelData data, ref List<Rect> hiddenAreas)
		{
		}

		// Token: 0x060120EA RID: 73962 RVA: 0x0006E7D8 File Offset: 0x0006C9D8
		[Token(Token = "0x60120EA")]
		[Address(RVA = "0xA27FC0", Offset = "0xA26BC0", VA = "0x180A27FC0")]
		public static bool CheckGridValid(LevelData data, List<Rect> hiddenArea, int col, int row)
		{
			return default(bool);
		}

		// Token: 0x060120EB RID: 73963 RVA: 0x0006E7F0 File Offset: 0x0006C9F0
		[Token(Token = "0x60120EB")]
		[Address(RVA = "0xA2AB30", Offset = "0xA29730", VA = "0x180A2AB30")]
		public static bool IsTileColorHighLand(TileData tileData)
		{
			return default(bool);
		}

		// Token: 0x060120EC RID: 73964 RVA: 0x0006E808 File Offset: 0x0006CA08
		[Token(Token = "0x60120EC")]
		[Address(RVA = "0xA28D20", Offset = "0xA27920", VA = "0x180A28D20")]
		public static bool GetEntityDropItem(SandboxV2Data dataTable, string entityId, ResDropSourceType type, out string itemId, out int count)
		{
			return default(bool);
		}

		// Token: 0x060120ED RID: 73965 RVA: 0x0006E820 File Offset: 0x0006CA20
		[Token(Token = "0x60120ED")]
		[Address(RVA = "0xA29200", Offset = "0xA27E00", VA = "0x180A29200")]
		public static int GetGold(ListDict<string, int> items)
		{
			return 0;
		}

		// Token: 0x060120EE RID: 73966 RVA: 0x0006E838 File Offset: 0x0006CA38
		[Token(Token = "0x60120EE")]
		[Address(RVA = "0xA2A720", Offset = "0xA29320", VA = "0x180A2A720")]
		public static bool GetUpgradeNeededRes(SandboxV2Data dataTable, string buildingId, ref ListDict<string, int> upgradeItemData)
		{
			return default(bool);
		}

		// Token: 0x060120EF RID: 73967 RVA: 0x0006E850 File Offset: 0x0006CA50
		[Token(Token = "0x60120EF")]
		[Address(RVA = "0xA29F10", Offset = "0xA28B10", VA = "0x180A29F10")]
		public static int GetResCntByWithdrawRatioAndHpRatio(float currentHpRatio, int withdrawRatio, int targetResCount)
		{
			return 0;
		}

		// Token: 0x060120F0 RID: 73968 RVA: 0x0006E868 File Offset: 0x0006CA68
		[Token(Token = "0x60120F0")]
		[Address(RVA = "0xA29020", Offset = "0xA27C20", VA = "0x180A29020")]
		public static int GetGoldCntByHpRatio(float currentHpRatio, int repairCost, int discount)
		{
			return 0;
		}

		// Token: 0x060120F1 RID: 73969 RVA: 0x0006E880 File Offset: 0x0006CA80
		[Token(Token = "0x60120F1")]
		[Address(RVA = "0xA2AA20", Offset = "0xA29620", VA = "0x180A2AA20")]
		public static bool IsBaseOrPortTrap(SandboxV2Data dataTable, Unit unit)
		{
			return default(bool);
		}

		// Token: 0x060120F2 RID: 73970 RVA: 0x0006E898 File Offset: 0x0006CA98
		[Token(Token = "0x60120F2")]
		[Address(RVA = "0xA29E70", Offset = "0xA28A70", VA = "0x180A29E70")]
		public static int GetRepairDiscount(string topicId)
		{
			return 0;
		}

		// Token: 0x060120F3 RID: 73971 RVA: 0x0006E8B0 File Offset: 0x0006CAB0
		[Token(Token = "0x60120F3")]
		[Address(RVA = "0xA29AF0", Offset = "0xA286F0", VA = "0x180A29AF0")]
		public static int GetRepairCostByCharacter(SandboxV2Data dataTable, Character trap, int discount)
		{
			return 0;
		}

		// Token: 0x060120F4 RID: 73972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120F4")]
		[Address(RVA = "0xA28F20", Offset = "0xA27B20", VA = "0x180A28F20")]
		public static string GetFenceId(SandboxV2Data dataTable)
		{
			return null;
		}

		// Token: 0x060120F5 RID: 73973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120F5")]
		[Address(RVA = "0xA299F0", Offset = "0xA285F0", VA = "0x180A299F0")]
		public static string GetRareFenceId(SandboxV2Data dataTable)
		{
			return null;
		}

		// Token: 0x060120F6 RID: 73974 RVA: 0x0006E8C8 File Offset: 0x0006CAC8
		[Token(Token = "0x60120F6")]
		[Address(RVA = "0xA28FA0", Offset = "0xA27BA0", VA = "0x180A28FA0")]
		public static int GetFenceLimit(SandboxV2Data dataTable)
		{
			return 0;
		}

		// Token: 0x060120F7 RID: 73975 RVA: 0x0006E8E0 File Offset: 0x0006CAE0
		[Token(Token = "0x60120F7")]
		[Address(RVA = "0xA29A70", Offset = "0xA28670", VA = "0x180A29A70")]
		public static int GetRareFenceLimit(SandboxV2Data dataTable)
		{
			return 0;
		}

		// Token: 0x060120F8 RID: 73976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120F8")]
		[Address(RVA = "0xA285A0", Offset = "0xA271A0", VA = "0x180A285A0")]
		public static void ConstructGetTrapTips(ref List<SandboxV2ConstructTipType> resultType, ref ListDict<string, int> upgradeCache, Unit unit, SandboxV2Data dataTable, string topicId)
		{
		}

		// Token: 0x060120F9 RID: 73977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60120F9")]
		[Address(RVA = "0xA29830", Offset = "0xA28430", VA = "0x180A29830")]
		public static LevelData.PredefinedData.PredefinedCharacter GetNpcReactInst(NpcBattleInput npc)
		{
			return null;
		}

		// Token: 0x0401464A RID: 83530
		[Token(Token = "0x401464A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadUIPlugin;

		// Token: 0x0401464B RID: 83531
		[Token(Token = "0x401464B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadHUDUIPlugin;

		// Token: 0x0401464C RID: 83532
		[Token(Token = "0x401464C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetItem;

		// Token: 0x0401464D RID: 83533
		[Token(Token = "0x401464D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResPackTypeViaItem;

		// Token: 0x0401464E RID: 83534
		[Token(Token = "0x401464E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ResPackTypeViaItemId;

		// Token: 0x0401464F RID: 83535
		[Token(Token = "0x401464F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ItemIdViaPackType;

		// Token: 0x04014650 RID: 83536
		[Token(Token = "0x4014650")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ItemIdViaSubTypeName;

		// Token: 0x04014651 RID: 83537
		[Token(Token = "0x4014651")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetTrapData;

		// Token: 0x04014652 RID: 83538
		[Token(Token = "0x4014652")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryGetRacerItemIdByEnemyId;

		// Token: 0x04014653 RID: 83539
		[Token(Token = "0x4014653")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetInstByBuildingId;

		// Token: 0x04014654 RID: 83540
		[Token(Token = "0x4014654")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetTrapItemId;

		// Token: 0x04014655 RID: 83541
		[Token(Token = "0x4014655")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetTrapItemIdByData;

		// Token: 0x04014656 RID: 83542
		[Token(Token = "0x4014656")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetRushEnemyGroupConfig;

		// Token: 0x04014657 RID: 83543
		[Token(Token = "0x4014657")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetRushEnemyLevel;

		// Token: 0x04014658 RID: 83544
		[Token(Token = "0x4014658")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_IsTimingNode;

		// Token: 0x04014659 RID: 83545
		[Token(Token = "0x4014659")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_TryGetLocatableArea;

		// Token: 0x0401465A RID: 83546
		[Token(Token = "0x401465A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckIsBuildingTrap;

		// Token: 0x0401465B RID: 83547
		[Token(Token = "0x401465B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CheckIsNPCTrap;

		// Token: 0x0401465C RID: 83548
		[Token(Token = "0x401465C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetHiddenAreas;

		// Token: 0x0401465D RID: 83549
		[Token(Token = "0x401465D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CheckGridValid;

		// Token: 0x0401465E RID: 83550
		[Token(Token = "0x401465E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_IsTileColorHighLand;

		// Token: 0x0401465F RID: 83551
		[Token(Token = "0x401465F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetEntityDropItem;

		// Token: 0x04014660 RID: 83552
		[Token(Token = "0x4014660")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetGold;

		// Token: 0x04014661 RID: 83553
		[Token(Token = "0x4014661")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetUpgradeNeededRes;

		// Token: 0x04014662 RID: 83554
		[Token(Token = "0x4014662")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetResCntByWithdrawRatioAndHpRatio;

		// Token: 0x04014663 RID: 83555
		[Token(Token = "0x4014663")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetGoldCntByHpRatio;

		// Token: 0x04014664 RID: 83556
		[Token(Token = "0x4014664")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_IsBaseOrPortTrap;

		// Token: 0x04014665 RID: 83557
		[Token(Token = "0x4014665")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetRepairDiscount;

		// Token: 0x04014666 RID: 83558
		[Token(Token = "0x4014666")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetRepairCostByCharacter;

		// Token: 0x04014667 RID: 83559
		[Token(Token = "0x4014667")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetFenceId;

		// Token: 0x04014668 RID: 83560
		[Token(Token = "0x4014668")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_GetRareFenceId;

		// Token: 0x04014669 RID: 83561
		[Token(Token = "0x4014669")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetFenceLimit;

		// Token: 0x0401466A RID: 83562
		[Token(Token = "0x401466A")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetRareFenceLimit;

		// Token: 0x0401466B RID: 83563
		[Token(Token = "0x401466B")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_ConstructGetTrapTips;

		// Token: 0x0401466C RID: 83564
		[Token(Token = "0x401466C")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_GetNpcReactInst;
	}
}
