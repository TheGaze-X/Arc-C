using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CD3 RID: 19667
	[Token(Token = "0x2004CD3")]
	public class GroceryOrderStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601D752 RID: 120658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D752")]
		[Address(RVA = "0x1703630", Offset = "0x1702230", VA = "0x181703630")]
		public GroceryOrderStateBean()
		{
		}

		// Token: 0x04026D6F RID: 159087
		[Token(Token = "0x4026D6F")]
		[FieldOffset(Offset = "0x10")]
		public GroceryOrderProperty property;

		// Token: 0x04026D70 RID: 159088
		[Token(Token = "0x4026D70")]
		[FieldOffset(Offset = "0x18")]
		public GroceryOrderResultProperty resultProperty;

		// Token: 0x04026D71 RID: 159089
		[Token(Token = "0x4026D71")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
