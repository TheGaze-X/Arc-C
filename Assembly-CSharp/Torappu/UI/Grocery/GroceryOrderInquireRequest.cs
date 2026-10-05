using System;
using Il2CppDummyDll;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D30 RID: 19760
	[Token(Token = "0x2004D30")]
	public class GroceryOrderInquireRequest
	{
		// Token: 0x0601D964 RID: 121188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D964")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GroceryOrderInquireRequest()
		{
		}

		// Token: 0x04027126 RID: 160038
		[Token(Token = "0x4027126")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04027127 RID: 160039
		[Token(Token = "0x4027127")]
		[FieldOffset(Offset = "0x18")]
		public string goodId;

		// Token: 0x04027128 RID: 160040
		[Token(Token = "0x4027128")]
		[FieldOffset(Offset = "0x20")]
		public string shopId;
	}
}
