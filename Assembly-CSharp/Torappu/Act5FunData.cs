using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EBD RID: 3773
	[Token(Token = "0x2000EBD")]
	public class Act5FunData
	{
		// Token: 0x06006B8E RID: 27534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B8E")]
		[Address(RVA = "0x1FF7710", Offset = "0x1FF6310", VA = "0x181FF7710")]
		public Act5FunData()
		{
		}

		// Token: 0x04004FC5 RID: 20421
		[Token(Token = "0x4004FC5")]
		[FieldOffset(Offset = "0x10")]
		public Act5FunData.BattleData battleData;

		// Token: 0x04004FC6 RID: 20422
		[Token(Token = "0x4004FC6")]
		[FieldOffset(Offset = "0x18")]
		public Act5funBasicConst constData;

		// Token: 0x04004FC7 RID: 20423
		[Token(Token = "0x4004FC7")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act5FunBasicNpcData> npcData;

		// Token: 0x04004FC8 RID: 20424
		[Token(Token = "0x4004FC8")]
		[FieldOffset(Offset = "0x28")]
		public List<Act5FunSettleRatingData> ratingData;

		// Token: 0x04004FC9 RID: 20425
		[Token(Token = "0x4004FC9")]
		[FieldOffset(Offset = "0x30")]
		public List<Act5FunSettleStreakData> streakData;

		// Token: 0x04004FCA RID: 20426
		[Token(Token = "0x4004FCA")]
		[FieldOffset(Offset = "0x38")]
		public List<Act5FunSettleSuccessData> successData;

		// Token: 0x02000EBE RID: 3774
		[Token(Token = "0x2000EBE")]
		public class BattleData
		{
			// Token: 0x06006B8F RID: 27535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B8F")]
			[Address(RVA = "0x2001980", Offset = "0x2000580", VA = "0x182001980")]
			public BattleData()
			{
			}

			// Token: 0x04004FCB RID: 20427
			[Token(Token = "0x4004FCB")]
			[FieldOffset(Offset = "0x10")]
			public Act5funConst battleConstData;

			// Token: 0x04004FCC RID: 20428
			[Token(Token = "0x4004FCC")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, Act5FunRoundData> roundData;

			// Token: 0x04004FCD RID: 20429
			[Token(Token = "0x4004FCD")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, Act5FunNpcData> npcData;

			// Token: 0x04004FCE RID: 20430
			[Token(Token = "0x4004FCE")]
			[FieldOffset(Offset = "0x28")]
			public List<Act5FunNpcSelectorData> npcSelectorData;

			// Token: 0x04004FCF RID: 20431
			[Token(Token = "0x4004FCF")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<string, Act5FunChoiceRewardData> choiceRewardData;

			// Token: 0x04004FD0 RID: 20432
			[Token(Token = "0x4004FD0")]
			[FieldOffset(Offset = "0x38")]
			public Dictionary<string, Act5FunEnemyIdMappingData> enemyIdMappingData;

			// Token: 0x04004FD1 RID: 20433
			[Token(Token = "0x4004FD1")]
			[FieldOffset(Offset = "0x40")]
			public List<float> battleStreak;
		}
	}
}
