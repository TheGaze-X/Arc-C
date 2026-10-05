using System;
using Il2CppDummyDll;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D26 RID: 19750
	[Token(Token = "0x2004D26")]
	public class GroceryRewardMileStoneRequest
	{
		// Token: 0x0601D95A RID: 121178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D95A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GroceryRewardMileStoneRequest()
		{
		}

		// Token: 0x0402711B RID: 160027
		[Token(Token = "0x402711B")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0402711C RID: 160028
		[Token(Token = "0x402711C")]
		[FieldOffset(Offset = "0x18")]
		public string milestoneId;
	}
}
