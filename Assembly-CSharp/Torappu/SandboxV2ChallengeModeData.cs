using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012F8 RID: 4856
	[Token(Token = "0x20012F8")]
	public class SandboxV2ChallengeModeData
	{
		// Token: 0x06007271 RID: 29297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007271")]
		[Address(RVA = "0x220E650", Offset = "0x220D250", VA = "0x18220E650")]
		public SandboxV2ChallengeModeData()
		{
		}

		// Token: 0x04006B51 RID: 27473
		[Token(Token = "0x4006B51")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2ChallengeConst challengeConst;

		// Token: 0x04006B52 RID: 27474
		[Token(Token = "0x4006B52")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, SandboxV2ChallengeModeUnlockData> challengeModeUnlockData;

		// Token: 0x04006B53 RID: 27475
		[Token(Token = "0x4006B53")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, SandboxV2ChallengeModeRewardData> challengeModeRewardData;

		// Token: 0x04006B54 RID: 27476
		[Token(Token = "0x4006B54")]
		[FieldOffset(Offset = "0x28")]
		public List<SandboxV2ChallengeModeDifficultyData> challengeModeDifficultyData;
	}
}
