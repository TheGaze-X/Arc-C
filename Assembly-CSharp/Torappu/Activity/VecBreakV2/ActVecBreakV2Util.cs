using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DDE RID: 28126
	[Token(Token = "0x2006DDE")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ActVecBreakV2Util
	{
		// Token: 0x060280AC RID: 164012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280AC")]
		[Address(RVA = "0x2358CF0", Offset = "0x23578F0", VA = "0x182358CF0")]
		public static void TriggerOffenseGuideBook(bool showAnyway)
		{
		}

		// Token: 0x060280AD RID: 164013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280AD")]
		[Address(RVA = "0x23570F0", Offset = "0x2355CF0", VA = "0x1823570F0")]
		public static ActVecBreakV2Data GetActData(string actId)
		{
			return null;
		}

		// Token: 0x060280AE RID: 164014 RVA: 0x000D0860 File Offset: 0x000CEA60
		[Token(Token = "0x60280AE")]
		[Address(RVA = "0x2358EA0", Offset = "0x2357AA0", VA = "0x182358EA0")]
		public static bool TryFindOpenAct(long currTs, out ActivityTable.BasicData basicData, out ActVecBreakV2Data targetActData)
		{
			return default(bool);
		}

		// Token: 0x060280AF RID: 164015 RVA: 0x000D0878 File Offset: 0x000CEA78
		[Token(Token = "0x60280AF")]
		[Address(RVA = "0x2356A40", Offset = "0x2355640", VA = "0x182356A40")]
		public static bool CheckIfVecBreakSysOpen(long currTs)
		{
			return default(bool);
		}

		// Token: 0x060280B0 RID: 164016 RVA: 0x000D0890 File Offset: 0x000CEA90
		[Token(Token = "0x60280B0")]
		[Address(RVA = "0x2356970", Offset = "0x2355570", VA = "0x182356970")]
		public static bool CheckIfStageBuffAvail(string actId, string stageId)
		{
			return default(bool);
		}

		// Token: 0x060280B1 RID: 164017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280B1")]
		[Address(RVA = "0x2357320", Offset = "0x2355F20", VA = "0x182357320")]
		public static string GetTokenItemId(string actId)
		{
			return null;
		}

		// Token: 0x060280B2 RID: 164018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280B2")]
		[Address(RVA = "0x2357FB0", Offset = "0x2356BB0", VA = "0x182357FB0")]
		public static ActVecBreakV2ResCollector LoadSeasonResCollector(string actId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x060280B3 RID: 164019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280B3")]
		[Address(RVA = "0x2358AC0", Offset = "0x23576C0", VA = "0x182358AC0")]
		public static void TextToast(ILoadAsset assetLoader, string toastStr)
		{
		}

		// Token: 0x060280B4 RID: 164020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280B4")]
		[Address(RVA = "0x2357B30", Offset = "0x2356730", VA = "0x182357B30")]
		public static Sprite LoadItemIcon(string itemId)
		{
			return null;
		}

		// Token: 0x060280B5 RID: 164021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280B5")]
		[Address(RVA = "0x23576E0", Offset = "0x23562E0", VA = "0x1823576E0")]
		public static Sprite LoadAchvAlphaOrderIcon(ActVecBreakV2StageOrderType orderType, bool isComplete, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060280B6 RID: 164022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280B6")]
		[Address(RVA = "0x2357E90", Offset = "0x2356A90", VA = "0x182357E90")]
		public static Sprite LoadRaidStageAlphaOrderIcon(ActVecBreakV2StageOrderType orderType, bool isComplete, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060280B7 RID: 164023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280B7")]
		[Address(RVA = "0x23578F0", Offset = "0x23564F0", VA = "0x1823578F0")]
		public static Sprite LoadBattleFinishAlphaOrderIcon(ActVecBreakV2StageOrderType orderType, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060280B8 RID: 164024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280B8")]
		[Address(RVA = "0x2357800", Offset = "0x2356400", VA = "0x182357800")]
		public static Sprite LoadAchvTitleIcon(string actId, bool isMini, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060280B9 RID: 164025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280B9")]
		[Address(RVA = "0x23579C0", Offset = "0x23565C0", VA = "0x1823579C0")]
		public static Sprite LoadBossDecoIcon(string bossDecoId, bool isTiny, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060280BA RID: 164026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280BA")]
		[Address(RVA = "0x2358230", Offset = "0x2356E30", VA = "0x182358230")]
		public static Sprite LoadSquadBuffIcon(string buffIconId, [Optional] ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060280BB RID: 164027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280BB")]
		[Address(RVA = "0x2357AA0", Offset = "0x23566A0", VA = "0x182357AA0")]
		public static Sprite LoadBossIcon(string bossIconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060280BC RID: 164028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280BC")]
		[Address(RVA = "0x2357C90", Offset = "0x2356890", VA = "0x182357C90")]
		public static Sprite LoadOffenseBossIcon(string bossIconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060280BD RID: 164029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280BD")]
		[Address(RVA = "0x2357DB0", Offset = "0x23569B0", VA = "0x182357DB0")]
		public static Sprite LoadOffenseTowerNumIcon(int level, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060280BE RID: 164030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280BE")]
		[Address(RVA = "0x2357D20", Offset = "0x2356920", VA = "0x182357D20")]
		public static Sprite LoadOffenseTowerBossItemIcon(string decoId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060280BF RID: 164031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280BF")]
		[Address(RVA = "0x23571C0", Offset = "0x2355DC0", VA = "0x1823571C0")]
		public static PlayerActivity.PlayerVecBreakV2 GetActPlayerData(string actId)
		{
			return null;
		}

		// Token: 0x060280C0 RID: 164032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280C0")]
		[Address(RVA = "0x2356190", Offset = "0x2354D90", VA = "0x182356190")]
		public static void ApplyColorConfigInGraphics(StageViewColorConfig[] colorConfigs, StageViewType viewType, Graphic[] bgGraphics, Graphic[] contentGraphics, Graphic[] lineGraphics)
		{
		}

		// Token: 0x060280C1 RID: 164033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280C1")]
		[Address(RVA = "0x2359260", Offset = "0x2357E60", VA = "0x182359260")]
		private static StageViewColorConfig _FindColorConfig(StageViewColorConfig[] colorConfigs, StageViewType viewType)
		{
			return null;
		}

		// Token: 0x060280C2 RID: 164034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280C2")]
		[Address(RVA = "0x23590F0", Offset = "0x2357CF0", VA = "0x1823590F0")]
		private static void _ApplyColorConfig(Color color, Graphic[] graphics)
		{
		}

		// Token: 0x060280C3 RID: 164035 RVA: 0x000D08A8 File Offset: 0x000CEAA8
		[Token(Token = "0x60280C3")]
		[Address(RVA = "0x2358D70", Offset = "0x2357970", VA = "0x182358D70")]
		public static bool TryFindNearestScheduleData(string actId, long currTs, out ActVecBreakV2ScheduleBlockData scheduleBlockData)
		{
			return default(bool);
		}

		// Token: 0x060280C4 RID: 164036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280C4")]
		[Address(RVA = "0x2356E60", Offset = "0x2355A60", VA = "0x182356E60")]
		public static string FindDefenseStageWithLimitReward(string actId, long currTs)
		{
			return null;
		}

		// Token: 0x060280C5 RID: 164037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280C5")]
		[Address(RVA = "0x2358670", Offset = "0x2357270", VA = "0x182358670")]
		public static void OpenMapPreview(string stageId, UICompDialogMgr dlgMgr)
		{
		}

		// Token: 0x060280C6 RID: 164038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280C6")]
		[Address(RVA = "0x23582D0", Offset = "0x2356ED0", VA = "0x1823582D0")]
		public static void OpenEnemyDetailWithBoss(string stageId, string bossId)
		{
		}

		// Token: 0x060280C7 RID: 164039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280C7")]
		[Address(RVA = "0x2358510", Offset = "0x2357110", VA = "0x182358510")]
		public static void OpenEnemyDetail(string stageId, [Optional] Comparison<EnemyHandBookEverViewModel> comp)
		{
		}

		// Token: 0x060280C8 RID: 164040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280C8")]
		[Address(RVA = "0x23587F0", Offset = "0x23573F0", VA = "0x1823587F0")]
		public static void SendRequestAndOpenAchv()
		{
		}

		// Token: 0x060280C9 RID: 164041 RVA: 0x000D08C0 File Offset: 0x000CEAC0
		[Token(Token = "0x60280C9")]
		[Address(RVA = "0x2356570", Offset = "0x2355170", VA = "0x182356570")]
		public static bool CheckIfDefenseZoneUnlock(string actId)
		{
			return default(bool);
		}

		// Token: 0x060280CA RID: 164042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280CA")]
		[Address(RVA = "0x23573A0", Offset = "0x2355FA0", VA = "0x1823573A0")]
		public static void JumpToDefensePage(string actId, [Optional] string focusStageId)
		{
		}

		// Token: 0x060280CB RID: 164043 RVA: 0x000D08D8 File Offset: 0x000CEAD8
		[Token(Token = "0x60280CB")]
		[Address(RVA = "0x2356330", Offset = "0x2354F30", VA = "0x182356330")]
		public static BattleFinishMilestoneInfo CalcMilestoneInfo(string actId, int currPoint, long timeStamp)
		{
			return default(BattleFinishMilestoneInfo);
		}

		// Token: 0x060280CC RID: 164044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280CC")]
		[Address(RVA = "0x2356DB0", Offset = "0x23559B0", VA = "0x182356DB0")]
		public static void ConsumeOffenseHardZoneTrack(string actId)
		{
		}

		// Token: 0x060280CD RID: 164045 RVA: 0x000D08F0 File Offset: 0x000CEAF0
		[Token(Token = "0x60280CD")]
		[Address(RVA = "0x23568C0", Offset = "0x23554C0", VA = "0x1823568C0")]
		public static bool CheckIfShowOffenseHardZoneTrack(string actId)
		{
			return default(bool);
		}

		// Token: 0x060280CE RID: 164046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280CE")]
		[Address(RVA = "0x2356D00", Offset = "0x2355900", VA = "0x182356D00")]
		public static void ConsumeOffenseHardStageTrack(string stageId)
		{
		}

		// Token: 0x060280CF RID: 164047 RVA: 0x000D0908 File Offset: 0x000CEB08
		[Token(Token = "0x60280CF")]
		[Address(RVA = "0x2356810", Offset = "0x2355410", VA = "0x182356810")]
		public static bool CheckIfShowOffenseHardStageTrack(string stageId)
		{
			return default(bool);
		}

		// Token: 0x060280D0 RID: 164048 RVA: 0x000D0920 File Offset: 0x000CEB20
		[Token(Token = "0x60280D0")]
		[Address(RVA = "0x2356BD0", Offset = "0x23557D0", VA = "0x182356BD0")]
		public static bool CheckMileStoneUpdated(string actId)
		{
			return default(bool);
		}

		// Token: 0x060280D1 RID: 164049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280D1")]
		[Address(RVA = "0x2356C70", Offset = "0x2355870", VA = "0x182356C70")]
		public static void ConsumeMileStoneUpdated(string actId)
		{
		}

		// Token: 0x04038CA1 RID: 232609
		[Token(Token = "0x4038CA1")]
		private const string GUIDE_BOOK_OFFENSE_SUB_SIGNAL = "offense";

		// Token: 0x04038CA2 RID: 232610
		[Token(Token = "0x4038CA2")]
		private const string ACHV_ALPHA_ORDER_NORMAL = "normal_order_{0}";

		// Token: 0x04038CA3 RID: 232611
		[Token(Token = "0x4038CA3")]
		private const string ACHV_ALPHA_ORDER_COMPLETE = "complete_order_{0}";

		// Token: 0x04038CA4 RID: 232612
		[Token(Token = "0x4038CA4")]
		private const string RAID_STAGE_ALPHA_ORDER_NORMAL = "normal_raid_order_{0}";

		// Token: 0x04038CA5 RID: 232613
		[Token(Token = "0x4038CA5")]
		private const string RAID_STAGE_ALPHA_ORDER_COMPLETE = "complete_raid_order_{0}";

		// Token: 0x04038CA6 RID: 232614
		[Token(Token = "0x4038CA6")]
		private const string BATTLE_FINISH_ALPHA_ORDER = "battle_finish_order_{0}";

		// Token: 0x04038CA7 RID: 232615
		[Token(Token = "0x4038CA7")]
		private const string TINY_ICON_ID = "{0}_tiny";

		// Token: 0x04038CA8 RID: 232616
		[Token(Token = "0x4038CA8")]
		private const string ACHV_TITLE_ICON_ID = "{0}_season_title";

		// Token: 0x04038CA9 RID: 232617
		[Token(Token = "0x4038CA9")]
		private const string ACHV_TITLE_MINI_ICON_ID = "{0}_season_title_mini";

		// Token: 0x04038CAA RID: 232618
		[Token(Token = "0x4038CAA")]
		private const string OFFENSE_TOWER_NUM_ID = "num_{0}";

		// Token: 0x04038CAB RID: 232619
		[Token(Token = "0x4038CAB")]
		public const int SQUAD_SLOT_ICON_NUM = 3;

		// Token: 0x04038CAC RID: 232620
		[Token(Token = "0x4038CAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TriggerOffenseGuideBook;

		// Token: 0x04038CAD RID: 232621
		[Token(Token = "0x4038CAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetActData;

		// Token: 0x04038CAE RID: 232622
		[Token(Token = "0x4038CAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryFindOpenAct;

		// Token: 0x04038CAF RID: 232623
		[Token(Token = "0x4038CAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfVecBreakSysOpen;

		// Token: 0x04038CB0 RID: 232624
		[Token(Token = "0x4038CB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfStageBuffAvail;

		// Token: 0x04038CB1 RID: 232625
		[Token(Token = "0x4038CB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetTokenItemId;

		// Token: 0x04038CB2 RID: 232626
		[Token(Token = "0x4038CB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadSeasonResCollector;

		// Token: 0x04038CB3 RID: 232627
		[Token(Token = "0x4038CB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TextToast;

		// Token: 0x04038CB4 RID: 232628
		[Token(Token = "0x4038CB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadItemIcon;

		// Token: 0x04038CB5 RID: 232629
		[Token(Token = "0x4038CB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadAchvAlphaOrderIcon;

		// Token: 0x04038CB6 RID: 232630
		[Token(Token = "0x4038CB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadRaidStageAlphaOrderIcon;

		// Token: 0x04038CB7 RID: 232631
		[Token(Token = "0x4038CB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadBattleFinishAlphaOrderIcon;

		// Token: 0x04038CB8 RID: 232632
		[Token(Token = "0x4038CB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadAchvTitleIcon;

		// Token: 0x04038CB9 RID: 232633
		[Token(Token = "0x4038CB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadBossDecoIcon;

		// Token: 0x04038CBA RID: 232634
		[Token(Token = "0x4038CBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadSquadBuffIcon;

		// Token: 0x04038CBB RID: 232635
		[Token(Token = "0x4038CBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_LoadBossIcon;

		// Token: 0x04038CBC RID: 232636
		[Token(Token = "0x4038CBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadOffenseBossIcon;

		// Token: 0x04038CBD RID: 232637
		[Token(Token = "0x4038CBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadOffenseTowerNumIcon;

		// Token: 0x04038CBE RID: 232638
		[Token(Token = "0x4038CBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadOffenseTowerBossItemIcon;

		// Token: 0x04038CBF RID: 232639
		[Token(Token = "0x4038CBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetActPlayerData;

		// Token: 0x04038CC0 RID: 232640
		[Token(Token = "0x4038CC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ApplyColorConfigInGraphics;

		// Token: 0x04038CC1 RID: 232641
		[Token(Token = "0x4038CC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__FindColorConfig;

		// Token: 0x04038CC2 RID: 232642
		[Token(Token = "0x4038CC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ApplyColorConfig;

		// Token: 0x04038CC3 RID: 232643
		[Token(Token = "0x4038CC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_TryFindNearestScheduleData;

		// Token: 0x04038CC4 RID: 232644
		[Token(Token = "0x4038CC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_FindDefenseStageWithLimitReward;

		// Token: 0x04038CC5 RID: 232645
		[Token(Token = "0x4038CC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OpenMapPreview;

		// Token: 0x04038CC6 RID: 232646
		[Token(Token = "0x4038CC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OpenEnemyDetailWithBoss;

		// Token: 0x04038CC7 RID: 232647
		[Token(Token = "0x4038CC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OpenEnemyDetail;

		// Token: 0x04038CC8 RID: 232648
		[Token(Token = "0x4038CC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_SendRequestAndOpenAchv;

		// Token: 0x04038CC9 RID: 232649
		[Token(Token = "0x4038CC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_CheckIfDefenseZoneUnlock;

		// Token: 0x04038CCA RID: 232650
		[Token(Token = "0x4038CCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_JumpToDefensePage;

		// Token: 0x04038CCB RID: 232651
		[Token(Token = "0x4038CCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CalcMilestoneInfo;

		// Token: 0x04038CCC RID: 232652
		[Token(Token = "0x4038CCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_ConsumeOffenseHardZoneTrack;

		// Token: 0x04038CCD RID: 232653
		[Token(Token = "0x4038CCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_CheckIfShowOffenseHardZoneTrack;

		// Token: 0x04038CCE RID: 232654
		[Token(Token = "0x4038CCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_ConsumeOffenseHardStageTrack;

		// Token: 0x04038CCF RID: 232655
		[Token(Token = "0x4038CCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CheckIfShowOffenseHardStageTrack;

		// Token: 0x04038CD0 RID: 232656
		[Token(Token = "0x4038CD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CheckMileStoneUpdated;

		// Token: 0x04038CD1 RID: 232657
		[Token(Token = "0x4038CD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_ConsumeMileStoneUpdated;
	}
}
