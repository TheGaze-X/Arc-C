using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008E2 RID: 2274
	[Token(Token = "0x20008E2")]
	public class ZoneRecordRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x06006597 RID: 26007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006597")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ZoneRecordRewardResponse()
		{
		}

		// Token: 0x040032F5 RID: 13045
		[Token(Token = "0x40032F5")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemGet> items;
	}
}
