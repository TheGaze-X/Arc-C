using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008A3 RID: 2211
	[Token(Token = "0x20008A3")]
	public class ReceiveSocialPointResponse : PlayerDeltaResponse
	{
		// Token: 0x06006542 RID: 25922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006542")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ReceiveSocialPointResponse()
		{
		}

		// Token: 0x0400326A RID: 12906
		[Token(Token = "0x400326A")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> reward;
	}
}
