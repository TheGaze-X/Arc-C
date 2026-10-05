using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D2D RID: 27949
	[Token(Token = "0x2006D2D")]
	public class ActivityRewardAllMilestoneResponse : PlayerDeltaResponse
	{
		// Token: 0x06027D98 RID: 163224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D98")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActivityRewardAllMilestoneResponse()
		{
		}

		// Token: 0x040387C0 RID: 231360
		[Token(Token = "0x40387C0")]
		[FieldOffset(Offset = "0x28")]
		public List<string> milestoneList;

		// Token: 0x040387C1 RID: 231361
		[Token(Token = "0x40387C1")]
		[FieldOffset(Offset = "0x30")]
		public List<RewardItemModel> items;
	}
}
