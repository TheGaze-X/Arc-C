using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000608 RID: 1544
	[Token(Token = "0x2000608")]
	public class GetChainLogInRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x0600622F RID: 25135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600622F")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetChainLogInRewardResponse()
		{
		}

		// Token: 0x04002D88 RID: 11656
		[Token(Token = "0x4002D88")]
		[FieldOffset(Offset = "0x28")]
		public ActivityItemModel reward;
	}
}
