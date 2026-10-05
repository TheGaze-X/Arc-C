using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D27 RID: 27943
	[Token(Token = "0x2006D27")]
	public class ActivityConfirmMissionResponse : PlayerDeltaResponse
	{
		// Token: 0x06027D92 RID: 163218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D92")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActivityConfirmMissionResponse()
		{
		}

		// Token: 0x040387B8 RID: 231352
		[Token(Token = "0x40387B8")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
