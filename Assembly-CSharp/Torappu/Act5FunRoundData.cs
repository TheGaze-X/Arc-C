using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EB1 RID: 3761
	[Token(Token = "0x2000EB1")]
	public class Act5FunRoundData
	{
		// Token: 0x06006B83 RID: 27523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B83")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5FunRoundData()
		{
		}

		// Token: 0x04004F81 RID: 20353
		[Token(Token = "0x4004F81")]
		[FieldOffset(Offset = "0x10")]
		public string roundId;

		// Token: 0x04004F82 RID: 20354
		[Token(Token = "0x4004F82")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04004F83 RID: 20355
		[Token(Token = "0x4004F83")]
		[FieldOffset(Offset = "0x20")]
		public bool enemyPredefined;

		// Token: 0x04004F84 RID: 20356
		[Token(Token = "0x4004F84")]
		[FieldOffset(Offset = "0x24")]
		public int round;

		// Token: 0x04004F85 RID: 20357
		[Token(Token = "0x4004F85")]
		[FieldOffset(Offset = "0x28")]
		public float enemyPoint;

		// Token: 0x04004F86 RID: 20358
		[Token(Token = "0x4004F86")]
		[FieldOffset(Offset = "0x2C")]
		public float enemyScoreRandom;

		// Token: 0x04004F87 RID: 20359
		[Token(Token = "0x4004F87")]
		[FieldOffset(Offset = "0x30")]
		public int minType;

		// Token: 0x04004F88 RID: 20360
		[Token(Token = "0x4004F88")]
		[FieldOffset(Offset = "0x34")]
		public int maxType;

		// Token: 0x04004F89 RID: 20361
		[Token(Token = "0x4004F89")]
		[FieldOffset(Offset = "0x38")]
		public int choiceCount;

		// Token: 0x04004F8A RID: 20362
		[Token(Token = "0x4004F8A")]
		[FieldOffset(Offset = "0x40")]
		public string choiceId1;

		// Token: 0x04004F8B RID: 20363
		[Token(Token = "0x4004F8B")]
		[FieldOffset(Offset = "0x48")]
		public string choiceId2;

		// Token: 0x04004F8C RID: 20364
		[Token(Token = "0x4004F8C")]
		[FieldOffset(Offset = "0x50")]
		public string choiceId3;

		// Token: 0x04004F8D RID: 20365
		[Token(Token = "0x4004F8D")]
		[FieldOffset(Offset = "0x58")]
		public string choiceId4;

		// Token: 0x04004F8E RID: 20366
		[Token(Token = "0x4004F8E")]
		[FieldOffset(Offset = "0x60")]
		public bool enableSideTarget;
	}
}
