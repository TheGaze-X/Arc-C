using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu
{
	// Token: 0x020013F4 RID: 5108
	[Token(Token = "0x20013F4")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CampaignDataUtil
	{
		// Token: 0x060074A8 RID: 29864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074A8")]
		[Address(RVA = "0x21FF620", Offset = "0x21FE220", VA = "0x1821FF620")]
		public static List<StageData> GetAllStages()
		{
			return null;
		}

		// Token: 0x060074A9 RID: 29865 RVA: 0x00033D38 File Offset: 0x00031F38
		[Token(Token = "0x60074A9")]
		[Address(RVA = "0x2200DD0", Offset = "0x21FF9D0", VA = "0x182200DD0")]
		public static CampaignStageType GetStageType(string stageId)
		{
			return CampaignStageType.NONE;
		}

		// Token: 0x060074AA RID: 29866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074AA")]
		[Address(RVA = "0x22008E0", Offset = "0x21FF4E0", VA = "0x1822008E0")]
		public static string GetStageRegion(string stageId)
		{
			return null;
		}

		// Token: 0x060074AB RID: 29867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074AB")]
		[Address(RVA = "0x2201200", Offset = "0x21FFE00", VA = "0x182201200")]
		public static string GetStageZone(string stageId)
		{
			return null;
		}

		// Token: 0x060074AC RID: 29868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074AC")]
		[Address(RVA = "0x2200840", Offset = "0x21FF440", VA = "0x182200840")]
		public static string GetStageName(string stageId)
		{
			return null;
		}

		// Token: 0x060074AD RID: 29869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074AD")]
		[Address(RVA = "0x2200F90", Offset = "0x21FFB90", VA = "0x182200F90")]
		public static string GetStageUnlockText(string stageId)
		{
			return null;
		}

		// Token: 0x060074AE RID: 29870 RVA: 0x00033D50 File Offset: 0x00031F50
		[Token(Token = "0x60074AE")]
		[Address(RVA = "0x2200C20", Offset = "0x21FF820", VA = "0x182200C20")]
		public static int GetStageTotalBreakFee(string stageId)
		{
			return 0;
		}

		// Token: 0x060074AF RID: 29871 RVA: 0x00033D68 File Offset: 0x00031F68
		[Token(Token = "0x60074AF")]
		[Address(RVA = "0x2200210", Offset = "0x21FEE10", VA = "0x182200210")]
		public static int GetStageBreakRewardProgress(string stageId)
		{
			return 0;
		}

		// Token: 0x060074B0 RID: 29872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074B0")]
		[Address(RVA = "0x2202910", Offset = "0x2201510", VA = "0x182202910")]
		public static List<int> LoadStageBreakRewardStatus(string stageId)
		{
			return null;
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x00033D80 File Offset: 0x00031F80
		[Token(Token = "0x60074B1")]
		[Address(RVA = "0x2200640", Offset = "0x21FF240", VA = "0x182200640")]
		public static int GetStageMaxKillCnt(string stageId)
		{
			return 0;
		}

		// Token: 0x060074B2 RID: 29874 RVA: 0x00033D98 File Offset: 0x00031F98
		[Token(Token = "0x60074B2")]
		[Address(RVA = "0x22018F0", Offset = "0x22004F0", VA = "0x1822018F0")]
		public static bool HasStageUnconfirmedBreakFee(string stageId)
		{
			return default(bool);
		}

		// Token: 0x060074B3 RID: 29875 RVA: 0x00033DB0 File Offset: 0x00031FB0
		[Token(Token = "0x60074B3")]
		[Address(RVA = "0x2201B80", Offset = "0x2200780", VA = "0x182201B80")]
		public static bool HasStageUnconfirmedReward(string stageId)
		{
			return default(bool);
		}

		// Token: 0x060074B4 RID: 29876 RVA: 0x00033DC8 File Offset: 0x00031FC8
		[Token(Token = "0x60074B4")]
		[Address(RVA = "0x2201790", Offset = "0x2200390", VA = "0x182201790")]
		public static bool HasAnyStageUnconfirmedReward()
		{
			return default(bool);
		}

		// Token: 0x060074B5 RID: 29877 RVA: 0x00033DE0 File Offset: 0x00031FE0
		[Token(Token = "0x60074B5")]
		[Address(RVA = "0x22015F0", Offset = "0x22001F0", VA = "0x1822015F0")]
		public static bool HasAnyCommonMissionUnconfirmedReward()
		{
			return default(bool);
		}

		// Token: 0x060074B6 RID: 29878 RVA: 0x00033DF8 File Offset: 0x00031FF8
		[Token(Token = "0x60074B6")]
		[Address(RVA = "0x2202120", Offset = "0x2200D20", VA = "0x182202120")]
		public static bool IsStageFinishAllReward(string stageId)
		{
			return default(bool);
		}

		// Token: 0x060074B7 RID: 29879 RVA: 0x00033E10 File Offset: 0x00032010
		[Token(Token = "0x60074B7")]
		[Address(RVA = "0x22024D0", Offset = "0x22010D0", VA = "0x1822024D0")]
		public static bool IsStageUnlocked(string stageId)
		{
			return default(bool);
		}

		// Token: 0x060074B8 RID: 29880 RVA: 0x00033E28 File Offset: 0x00032028
		[Token(Token = "0x60074B8")]
		[Address(RVA = "0x2201F80", Offset = "0x2200B80", VA = "0x182201F80")]
		public static bool IsStageClosed(string stageId)
		{
			return default(bool);
		}

		// Token: 0x060074B9 RID: 29881 RVA: 0x00033E40 File Offset: 0x00032040
		[Token(Token = "0x60074B9")]
		[Address(RVA = "0x22023B0", Offset = "0x2200FB0", VA = "0x1822023B0")]
		public static bool IsStageUnknown(string stageId)
		{
			return default(bool);
		}

		// Token: 0x060074BA RID: 29882 RVA: 0x00033E58 File Offset: 0x00032058
		[Token(Token = "0x60074BA")]
		[Address(RVA = "0x22025E0", Offset = "0x22011E0", VA = "0x1822025E0")]
		public static bool IsTrainingAllOpen()
		{
			return default(bool);
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x00033E70 File Offset: 0x00032070
		[Token(Token = "0x60074BB")]
		[Address(RVA = "0x2202730", Offset = "0x2201330", VA = "0x182202730")]
		public static bool IsTrainingReturnAllOpen()
		{
			return default(bool);
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x00033E88 File Offset: 0x00032088
		[Token(Token = "0x60074BC")]
		[Address(RVA = "0x21FF910", Offset = "0x21FE510", VA = "0x1821FF910")]
		public static long GetCurrentTrainingAllOpenEndTs()
		{
			return 0L;
		}

		// Token: 0x060074BD RID: 29885 RVA: 0x00033EA0 File Offset: 0x000320A0
		[Token(Token = "0x60074BD")]
		[Address(RVA = "0x2200070", Offset = "0x21FEC70", VA = "0x182200070")]
		public static long GetReturnV2AllOpenEndTs()
		{
			return 0L;
		}

		// Token: 0x060074BE RID: 29886 RVA: 0x00033EB8 File Offset: 0x000320B8
		[Token(Token = "0x60074BE")]
		[Address(RVA = "0x22012F0", Offset = "0x21FFEF0", VA = "0x1822012F0")]
		public static long GetTrainingAllOpenGroupEndTs(string groupId)
		{
			return 0L;
		}

		// Token: 0x060074BF RID: 29887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074BF")]
		[Address(RVA = "0x22014D0", Offset = "0x22000D0", VA = "0x1822014D0")]
		public static string GetZoneUnlockText()
		{
			return null;
		}

		// Token: 0x060074C0 RID: 29888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C0")]
		[Address(RVA = "0x2201390", Offset = "0x21FFF90", VA = "0x182201390")]
		public static string GetZoneRegion(string zoneId)
		{
			return null;
		}

		// Token: 0x060074C1 RID: 29889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C1")]
		[Address(RVA = "0x21FFF60", Offset = "0x21FEB60", VA = "0x1821FFF60")]
		public static string GetRemainTimeText(long endTs)
		{
			return null;
		}

		// Token: 0x060074C2 RID: 29890 RVA: 0x00033ED0 File Offset: 0x000320D0
		[Token(Token = "0x60074C2")]
		[Address(RVA = "0x21FFCA0", Offset = "0x21FE8A0", VA = "0x1821FFCA0")]
		public static int GetMissionBreakFee(string missionId)
		{
			return 0;
		}

		// Token: 0x060074C3 RID: 29891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C3")]
		[Address(RVA = "0x21FF6A0", Offset = "0x21FE2A0", VA = "0x1821FF6A0")]
		public static string GetCampFeeRefreshCountDownText()
		{
			return null;
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C4")]
		[Address(RVA = "0x2202A20", Offset = "0x2201620", VA = "0x182202A20")]
		public static Dictionary<string, long> LoadStageEndTimes()
		{
			return null;
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x00033EE8 File Offset: 0x000320E8
		[Token(Token = "0x60074C5")]
		[Address(RVA = "0x22003F0", Offset = "0x21FEFF0", VA = "0x1822003F0")]
		public static long GetStageEndTs(string stageId)
		{
			return 0L;
		}

		// Token: 0x060074C6 RID: 29894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C6")]
		[Address(RVA = "0x2202FD0", Offset = "0x2201BD0", VA = "0x182202FD0")]
		private static string _GetStageNameInUnlockText(string stageId)
		{
			return null;
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C7")]
		[Address(RVA = "0x2202E60", Offset = "0x2201A60", VA = "0x182202E60")]
		private static string _FormatTimeDelta(TimeSpan timeSpan)
		{
			return null;
		}

		// Token: 0x060074C8 RID: 29896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C8")]
		[Address(RVA = "0x21FFE10", Offset = "0x21FEA10", VA = "0x1821FFE10")]
		public static CampaignData.GainLadder GetProperGainLadder(string stageId, CampaignStageType stageType, int killCount)
		{
			return null;
		}

		// Token: 0x060074C9 RID: 29897 RVA: 0x00033F00 File Offset: 0x00032100
		[Token(Token = "0x60074C9")]
		[Address(RVA = "0x21FF580", Offset = "0x21FE180", VA = "0x1821FF580")]
		public static bool CheckIfFastBattleSysOpen(long curTs)
		{
			return default(bool);
		}

		// Token: 0x060074CA RID: 29898 RVA: 0x00033F18 File Offset: 0x00032118
		[Token(Token = "0x60074CA")]
		[Address(RVA = "0x22027F0", Offset = "0x22013F0", VA = "0x1822027F0")]
		public static int LoadFastBattleTktInfo(long curTs, ref List<ItemUtil.ConsumableInfo> tktFormation)
		{
			return 0;
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x00033F30 File Offset: 0x00032130
		[Token(Token = "0x60074CB")]
		[Address(RVA = "0x2200B30", Offset = "0x21FF730", VA = "0x182200B30")]
		public static int GetStageSweepCount(string stageId)
		{
			return 0;
		}

		// Token: 0x040071D8 RID: 29144
		[Token(Token = "0x40071D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAllStages;

		// Token: 0x040071D9 RID: 29145
		[Token(Token = "0x40071D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetStageType;

		// Token: 0x040071DA RID: 29146
		[Token(Token = "0x40071DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetStageRegion;

		// Token: 0x040071DB RID: 29147
		[Token(Token = "0x40071DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetStageZone;

		// Token: 0x040071DC RID: 29148
		[Token(Token = "0x40071DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetStageName;

		// Token: 0x040071DD RID: 29149
		[Token(Token = "0x40071DD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetStageUnlockText;

		// Token: 0x040071DE RID: 29150
		[Token(Token = "0x40071DE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetStageTotalBreakFee;

		// Token: 0x040071DF RID: 29151
		[Token(Token = "0x40071DF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetStageBreakRewardProgress;

		// Token: 0x040071E0 RID: 29152
		[Token(Token = "0x40071E0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadStageBreakRewardStatus;

		// Token: 0x040071E1 RID: 29153
		[Token(Token = "0x40071E1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetStageMaxKillCnt;

		// Token: 0x040071E2 RID: 29154
		[Token(Token = "0x40071E2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HasStageUnconfirmedBreakFee;

		// Token: 0x040071E3 RID: 29155
		[Token(Token = "0x40071E3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HasStageUnconfirmedReward;

		// Token: 0x040071E4 RID: 29156
		[Token(Token = "0x40071E4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HasAnyStageUnconfirmedReward;

		// Token: 0x040071E5 RID: 29157
		[Token(Token = "0x40071E5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_HasAnyCommonMissionUnconfirmedReward;

		// Token: 0x040071E6 RID: 29158
		[Token(Token = "0x40071E6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_IsStageFinishAllReward;

		// Token: 0x040071E7 RID: 29159
		[Token(Token = "0x40071E7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_IsStageUnlocked;

		// Token: 0x040071E8 RID: 29160
		[Token(Token = "0x40071E8")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_IsStageClosed;

		// Token: 0x040071E9 RID: 29161
		[Token(Token = "0x40071E9")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_IsStageUnknown;

		// Token: 0x040071EA RID: 29162
		[Token(Token = "0x40071EA")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_IsTrainingAllOpen;

		// Token: 0x040071EB RID: 29163
		[Token(Token = "0x40071EB")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_IsTrainingReturnAllOpen;

		// Token: 0x040071EC RID: 29164
		[Token(Token = "0x40071EC")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetCurrentTrainingAllOpenEndTs;

		// Token: 0x040071ED RID: 29165
		[Token(Token = "0x40071ED")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetReturnV2AllOpenEndTs;

		// Token: 0x040071EE RID: 29166
		[Token(Token = "0x40071EE")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetTrainingAllOpenGroupEndTs;

		// Token: 0x040071EF RID: 29167
		[Token(Token = "0x40071EF")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetZoneUnlockText;

		// Token: 0x040071F0 RID: 29168
		[Token(Token = "0x40071F0")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetZoneRegion;

		// Token: 0x040071F1 RID: 29169
		[Token(Token = "0x40071F1")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetRemainTimeText;

		// Token: 0x040071F2 RID: 29170
		[Token(Token = "0x40071F2")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetMissionBreakFee;

		// Token: 0x040071F3 RID: 29171
		[Token(Token = "0x40071F3")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetCampFeeRefreshCountDownText;

		// Token: 0x040071F4 RID: 29172
		[Token(Token = "0x40071F4")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_LoadStageEndTimes;

		// Token: 0x040071F5 RID: 29173
		[Token(Token = "0x40071F5")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetStageEndTs;

		// Token: 0x040071F6 RID: 29174
		[Token(Token = "0x40071F6")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__GetStageNameInUnlockText;

		// Token: 0x040071F7 RID: 29175
		[Token(Token = "0x40071F7")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__FormatTimeDelta;

		// Token: 0x040071F8 RID: 29176
		[Token(Token = "0x40071F8")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetProperGainLadder;

		// Token: 0x040071F9 RID: 29177
		[Token(Token = "0x40071F9")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_CheckIfFastBattleSysOpen;

		// Token: 0x040071FA RID: 29178
		[Token(Token = "0x40071FA")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_LoadFastBattleTktInfo;

		// Token: 0x040071FB RID: 29179
		[Token(Token = "0x40071FB")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetStageSweepCount;
	}
}
