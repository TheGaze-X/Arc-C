using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000652 RID: 1618
	[Token(Token = "0x2000652")]
	public class BuildingTradingDeliveryRequest
	{
		// Token: 0x06006280 RID: 25216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006280")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingTradingDeliveryRequest()
		{
		}

		// Token: 0x04002E09 RID: 11785
		[Token(Token = "0x4002E09")]
		[FieldOffset(Offset = "0x10")]
		public string slotId;

		// Token: 0x04002E0A RID: 11786
		[Token(Token = "0x4002E0A")]
		[FieldOffset(Offset = "0x18")]
		public long orderId;
	}
}
