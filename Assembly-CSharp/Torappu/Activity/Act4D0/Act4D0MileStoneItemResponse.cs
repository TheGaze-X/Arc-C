using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007273 RID: 29299
	[Token(Token = "0x2007273")]
	public class Act4D0MileStoneItemResponse : PlayerDeltaResponse
	{
		// Token: 0x06029817 RID: 170007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029817")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act4D0MileStoneItemResponse()
		{
		}

		// Token: 0x0403B4E7 RID: 242919
		[Token(Token = "0x403B4E7")]
		[FieldOffset(Offset = "0x28")]
		public ActivityItemModel reward;
	}
}
