using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Building.DIY;
using Torappu.Building.UI;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building
{
	// Token: 0x0200181F RID: 6175
	[Token(Token = "0x200181F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class BuildingDataConverter
	{
		// Token: 0x06009C21 RID: 39969 RVA: 0x0003CDB0 File Offset: 0x0003AFB0
		[Token(Token = "0x6009C21")]
		[Address(RVA = "0x3171A40", Offset = "0x3170640", VA = "0x183171A40")]
		public static bool IsBigRoomSlot(GridPosition size)
		{
			return default(bool);
		}

		// Token: 0x06009C22 RID: 39970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C22")]
		[Address(RVA = "0x316DF50", Offset = "0x316CB50", VA = "0x18316DF50")]
		public static ListDict<BuildingData.RoomType, int> CountAllRooms(BuildingModel model)
		{
			return null;
		}

		// Token: 0x06009C23 RID: 39971 RVA: 0x0003CDC8 File Offset: 0x0003AFC8
		[Token(Token = "0x6009C23")]
		[Address(RVA = "0x316DED0", Offset = "0x316CAD0", VA = "0x18316DED0")]
		public static RoomSlotState ConvertPlayerRoomSlotState(PlayerRoomSlotState playerState)
		{
			return RoomSlotState.UNCLEANED;
		}

		// Token: 0x06009C24 RID: 39972 RVA: 0x0003CDE0 File Offset: 0x0003AFE0
		[Token(Token = "0x6009C24")]
		[Address(RVA = "0x3171130", Offset = "0x316FD30", VA = "0x183171130")]
		public static int GetRoomMaxLevel(BuildingData.RoomType roomId)
		{
			return 0;
		}

		// Token: 0x06009C25 RID: 39973 RVA: 0x0003CDF8 File Offset: 0x0003AFF8
		[Token(Token = "0x6009C25")]
		[Address(RVA = "0x31708C0", Offset = "0x316F4C0", VA = "0x1831708C0")]
		public static int GetMaxRoomCount(BuildingData.RoomType roomId)
		{
			return 0;
		}

		// Token: 0x06009C26 RID: 39974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C26")]
		[Address(RVA = "0x3170E40", Offset = "0x316FA40", VA = "0x183170E40")]
		public static BuildingData.RoomData.PhaseData GetPhase(this BuildingData.RoomData.PhaseData[] phases, int level)
		{
			return null;
		}

		// Token: 0x06009C27 RID: 39975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C27")]
		[Address(RVA = "0x316F790", Offset = "0x316E390", VA = "0x18316F790")]
		public static List<RoomSlotModel.RoomPanelInfo> GetCanSetRoomForEmpty(BuildingData.RoomCategory category, GridPosition size)
		{
			return null;
		}

		// Token: 0x06009C28 RID: 39976 RVA: 0x0003CE10 File Offset: 0x0003B010
		[Token(Token = "0x6009C28")]
		[Address(RVA = "0x3176150", Offset = "0x3174D50", VA = "0x183176150")]
		private static int _RoomPanelInfoComparasion(RoomSlotModel.RoomPanelInfo v0, RoomSlotModel.RoomPanelInfo v1)
		{
			return 0;
		}

		// Token: 0x06009C29 RID: 39977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C29")]
		[Address(RVA = "0x31728B0", Offset = "0x31714B0", VA = "0x1831728B0")]
		public static BuildingCharModel[] LoadStationedChars(string slotId, PlayerBuildingRoomSlot playerSlot, PlayerBuilding playerBuilding)
		{
			return null;
		}

		// Token: 0x06009C2A RID: 39978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C2A")]
		[Address(RVA = "0x31723A0", Offset = "0x3170FA0", VA = "0x1831723A0")]
		public static BuildingCharModel[] LoadStationedCharsForVisiting(string slotId, PlayerBuildingRoomSlot playerSlot, VisitBuildingResponse visitResponse)
		{
			return null;
		}

		// Token: 0x06009C2B RID: 39979 RVA: 0x0003CE28 File Offset: 0x0003B028
		[Token(Token = "0x6009C2B")]
		[Address(RVA = "0x3175490", Offset = "0x3174090", VA = "0x183175490")]
		private static DateTime _FindCharWorkFinishTime(string slotId, PlayerBuildingChar playerChar, PlayerBuildingRoomSlot playerSlot, PlayerBuilding playerBuilding)
		{
			return default(DateTime);
		}

		// Token: 0x06009C2C RID: 39980 RVA: 0x0003CE40 File Offset: 0x0003B040
		[Token(Token = "0x6009C2C")]
		[Address(RVA = "0x3175F30", Offset = "0x3174B30", VA = "0x183175F30")]
		private static DateTime _GetManufactFinishTime(string slotId, PlayerBuilding playerBuilding)
		{
			return default(DateTime);
		}

		// Token: 0x06009C2D RID: 39981 RVA: 0x0003CE58 File Offset: 0x0003B058
		[Token(Token = "0x6009C2D")]
		[Address(RVA = "0x3176040", Offset = "0x3174C40", VA = "0x183176040")]
		private static DateTime _GetTrainingFinishTime(string slotId, PlayerBuilding playerBuilding)
		{
			return default(DateTime);
		}

		// Token: 0x06009C2E RID: 39982 RVA: 0x0003CE70 File Offset: 0x0003B070
		[Token(Token = "0x6009C2E")]
		[Address(RVA = "0x3175E20", Offset = "0x3174A20", VA = "0x183175E20")]
		private static DateTime _GetHireFinishTime(string slotId, PlayerBuilding playerBuilding)
		{
			return default(DateTime);
		}

		// Token: 0x06009C2F RID: 39983 RVA: 0x0003CE88 File Offset: 0x0003B088
		[Token(Token = "0x6009C2F")]
		[Address(RVA = "0x3175AB0", Offset = "0x31746B0", VA = "0x183175AB0")]
		private static DateTime _GetContactFinishTime(string slotId, PlayerBuilding playerBuilding)
		{
			return default(DateTime);
		}

		// Token: 0x06009C30 RID: 39984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C30")]
		[Address(RVA = "0x31707F0", Offset = "0x316F3F0", VA = "0x1831707F0")]
		public static BuildingData.ManufactFormula GetManufactFormula(string formulaId)
		{
			return null;
		}

		// Token: 0x06009C31 RID: 39985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C31")]
		[Address(RVA = "0x3171390", Offset = "0x316FF90", VA = "0x183171390")]
		public static BuildingData.ShopFormula GetShopFormula(string formulaId)
		{
			return null;
		}

		// Token: 0x06009C32 RID: 39986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C32")]
		[Address(RVA = "0x3170FB0", Offset = "0x316FBB0", VA = "0x183170FB0")]
		public static BuildingData.RoomData GetRoomData(BuildingData.RoomType roomId)
		{
			return null;
		}

		// Token: 0x06009C33 RID: 39987 RVA: 0x0003CEA0 File Offset: 0x0003B0A0
		[Token(Token = "0x6009C33")]
		[Address(RVA = "0x3170600", Offset = "0x316F200", VA = "0x183170600")]
		public static int GetManufactCostReserve(string itemId, ItemType itemType, ManufactSnapshot snapshot)
		{
			return 0;
		}

		// Token: 0x06009C34 RID: 39988 RVA: 0x0003CEB8 File Offset: 0x0003B0B8
		[Token(Token = "0x6009C34")]
		[Address(RVA = "0x3171460", Offset = "0x3170060", VA = "0x183171460")]
		public static int GetShopSaleReserve(string itemId, ItemType itemType, ShopStockSnapshot snapshot)
		{
			return 0;
		}

		// Token: 0x06009C35 RID: 39989 RVA: 0x0003CED0 File Offset: 0x0003B0D0
		[Token(Token = "0x6009C35")]
		[Address(RVA = "0x316E120", Offset = "0x316CD20", VA = "0x18316E120")]
		public static int CountUnlockedManufactFormulaRoomLevelOnly(RoomConditionCheckOptions options)
		{
			return 0;
		}

		// Token: 0x06009C36 RID: 39990 RVA: 0x0003CEE8 File Offset: 0x0003B0E8
		[Token(Token = "0x6009C36")]
		[Address(RVA = "0x316E3E0", Offset = "0x316CFE0", VA = "0x18316E3E0")]
		public static int CountUnlockedWorkshopFormulaRoomLevelOnly(RoomConditionCheckOptions options)
		{
			return 0;
		}

		// Token: 0x06009C37 RID: 39991 RVA: 0x0003CF00 File Offset: 0x0003B100
		[Token(Token = "0x6009C37")]
		[Address(RVA = "0x3171C00", Offset = "0x3170800", VA = "0x183171C00")]
		public static bool LoadManufactFormulaUnlockCondition(BuildingData.ManufactFormula formula, out string unlockCond)
		{
			return default(bool);
		}

		// Token: 0x06009C38 RID: 39992 RVA: 0x0003CF18 File Offset: 0x0003B118
		[Token(Token = "0x6009C38")]
		[Address(RVA = "0x3172FC0", Offset = "0x3171BC0", VA = "0x183172FC0")]
		public static bool LoadWorkshopFormulaUnlockCondition(BuildingData.WorkshopFormula formula, out string unlockCond)
		{
			return default(bool);
		}

		// Token: 0x06009C39 RID: 39993 RVA: 0x0003CF30 File Offset: 0x0003B130
		[Token(Token = "0x6009C39")]
		[Address(RVA = "0x3175190", Offset = "0x3173D90", VA = "0x183175190")]
		private static bool _CheckRequiredRoomLevel(PlayerBuilding playerBuilding, BuildingData.RoomType roomId, int requireLevel, int requireCount, RoomConditionCheckOptions options)
		{
			return default(bool);
		}

		// Token: 0x06009C3A RID: 39994 RVA: 0x0003CF48 File Offset: 0x0003B148
		[Token(Token = "0x6009C3A")]
		[Address(RVA = "0x3175070", Offset = "0x3173C70", VA = "0x183175070")]
		private static bool _CheckRequireStage(string stageId, int rank)
		{
			return default(bool);
		}

		// Token: 0x06009C3B RID: 39995 RVA: 0x0003CF60 File Offset: 0x0003B160
		[Token(Token = "0x6009C3B")]
		[Address(RVA = "0x3174E70", Offset = "0x3173A70", VA = "0x183174E70")]
		private static bool _CheckIfUnlockedInPlayerDexNav(BuildingData.RoomType roomId, string formulaId)
		{
			return default(bool);
		}

		// Token: 0x06009C3C RID: 39996 RVA: 0x0003CF78 File Offset: 0x0003B178
		[Token(Token = "0x6009C3C")]
		[Address(RVA = "0x3172250", Offset = "0x3170E50", VA = "0x183172250")]
		public static float LoadManufactSpeed(int level)
		{
			return 0f;
		}

		// Token: 0x06009C3D RID: 39997 RVA: 0x0003CF90 File Offset: 0x0003B190
		[Token(Token = "0x6009C3D")]
		[Address(RVA = "0x316CE30", Offset = "0x316BA30", VA = "0x18316CE30")]
		public static RoomLevelConditionCheckingResult CheckRoomLevelConditionE(BuildingData.RoomData.PhaseData phase, BuildingData.RoomType roomType, int level, int countOffset = 0, [Optional] List<LevelConditionCheckItem> overrideRoomList, int overrideRoomCount = -1)
		{
			return default(RoomLevelConditionCheckingResult);
		}

		// Token: 0x06009C3E RID: 39998 RVA: 0x0003CFA8 File Offset: 0x0003B1A8
		[Token(Token = "0x6009C3E")]
		[Address(RVA = "0x316D400", Offset = "0x316C000", VA = "0x18316D400")]
		public static RoomLevelConditionCheckingResult CheckRoomLevelConditionE(RoomSlotModel model, [Optional] List<LevelConditionCheckItem> overrideRoomList, int overrideRoomLevel = -1, int overrideRoomCount = -1)
		{
			return default(RoomLevelConditionCheckingResult);
		}

		// Token: 0x06009C3F RID: 39999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C3F")]
		[Address(RVA = "0x3173A90", Offset = "0x3172690", VA = "0x183173A90")]
		public static void QueryRoomConnectedWithControl(Action<RoomSlotModel> action)
		{
		}

		// Token: 0x06009C40 RID: 40000 RVA: 0x0003CFC0 File Offset: 0x0003B1C0
		[Token(Token = "0x6009C40")]
		[Address(RVA = "0x316CC20", Offset = "0x316B820", VA = "0x18316CC20")]
		public static CleanConditionCheckingResult CheckRoomCanBeCleaned(RoomSlotModel room)
		{
			return default(CleanConditionCheckingResult);
		}

		// Token: 0x06009C41 RID: 40001 RVA: 0x0003CFD8 File Offset: 0x0003B1D8
		[Token(Token = "0x6009C41")]
		[Address(RVA = "0x316CBB0", Offset = "0x316B7B0", VA = "0x18316CBB0")]
		public static bool CheckRoomCanBeCleanedSimple(RoomSlotModel room)
		{
			return default(bool);
		}

		// Token: 0x06009C42 RID: 40002 RVA: 0x0003CFF0 File Offset: 0x0003B1F0
		[Token(Token = "0x6009C42")]
		[Address(RVA = "0x3173D10", Offset = "0x3172910", VA = "0x183173D10")]
		public static int SumElectricForBuild(RoomSlotModel targetSlot, BuildingData.RoomType targetRoom)
		{
			return 0;
		}

		// Token: 0x06009C43 RID: 40003 RVA: 0x0003D008 File Offset: 0x0003B208
		[Token(Token = "0x6009C43")]
		[Address(RVA = "0x3174060", Offset = "0x3172C60", VA = "0x183174060")]
		public static int SumElectricForUpgrade(RoomSlotModel targetSlot)
		{
			return 0;
		}

		// Token: 0x06009C44 RID: 40004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C44")]
		[Address(RVA = "0x3170F00", Offset = "0x316FB00", VA = "0x183170F00")]
		public static Func<RoomSlotModel, bool> GetRoomArchitectureValidPredicator(RoomSlotState state)
		{
			return null;
		}

		// Token: 0x06009C45 RID: 40005 RVA: 0x0003D020 File Offset: 0x0003B220
		[Token(Token = "0x6009C45")]
		[Address(RVA = "0x3170D20", Offset = "0x316F920", VA = "0x183170D20")]
		public static int GetOutputCountFromItemInShop(ItemType itemType, int count)
		{
			return 0;
		}

		// Token: 0x06009C46 RID: 40006 RVA: 0x0003D038 File Offset: 0x0003B238
		[Token(Token = "0x6009C46")]
		[Address(RVA = "0x316F990", Offset = "0x316E590", VA = "0x18316F990")]
		public static int GetCardCountInShop(ItemType itemType, int count)
		{
			return 0;
		}

		// Token: 0x06009C47 RID: 40007 RVA: 0x0003D050 File Offset: 0x0003B250
		[Token(Token = "0x6009C47")]
		[Address(RVA = "0x31715B0", Offset = "0x31701B0", VA = "0x1831715B0")]
		public static StationedCharState GetStationedCharState(BuildingCharModel charModel)
		{
			return StationedCharState.NONE;
		}

		// Token: 0x06009C48 RID: 40008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C48")]
		[Address(RVA = "0x3170C60", Offset = "0x316F860", VA = "0x183170C60")]
		public static string GetNotTooLargeCount(int count)
		{
			return null;
		}

		// Token: 0x06009C49 RID: 40009 RVA: 0x0003D068 File Offset: 0x0003B268
		[Token(Token = "0x6009C49")]
		[Address(RVA = "0x316DB30", Offset = "0x316C730", VA = "0x18316DB30")]
		public static BuildCostCheckingResult CheckingGeneralBuildCost(BuildingData.RoomData.BuildCost buildCost)
		{
			return default(BuildCostCheckingResult);
		}

		// Token: 0x06009C4A RID: 40010 RVA: 0x0003D080 File Offset: 0x0003B280
		[Token(Token = "0x6009C4A")]
		[Address(RVA = "0x316C830", Offset = "0x316B430", VA = "0x18316C830")]
		public static bool CheckIfRoomWorking(RoomSlotModel slotModel)
		{
			return default(bool);
		}

		// Token: 0x06009C4B RID: 40011 RVA: 0x0003D098 File Offset: 0x0003B298
		[Token(Token = "0x6009C4B")]
		[Address(RVA = "0x316C580", Offset = "0x316B180", VA = "0x18316C580")]
		public static bool CheckIfRoomBusyToUpLevel(RoomSlotModel slotModel, out string alert)
		{
			return default(bool);
		}

		// Token: 0x06009C4C RID: 40012 RVA: 0x0003D0B0 File Offset: 0x0003B2B0
		[Token(Token = "0x6009C4C")]
		[Address(RVA = "0x316C370", Offset = "0x316AF70", VA = "0x18316C370")]
		public static bool CheckIfRoomBusyToTearDown(RoomSlotModel slotModel, out string alert)
		{
			return default(bool);
		}

		// Token: 0x06009C4D RID: 40013 RVA: 0x0003D0C8 File Offset: 0x0003B2C8
		[Token(Token = "0x6009C4D")]
		[Address(RVA = "0x316CA70", Offset = "0x316B670", VA = "0x18316CA70")]
		public static bool CheckIfTrainingRoomBusy()
		{
			return default(bool);
		}

		// Token: 0x06009C4E RID: 40014 RVA: 0x0003D0E0 File Offset: 0x0003B2E0
		[Token(Token = "0x6009C4E")]
		[Address(RVA = "0x3174DF0", Offset = "0x31739F0", VA = "0x183174DF0")]
		private static bool _CheckIfTrainingRoomBusy(PlayerBuildingTraining playerTraining)
		{
			return default(bool);
		}

		// Token: 0x06009C4F RID: 40015 RVA: 0x0003D0F8 File Offset: 0x0003B2F8
		[Token(Token = "0x6009C4F")]
		[Address(RVA = "0x316D600", Offset = "0x316C200", VA = "0x18316D600")]
		public static BuildCostCheckingResult CheckingCleanCost(RoomSlotModel model, [Optional] Action<UIItemViewModel, int, int> action)
		{
			return default(BuildCostCheckingResult);
		}

		// Token: 0x06009C50 RID: 40016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C50")]
		[Address(RVA = "0x316EC60", Offset = "0x316D860", VA = "0x18316EC60")]
		public static string DisplayDormApRecovery(int level, int customManpowerRecover = 0, bool useCustom = false, int bufPercent = 0)
		{
			return null;
		}

		// Token: 0x06009C51 RID: 40017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C51")]
		[Address(RVA = "0x316EAD0", Offset = "0x316D6D0", VA = "0x18316EAD0")]
		public static string DisplayCommonRate(float rate)
		{
			return null;
		}

		// Token: 0x06009C52 RID: 40018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C52")]
		[Address(RVA = "0x316EB80", Offset = "0x316D780", VA = "0x18316EB80")]
		public static string DisplayCommonRealNumber(int ap)
		{
			return null;
		}

		// Token: 0x06009C53 RID: 40019 RVA: 0x0003D110 File Offset: 0x0003B310
		[Token(Token = "0x6009C53")]
		[Address(RVA = "0x316FBD0", Offset = "0x316E7D0", VA = "0x18316FBD0")]
		public static int GetDIYComfortValue(int roomIndex, [Optional] IFurnitureProvider overrideFurnitureProvider, [Optional] IDIYRoomModifierProvider overrideModifierProvider)
		{
			return 0;
		}

		// Token: 0x06009C54 RID: 40020 RVA: 0x0003D128 File Offset: 0x0003B328
		[Token(Token = "0x6009C54")]
		[Address(RVA = "0x3174B10", Offset = "0x3173710", VA = "0x183174B10")]
		private static int _CalculateComfortSingleFurniture(int roomIndex, IFurnitureProvider furnitureProvider, IDIYRoomModifierProvider modifierProvider, Action<IDIYItem, int> singleFurnitureHandler)
		{
			return 0;
		}

		// Token: 0x06009C55 RID: 40021 RVA: 0x0003D140 File Offset: 0x0003B340
		[Token(Token = "0x6009C55")]
		[Address(RVA = "0x3174410", Offset = "0x3173010", VA = "0x183174410")]
		private static int _CalculateComfortFurnitureGroup(int roomIndex, IFurnitureGroupData group, IFurnitureProvider furnitureProvider, IDIYRoomModifierProvider modifierProvider, out int collectCount)
		{
			return 0;
		}

		// Token: 0x06009C56 RID: 40022 RVA: 0x0003D158 File Offset: 0x0003B358
		[Token(Token = "0x6009C56")]
		[Address(RVA = "0x316BF20", Offset = "0x316AB20", VA = "0x18316BF20")]
		public static int CalculateComfort(int roomIndex, Action<IDIYItem, int> singleFurnitureHandler, Action<IFurnitureGroupData, int> furnitureGroupHandler, [Optional] IFurnitureProvider overrideFurnitureProvider, [Optional] IDIYRoomModifierProvider overrideModifierProvider)
		{
			return 0;
		}

		// Token: 0x06009C57 RID: 40023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C57")]
		[Address(RVA = "0x316E6A0", Offset = "0x316D2A0", VA = "0x18316E6A0")]
		public static DIYPreset CreateDIYPresetByRoom(int roomIndex, IFurnitureProvider furnitureManager, IDIYRoomModifierProvider modifierProvider)
		{
			return null;
		}

		// Token: 0x06009C58 RID: 40024 RVA: 0x0003D170 File Offset: 0x0003B370
		[Token(Token = "0x6009C58")]
		[Address(RVA = "0x316A2E0", Offset = "0x3168EE0", VA = "0x18316A2E0")]
		public static int ApplyDIYPreset(IDIYPreset preset, int roomIndex, IFurnitureManager furnitureManager, IDIYRoomModifierManager modifierManager, out string lackFurnitureId, [Optional] DIYRoom room)
		{
			return 0;
		}

		// Token: 0x06009C59 RID: 40025 RVA: 0x0003D188 File Offset: 0x0003B388
		[Token(Token = "0x6009C59")]
		[Address(RVA = "0x316BBF0", Offset = "0x316A7F0", VA = "0x18316BBF0")]
		public static KeyValuePair<int, int> CalcCreditProvidedByDorms()
		{
			return default(KeyValuePair<int, int>);
		}

		// Token: 0x06009C5A RID: 40026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C5A")]
		[Address(RVA = "0x31738A0", Offset = "0x31724A0", VA = "0x1831738A0")]
		public static string ParseRequireItemCount(long curCount, long requireCount, ItemType itemType, string hilightColorCode)
		{
			return null;
		}

		// Token: 0x06009C5B RID: 40027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C5B")]
		[Address(RVA = "0x3173640", Offset = "0x3172240", VA = "0x183173640")]
		public static string ParseRequireItemCount(long curCount, long requireCount, ItemType itemType, Color hilightColor)
		{
			return null;
		}

		// Token: 0x06009C5C RID: 40028 RVA: 0x0003D1A0 File Offset: 0x0003B3A0
		[Token(Token = "0x6009C5C")]
		[Address(RVA = "0x316BE60", Offset = "0x316AA60", VA = "0x18316BE60")]
		public static KeyValuePair<int, int> CalcCreditProvidedBySingleDorm(string slotId)
		{
			return default(KeyValuePair<int, int>);
		}

		// Token: 0x06009C5D RID: 40029 RVA: 0x0003D1B8 File Offset: 0x0003B3B8
		[Token(Token = "0x6009C5D")]
		[Address(RVA = "0x3175390", Offset = "0x3173F90", VA = "0x183175390")]
		private static int _DormComfortToCreditFormula(int comfort)
		{
			return 0;
		}

		// Token: 0x06009C5E RID: 40030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C5E")]
		[Address(RVA = "0x3171890", Offset = "0x3170490", VA = "0x183171890")]
		public static string GetTradingStrategyUnlockCond()
		{
			return null;
		}

		// Token: 0x06009C5F RID: 40031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C5F")]
		[Address(RVA = "0x3171760", Offset = "0x3170360", VA = "0x183171760")]
		public static string GetTradingOrderTypeName(BuildingData.OrderType type, [Optional] PlayerBuildingTradingOrder.TradingGoldTag tag)
		{
			return null;
		}

		// Token: 0x06009C60 RID: 40032 RVA: 0x0003D1D0 File Offset: 0x0003B3D0
		[Token(Token = "0x6009C60")]
		[Address(RVA = "0x316B700", Offset = "0x316A300", VA = "0x18316B700")]
		public static CharManpowerState CalcCharManpowerState(BuildingCharModel charModel)
		{
			return CharManpowerState.NONE;
		}

		// Token: 0x06009C61 RID: 40033 RVA: 0x0003D1E8 File Offset: 0x0003B3E8
		[Token(Token = "0x6009C61")]
		[Address(RVA = "0x316BA20", Offset = "0x316A620", VA = "0x18316BA20")]
		public static CharManpowerState CalcCharManpowerState(BuildingCharModel charModel, KeyValuePair<long, int> apInfo)
		{
			return CharManpowerState.NONE;
		}

		// Token: 0x06009C62 RID: 40034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C62")]
		[Address(RVA = "0x316FAD0", Offset = "0x316E6D0", VA = "0x18316FAD0")]
		public static string GetCharManpowerStateName(CharManpowerState state)
		{
			return null;
		}

		// Token: 0x06009C63 RID: 40035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C63")]
		[Address(RVA = "0x316FE80", Offset = "0x316EA80", VA = "0x18316FE80")]
		public static string GetLaborAccelUnlockAlert()
		{
			return null;
		}

		// Token: 0x06009C64 RID: 40036 RVA: 0x0003D200 File Offset: 0x0003B400
		[Token(Token = "0x6009C64")]
		[Address(RVA = "0x3171B80", Offset = "0x3170780", VA = "0x183171B80")]
		public static bool IsRoomCategoryCoded(BuildingData.RoomCategory category)
		{
			return default(bool);
		}

		// Token: 0x06009C65 RID: 40037 RVA: 0x0003D218 File Offset: 0x0003B418
		[Token(Token = "0x6009C65")]
		[Address(RVA = "0x3171B10", Offset = "0x3170710", VA = "0x183171B10")]
		public static bool IsElevatorRoom(BuildingData.RoomCategory category)
		{
			return default(bool);
		}

		// Token: 0x06009C66 RID: 40038 RVA: 0x0003D230 File Offset: 0x0003B430
		[Token(Token = "0x6009C66")]
		[Address(RVA = "0x3171AA0", Offset = "0x31706A0", VA = "0x183171AA0")]
		public static bool IsDiyEnabledRoomType(BuildingData.RoomType type)
		{
			return default(bool);
		}

		// Token: 0x06009C67 RID: 40039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C67")]
		[Address(RVA = "0x3171250", Offset = "0x316FE50", VA = "0x183171250")]
		public static string GetRoomName(BuildingData.RoomType roomType)
		{
			return null;
		}

		// Token: 0x06009C68 RID: 40040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C68")]
		[Address(RVA = "0x316FFE0", Offset = "0x316EBE0", VA = "0x18316FFE0")]
		public static string GetLevelInfoTypeName(LevelInfoType type)
		{
			return null;
		}

		// Token: 0x06009C69 RID: 40041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C69")]
		[Address(RVA = "0x316F2C0", Offset = "0x316DEC0", VA = "0x18316F2C0")]
		public static string FormatBuffedValue(float baseVal, string colorCode, params float[] buffVals)
		{
			return null;
		}

		// Token: 0x06009C6A RID: 40042 RVA: 0x0003D248 File Offset: 0x0003B448
		[Token(Token = "0x6009C6A")]
		[Address(RVA = "0x316F090", Offset = "0x316DC90", VA = "0x18316F090")]
		public static BuildingBuffedValueView.BuffedValue FormatBuffedValue(float buffedVal, Color bkgColor, Color textColor, bool usePercentFormat)
		{
			return default(BuildingBuffedValueView.BuffedValue);
		}

		// Token: 0x06009C6B RID: 40043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C6B")]
		[Address(RVA = "0x316EE20", Offset = "0x316DA20", VA = "0x18316EE20")]
		public static string FormatBuffedPercent(params float[] buffVals)
		{
			return null;
		}

		// Token: 0x06009C6C RID: 40044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C6C")]
		[Address(RVA = "0x316F580", Offset = "0x316E180", VA = "0x18316F580")]
		public static string FormatBuildingRestTime(TimeSpan restTime)
		{
			return null;
		}

		// Token: 0x06009C6D RID: 40045 RVA: 0x0003D260 File Offset: 0x0003B460
		[Token(Token = "0x6009C6D")]
		[Address(RVA = "0x3170A70", Offset = "0x316F670", VA = "0x183170A70")]
		public static DateTime GetNextMeetingUpdateTime()
		{
			return default(DateTime);
		}

		// Token: 0x06009C6E RID: 40046 RVA: 0x0003D278 File Offset: 0x0003B478
		[Token(Token = "0x6009C6E")]
		[Address(RVA = "0x316C290", Offset = "0x316AE90", VA = "0x18316C290")]
		public static bool CheckIfMeetingRoomTransferring(PlayerBuildingMeeting room)
		{
			return default(bool);
		}

		// Token: 0x06009C6F RID: 40047 RVA: 0x0003D290 File Offset: 0x0003B490
		[Token(Token = "0x6009C6F")]
		[Address(RVA = "0x316C690", Offset = "0x316B290", VA = "0x18316C690")]
		public static bool CheckIfRoomCanUse(BuildingData.RoomType roomType)
		{
			return default(bool);
		}

		// Token: 0x06009C70 RID: 40048 RVA: 0x0003D2A8 File Offset: 0x0003B4A8
		[Token(Token = "0x6009C70")]
		[Address(RVA = "0x3175CC0", Offset = "0x31748C0", VA = "0x183175CC0")]
		private static int _GetFurnitureTotalCount(string furnitureId)
		{
			return 0;
		}

		// Token: 0x04009319 RID: 37657
		[Token(Token = "0x4009319")]
		private const int LARGE_COUNT_NUMBER = 999999;

		// Token: 0x0400931A RID: 37658
		[Token(Token = "0x400931A")]
		private const float MANPOWER_DISPLAY_FACTOR = 3600f;

		// Token: 0x0400931B RID: 37659
		[Token(Token = "0x400931B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsBigRoomSlot;

		// Token: 0x0400931C RID: 37660
		[Token(Token = "0x400931C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CountAllRooms;

		// Token: 0x0400931D RID: 37661
		[Token(Token = "0x400931D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ConvertPlayerRoomSlotState;

		// Token: 0x0400931E RID: 37662
		[Token(Token = "0x400931E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetRoomMaxLevel;

		// Token: 0x0400931F RID: 37663
		[Token(Token = "0x400931F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetMaxRoomCount;

		// Token: 0x04009320 RID: 37664
		[Token(Token = "0x4009320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPhase;

		// Token: 0x04009321 RID: 37665
		[Token(Token = "0x4009321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCanSetRoomForEmpty;

		// Token: 0x04009322 RID: 37666
		[Token(Token = "0x4009322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RoomPanelInfoComparasion;

		// Token: 0x04009323 RID: 37667
		[Token(Token = "0x4009323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadStationedChars;

		// Token: 0x04009324 RID: 37668
		[Token(Token = "0x4009324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadStationedCharsForVisiting;

		// Token: 0x04009325 RID: 37669
		[Token(Token = "0x4009325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__FindCharWorkFinishTime;

		// Token: 0x04009326 RID: 37670
		[Token(Token = "0x4009326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetManufactFinishTime;

		// Token: 0x04009327 RID: 37671
		[Token(Token = "0x4009327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetTrainingFinishTime;

		// Token: 0x04009328 RID: 37672
		[Token(Token = "0x4009328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetHireFinishTime;

		// Token: 0x04009329 RID: 37673
		[Token(Token = "0x4009329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetContactFinishTime;

		// Token: 0x0400932A RID: 37674
		[Token(Token = "0x400932A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetManufactFormula;

		// Token: 0x0400932B RID: 37675
		[Token(Token = "0x400932B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetShopFormula;

		// Token: 0x0400932C RID: 37676
		[Token(Token = "0x400932C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetRoomData;

		// Token: 0x0400932D RID: 37677
		[Token(Token = "0x400932D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetManufactCostReserve;

		// Token: 0x0400932E RID: 37678
		[Token(Token = "0x400932E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetShopSaleReserve;

		// Token: 0x0400932F RID: 37679
		[Token(Token = "0x400932F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CountUnlockedManufactFormulaRoomLevelOnly;

		// Token: 0x04009330 RID: 37680
		[Token(Token = "0x4009330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CountUnlockedWorkshopFormulaRoomLevelOnly;

		// Token: 0x04009331 RID: 37681
		[Token(Token = "0x4009331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadManufactFormulaUnlockCondition;

		// Token: 0x04009332 RID: 37682
		[Token(Token = "0x4009332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_LoadWorkshopFormulaUnlockCondition;

		// Token: 0x04009333 RID: 37683
		[Token(Token = "0x4009333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CheckRequiredRoomLevel;

		// Token: 0x04009334 RID: 37684
		[Token(Token = "0x4009334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__CheckRequireStage;

		// Token: 0x04009335 RID: 37685
		[Token(Token = "0x4009335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CheckIfUnlockedInPlayerDexNav;

		// Token: 0x04009336 RID: 37686
		[Token(Token = "0x4009336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_LoadManufactSpeed;

		// Token: 0x04009337 RID: 37687
		[Token(Token = "0x4009337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_CheckRoomLevelConditionE;

		// Token: 0x04009338 RID: 37688
		[Token(Token = "0x4009338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix1_CheckRoomLevelConditionE;

		// Token: 0x04009339 RID: 37689
		[Token(Token = "0x4009339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_QueryRoomConnectedWithControl;

		// Token: 0x0400933A RID: 37690
		[Token(Token = "0x400933A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CheckRoomCanBeCleaned;

		// Token: 0x0400933B RID: 37691
		[Token(Token = "0x400933B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_CheckRoomCanBeCleanedSimple;

		// Token: 0x0400933C RID: 37692
		[Token(Token = "0x400933C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_SumElectricForBuild;

		// Token: 0x0400933D RID: 37693
		[Token(Token = "0x400933D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_SumElectricForUpgrade;

		// Token: 0x0400933E RID: 37694
		[Token(Token = "0x400933E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetRoomArchitectureValidPredicator;

		// Token: 0x0400933F RID: 37695
		[Token(Token = "0x400933F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetOutputCountFromItemInShop;

		// Token: 0x04009340 RID: 37696
		[Token(Token = "0x4009340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_GetCardCountInShop;

		// Token: 0x04009341 RID: 37697
		[Token(Token = "0x4009341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_GetStationedCharState;

		// Token: 0x04009342 RID: 37698
		[Token(Token = "0x4009342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GetNotTooLargeCount;

		// Token: 0x04009343 RID: 37699
		[Token(Token = "0x4009343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_CheckingGeneralBuildCost;

		// Token: 0x04009344 RID: 37700
		[Token(Token = "0x4009344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_CheckIfRoomWorking;

		// Token: 0x04009345 RID: 37701
		[Token(Token = "0x4009345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_CheckIfRoomBusyToUpLevel;

		// Token: 0x04009346 RID: 37702
		[Token(Token = "0x4009346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_CheckIfRoomBusyToTearDown;

		// Token: 0x04009347 RID: 37703
		[Token(Token = "0x4009347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_CheckIfTrainingRoomBusy;

		// Token: 0x04009348 RID: 37704
		[Token(Token = "0x4009348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__CheckIfTrainingRoomBusy;

		// Token: 0x04009349 RID: 37705
		[Token(Token = "0x4009349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_CheckingCleanCost;

		// Token: 0x0400934A RID: 37706
		[Token(Token = "0x400934A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_DisplayDormApRecovery;

		// Token: 0x0400934B RID: 37707
		[Token(Token = "0x400934B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_DisplayCommonRate;

		// Token: 0x0400934C RID: 37708
		[Token(Token = "0x400934C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_DisplayCommonRealNumber;

		// Token: 0x0400934D RID: 37709
		[Token(Token = "0x400934D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_GetDIYComfortValue;

		// Token: 0x0400934E RID: 37710
		[Token(Token = "0x400934E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__CalculateComfortSingleFurniture;

		// Token: 0x0400934F RID: 37711
		[Token(Token = "0x400934F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__CalculateComfortFurnitureGroup;

		// Token: 0x04009350 RID: 37712
		[Token(Token = "0x4009350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_CalculateComfort;

		// Token: 0x04009351 RID: 37713
		[Token(Token = "0x4009351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_CreateDIYPresetByRoom;

		// Token: 0x04009352 RID: 37714
		[Token(Token = "0x4009352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_ApplyDIYPreset;

		// Token: 0x04009353 RID: 37715
		[Token(Token = "0x4009353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_CalcCreditProvidedByDorms;

		// Token: 0x04009354 RID: 37716
		[Token(Token = "0x4009354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_ParseRequireItemCount;

		// Token: 0x04009355 RID: 37717
		[Token(Token = "0x4009355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix1_ParseRequireItemCount;

		// Token: 0x04009356 RID: 37718
		[Token(Token = "0x4009356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_CalcCreditProvidedBySingleDorm;

		// Token: 0x04009357 RID: 37719
		[Token(Token = "0x4009357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__DormComfortToCreditFormula;

		// Token: 0x04009358 RID: 37720
		[Token(Token = "0x4009358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_GetTradingStrategyUnlockCond;

		// Token: 0x04009359 RID: 37721
		[Token(Token = "0x4009359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_GetTradingOrderTypeName;

		// Token: 0x0400935A RID: 37722
		[Token(Token = "0x400935A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_CalcCharManpowerState;

		// Token: 0x0400935B RID: 37723
		[Token(Token = "0x400935B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix1_CalcCharManpowerState;

		// Token: 0x0400935C RID: 37724
		[Token(Token = "0x400935C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_GetCharManpowerStateName;

		// Token: 0x0400935D RID: 37725
		[Token(Token = "0x400935D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_GetLaborAccelUnlockAlert;

		// Token: 0x0400935E RID: 37726
		[Token(Token = "0x400935E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_IsRoomCategoryCoded;

		// Token: 0x0400935F RID: 37727
		[Token(Token = "0x400935F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_IsElevatorRoom;

		// Token: 0x04009360 RID: 37728
		[Token(Token = "0x4009360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_IsDiyEnabledRoomType;

		// Token: 0x04009361 RID: 37729
		[Token(Token = "0x4009361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_GetRoomName;

		// Token: 0x04009362 RID: 37730
		[Token(Token = "0x4009362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_GetLevelInfoTypeName;

		// Token: 0x04009363 RID: 37731
		[Token(Token = "0x4009363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_FormatBuffedValue;

		// Token: 0x04009364 RID: 37732
		[Token(Token = "0x4009364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix1_FormatBuffedValue;

		// Token: 0x04009365 RID: 37733
		[Token(Token = "0x4009365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_FormatBuffedPercent;

		// Token: 0x04009366 RID: 37734
		[Token(Token = "0x4009366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_FormatBuildingRestTime;

		// Token: 0x04009367 RID: 37735
		[Token(Token = "0x4009367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_GetNextMeetingUpdateTime;

		// Token: 0x04009368 RID: 37736
		[Token(Token = "0x4009368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_CheckIfMeetingRoomTransferring;

		// Token: 0x04009369 RID: 37737
		[Token(Token = "0x4009369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_CheckIfRoomCanUse;

		// Token: 0x0400936A RID: 37738
		[Token(Token = "0x400936A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0__GetFurnitureTotalCount;
	}
}
