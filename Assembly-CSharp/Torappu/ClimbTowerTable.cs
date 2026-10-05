using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F94 RID: 3988
	[Token(Token = "0x2000F94")]
	[Serializable]
	public class ClimbTowerTable
	{
		// Token: 0x06006CD4 RID: 27860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD4")]
		[Address(RVA = "0x21002B0", Offset = "0x20FEEB0", VA = "0x1821002B0")]
		public ClimbTowerTable()
		{
		}

		// Token: 0x040054A9 RID: 21673
		[Token(Token = "0x40054A9")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ClimbTowerSingleTowerData> towers;

		// Token: 0x040054AA RID: 21674
		[Token(Token = "0x40054AA")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ClimbTowerSingleLevelData> levels;

		// Token: 0x040054AB RID: 21675
		[Token(Token = "0x40054AB")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, ClimbTowerTacticalBuffData> tacticalBuffs;

		// Token: 0x040054AC RID: 21676
		[Token(Token = "0x40054AC")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ClimbTowerMainCardData> mainCards;

		// Token: 0x040054AD RID: 21677
		[Token(Token = "0x40054AD")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, ClimbTowerSubCardData> subCards;

		// Token: 0x040054AE RID: 21678
		[Token(Token = "0x40054AE")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, ClimbTowerCurseCardData> curseCards;

		// Token: 0x040054AF RID: 21679
		[Token(Token = "0x40054AF")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, ClimbTowerSeasonInfoData> seasonInfos;

		// Token: 0x040054B0 RID: 21680
		[Token(Token = "0x40054B0")]
		[FieldOffset(Offset = "0x48")]
		public ClimbTowerDetailConst detailConst;

		// Token: 0x040054B1 RID: 21681
		[Token(Token = "0x40054B1")]
		[FieldOffset(Offset = "0x50")]
		public List<ClimbTowerRewardInfo> rewardInfoList;

		// Token: 0x040054B2 RID: 21682
		[Token(Token = "0x40054B2")]
		[FieldOffset(Offset = "0x58")]
		public List<ClimbTowerRewardInfo> rewardInfoListHardMode;

		// Token: 0x040054B3 RID: 21683
		[Token(Token = "0x40054B3")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, ClimbTowerMissionData> missionData;

		// Token: 0x040054B4 RID: 21684
		[Token(Token = "0x40054B4")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, MissionGroup> missionGroup;
	}
}
