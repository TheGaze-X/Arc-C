using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200083E RID: 2110
	[Token(Token = "0x200083E")]
	public class BuyCashGoodResponse : PlayerDeltaResponse
	{
		// Token: 0x060064D6 RID: 25814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D6")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuyCashGoodResponse()
		{
		}

		// Token: 0x04003142 RID: 12610
		[Token(Token = "0x4003142")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
