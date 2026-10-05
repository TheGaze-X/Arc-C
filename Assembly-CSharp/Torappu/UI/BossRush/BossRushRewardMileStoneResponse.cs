using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006174 RID: 24948
	[Token(Token = "0x2006174")]
	public class BossRushRewardMileStoneResponse : PlayerDeltaResponse
	{
		// Token: 0x06024003 RID: 147459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024003")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BossRushRewardMileStoneResponse()
		{
		}

		// Token: 0x04032034 RID: 204852
		[Token(Token = "0x4032034")]
		[FieldOffset(Offset = "0x28")]
		public List<ActivityItemModel> items;
	}
}
