using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act12side
{
	// Token: 0x02007A5C RID: 31324
	[Token(Token = "0x2007A5C")]
	public class GetCharmFirstRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x0602BE14 RID: 179732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE14")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetCharmFirstRewardResponse()
		{
		}

		// Token: 0x0403F8C2 RID: 260290
		[Token(Token = "0x403F8C2")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<string, int> settles;

		// Token: 0x0403F8C3 RID: 260291
		[Token(Token = "0x403F8C3")]
		[FieldOffset(Offset = "0x30")]
		public List<RewardItemModel> coinGot;
	}
}
