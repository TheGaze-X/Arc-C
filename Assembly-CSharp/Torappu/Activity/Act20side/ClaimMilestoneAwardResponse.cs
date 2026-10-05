using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200764A RID: 30282
	[Token(Token = "0x200764A")]
	public class ClaimMilestoneAwardResponse : PlayerDeltaResponse
	{
		// Token: 0x0602A9AC RID: 174508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9AC")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ClaimMilestoneAwardResponse()
		{
		}

		// Token: 0x0403D57C RID: 251260
		[Token(Token = "0x403D57C")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
