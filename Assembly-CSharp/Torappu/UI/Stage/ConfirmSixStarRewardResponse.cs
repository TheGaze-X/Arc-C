using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x0200684C RID: 26700
	[Token(Token = "0x200684C")]
	public class ConfirmSixStarRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x06026389 RID: 156553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026389")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ConfirmSixStarRewardResponse()
		{
		}

		// Token: 0x04035DFF RID: 220671
		[Token(Token = "0x4035DFF")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> items;
	}
}
