using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000606 RID: 1542
	[Token(Token = "0x2000606")]
	public class GetOpenServerCheckInRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x0600622D RID: 25133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600622D")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetOpenServerCheckInRewardResponse()
		{
		}

		// Token: 0x04002D86 RID: 11654
		[Token(Token = "0x4002D86")]
		[FieldOffset(Offset = "0x28")]
		public ActivityItemModel reward;
	}
}
