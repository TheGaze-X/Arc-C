using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D05 RID: 19717
	[Token(Token = "0x2004D05")]
	public class GrocerySellCustomerModel : IHotfixable
	{
		// Token: 0x0601D8D8 RID: 121048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8D8")]
		[Address(RVA = "0x1715E00", Offset = "0x1714A00", VA = "0x181715E00")]
		public GrocerySellCustomerModel()
		{
		}

		// Token: 0x04027015 RID: 159765
		[Token(Token = "0x4027015")]
		[FieldOffset(Offset = "0x10")]
		public int selectedPrice;

		// Token: 0x04027016 RID: 159766
		[Token(Token = "0x4027016")]
		[FieldOffset(Offset = "0x18")]
		public int[] customerCount;

		// Token: 0x04027017 RID: 159767
		[Token(Token = "0x4027017")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
