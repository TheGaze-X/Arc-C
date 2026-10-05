using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007556 RID: 30038
	[Token(Token = "0x2007556")]
	public class Act24sideGetHuntWikiRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x0602A4DB RID: 173275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4DB")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act24sideGetHuntWikiRewardResponse()
		{
		}

		// Token: 0x0403CD34 RID: 249140
		[Token(Token = "0x403CD34")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> rewards;
	}
}
