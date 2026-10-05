using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000658 RID: 1624
	[Token(Token = "0x2000658")]
	public class BuildingTradingLaborAccelRequest
	{
		// Token: 0x06006286 RID: 25222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006286")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingTradingLaborAccelRequest()
		{
		}

		// Token: 0x04002E0F RID: 11791
		[Token(Token = "0x4002E0F")]
		[FieldOffset(Offset = "0x10")]
		public string slotId;

		// Token: 0x04002E10 RID: 11792
		[Token(Token = "0x4002E10")]
		[FieldOffset(Offset = "0x18")]
		public long orderId;

		// Token: 0x04002E11 RID: 11793
		[Token(Token = "0x4002E11")]
		[FieldOffset(Offset = "0x20")]
		public int cost;
	}
}
