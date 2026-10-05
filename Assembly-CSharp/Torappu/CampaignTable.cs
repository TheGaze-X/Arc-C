using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F4A RID: 3914
	[Token(Token = "0x2000F4A")]
	[Serializable]
	public class CampaignTable
	{
		// Token: 0x06006C56 RID: 27734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C56")]
		[Address(RVA = "0x2007CA0", Offset = "0x20068A0", VA = "0x182007CA0")]
		public CampaignTable()
		{
		}

		// Token: 0x04005334 RID: 21300
		[Token(Token = "0x4005334")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, CampaignData> campaigns;

		// Token: 0x04005335 RID: 21301
		[Token(Token = "0x4005335")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, CampaignGroupData> campaignGroups;

		// Token: 0x04005336 RID: 21302
		[Token(Token = "0x4005336")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, CampaignRegionData> campaignRegions;

		// Token: 0x04005337 RID: 21303
		[Token(Token = "0x4005337")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, CampaignZoneData> campaignZones;

		// Token: 0x04005338 RID: 21304
		[Token(Token = "0x4005338")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, CampaignMissionData> campaignMissions;

		// Token: 0x04005339 RID: 21305
		[Token(Token = "0x4005339")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, int> stageIndexInZoneMap;

		// Token: 0x0400533A RID: 21306
		[Token(Token = "0x400533A")]
		[FieldOffset(Offset = "0x40")]
		public CampaignConstTable campaignConstTable;

		// Token: 0x0400533B RID: 21307
		[Token(Token = "0x400533B")]
		[FieldOffset(Offset = "0x48")]
		public List<CampaignRotateOpenTimeData> campaignRotateStageOpenTimes;

		// Token: 0x0400533C RID: 21308
		[Token(Token = "0x400533C")]
		[FieldOffset(Offset = "0x50")]
		public List<CampaignTrainingOpenTimeData> campaignTrainingStageOpenTimes;

		// Token: 0x0400533D RID: 21309
		[Token(Token = "0x400533D")]
		[FieldOffset(Offset = "0x58")]
		public List<CampaignTrainingAllOpenTimeData> campaignTrainingAllOpenTimes;

		// Token: 0x0400533E RID: 21310
		[Token(Token = "0x400533E")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, Dictionary<string, CampaignStageMapData>> campaignZoneMapData;
	}
}
