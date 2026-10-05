using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CFE RID: 19710
	[Token(Token = "0x2004CFE")]
	public class GrocerySellStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601D8B0 RID: 121008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8B0")]
		[Address(RVA = "0x171CD90", Offset = "0x171B990", VA = "0x18171CD90")]
		public GrocerySellStateBean()
		{
		}

		// Token: 0x04026FB4 RID: 159668
		[Token(Token = "0x4026FB4")]
		[FieldOffset(Offset = "0x10")]
		public GrocerySellProperty property;

		// Token: 0x04026FB5 RID: 159669
		[Token(Token = "0x4026FB5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
