using System;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D2A RID: 27946
	[Token(Token = "0x2006D2A")]
	public class ActivityRewardMilestoneRequest
	{
		// Token: 0x06027D95 RID: 163221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D95")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityRewardMilestoneRequest()
		{
		}

		// Token: 0x040387BC RID: 231356
		[Token(Token = "0x40387BC")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040387BD RID: 231357
		[Token(Token = "0x40387BD")]
		[FieldOffset(Offset = "0x18")]
		public string milestoneId;
	}
}
