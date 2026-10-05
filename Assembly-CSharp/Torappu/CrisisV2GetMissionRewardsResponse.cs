using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006E6 RID: 1766
	[Token(Token = "0x20006E6")]
	public class CrisisV2GetMissionRewardsResponse : PlayerDeltaResponse
	{
		// Token: 0x06006335 RID: 25397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006335")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public CrisisV2GetMissionRewardsResponse()
		{
		}

		// Token: 0x04002EFA RID: 12026
		[Token(Token = "0x4002EFA")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> rewards;
	}
}
