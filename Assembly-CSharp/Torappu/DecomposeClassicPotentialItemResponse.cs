using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200085E RID: 2142
	[Token(Token = "0x200085E")]
	public class DecomposeClassicPotentialItemResponse : PlayerDeltaResponse
	{
		// Token: 0x060064F5 RID: 25845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F5")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public DecomposeClassicPotentialItemResponse()
		{
		}

		// Token: 0x04003173 RID: 12659
		[Token(Token = "0x4003173")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
