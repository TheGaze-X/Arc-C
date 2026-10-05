using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001205 RID: 4613
	[Token(Token = "0x2001205")]
	public class RoguelikeTopicBankReward
	{
		// Token: 0x06006FFB RID: 28667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicBankReward()
		{
		}

		// Token: 0x04006346 RID: 25414
		[Token(Token = "0x4006346")]
		[FieldOffset(Offset = "0x10")]
		public string rewardId;

		// Token: 0x04006347 RID: 25415
		[Token(Token = "0x4006347")]
		[FieldOffset(Offset = "0x18")]
		public int unlockGoldCnt;

		// Token: 0x04006348 RID: 25416
		[Token(Token = "0x4006348")]
		[FieldOffset(Offset = "0x1C")]
		public RoguelikeTopicBankRewardType rewardType;

		// Token: 0x04006349 RID: 25417
		[Token(Token = "0x4006349")]
		[FieldOffset(Offset = "0x20")]
		public string desc;
	}
}
