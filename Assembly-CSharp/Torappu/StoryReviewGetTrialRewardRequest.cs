using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008C4 RID: 2244
	[Token(Token = "0x20008C4")]
	public class StoryReviewGetTrialRewardRequest
	{
		// Token: 0x06006576 RID: 25974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006576")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StoryReviewGetTrialRewardRequest()
		{
		}

		// Token: 0x040032B6 RID: 12982
		[Token(Token = "0x40032B6")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x040032B7 RID: 12983
		[Token(Token = "0x40032B7")]
		[FieldOffset(Offset = "0x18")]
		public List<string> rewardIdList;
	}
}
