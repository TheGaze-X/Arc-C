using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CB5 RID: 3253
	[Token(Token = "0x2000CB5")]
	public class Act1VHalfIdleData
	{
		// Token: 0x06006996 RID: 27030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006996")]
		[Address(RVA = "0x1FF2E50", Offset = "0x1FF1A50", VA = "0x181FF2E50")]
		public Act1VHalfIdleData()
		{
		}

		// Token: 0x0400425A RID: 16986
		[Token(Token = "0x400425A")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act1VHalfIdleGachaPoolData> gachaPoolData;

		// Token: 0x0400425B RID: 16987
		[Token(Token = "0x400425B")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act1VHalfIdleGachaCharData> gachaCharData;

		// Token: 0x0400425C RID: 16988
		[Token(Token = "0x400425C")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act1VHalfIdlePlotTypeData> plotTypeData;

		// Token: 0x0400425D RID: 16989
		[Token(Token = "0x400425D")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act1VHalfIdlePlotData> plotData;

		// Token: 0x0400425E RID: 16990
		[Token(Token = "0x400425E")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, Act1VHalfIdleStageProductionData> stageProductionData;

		// Token: 0x0400425F RID: 16991
		[Token(Token = "0x400425F")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, Act1VHalfIdleCharRankData> charRankData;

		// Token: 0x04004260 RID: 16992
		[Token(Token = "0x4004260")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, Act1VHalfIdleCharEvolveData> charEvolveData;

		// Token: 0x04004261 RID: 16993
		[Token(Token = "0x4004261")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, Act1VHalfIdleCharMaxRankData> charMaxRankData;

		// Token: 0x04004262 RID: 16994
		[Token(Token = "0x4004262")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, Act1VHalfIdleCharSkillRankData> charSkillRankData;

		// Token: 0x04004263 RID: 16995
		[Token(Token = "0x4004263")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, Act1VHalfIdleTechTreeData> techTreeData;

		// Token: 0x04004264 RID: 16996
		[Token(Token = "0x4004264")]
		[FieldOffset(Offset = "0x60")]
		public List<Act1VHalfIdleCharBuffData> charBuffData;

		// Token: 0x04004265 RID: 16997
		[Token(Token = "0x4004265")]
		[FieldOffset(Offset = "0x68")]
		public List<Act1VHalfIdleMilestoneItemData> milestoneList;

		// Token: 0x04004266 RID: 16998
		[Token(Token = "0x4004266")]
		[FieldOffset(Offset = "0x70")]
		public List<Act1VHalfIdleGachaPoolTypeData> poolTypeData;

		// Token: 0x04004267 RID: 16999
		[Token(Token = "0x4004267")]
		[FieldOffset(Offset = "0x78")]
		public List<string> stageIds;

		// Token: 0x04004268 RID: 17000
		[Token(Token = "0x4004268")]
		[FieldOffset(Offset = "0x80")]
		public string zoneId;

		// Token: 0x04004269 RID: 17001
		[Token(Token = "0x4004269")]
		[FieldOffset(Offset = "0x88")]
		public Act1VHalfIdleConstData constData;

		// Token: 0x0400426A RID: 17002
		[Token(Token = "0x400426A")]
		[FieldOffset(Offset = "0x90")]
		public List<Act1VHalfIdleDiagramData> diagramList;

		// Token: 0x0400426B RID: 17003
		[Token(Token = "0x400426B")]
		[FieldOffset(Offset = "0x98")]
		public Dictionary<string, Act1VHalfIdleEnemyDropBundle> enemyItemDropPoolDict;

		// Token: 0x0400426C RID: 17004
		[Token(Token = "0x400426C")]
		[FieldOffset(Offset = "0xA0")]
		public Dictionary<string, List<Act1VBattleItemDropSlot>> battleItemPoolDict;

		// Token: 0x0400426D RID: 17005
		[Token(Token = "0x400426D")]
		[FieldOffset(Offset = "0xA8")]
		public Dictionary<string, List<Act1VWeightedResItemBundle>> resourceItemPoolDict;

		// Token: 0x0400426E RID: 17006
		[Token(Token = "0x400426E")]
		[FieldOffset(Offset = "0xB0")]
		public Dictionary<string, List<Act1VHalfIdleWeightedBattleEquip>> equipItemPoolDict;

		// Token: 0x0400426F RID: 17007
		[Token(Token = "0x400426F")]
		[FieldOffset(Offset = "0xB8")]
		public Dictionary<string, List<string>> trapItemPoolDict;

		// Token: 0x04004270 RID: 17008
		[Token(Token = "0x4004270")]
		[FieldOffset(Offset = "0xC0")]
		public Dictionary<string, Dictionary<int, List<Act1VHalfIdleEquipData>>> equipItemData;

		// Token: 0x04004271 RID: 17009
		[Token(Token = "0x4004271")]
		[FieldOffset(Offset = "0xC8")]
		public Dictionary<string, Act1VHalfIdleTrapMeta> trapMetaDict;

		// Token: 0x04004272 RID: 17010
		[Token(Token = "0x4004272")]
		[FieldOffset(Offset = "0xD0")]
		public Dictionary<string, List<string>> plotShowCombineHighlightDict;
	}
}
