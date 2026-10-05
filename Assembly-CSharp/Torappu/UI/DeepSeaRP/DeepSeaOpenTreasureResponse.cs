using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005154 RID: 20820
	[Token(Token = "0x2005154")]
	public class DeepSeaOpenTreasureResponse : PlayerDeltaResponse
	{
		// Token: 0x0601EC76 RID: 126070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC76")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public DeepSeaOpenTreasureResponse()
		{
		}

		// Token: 0x04029438 RID: 169016
		[Token(Token = "0x4029438")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
