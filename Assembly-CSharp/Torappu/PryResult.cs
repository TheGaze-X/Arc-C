using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200070B RID: 1803
	[Token(Token = "0x200070B")]
	public class PryResult
	{
		// Token: 0x06006369 RID: 25449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006369")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PryResult()
		{
		}

		// Token: 0x04002F31 RID: 12081
		[Token(Token = "0x4002F31")]
		[FieldOffset(Offset = "0x10")]
		public string pryStage;

		// Token: 0x04002F32 RID: 12082
		[Token(Token = "0x4002F32")]
		[FieldOffset(Offset = "0x18")]
		public float expScale;

		// Token: 0x04002F33 RID: 12083
		[Token(Token = "0x4002F33")]
		[FieldOffset(Offset = "0x1C")]
		public float goldScale;

		// Token: 0x04002F34 RID: 12084
		[Token(Token = "0x4002F34")]
		[FieldOffset(Offset = "0x20")]
		public List<CommonFinishBattleResponse.RewardModel> rewards;

		// Token: 0x04002F35 RID: 12085
		[Token(Token = "0x4002F35")]
		[FieldOffset(Offset = "0x28")]
		public List<CommonFinishBattleResponse.RewardModel> overrideRewards;

		// Token: 0x04002F36 RID: 12086
		[Token(Token = "0x4002F36")]
		[FieldOffset(Offset = "0x30")]
		public List<CommonFinishBattleResponse.RewardModel> unusualRewards;

		// Token: 0x04002F37 RID: 12087
		[Token(Token = "0x4002F37")]
		[FieldOffset(Offset = "0x38")]
		public List<CommonFinishBattleResponse.RewardModel> additionalRewards;

		// Token: 0x04002F38 RID: 12088
		[Token(Token = "0x4002F38")]
		[FieldOffset(Offset = "0x40")]
		public List<CommonFinishBattleResponse.RewardModel> furnitureRewards;

		// Token: 0x04002F39 RID: 12089
		[Token(Token = "0x4002F39")]
		[FieldOffset(Offset = "0x48")]
		public List<CommonFinishBattleResponse.RewardModel> firstRewards;
	}
}
