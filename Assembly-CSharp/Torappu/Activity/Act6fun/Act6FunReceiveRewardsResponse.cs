using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071AB RID: 29099
	[Token(Token = "0x20071AB")]
	public class Act6FunReceiveRewardsResponse : PlayerDeltaResponse
	{
		// Token: 0x060294C5 RID: 169157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60294C5")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act6FunReceiveRewardsResponse()
		{
		}

		// Token: 0x0403AF98 RID: 241560
		[Token(Token = "0x403AF98")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
