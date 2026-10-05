using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007D9 RID: 2009
	[Token(Token = "0x20007D9")]
	public class RecalRuneSeasonRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x06006464 RID: 25700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006464")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RecalRuneSeasonRewardResponse()
		{
		}

		// Token: 0x040030FA RID: 12538
		[Token(Token = "0x40030FA")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
