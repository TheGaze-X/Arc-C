using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200109F RID: 4255
	[Token(Token = "0x200109F")]
	[Serializable]
	public class HandbookInfoTable
	{
		// Token: 0x06006E2A RID: 28202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E2A")]
		[Address(RVA = "0x2105870", Offset = "0x2104470", VA = "0x182105870")]
		public HandbookInfoTable()
		{
		}

		// Token: 0x04005AC2 RID: 23234
		[Token(Token = "0x4005AC2")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, HandbookInfoData> handbookDict;

		// Token: 0x04005AC3 RID: 23235
		[Token(Token = "0x4005AC3")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, NPCData> npcDict;

		// Token: 0x04005AC4 RID: 23236
		[Token(Token = "0x4005AC4")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, HandbookTeamMission> teamMissionList;

		// Token: 0x04005AC5 RID: 23237
		[Token(Token = "0x4005AC5")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, HandbookDisplayCondition> handbookDisplayConditionList;

		// Token: 0x04005AC6 RID: 23238
		[Token(Token = "0x4005AC6")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, HandbookStoryStageData> handbookStageData;

		// Token: 0x04005AC7 RID: 23239
		[Token(Token = "0x4005AC7")]
		[FieldOffset(Offset = "0x38")]
		public List<HandbookStageTimeData> handbookStageTime;
	}
}
