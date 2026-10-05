using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CB6 RID: 19638
	[Token(Token = "0x2004CB6")]
	public class GroceryHomeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601D6E2 RID: 120546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6E2")]
		[Address(RVA = "0x16F6540", Offset = "0x16F5140", VA = "0x1816F6540")]
		public GroceryHomeStateBean()
		{
		}

		// Token: 0x04026C4E RID: 158798
		[Token(Token = "0x4026C4E")]
		[FieldOffset(Offset = "0x10")]
		public GroceryHomeProperty property;

		// Token: 0x04026C4F RID: 158799
		[Token(Token = "0x4026C4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
