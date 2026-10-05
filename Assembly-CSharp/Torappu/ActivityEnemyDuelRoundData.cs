using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000DFE RID: 3582
	[Token(Token = "0x2000DFE")]
	public class ActivityEnemyDuelRoundData
	{
		// Token: 0x06006ACF RID: 27343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ACF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityEnemyDuelRoundData()
		{
		}

		// Token: 0x04004A5C RID: 19036
		[Token(Token = "0x4004A5C")]
		[FieldOffset(Offset = "0x10")]
		public string roundId;

		// Token: 0x04004A5D RID: 19037
		[Token(Token = "0x4004A5D")]
		[FieldOffset(Offset = "0x18")]
		public string modeId;

		// Token: 0x04004A5E RID: 19038
		[Token(Token = "0x4004A5E")]
		[FieldOffset(Offset = "0x20")]
		public int guessTime;

		// Token: 0x04004A5F RID: 19039
		[Token(Token = "0x4004A5F")]
		[FieldOffset(Offset = "0x24")]
		public int round;

		// Token: 0x04004A60 RID: 19040
		[Token(Token = "0x4004A60")]
		[FieldOffset(Offset = "0x28")]
		public bool enemyPredefined;

		// Token: 0x04004A61 RID: 19041
		[Token(Token = "0x4004A61")]
		[FieldOffset(Offset = "0x2C")]
		public int roundScore;

		// Token: 0x04004A62 RID: 19042
		[Token(Token = "0x4004A62")]
		[FieldOffset(Offset = "0x30")]
		public float enemyScore;

		// Token: 0x04004A63 RID: 19043
		[Token(Token = "0x4004A63")]
		[FieldOffset(Offset = "0x34")]
		public float enemyScoreRandom;

		// Token: 0x04004A64 RID: 19044
		[Token(Token = "0x4004A64")]
		[FieldOffset(Offset = "0x38")]
		public int enemySideMinLeft;

		// Token: 0x04004A65 RID: 19045
		[Token(Token = "0x4004A65")]
		[FieldOffset(Offset = "0x3C")]
		public int enemySideMaxLeft;

		// Token: 0x04004A66 RID: 19046
		[Token(Token = "0x4004A66")]
		[FieldOffset(Offset = "0x40")]
		public int enemySideMinRight;

		// Token: 0x04004A67 RID: 19047
		[Token(Token = "0x4004A67")]
		[FieldOffset(Offset = "0x44")]
		public int enemySideMaxRight;

		// Token: 0x04004A68 RID: 19048
		[Token(Token = "0x4004A68")]
		[FieldOffset(Offset = "0x48")]
		public string enemyPoolLeft;

		// Token: 0x04004A69 RID: 19049
		[Token(Token = "0x4004A69")]
		[FieldOffset(Offset = "0x50")]
		public string enemyPoolRight;

		// Token: 0x04004A6A RID: 19050
		[Token(Token = "0x4004A6A")]
		[FieldOffset(Offset = "0x58")]
		public bool canSkip;

		// Token: 0x04004A6B RID: 19051
		[Token(Token = "0x4004A6B")]
		[FieldOffset(Offset = "0x59")]
		public bool canAllIn;
	}
}
