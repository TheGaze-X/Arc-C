using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003471 RID: 13425
	[Token(Token = "0x2003471")]
	[Hotfix(HotfixFlag.Stateless)]
	[LuaCallCSharp(GenFlag.No)]
	public class ActivityUtil
	{
		// Token: 0x060156B7 RID: 87735 RVA: 0x0008BC08 File Offset: 0x00089E08
		[Token(Token = "0x60156B7")]
		[Address(RVA = "0xDE2460", Offset = "0xDE1060", VA = "0x180DE2460")]
		public static bool CheckIfMissionActivityUncomplete(string actId)
		{
			return default(bool);
		}

		// Token: 0x060156B8 RID: 87736 RVA: 0x0008BC20 File Offset: 0x00089E20
		[Token(Token = "0x60156B8")]
		[Address(RVA = "0xDE1F30", Offset = "0xDE0B30", VA = "0x180DE1F30")]
		public static bool CheckIfCollectionActivityUncomplete(string actId)
		{
			return default(bool);
		}

		// Token: 0x060156B9 RID: 87737 RVA: 0x0008BC38 File Offset: 0x00089E38
		[Token(Token = "0x60156B9")]
		[Address(RVA = "0xDE46F0", Offset = "0xDE32F0", VA = "0x180DE46F0")]
		public static bool GetPicId(string activityId, out string picId)
		{
			return default(bool);
		}

		// Token: 0x060156BA RID: 87738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156BA")]
		[Address(RVA = "0xDE2620", Offset = "0xDE1220", VA = "0x180DE2620")]
		public static void CollectionActivityJumpToRelatedSystem(string actId, bool passPreCheck)
		{
		}

		// Token: 0x060156BB RID: 87739 RVA: 0x0008BC50 File Offset: 0x00089E50
		[Token(Token = "0x60156BB")]
		[Address(RVA = "0xDE5410", Offset = "0xDE4010", VA = "0x180DE5410")]
		public static bool IfCollectionActivityCanJumpToRelatedSystem(string actId)
		{
			return default(bool);
		}

		// Token: 0x060156BC RID: 87740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156BC")]
		[Address(RVA = "0xDE3420", Offset = "0xDE2020", VA = "0x180DE3420")]
		public static List<string> FindValidCollectionActivity()
		{
			return null;
		}

		// Token: 0x060156BD RID: 87741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156BD")]
		[Address(RVA = "0xDE3E00", Offset = "0xDE2A00", VA = "0x180DE3E00")]
		public static List<string> FindValidMissionActivity()
		{
			return null;
		}

		// Token: 0x060156BE RID: 87742 RVA: 0x0008BC68 File Offset: 0x00089E68
		[Token(Token = "0x60156BE")]
		[Address(RVA = "0xDE42C0", Offset = "0xDE2EC0", VA = "0x180DE42C0")]
		public static ActivityCompleteType GetActivityCompleteType(string actId)
		{
			return ActivityCompleteType.SPECIAL;
		}

		// Token: 0x060156BF RID: 87743 RVA: 0x0008BC80 File Offset: 0x00089E80
		[Token(Token = "0x60156BF")]
		[Address(RVA = "0xDE1B70", Offset = "0xDE0770", VA = "0x180DE1B70")]
		public static bool CheckIfCheckinActivityUncomplete(string actId)
		{
			return default(bool);
		}

		// Token: 0x060156C0 RID: 87744 RVA: 0x0008BC98 File Offset: 0x00089E98
		[Token(Token = "0x60156C0")]
		[Address(RVA = "0xDE1930", Offset = "0xDE0530", VA = "0x180DE1930")]
		public static bool CheckIfCheckinActivityFinished(ActivityUtil.SortableActivity actId)
		{
			return default(bool);
		}

		// Token: 0x060156C1 RID: 87745 RVA: 0x0008BCB0 File Offset: 0x00089EB0
		[Token(Token = "0x60156C1")]
		[Address(RVA = "0xDE1CD0", Offset = "0xDE08D0", VA = "0x180DE1CD0")]
		public static bool CheckIfCollectionActivityFinished(ActivityUtil.SortableActivity actId)
		{
			return default(bool);
		}

		// Token: 0x060156C2 RID: 87746 RVA: 0x0008BCC8 File Offset: 0x00089EC8
		[Token(Token = "0x60156C2")]
		[Address(RVA = "0xDE5F60", Offset = "0xDE4B60", VA = "0x180DE5F60")]
		public static bool _CheckRewardListFinished(int rewardCount, List<int> history)
		{
			return default(bool);
		}

		// Token: 0x060156C3 RID: 87747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156C3")]
		[Address(RVA = "0xDE3190", Offset = "0xDE1D90", VA = "0x180DE3190")]
		public static List<string> FindValidCheckinActivity()
		{
			return null;
		}

		// Token: 0x060156C4 RID: 87748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156C4")]
		[Address(RVA = "0xDE29D0", Offset = "0xDE15D0", VA = "0x180DE29D0")]
		public static string FindValidAVGActivity()
		{
			return null;
		}

		// Token: 0x060156C5 RID: 87749 RVA: 0x0008BCE0 File Offset: 0x00089EE0
		[Token(Token = "0x60156C5")]
		[Address(RVA = "0xDE2380", Offset = "0xDE0F80", VA = "0x180DE2380")]
		public static bool CheckIfLoginActivityUncomplete(string actId)
		{
			return default(bool);
		}

		// Token: 0x060156C6 RID: 87750 RVA: 0x0008BCF8 File Offset: 0x00089EF8
		[Token(Token = "0x60156C6")]
		[Address(RVA = "0xDE2270", Offset = "0xDE0E70", VA = "0x180DE2270")]
		public static bool CheckIfLoginActivityFinished(ActivityUtil.SortableActivity actId)
		{
			return default(bool);
		}

		// Token: 0x060156C7 RID: 87751 RVA: 0x0008BD10 File Offset: 0x00089F10
		[Token(Token = "0x60156C7")]
		[Address(RVA = "0xDE1450", Offset = "0xDE0050", VA = "0x180DE1450")]
		public static bool CheckIfActivityPopupAfterCheckin(string actId)
		{
			return default(bool);
		}

		// Token: 0x060156C8 RID: 87752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156C8")]
		[Address(RVA = "0xDE3B90", Offset = "0xDE2790", VA = "0x180DE3B90")]
		public static List<string> FindValidLoginOnlyActs()
		{
			return null;
		}

		// Token: 0x060156C9 RID: 87753 RVA: 0x0008BD28 File Offset: 0x00089F28
		[Token(Token = "0x60156C9")]
		[Address(RVA = "0xDE50D0", Offset = "0xDE3CD0", VA = "0x180DE50D0")]
		public static UILockTarget GetUILockTargetFromActivity(string actId)
		{
			return UILockTarget.NONE;
		}

		// Token: 0x060156CA RID: 87754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156CA")]
		[Address(RVA = "0xDE4050", Offset = "0xDE2C50", VA = "0x180DE4050")]
		public static List<string> FindValidPrayOnlyActs()
		{
			return null;
		}

		// Token: 0x060156CB RID: 87755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156CB")]
		[Address(RVA = "0xDE36B0", Offset = "0xDE22B0", VA = "0x180DE36B0")]
		public static List<string> FindValidFlipOnlyActs()
		{
			return null;
		}

		// Token: 0x060156CC RID: 87756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156CC")]
		[Address(RVA = "0xDE3920", Offset = "0xDE2520", VA = "0x180DE3920")]
		public static List<string> FindValidGridGachaActs()
		{
			return null;
		}

		// Token: 0x060156CD RID: 87757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156CD")]
		[Address(RVA = "0xDE2E80", Offset = "0xDE1A80", VA = "0x180DE2E80")]
		public static List<string> FindValidActs(ActivityType type)
		{
			return null;
		}

		// Token: 0x060156CE RID: 87758 RVA: 0x0008BD40 File Offset: 0x00089F40
		[Token(Token = "0x60156CE")]
		[Address(RVA = "0xDE2540", Offset = "0xDE1140", VA = "0x180DE2540")]
		public static bool CheckIfPrayOnlyActUncomplete(string actId)
		{
			return default(bool);
		}

		// Token: 0x060156CF RID: 87759 RVA: 0x0008BD58 File Offset: 0x00089F58
		[Token(Token = "0x60156CF")]
		[Address(RVA = "0xDE2170", Offset = "0xDE0D70", VA = "0x180DE2170")]
		public static bool CheckIfGridGachaActUncomplete(string actId)
		{
			return default(bool);
		}

		// Token: 0x060156D0 RID: 87760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156D0")]
		[Address(RVA = "0xDE2B70", Offset = "0xDE1770", VA = "0x180DE2B70")]
		public static string FindValidAct17d7Activity()
		{
			return null;
		}

		// Token: 0x060156D1 RID: 87761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156D1")]
		[Address(RVA = "0xDE2D10", Offset = "0xDE1910", VA = "0x180DE2D10")]
		public static string FindValidActFunActivity()
		{
			return null;
		}

		// Token: 0x060156D2 RID: 87762 RVA: 0x0008BD70 File Offset: 0x00089F70
		[Token(Token = "0x60156D2")]
		[Address(RVA = "0xDE18C0", Offset = "0xDE04C0", VA = "0x180DE18C0")]
		public static bool CheckIfAprilFoolActType(ActivityType type)
		{
			return default(bool);
		}

		// Token: 0x060156D3 RID: 87763 RVA: 0x0008BD88 File Offset: 0x00089F88
		[Token(Token = "0x60156D3")]
		[Address(RVA = "0xDE4ED0", Offset = "0xDE3AD0", VA = "0x180DE4ED0")]
		public static UILockTarget GetUILockTargetFromActivity(ActivityTable.BasicData actBasicData)
		{
			return UILockTarget.NONE;
		}

		// Token: 0x060156D4 RID: 87764 RVA: 0x0008BDA0 File Offset: 0x00089FA0
		[Token(Token = "0x60156D4")]
		[Address(RVA = "0xDE6250", Offset = "0xDE4E50", VA = "0x180DE6250")]
		private static bool _IsActTypeLockCondCustomized(ActivityType type)
		{
			return default(bool);
		}

		// Token: 0x060156D5 RID: 87765 RVA: 0x0008BDB8 File Offset: 0x00089FB8
		[Token(Token = "0x60156D5")]
		[Address(RVA = "0xDE06F0", Offset = "0xDDF2F0", VA = "0x180DE06F0")]
		public static bool CheckActivityHomeRedPoints(string actId)
		{
			return default(bool);
		}

		// Token: 0x060156D6 RID: 87766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156D6")]
		[Address(RVA = "0xDE48C0", Offset = "0xDE34C0", VA = "0x180DE48C0")]
		public static PlayerActivity.PlayerMiniStoryActivity GetPlayerMiniStoryAct(string actId)
		{
			return null;
		}

		// Token: 0x060156D7 RID: 87767 RVA: 0x0008BDD0 File Offset: 0x00089FD0
		[Token(Token = "0x60156D7")]
		[Address(RVA = "0xDE10F0", Offset = "0xDDFCF0", VA = "0x180DE10F0")]
		public static bool CheckIfActivityInPlayerData(string actId)
		{
			return default(bool);
		}

		// Token: 0x060156D8 RID: 87768 RVA: 0x0008BDE8 File Offset: 0x00089FE8
		[Token(Token = "0x60156D8")]
		[Address(RVA = "0xDE1530", Offset = "0xDE0130", VA = "0x180DE1530")]
		public static bool CheckIfActivityUnlocked(string actId, out string lockAlert)
		{
			return default(bool);
		}

		// Token: 0x060156D9 RID: 87769 RVA: 0x0008BE00 File Offset: 0x0008A000
		[Token(Token = "0x60156D9")]
		[Address(RVA = "0xDE44E0", Offset = "0xDE30E0", VA = "0x180DE44E0")]
		public static int GetActivityMainItemCount(string actId, ActivityType actType)
		{
			return 0;
		}

		// Token: 0x060156DA RID: 87770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156DA")]
		[Address(RVA = "0xDE4390", Offset = "0xDE2F90", VA = "0x180DE4390")]
		public static ActivityTable.BasicData GetActivityInfoFromStage(string stageId)
		{
			return null;
		}

		// Token: 0x060156DB RID: 87771 RVA: 0x0008BE18 File Offset: 0x0008A018
		[Token(Token = "0x60156DB")]
		[Address(RVA = "0xDE0FA0", Offset = "0xDDFBA0", VA = "0x180DE0FA0")]
		public static bool CheckIfActivityCustomZone(string zoneId, out ActivityTable.BasicData actInfo)
		{
			return default(bool);
		}

		// Token: 0x060156DC RID: 87772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156DC")]
		[Address(RVA = "0xDE2780", Offset = "0xDE1380", VA = "0x180DE2780")]
		public static ActivityThemeData FindMainActivityThemeData(long curTs)
		{
			return null;
		}

		// Token: 0x060156DD RID: 87773 RVA: 0x0008BE30 File Offset: 0x0008A030
		[Token(Token = "0x60156DD")]
		[Address(RVA = "0xDE5540", Offset = "0xDE4140", VA = "0x180DE5540")]
		public static bool StageCanUseCart(string stageId)
		{
			return default(bool);
		}

		// Token: 0x060156DE RID: 87774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156DE")]
		[Address(RVA = "0xDE49A0", Offset = "0xDE35A0", VA = "0x180DE49A0")]
		public static List<RuneTable.PackedRuneData> GetRuneListByCart(Dictionary<CartComponents.CartAccessoryPos, string> cartCompDict)
		{
			return null;
		}

		// Token: 0x060156DF RID: 87775 RVA: 0x0008BE48 File Offset: 0x0008A048
		[Token(Token = "0x60156DF")]
		[Address(RVA = "0xDE57D0", Offset = "0xDE43D0", VA = "0x180DE57D0")]
		private static bool _CheckIfActUnlockedByCustomUnlockCond(ActivityTable.BasicData basicInfo, out string lockAlert)
		{
			return default(bool);
		}

		// Token: 0x060156E0 RID: 87776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156E0")]
		[Address(RVA = "0xDE6060", Offset = "0xDE4C60", VA = "0x180DE6060")]
		private static List<ActivityTable.CustomUnlockCond> _GetActCustomUnlockConds(ActivityTable.BasicData basicInfo)
		{
			return null;
		}

		// Token: 0x060156E1 RID: 87777 RVA: 0x0008BE60 File Offset: 0x0008A060
		[Token(Token = "0x60156E1")]
		[Address(RVA = "0xDE5630", Offset = "0xDE4230", VA = "0x180DE5630")]
		private static bool _CheckCustomUnlockConds(ActivityTable.BasicData basicInfo, List<ActivityTable.CustomUnlockCond> unlockConds, bool checkActConds, bool checkNonActConds, out string lockAlert)
		{
			return default(bool);
		}

		// Token: 0x060156E2 RID: 87778 RVA: 0x0008BE78 File Offset: 0x0008A078
		[Token(Token = "0x60156E2")]
		[Address(RVA = "0xDE5C20", Offset = "0xDE4820", VA = "0x180DE5C20")]
		private static bool _CheckIfCustomUnlockCondSatisfied(ActivityTable.BasicData basicInfo, ActivityTable.CustomUnlockCond cond, out string lockAlert)
		{
			return default(bool);
		}

		// Token: 0x060156E3 RID: 87779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156E3")]
		[Address(RVA = "0xDE6140", Offset = "0xDE4D40", VA = "0x180DE6140")]
		private static string _GetCustomUnlockCondAlert(ActivityTable.BasicData condActData, string condStageId)
		{
			return null;
		}

		// Token: 0x060156E4 RID: 87780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156E4")]
		[Address(RVA = "0xDE62B0", Offset = "0xDE4EB0", VA = "0x180DE62B0")]
		public ActivityUtil()
		{
		}

		// Token: 0x04019A58 RID: 105048
		[Token(Token = "0x4019A58")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfMissionActivityUncomplete;

		// Token: 0x04019A59 RID: 105049
		[Token(Token = "0x4019A59")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfCollectionActivityUncomplete;

		// Token: 0x04019A5A RID: 105050
		[Token(Token = "0x4019A5A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPicId;

		// Token: 0x04019A5B RID: 105051
		[Token(Token = "0x4019A5B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CollectionActivityJumpToRelatedSystem;

		// Token: 0x04019A5C RID: 105052
		[Token(Token = "0x4019A5C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IfCollectionActivityCanJumpToRelatedSystem;

		// Token: 0x04019A5D RID: 105053
		[Token(Token = "0x4019A5D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FindValidCollectionActivity;

		// Token: 0x04019A5E RID: 105054
		[Token(Token = "0x4019A5E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FindValidMissionActivity;

		// Token: 0x04019A5F RID: 105055
		[Token(Token = "0x4019A5F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetActivityCompleteType;

		// Token: 0x04019A60 RID: 105056
		[Token(Token = "0x4019A60")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfCheckinActivityUncomplete;

		// Token: 0x04019A61 RID: 105057
		[Token(Token = "0x4019A61")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfCheckinActivityFinished;

		// Token: 0x04019A62 RID: 105058
		[Token(Token = "0x4019A62")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfCollectionActivityFinished;

		// Token: 0x04019A63 RID: 105059
		[Token(Token = "0x4019A63")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckRewardListFinished;

		// Token: 0x04019A64 RID: 105060
		[Token(Token = "0x4019A64")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_FindValidCheckinActivity;

		// Token: 0x04019A65 RID: 105061
		[Token(Token = "0x4019A65")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_FindValidAVGActivity;

		// Token: 0x04019A66 RID: 105062
		[Token(Token = "0x4019A66")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CheckIfLoginActivityUncomplete;

		// Token: 0x04019A67 RID: 105063
		[Token(Token = "0x4019A67")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckIfLoginActivityFinished;

		// Token: 0x04019A68 RID: 105064
		[Token(Token = "0x4019A68")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckIfActivityPopupAfterCheckin;

		// Token: 0x04019A69 RID: 105065
		[Token(Token = "0x4019A69")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_FindValidLoginOnlyActs;

		// Token: 0x04019A6A RID: 105066
		[Token(Token = "0x4019A6A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetUILockTargetFromActivity;

		// Token: 0x04019A6B RID: 105067
		[Token(Token = "0x4019A6B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_FindValidPrayOnlyActs;

		// Token: 0x04019A6C RID: 105068
		[Token(Token = "0x4019A6C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_FindValidFlipOnlyActs;

		// Token: 0x04019A6D RID: 105069
		[Token(Token = "0x4019A6D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_FindValidGridGachaActs;

		// Token: 0x04019A6E RID: 105070
		[Token(Token = "0x4019A6E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_FindValidActs;

		// Token: 0x04019A6F RID: 105071
		[Token(Token = "0x4019A6F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CheckIfPrayOnlyActUncomplete;

		// Token: 0x04019A70 RID: 105072
		[Token(Token = "0x4019A70")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_CheckIfGridGachaActUncomplete;

		// Token: 0x04019A71 RID: 105073
		[Token(Token = "0x4019A71")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_FindValidAct17d7Activity;

		// Token: 0x04019A72 RID: 105074
		[Token(Token = "0x4019A72")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_FindValidActFunActivity;

		// Token: 0x04019A73 RID: 105075
		[Token(Token = "0x4019A73")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CheckIfAprilFoolActType;

		// Token: 0x04019A74 RID: 105076
		[Token(Token = "0x4019A74")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix1_GetUILockTargetFromActivity;

		// Token: 0x04019A75 RID: 105077
		[Token(Token = "0x4019A75")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__IsActTypeLockCondCustomized;

		// Token: 0x04019A76 RID: 105078
		[Token(Token = "0x4019A76")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CheckActivityHomeRedPoints;

		// Token: 0x04019A77 RID: 105079
		[Token(Token = "0x4019A77")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetPlayerMiniStoryAct;

		// Token: 0x04019A78 RID: 105080
		[Token(Token = "0x4019A78")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_CheckIfActivityInPlayerData;

		// Token: 0x04019A79 RID: 105081
		[Token(Token = "0x4019A79")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_CheckIfActivityUnlocked;

		// Token: 0x04019A7A RID: 105082
		[Token(Token = "0x4019A7A")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_GetActivityMainItemCount;

		// Token: 0x04019A7B RID: 105083
		[Token(Token = "0x4019A7B")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetActivityInfoFromStage;

		// Token: 0x04019A7C RID: 105084
		[Token(Token = "0x4019A7C")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CheckIfActivityCustomZone;

		// Token: 0x04019A7D RID: 105085
		[Token(Token = "0x4019A7D")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_FindMainActivityThemeData;

		// Token: 0x04019A7E RID: 105086
		[Token(Token = "0x4019A7E")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_StageCanUseCart;

		// Token: 0x04019A7F RID: 105087
		[Token(Token = "0x4019A7F")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GetRuneListByCart;

		// Token: 0x04019A80 RID: 105088
		[Token(Token = "0x4019A80")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__CheckIfActUnlockedByCustomUnlockCond;

		// Token: 0x04019A81 RID: 105089
		[Token(Token = "0x4019A81")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__GetActCustomUnlockConds;

		// Token: 0x04019A82 RID: 105090
		[Token(Token = "0x4019A82")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__CheckCustomUnlockConds;

		// Token: 0x04019A83 RID: 105091
		[Token(Token = "0x4019A83")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__CheckIfCustomUnlockCondSatisfied;

		// Token: 0x04019A84 RID: 105092
		[Token(Token = "0x4019A84")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__GetCustomUnlockCondAlert;

		// Token: 0x04019A85 RID: 105093
		[Token(Token = "0x4019A85")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003472 RID: 13426
		[Token(Token = "0x2003472")]
		public struct SortableActivity : IHotfixable
		{
			// Token: 0x060156E5 RID: 87781 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60156E5")]
			[Address(RVA = "0xDEBCE0", Offset = "0xDEA8E0", VA = "0x180DEBCE0")]
			public SortableActivity(string actId, int actWeight)
			{
			}

			// Token: 0x060156E6 RID: 87782 RVA: 0x0008BE90 File Offset: 0x0008A090
			[Token(Token = "0x60156E6")]
			[Address(RVA = "0xDEBA20", Offset = "0xDEA620", VA = "0x180DEBA20")]
			public static int Compare(ActivityUtil.SortableActivity lhs, ActivityUtil.SortableActivity rhs)
			{
				return 0;
			}

			// Token: 0x060156E7 RID: 87783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60156E7")]
			[Address(RVA = "0xDEBB80", Offset = "0xDEA780", VA = "0x180DEBB80")]
			public static void FlushToStringList(List<ActivityUtil.SortableActivity> src, ref List<string> dst)
			{
			}

			// Token: 0x04019A86 RID: 105094
			[Token(Token = "0x4019A86")]
			[FieldOffset(Offset = "0x0")]
			public SortableString actId;

			// Token: 0x04019A87 RID: 105095
			[Token(Token = "0x4019A87")]
			[FieldOffset(Offset = "0x10")]
			public ActivityCompleteType completeType;

			// Token: 0x04019A88 RID: 105096
			[Token(Token = "0x4019A88")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04019A89 RID: 105097
			[Token(Token = "0x4019A89")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Compare;

			// Token: 0x04019A8A RID: 105098
			[Token(Token = "0x4019A8A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_FlushToStringList;
		}
	}
}
