using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200085C RID: 2140
	[Token(Token = "0x200085C")]
	public class DecomposePotentialItemResponse : PlayerDeltaResponse
	{
		// Token: 0x060064F3 RID: 25843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F3")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public DecomposePotentialItemResponse()
		{
		}

		// Token: 0x04003171 RID: 12657
		[Token(Token = "0x4003171")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
