using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006176 RID: 24950
	[Token(Token = "0x2006176")]
	public class BossRushRewardAllMileStoneResponse : PlayerDeltaResponse
	{
		// Token: 0x06024005 RID: 147461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024005")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BossRushRewardAllMileStoneResponse()
		{
		}

		// Token: 0x04032036 RID: 204854
		[Token(Token = "0x4032036")]
		[FieldOffset(Offset = "0x28")]
		public List<ActivityItemModel> items;
	}
}
