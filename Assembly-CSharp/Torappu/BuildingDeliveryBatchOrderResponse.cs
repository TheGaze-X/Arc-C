using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000661 RID: 1633
	[Token(Token = "0x2000661")]
	public class BuildingDeliveryBatchOrderResponse : PlayerDeltaResponse
	{
		// Token: 0x0600628F RID: 25231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628F")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingDeliveryBatchOrderResponse()
		{
		}

		// Token: 0x04002E1B RID: 11803
		[Token(Token = "0x4002E1B")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, List<ItemBundle>> delivered;
	}
}
