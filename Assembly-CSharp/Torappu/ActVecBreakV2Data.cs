using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E5D RID: 3677
	[Token(Token = "0x2000E5D")]
	public class ActVecBreakV2Data
	{
		// Token: 0x06006B2A RID: 27434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B2A")]
		[Address(RVA = "0x1FFA710", Offset = "0x1FF9310", VA = "0x181FFA710")]
		public ActVecBreakV2Data()
		{
		}

		// Token: 0x04004CF4 RID: 19700
		[Token(Token = "0x4004CF4")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActVecBreakV2OffenseStageData> offenseStageDict;

		// Token: 0x04004CF5 RID: 19701
		[Token(Token = "0x4004CF5")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ActVecBreakV2HardStageData> hardStageDict;

		// Token: 0x04004CF6 RID: 19702
		[Token(Token = "0x4004CF6")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, ActVecBreakV2DefenseBasicData> defenseBasicDict;

		// Token: 0x04004CF7 RID: 19703
		[Token(Token = "0x4004CF7")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ActVecBreakV2DefenseDetailData> defenseDetailDict;

		// Token: 0x04004CF8 RID: 19704
		[Token(Token = "0x4004CF8")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, ActVecBreakV2ZoneData> zoneDict;

		// Token: 0x04004CF9 RID: 19705
		[Token(Token = "0x4004CF9")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, ActVecBreakV2DefenseGroupData> defenseGroupDict;

		// Token: 0x04004CFA RID: 19706
		[Token(Token = "0x4004CFA")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, ActVecBreakV2BattleBuffData> battleBuffDict;

		// Token: 0x04004CFB RID: 19707
		[Token(Token = "0x4004CFB")]
		[FieldOffset(Offset = "0x48")]
		public List<ActVecBreakV2MilestoneItemData> milestoneList;

		// Token: 0x04004CFC RID: 19708
		[Token(Token = "0x4004CFC")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, ActVecBreakV2StageRewardData> stageRewardDict;

		// Token: 0x04004CFD RID: 19709
		[Token(Token = "0x4004CFD")]
		[FieldOffset(Offset = "0x58")]
		public ActVecBreakV2ConstData constData;

		// Token: 0x04004CFE RID: 19710
		[Token(Token = "0x4004CFE")]
		[FieldOffset(Offset = "0x60")]
		public List<string> squadBuffAvailStageList;

		// Token: 0x04004CFF RID: 19711
		[Token(Token = "0x4004CFF")]
		[FieldOffset(Offset = "0x68")]
		public List<ActVecBreakV2ScheduleBlockData> scheduleBlockList;

		// Token: 0x04004D00 RID: 19712
		[Token(Token = "0x4004D00")]
		[FieldOffset(Offset = "0x70")]
		public string defenseZoneId;

		// Token: 0x04004D01 RID: 19713
		[Token(Token = "0x4004D01")]
		[FieldOffset(Offset = "0x78")]
		public string offenseZoneId;

		// Token: 0x04004D02 RID: 19714
		[Token(Token = "0x4004D02")]
		[FieldOffset(Offset = "0x80")]
		public string hardZoneId;

		// Token: 0x04004D03 RID: 19715
		[Token(Token = "0x4004D03")]
		[FieldOffset(Offset = "0x88")]
		public string firstDefenseStageId;
	}
}
