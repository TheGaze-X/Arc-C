using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000656 RID: 1622
	[Token(Token = "0x2000656")]
	public class BuildingTradingDeleteOrderRequest
	{
		// Token: 0x06006284 RID: 25220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006284")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingTradingDeleteOrderRequest()
		{
		}

		// Token: 0x04002E0D RID: 11789
		[Token(Token = "0x4002E0D")]
		[FieldOffset(Offset = "0x10")]
		public string slotId;

		// Token: 0x04002E0E RID: 11790
		[Token(Token = "0x4002E0E")]
		[FieldOffset(Offset = "0x18")]
		public long orderId;
	}
}
