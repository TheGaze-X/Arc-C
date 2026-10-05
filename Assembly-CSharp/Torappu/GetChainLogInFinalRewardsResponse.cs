using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200060A RID: 1546
	[Token(Token = "0x200060A")]
	public class GetChainLogInFinalRewardsResponse : PlayerDeltaResponse
	{
		// Token: 0x06006231 RID: 25137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006231")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetChainLogInFinalRewardsResponse()
		{
		}

		// Token: 0x04002D89 RID: 11657
		[Token(Token = "0x4002D89")]
		[FieldOffset(Offset = "0x28")]
		public List<ActivityItemModel> rewards;
	}
}
