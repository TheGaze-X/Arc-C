using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D29 RID: 27945
	[Token(Token = "0x2006D29")]
	public class ActivityConfirmMissionGroupResponse : PlayerDeltaResponse
	{
		// Token: 0x06027D94 RID: 163220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D94")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActivityConfirmMissionGroupResponse()
		{
		}

		// Token: 0x040387BB RID: 231355
		[Token(Token = "0x40387BB")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
