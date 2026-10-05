using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D36 RID: 27958
	[Token(Token = "0x2006D36")]
	public class ActivityMissionCheckResponse : PlayerDeltaResponse
	{
		// Token: 0x06027DA1 RID: 163233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DA1")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActivityMissionCheckResponse()
		{
		}

		// Token: 0x040387D3 RID: 231379
		[Token(Token = "0x40387D3")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
