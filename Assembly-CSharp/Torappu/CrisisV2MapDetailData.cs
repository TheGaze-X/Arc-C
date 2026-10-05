using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FD6 RID: 4054
	[Token(Token = "0x2000FD6")]
	public class CrisisV2MapDetailData
	{
		// Token: 0x06006D24 RID: 27940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D24")]
		[Address(RVA = "0x2100FE0", Offset = "0x20FFBE0", VA = "0x182100FE0")]
		public CrisisV2MapDetailData()
		{
		}

		// Token: 0x040055FA RID: 22010
		[Token(Token = "0x40055FA")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, CrisisV2RuneData> runeDataMap;

		// Token: 0x040055FB RID: 22011
		[Token(Token = "0x40055FB")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, CrisisV2RuneGroupDescData> groupDescDataMap;

		// Token: 0x040055FC RID: 22012
		[Token(Token = "0x40055FC")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, CrisisV2NodeData> nodeDataMap;

		// Token: 0x040055FD RID: 22013
		[Token(Token = "0x40055FD")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, CrisisV2MapRoadRelationData> roadRelationDataMap;

		// Token: 0x040055FE RID: 22014
		[Token(Token = "0x40055FE")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, CrisisV2BagRoadData> bagRoadDataMap;

		// Token: 0x040055FF RID: 22015
		[Token(Token = "0x40055FF")]
		[FieldOffset(Offset = "0x38")]
		public CrisisV2NodeViewData nodeViewData;

		// Token: 0x04005600 RID: 22016
		[Token(Token = "0x4005600")]
		[FieldOffset(Offset = "0x40")]
		public CrisisV2BagViewData bagViewData;

		// Token: 0x04005601 RID: 22017
		[Token(Token = "0x4005601")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, CrisisV2BagData> bagDataMap;

		// Token: 0x04005602 RID: 22018
		[Token(Token = "0x4005602")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, CrisisV2ExclusionData> exclusionDataMap;

		// Token: 0x04005603 RID: 22019
		[Token(Token = "0x4005603")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, CrisisV2CommentData> commentDataMap;

		// Token: 0x04005604 RID: 22020
		[Token(Token = "0x4005604")]
		[FieldOffset(Offset = "0x60")]
		public List<CrisisV2DimensionItemData> dimensionItemList;

		// Token: 0x04005605 RID: 22021
		[Token(Token = "0x4005605")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, CrisisV2ChallengeNodeData> challengeNodeDataMap;

		// Token: 0x04005606 RID: 22022
		[Token(Token = "0x4005606")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, CrisisV2RewardNodeData> rewardNodeDataMap;

		// Token: 0x04005607 RID: 22023
		[Token(Token = "0x4005607")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, CrisisV2DailyRuneUnlockData> dailyRuneUnlcokDataMap;
	}
}
