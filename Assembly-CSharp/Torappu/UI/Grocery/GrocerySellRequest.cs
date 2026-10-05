using System;
using Il2CppDummyDll;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D2C RID: 19756
	[Token(Token = "0x2004D2C")]
	public class GrocerySellRequest
	{
		// Token: 0x0601D960 RID: 121184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D960")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GrocerySellRequest()
		{
		}

		// Token: 0x04027121 RID: 160033
		[Token(Token = "0x4027121")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04027122 RID: 160034
		[Token(Token = "0x4027122")]
		[FieldOffset(Offset = "0x18")]
		public int price;
	}
}
