using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001425 RID: 5157
	[Token(Token = "0x2001425")]
	public class GetRewardMedalResponse : PlayerDeltaResponse
	{
		// Token: 0x060076E6 RID: 30438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E6")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetRewardMedalResponse()
		{
		}

		// Token: 0x04007455 RID: 29781
		[Token(Token = "0x4007455")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemGet> items;
	}
}
