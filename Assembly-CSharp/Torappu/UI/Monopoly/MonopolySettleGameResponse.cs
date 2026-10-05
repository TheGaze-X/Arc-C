using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004833 RID: 18483
	[Token(Token = "0x2004833")]
	public class MonopolySettleGameResponse : PlayerDeltaResponse
	{
		// Token: 0x0601BECE RID: 114382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BECE")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public MonopolySettleGameResponse()
		{
		}

		// Token: 0x04024680 RID: 149120
		[Token(Token = "0x4024680")]
		[FieldOffset(Offset = "0x28")]
		public string stageId;

		// Token: 0x04024681 RID: 149121
		[Token(Token = "0x4024681")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, int> resource;

		// Token: 0x04024682 RID: 149122
		[Token(Token = "0x4024682")]
		[FieldOffset(Offset = "0x38")]
		public int score;

		// Token: 0x04024683 RID: 149123
		[Token(Token = "0x4024683")]
		[FieldOffset(Offset = "0x3C")]
		public int target;

		// Token: 0x04024684 RID: 149124
		[Token(Token = "0x4024684")]
		[FieldOffset(Offset = "0x40")]
		public bool isHighScore;

		// Token: 0x04024685 RID: 149125
		[Token(Token = "0x4024685")]
		[FieldOffset(Offset = "0x48")]
		public List<RewardItemModel> rewards;
	}
}
