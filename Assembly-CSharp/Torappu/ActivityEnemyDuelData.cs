using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000DF9 RID: 3577
	[Token(Token = "0x2000DF9")]
	public class ActivityEnemyDuelData
	{
		// Token: 0x06006ACC RID: 27340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ACC")]
		[Address(RVA = "0x1FFBE90", Offset = "0x1FFAA90", VA = "0x181FFBE90")]
		public ActivityEnemyDuelData()
		{
		}

		// Token: 0x04004A24 RID: 18980
		[Token(Token = "0x4004A24")]
		[FieldOffset(Offset = "0x10")]
		public List<ActivityEnemyDuelMilestoneItemData> milestoneList;

		// Token: 0x04004A25 RID: 18981
		[Token(Token = "0x4004A25")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ActivityEnemyDuelModeData> modeData;

		// Token: 0x04004A26 RID: 18982
		[Token(Token = "0x4004A26")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, ActivityEnemyDuelRoundData> roundData;

		// Token: 0x04004A27 RID: 18983
		[Token(Token = "0x4004A27")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ActivityEnemyDuelPoolData> poolData;

		// Token: 0x04004A28 RID: 18984
		[Token(Token = "0x4004A28")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, ActivityEnemyDuelNpcData> npcData;

		// Token: 0x04004A29 RID: 18985
		[Token(Token = "0x4004A29")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, ActivityEnemyDuelNpcSelectorGroupData> npcSelectorData;

		// Token: 0x04004A2A RID: 18986
		[Token(Token = "0x4004A2A")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, ActivityEnemyDuelEnemyData> enemyData;

		// Token: 0x04004A2B RID: 18987
		[Token(Token = "0x4004A2B")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, ActivityEnemyDuelExtraScoreGroupData> extraScoreData;

		// Token: 0x04004A2C RID: 18988
		[Token(Token = "0x4004A2C")]
		[FieldOffset(Offset = "0x50")]
		public List<int> basicScores;

		// Token: 0x04004A2D RID: 18989
		[Token(Token = "0x4004A2D")]
		[FieldOffset(Offset = "0x58")]
		public List<ActivityEnemyDuelAnnounceData> announceData;

		// Token: 0x04004A2E RID: 18990
		[Token(Token = "0x4004A2E")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, ListDict<string, ActivityEnemyDuelSingleCommentData>> commentData;

		// Token: 0x04004A2F RID: 18991
		[Token(Token = "0x4004A2F")]
		[FieldOffset(Offset = "0x68")]
		public ActivityEnemyDuelConstData constData;

		// Token: 0x04004A30 RID: 18992
		[Token(Token = "0x4004A30")]
		[FieldOffset(Offset = "0x70")]
		public ActivityEnemyDuelConstToastData constToastData;

		// Token: 0x04004A31 RID: 18993
		[Token(Token = "0x4004A31")]
		[FieldOffset(Offset = "0x78")]
		public List<ActivityEnemyDuelTipsData> tipsData;

		// Token: 0x04004A32 RID: 18994
		[Token(Token = "0x4004A32")]
		[FieldOffset(Offset = "0x80")]
		public List<string> enabledEmoticonThemeIdList;
	}
}
