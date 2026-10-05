using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001104 RID: 4356
	[Token(Token = "0x2001104")]
	public class MissionTable
	{
		// Token: 0x06006EC5 RID: 28357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC5")]
		[Address(RVA = "0x2108130", Offset = "0x2106D30", VA = "0x182108130")]
		public MissionTable()
		{
		}

		// Token: 0x04005D55 RID: 23893
		[Token(Token = "0x4005D55")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, MissionData> missions;

		// Token: 0x04005D56 RID: 23894
		[Token(Token = "0x4005D56")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, MissionGroup> missionGroups;

		// Token: 0x04005D57 RID: 23895
		[Token(Token = "0x4005D57")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, MissionDailyRewardConf> periodicalRewards;

		// Token: 0x04005D58 RID: 23896
		[Token(Token = "0x4005D58")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, MissionWeeklyRewardConf> weeklyRewards;

		// Token: 0x04005D59 RID: 23897
		[Token(Token = "0x4005D59")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, SOCharMissionGroup> soCharMissionGroupInfo;

		// Token: 0x04005D5A RID: 23898
		[Token(Token = "0x4005D5A")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, DailyMissionGroupInfo> dailyMissionGroupInfo;

		// Token: 0x04005D5B RID: 23899
		[Token(Token = "0x4005D5B")]
		[FieldOffset(Offset = "0x40")]
		public List<DailyMissionGroupInfo> dailyMissionPeriodInfo;

		// Token: 0x04005D5C RID: 23900
		[Token(Token = "0x4005D5C")]
		[FieldOffset(Offset = "0x48")]
		public List<MainlineMissionEndImageData> mainlineMissionEndImageDataList;

		// Token: 0x04005D5D RID: 23901
		[Token(Token = "0x4005D5D")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, CrossAppShareMission> crossAppShareMissions;

		// Token: 0x04005D5E RID: 23902
		[Token(Token = "0x4005D5E")]
		[FieldOffset(Offset = "0x58")]
		public CrossAppShareMissionConst crossAppShareMissionConst;

		// Token: 0x04005D5F RID: 23903
		[Token(Token = "0x4005D5F")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, GuideMissionGroupInfo> guideMissionGroupInfo;
	}
}
