using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000660 RID: 1632
	[Token(Token = "0x2000660")]
	public class BuildingDeliveryBatchOrderRequest : BuildingRequest
	{
		// Token: 0x0600628E RID: 25230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingDeliveryBatchOrderRequest()
		{
		}

		// Token: 0x04002E1A RID: 11802
		[Token(Token = "0x4002E1A")]
		[FieldOffset(Offset = "0x10")]
		public List<string> slotList;
	}
}
