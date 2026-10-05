using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CBE RID: 23742
	[Token(Token = "0x2005CBE")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ClimbTowerUtil
	{
		// Token: 0x060225CE RID: 140750 RVA: 0x000BD2A0 File Offset: 0x000BB4A0
		[Token(Token = "0x60225CE")]
		[Address(RVA = "0x1CDBDF0", Offset = "0x1CDA9F0", VA = "0x181CDBDF0")]
		public static bool EnsurePlayerClimbTower()
		{
			return default(bool);
		}

		// Token: 0x060225CF RID: 140751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225CF")]
		[Address(RVA = "0x1CDBEA0", Offset = "0x1CDAAA0", VA = "0x181CDBEA0")]
		public static string GetClimbTowerFuncLockedToast()
		{
			return null;
		}

		// Token: 0x060225D0 RID: 140752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225D0")]
		[Address(RVA = "0x1CDC440", Offset = "0x1CDB040", VA = "0x181CDC440")]
		public static string GetIncompleteTrainTowerId()
		{
			return null;
		}

		// Token: 0x060225D1 RID: 140753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225D1")]
		[Address(RVA = "0x1CDD330", Offset = "0x1CDBF30", VA = "0x181CDD330")]
		public static UIPageControllerParam SceneParamToClimbTower(DataBundle bundleToJumpBack)
		{
			return null;
		}

		// Token: 0x060225D2 RID: 140754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225D2")]
		[Address(RVA = "0x1CDC660", Offset = "0x1CDB260", VA = "0x181CDC660")]
		public static string GetRemainTimeText(long endTs)
		{
			return null;
		}

		// Token: 0x060225D3 RID: 140755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225D3")]
		[Address(RVA = "0x1CDD100", Offset = "0x1CDBD00", VA = "0x181CDD100")]
		public static Sprite LoadTowerIcon(string towerId, ILoadAsset page)
		{
			return null;
		}

		// Token: 0x060225D4 RID: 140756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225D4")]
		[Address(RVA = "0x1CDCEE0", Offset = "0x1CDBAE0", VA = "0x181CDCEE0")]
		public static Sprite LoadTowerIconForBattleFinish(string towerId)
		{
			return null;
		}

		// Token: 0x060225D5 RID: 140757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225D5")]
		[Address(RVA = "0x1CDCC20", Offset = "0x1CDB820", VA = "0x181CDCC20")]
		public static Sprite LoadGodCardIcon(string cardId, ILoadAsset iLoadAsset)
		{
			return null;
		}

		// Token: 0x060225D6 RID: 140758 RVA: 0x000BD2B8 File Offset: 0x000BB4B8
		[Token(Token = "0x60225D6")]
		[Address(RVA = "0x1CDB750", Offset = "0x1CDA350", VA = "0x181CDB750")]
		public static int CalcTrapCount(string towerId)
		{
			return 0;
		}

		// Token: 0x060225D7 RID: 140759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225D7")]
		[Address(RVA = "0x1CDCDA0", Offset = "0x1CDB9A0", VA = "0x181CDCDA0")]
		public static Sprite LoadTowerBkg(string towerId, UIPage page)
		{
			return null;
		}

		// Token: 0x060225D8 RID: 140760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225D8")]
		[Address(RVA = "0x1CDCD00", Offset = "0x1CDB900", VA = "0x181CDCD00")]
		public static Sprite LoadStageBtnIcon(string towerId, UIPage page)
		{
			return null;
		}

		// Token: 0x060225D9 RID: 140761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225D9")]
		[Address(RVA = "0x1CDC8C0", Offset = "0x1CDB4C0", VA = "0x181CDC8C0")]
		public static string GetTimeCountDownText(long targetTimeStamp)
		{
			return null;
		}

		// Token: 0x060225DA RID: 140762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225DA")]
		[Address(RVA = "0x1CDDD00", Offset = "0x1CDC900", VA = "0x181CDDD00")]
		private static Sprite _LoadAutoPackSprite(string spriteId, string hubPath, ILoadAsset iLoadAsset)
		{
			return null;
		}

		// Token: 0x060225DB RID: 140763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225DB")]
		[Address(RVA = "0x1CDCCA0", Offset = "0x1CDB8A0", VA = "0x181CDCCA0")]
		public static List<EnemyHandBookEverViewModel> LoadLevelEnemyHandbookData(string levelPath)
		{
			return null;
		}

		// Token: 0x060225DC RID: 140764 RVA: 0x000BD2D0 File Offset: 0x000BB4D0
		[Token(Token = "0x60225DC")]
		[Address(RVA = "0x1CDC810", Offset = "0x1CDB410", VA = "0x181CDC810")]
		public static int GetTacticalBuffProfessionOrder(ProfessionCategory profession)
		{
			return 0;
		}

		// Token: 0x060225DD RID: 140765 RVA: 0x000BD2E8 File Offset: 0x000BB4E8
		[Token(Token = "0x60225DD")]
		[Address(RVA = "0x1CDC770", Offset = "0x1CDB370", VA = "0x181CDC770")]
		public static int GetStepVal(TowerCurrent.TowerGameState gameState, bool isHard)
		{
			return 0;
		}

		// Token: 0x060225DE RID: 140766 RVA: 0x000BD300 File Offset: 0x000BB500
		[Token(Token = "0x60225DE")]
		[Address(RVA = "0x1CDCB20", Offset = "0x1CDB720", VA = "0x181CDCB20")]
		public static int GetTotalStepCount(bool isHard)
		{
			return 0;
		}

		// Token: 0x060225DF RID: 140767 RVA: 0x000BD318 File Offset: 0x000BB518
		[Token(Token = "0x60225DF")]
		[Address(RVA = "0x1CDC110", Offset = "0x1CDAD10", VA = "0x181CDC110")]
		public static int GetEquipUnlockCount()
		{
			return 0;
		}

		// Token: 0x060225E0 RID: 140768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225E0")]
		[Address(RVA = "0x1CDDBD0", Offset = "0x1CDC7D0", VA = "0x181CDDBD0")]
		private static string _GetEquipUnlockText()
		{
			return null;
		}

		// Token: 0x060225E1 RID: 140769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225E1")]
		[Address(RVA = "0x1CDD880", Offset = "0x1CDC480", VA = "0x181CDD880")]
		private static string _FormatTimeDelta(TimeSpan timeSpan)
		{
			return null;
		}

		// Token: 0x060225E2 RID: 140770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225E2")]
		[Address(RVA = "0x1CDBBB0", Offset = "0x1CDA7B0", VA = "0x181CDBBB0")]
		public static void ConsumeAllCharExpansionTrack()
		{
		}

		// Token: 0x060225E3 RID: 140771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225E3")]
		[Address(RVA = "0x1CDD250", Offset = "0x1CDBE50", VA = "0x181CDD250")]
		public static void RecordNewCharExpansion(string charId)
		{
		}

		// Token: 0x060225E4 RID: 140772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225E4")]
		[Address(RVA = "0x1CDBC50", Offset = "0x1CDA850", VA = "0x181CDBC50")]
		public static void ConsumeNewCharExpansion(string charId)
		{
		}

		// Token: 0x060225E5 RID: 140773 RVA: 0x000BD330 File Offset: 0x000BB530
		[Token(Token = "0x60225E5")]
		[Address(RVA = "0x1CDBA00", Offset = "0x1CDA600", VA = "0x181CDBA00")]
		public static bool CheckNewCharExpansion(string charId)
		{
			return default(bool);
		}

		// Token: 0x060225E6 RID: 140774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225E6")]
		[Address(RVA = "0x1CDDB10", Offset = "0x1CDC710", VA = "0x181CDDB10")]
		private static string _GetCurrentGameId()
		{
			return null;
		}

		// Token: 0x060225E7 RID: 140775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225E7")]
		[Address(RVA = "0x1CDD9F0", Offset = "0x1CDC5F0", VA = "0x181CDD9F0")]
		private static string _GetClimbTowerCharTrackType()
		{
			return null;
		}

		// Token: 0x060225E8 RID: 140776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225E8")]
		[Address(RVA = "0x1CDD7E0", Offset = "0x1CDC3E0", VA = "0x181CDD7E0")]
		private static void _DoTrack(string id)
		{
		}

		// Token: 0x060225E9 RID: 140777 RVA: 0x000BD348 File Offset: 0x000BB548
		[Token(Token = "0x60225E9")]
		[Address(RVA = "0x1CDD730", Offset = "0x1CDC330", VA = "0x181CDD730")]
		private static bool _ConsumeTrack(string id)
		{
			return default(bool);
		}

		// Token: 0x060225EA RID: 140778 RVA: 0x000BD360 File Offset: 0x000BB560
		[Token(Token = "0x60225EA")]
		[Address(RVA = "0x1CDD680", Offset = "0x1CDC280", VA = "0x181CDD680")]
		private static bool _CheckTrack(string id)
		{
			return default(bool);
		}

		// Token: 0x060225EB RID: 140779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225EB")]
		[Address(RVA = "0x1CDD1A0", Offset = "0x1CDBDA0", VA = "0x181CDD1A0")]
		public static void LogTowerHardModeUnlocked(string towerId)
		{
		}

		// Token: 0x060225EC RID: 140780 RVA: 0x000BD378 File Offset: 0x000BB578
		[Token(Token = "0x60225EC")]
		[Address(RVA = "0x1CDBB00", Offset = "0x1CDA700", VA = "0x181CDBB00")]
		public static bool CheckTowerHardModeUnlockTrack(string towerId)
		{
			return default(bool);
		}

		// Token: 0x060225ED RID: 140781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60225ED")]
		[Address(RVA = "0x1CDBD40", Offset = "0x1CDA940", VA = "0x181CDBD40")]
		public static void ConsumeTowerHardModeUnlockTrack(string towerId)
		{
		}

		// Token: 0x060225EE RID: 140782 RVA: 0x000BD390 File Offset: 0x000BB590
		[Token(Token = "0x60225EE")]
		[Address(RVA = "0x1CDC030", Offset = "0x1CDAC30", VA = "0x181CDC030")]
		public static Color GetColorByMode(bool isHardMode)
		{
			return default(Color);
		}

		// Token: 0x060225EF RID: 140783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225EF")]
		[Address(RVA = "0x1CDC5E0", Offset = "0x1CDB1E0", VA = "0x181CDC5E0")]
		public static string GetNamePostfixByMode(bool isHardMode)
		{
			return null;
		}

		// Token: 0x060225F0 RID: 140784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60225F0")]
		[Address(RVA = "0x1CDCB80", Offset = "0x1CDB780", VA = "0x181CDCB80")]
		public static string[] GetTowerLevelsByMode(ClimbTowerSingleTowerData towerData, bool isHardMode)
		{
			return null;
		}

		// Token: 0x060225F1 RID: 140785 RVA: 0x000BD3A8 File Offset: 0x000BB5A8
		[Token(Token = "0x60225F1")]
		[Address(RVA = "0x1CDB950", Offset = "0x1CDA550", VA = "0x181CDB950")]
		public static bool CheckIsHardStageInTowerByStageId(string stageId, ClimbTowerSingleTowerData towerData)
		{
			return default(bool);
		}

		// Token: 0x0402F3A1 RID: 193441
		[Token(Token = "0x402F3A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EnsurePlayerClimbTower;

		// Token: 0x0402F3A2 RID: 193442
		[Token(Token = "0x402F3A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetClimbTowerFuncLockedToast;

		// Token: 0x0402F3A3 RID: 193443
		[Token(Token = "0x402F3A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetIncompleteTrainTowerId;

		// Token: 0x0402F3A4 RID: 193444
		[Token(Token = "0x402F3A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SceneParamToClimbTower;

		// Token: 0x0402F3A5 RID: 193445
		[Token(Token = "0x402F3A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetRemainTimeText;

		// Token: 0x0402F3A6 RID: 193446
		[Token(Token = "0x402F3A6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadTowerIcon;

		// Token: 0x0402F3A7 RID: 193447
		[Token(Token = "0x402F3A7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadTowerIconForBattleFinish;

		// Token: 0x0402F3A8 RID: 193448
		[Token(Token = "0x402F3A8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadGodCardIcon;

		// Token: 0x0402F3A9 RID: 193449
		[Token(Token = "0x402F3A9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CalcTrapCount;

		// Token: 0x0402F3AA RID: 193450
		[Token(Token = "0x402F3AA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadTowerBkg;

		// Token: 0x0402F3AB RID: 193451
		[Token(Token = "0x402F3AB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadStageBtnIcon;

		// Token: 0x0402F3AC RID: 193452
		[Token(Token = "0x402F3AC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetTimeCountDownText;

		// Token: 0x0402F3AD RID: 193453
		[Token(Token = "0x402F3AD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadAutoPackSprite;

		// Token: 0x0402F3AE RID: 193454
		[Token(Token = "0x402F3AE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadLevelEnemyHandbookData;

		// Token: 0x0402F3AF RID: 193455
		[Token(Token = "0x402F3AF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetTacticalBuffProfessionOrder;

		// Token: 0x0402F3B0 RID: 193456
		[Token(Token = "0x402F3B0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetStepVal;

		// Token: 0x0402F3B1 RID: 193457
		[Token(Token = "0x402F3B1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetTotalStepCount;

		// Token: 0x0402F3B2 RID: 193458
		[Token(Token = "0x402F3B2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetEquipUnlockCount;

		// Token: 0x0402F3B3 RID: 193459
		[Token(Token = "0x402F3B3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetEquipUnlockText;

		// Token: 0x0402F3B4 RID: 193460
		[Token(Token = "0x402F3B4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__FormatTimeDelta;

		// Token: 0x0402F3B5 RID: 193461
		[Token(Token = "0x402F3B5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ConsumeAllCharExpansionTrack;

		// Token: 0x0402F3B6 RID: 193462
		[Token(Token = "0x402F3B6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_RecordNewCharExpansion;

		// Token: 0x0402F3B7 RID: 193463
		[Token(Token = "0x402F3B7")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ConsumeNewCharExpansion;

		// Token: 0x0402F3B8 RID: 193464
		[Token(Token = "0x402F3B8")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CheckNewCharExpansion;

		// Token: 0x0402F3B9 RID: 193465
		[Token(Token = "0x402F3B9")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GetCurrentGameId;

		// Token: 0x0402F3BA RID: 193466
		[Token(Token = "0x402F3BA")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__GetClimbTowerCharTrackType;

		// Token: 0x0402F3BB RID: 193467
		[Token(Token = "0x402F3BB")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__DoTrack;

		// Token: 0x0402F3BC RID: 193468
		[Token(Token = "0x402F3BC")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ConsumeTrack;

		// Token: 0x0402F3BD RID: 193469
		[Token(Token = "0x402F3BD")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CheckTrack;

		// Token: 0x0402F3BE RID: 193470
		[Token(Token = "0x402F3BE")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_LogTowerHardModeUnlocked;

		// Token: 0x0402F3BF RID: 193471
		[Token(Token = "0x402F3BF")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CheckTowerHardModeUnlockTrack;

		// Token: 0x0402F3C0 RID: 193472
		[Token(Token = "0x402F3C0")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_ConsumeTowerHardModeUnlockTrack;

		// Token: 0x0402F3C1 RID: 193473
		[Token(Token = "0x402F3C1")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetColorByMode;

		// Token: 0x0402F3C2 RID: 193474
		[Token(Token = "0x402F3C2")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_GetNamePostfixByMode;

		// Token: 0x0402F3C3 RID: 193475
		[Token(Token = "0x402F3C3")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_GetTowerLevelsByMode;

		// Token: 0x0402F3C4 RID: 193476
		[Token(Token = "0x402F3C4")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CheckIsHardStageInTowerByStageId;
	}
}
